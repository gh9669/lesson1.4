using System;
using System.Collections.Generic;

namespace lesson1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static void pers()
        {
            Dictionary<string, string> characterName = new Dictionary<string, string>(3);
            characterName.Add("knight" , "sword");
            //["archer"] = new Archer();
            //characterName["mage"] = new Mage();

            foreach (KeyValuePair<string, string> keyValue in characterName)
            {
                Console.WriteLine(keyValue.Key + "  " + keyValue.Value);
            }
        }


        
    }
}
