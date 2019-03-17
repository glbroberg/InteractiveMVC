using System.Collections.Generic;

namespace InteractiveMVC.Models
{
    public class Character
    {
        public string Name {get; set;}
        public bool IsActive { get; set; }
        public int Level { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public static void Create (string characterName)
        {
            var character = new Character();
            character.Name = characterName;
            GlobalVariables.CharacterList.Add(character);
        }

        public static List<Character> GetAll ()
        {            
            return GlobalVariables.CharacterList;
        }
    }
}