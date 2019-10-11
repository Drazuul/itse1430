//Jacob Ivey
//ITSE 1430
//Character Creator

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    /// <summary> Character Data </summary>
    public class Character
    {
        #region Properties

        /// <summary> gets or sets character's name </summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value; }
        }

        /// <summary> gets or sets character's description </summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }

        /// <summary> gets or sets character's profession </summary>
        public string Profession
        {
            get { return _profession ?? ""; }
            set { _profession = value; }
        }

        /// <summary> gets or sets character's race </summary>
        public string Race
        {
            get { return _race ?? ""; }
            set { _race = value; }
        }

        /// <summary> gets or sets character's attributes </summary>
        public int Strength { get; set; } = 10;
        public int Dexterity { get; set; } = 10;
        public int Constitution { get; set; } = 10;
        public int Intelligence { get; set; } = 10;
        public int Wisdom { get; set; } = 10;
        public int Charisma { get; set; } = 10;
        #endregion

        public override string ToString ()
        {
            return $"{Name} - {Race} / {Profession}";
        }

        /// <summary>Validates the character.</summary>
        /// <returns>An error message if validation fails or empty string otherwise.</returns>
        public string Validate ()
        {
            var attributeError = "All attributes must be a number between 1 and 20.";

            if (String.IsNullOrEmpty (Name))
                return "Name required";
            if (String.IsNullOrEmpty (Profession))
                return "Profession Required";
            if (String.IsNullOrEmpty (Race))
                return "Race required";

            if (Strength < 1 || Strength > 20)
                return attributeError;
            if (Dexterity < 1 || Dexterity > 20)
                return attributeError;
            if (Constitution < 1 || Constitution > 20)
                return attributeError;
            if (Intelligence < 1 || Intelligence > 20)
                return attributeError;
            if (Wisdom < 1 || Wisdom > 20)
                return attributeError;
            if (Charisma < 1 || Charisma > 20)
                return attributeError;

            return "";
        }

        #region Private Members
        private string _name;
        private string _description;
        private string _profession;
        private string _race;
        #endregion
    }
}
