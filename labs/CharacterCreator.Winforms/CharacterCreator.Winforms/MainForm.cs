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
    public partial class MainForm : Form
    {
        public MainForm ()
        {
            InitializeComponent ();
        }

        private void OnCharacterNew ( object sender, EventArgs e )
        {
            var form = new CharacterForm ();

            if (form.ShowDialog (this)==DialogResult.OK)
            {
                AddCharacter (form.Character);
                UpdateUI ();
            }            
        }

        private void OnCharacterDelete ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var msg = $"Are you sure you want to delete {character.Name}?";
            var result = MessageBox.Show (msg, "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            RemoveCharacter (character);
            UpdateUI ();
        }

        private void OnCharacterEdit ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter ();
            if (character == null)
                return;

            var form = new CharacterForm ();
            form.Character = character;
            form.Text = "Edit Character";

            if (form.ShowDialog (this) == DialogResult.OK)
            {
                RemoveCharacter (character);
                AddCharacter (form.Character);
                UpdateUI ();
            };
        }

        private void OnFileExit ( object sender, EventArgs e )
        {
            Close ();
        }

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }

        private Character GetSelectedCharacter ()
        {
            var item = _listCharacters.SelectedItem;
            return item as Character;
        }

        private void UpdateUI ()
        {
            var character = GetCharacters ();
            _listCharacters.DataSource = character;
        }

        private void AddCharacter ( Character character )
        {
            for (var index = 0;index < _characters.Length; index++)
            {
                if (_characters[index] == null)
                {
                    _characters[index] = character;
                    return;
                };
            };
        }

        private void RemoveCharacter ( Character character )
        {
            for (var index = 0; index < _characters.Length; ++index)
            {
                if (_characters[index] == character)
                {
                    _characters[index] = null;
                    return;
                };
            };
        }

        private Character[] GetCharacters()
        {
            var count = 0;
            foreach (var character in _characters)
                if (character != null)
                    ++count;

            var index = 0;
            var characters = new Character[count];
            foreach (var character in _characters)
                if (character != null)
                    characters[index++] = character;

            return characters;
        }

        private Character[] _characters = new Character[100];
    }
}
