//Jacob Ivey
//ITSE 1430
//Character Creator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                _txtDesctription.Text = Character.Description;
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
                //_txtStrength.Text = "10";
                //_txtDexterity.Text = "10";
                //_txtConstitution.Text = "10";
                //_txtIntelligence.Text = "10";
                //_txtWisdom.Text = "10";
                //_txtCharisma.Text = "10";

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

            var character = new Character ();
            character.Name = _txtName.Text;
            character.Description = _txtDesctription.Text;
            character.Profession = _boxProfession.Text;
            character.Race = _boxRace.Text;

            character.Strength = GetAsInt32 (_txtStrength);
            character.Dexterity = GetAsInt32 (_txtDexterity);
            character.Constitution = GetAsInt32 (_txtConstitution);
            character.Intelligence = GetAsInt32 (_txtIntelligence);
            character.Wisdom = GetAsInt32 (_txtWisdom);
            character.Charisma = GetAsInt32 (_txtCharisma);

            var message = character.Validate ();
            if (!String.IsNullOrEmpty (message))
            {
                MessageBox.Show (this, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            };

            Character = character;

            DialogResult = DialogResult.OK;
            Close ();
        }

        private void OnCancel ( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close ();
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
