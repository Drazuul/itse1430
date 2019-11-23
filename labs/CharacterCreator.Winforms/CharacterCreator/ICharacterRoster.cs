//Jacob Ivey
//ITSE 1430
//Character Creator


using System.Collections.Generic;


namespace CharacterCreator
{
    /// <summary> Provides a roster for characters. </summary>
    public interface ICharacterRoster
    {
        /// <summary> Add a character. </summary>
        /// <param name="character"> New character to be added. </param>
        /// <returns> New Character. </returns>
        Character Add ( Character character );

        /// <summary> Deletes a character </summary>
        /// <param name="id"> the ID of the Character </param>
        void Remove ( int id );

        /// <summary> Gets a character </summary>
        /// <param name="id"> The ID of the character </param>
        /// <returns> The character </returns>
        Character Get ( int id );

        /// <summary> Gets all of the characters </summary>
        /// <returns> The characters </returns>
        IEnumerable<Character> GetAll ();

        /// <summary> Updates a character </summary>
        /// <param name="id"> Id of the character </param>
        /// <param name="character"> Updated character </param>
        void Update ( int id, Character character );
    }
}
