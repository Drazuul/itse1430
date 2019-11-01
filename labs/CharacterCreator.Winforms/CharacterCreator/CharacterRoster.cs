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
    /// <summary> Provides a base type for <see cref="ICharacterRoster"/>. </summary>
    public abstract class CharacterRoster : ICharacterRoster
    {
        public Character Add ( Character character )
        {
            if (character == null)
                return null;

            var results = ObjectValidator.TryValidateObject (character);
            var existing = GetByNameCore (character.Name);
            if (existing != null)
                return null;

            return AddCore (character);
        }

        public void Remove ( int id )
        {
            if (id <= 0)
                return;

            RemoveCore (id);
        }

        public Character Get ( int id )
        {
            if (id <= 0)
                return null;

            return GetCore (id);
        }

        public IEnumerable<Character> GetAll ()
            => GetAllCore ();
       

        public void Update ( int id, Character character )
        {
            if (id <= 0)
                return;
            if (character == null)
                return;

             var results = ObjectValidator.TryValidateObject (character);
             if (results.Count () > 0)
                 return;

            var existing = GetByNameCore (character.Name);
            if (existing != null)
                return;

            UpdateCore (id, character);
        }




        protected abstract Character AddCore ( Character character );

        protected abstract Character GetCore ( int id );

        protected abstract Character GetByNameCore ( string name );

        protected abstract IEnumerable<Character> GetAllCore ();

        protected abstract void RemoveCore ( int id );

        protected abstract Character UpdateCore ( int id, Character character );
    }
}
