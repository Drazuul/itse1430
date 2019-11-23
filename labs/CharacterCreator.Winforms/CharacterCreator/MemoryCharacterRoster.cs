//Jacob Ivey
//ITSE 1430
//Character Creator

using System;
using System.Collections.Generic;

namespace CharacterCreator
{
    public class MemoryCharacterRoster : CharacterRoster
    {
        protected override Character AddCore ( Character character )
        {
            character.Id = ++_id;

            var newCharacter = Clone (new Character (), character);
            _characters.Add (newCharacter);

            return character;
        }

        protected override IEnumerable<Character> GetAllCore ()
        {
            foreach (var character in _characters)
                yield return Clone (new Character (), character);
        }

        protected override Character GetCore ( int id )
        {
            var character = FindCharacter (id);

            return character != null ? Clone (new Character (), character) : null;
        }
        
        protected override void RemoveCore ( int id )
        {
            var character = FindCharacter (id);
            if (character != null)
                _characters.Remove (character);
        }

        protected override Character UpdateCore ( int id, Character character )
        {
            var existing = FindCharacter (id);
            if (existing == null)
                return null;

            character.Id = id;
            Clone (existing, character);

            return character;
        }

        private Character Clone ( Character target, Character source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;

            target.Strength = source.Strength;
            target.Dexterity = source.Dexterity;
            target.Constitution = source.Constitution;
            target.Intelligence = source.Intelligence;
            target.Wisdom = source.Wisdom;
            target.Charisma = source.Charisma;

            target.Profession = source.Profession;
            target.Race = source.Race;

            return target;
        }

        private Character FindCharacter ( int id )
        {
            foreach (var character in _characters)
                if (character.Id == id)
                    return character;

            return null;
        }

        protected override Character GetByNameCore ( string name )
        {
            foreach (var character in _characters)
                if (String.Compare (character.Name, name, true) == 0)
                    return character;

            return null;
        }

        private List<Character> _characters = new List<Character> ();

        private int _id = 0;

    }
}
