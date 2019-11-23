//Jacob Ivey
//ITSE 1430
//Character Creator

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
{
    public partial class CharacterForm : Form
    {
        public CharacterForm ()
        {
            InitializeComponent ();
        }

        public Character Character { get; set; }

        protected override void OnLoad ( EventArgs e )
        {
            base.OnLoad (e);

            if (Character != null)
            {
                _txtName.Text = Character.Name;
                _txtDescription.Text = Character.Description;
                _boxProfession.Text = Character.Profession;
                _boxRace.Text = Character.Race;

                _txtStrength.Text = Character.Strength.ToString ();
                _txtDexterity.Text = Character.Dexterity.ToString ();
                _txtConstitution.Text = Character.Constitution.ToString ();
                _txtIntelligence.Text = Character.Intelligence.ToString ();
                _txtWisdom.Text = Character.Wisdom.ToString ();
                _txtCharisma.Text = Character.Charisma.ToString ();
            }

            if (Character == null)
            {
                var character = new Character ();
                _txtStrength.Text = character.Strength.ToString ();
                _txtDexterity.Text = character.Dexterity.ToString ();
                _txtConstitution.Text = character.Constitution.ToString ();
                _txtIntelligence.Text = character.Intelligence.ToString ();
                _txtWisdom.Text = character.Wisdom.ToString ();
                _txtCharisma.Text = character.Charisma.ToString ();
            }
        }

        private void OnSave ( object sender, EventArgs e )
        {
            if (!ValidateChildren ())
                return;

            var character = new Character () {
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                Profession = _boxProfession.Text,
                Race = _boxRace.Text,

                Strength = GetAsInt32 (_txtStrength),
                Dexterity = GetAsInt32 (_txtDexterity),
                Constitution = GetAsInt32 (_txtConstitution),
                Intelligence = GetAsInt32 (_txtIntelligence),
                Wisdom = GetAsInt32 (_txtWisdom),
                Charisma = GetAsInt32 (_txtCharisma), };

            if (!Validate (character))
                return;

            Character = character;

            DialogResult = DialogResult.OK;
            Close ();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
        }
        private bool Validate ( IValidatableObject character )
        {
            var results = ObjectValidator.TryValidateObject (character);
            if (results.Count () > 0)
            {
                foreach (var result in results)
                {
                    MessageBox.Show (this, result.ErrorMessage,
                                    "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                };
                return false;
            };

            return true;
        }

        private int GetAsInt32 ( TextBox control )
        {
            if (Int32.TryParse (control.Text, out var result))
                return result;

            return 0;
        }

        private void OnValidatingName ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            //Name is required
            if (control.Text == "")
            {
                e.Cancel = true;
                _errors.SetError (control, "Name is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingProfession ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Profession is required
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Profession is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }

        private void OnValidatingRace ( object sender, CancelEventArgs e )
        {
            var control = sender as ComboBox;

            //Race is required
            if (control.SelectedIndex == -1)
            {
                e.Cancel = true;
                _errors.SetError (control, "Race is required");
            } else
            {
                _errors.SetError (control, "");
            }
        }
        private void OnValidatingAttribute ( object sender, CancelEventArgs e )
        {
            var control = sender as TextBox;

            var value = GetAsInt32 (control);
            if (value < 1 || value > 20)
            {
                e.Cancel = true;
                _errors.SetError (control, "must be between 1-20");
            } else
            {
                _errors.SetError (control, "");
            }
        }
    }
}
