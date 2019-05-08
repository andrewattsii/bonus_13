using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter[] newCharacter = new GameCharacter[5];

            Warrior newWarrior1 = new Warrior("Andre", 10, 8, "Sword");
            newCharacter[0] = newWarrior1;

            Warrior newWarrior2 = new Warrior("Kraket", 10, 8, "Axe");
            newCharacter[1] = newWarrior2;

            Wizard newWizard1 = new Wizard("Antonie", 7, 5, 300);
            newCharacter[2] = newWizard1;

            Wizard newWizard2 = new Wizard("Diffindore", 7, 10, 200);
            newCharacter[3] = newWizard2;

            Wizard newWizard3 = new Wizard("Selfi", 7, 3, 240);
            newCharacter[4] = newWizard3;


            foreach (GameCharacter c in newCharacter)
            {
                Console.WriteLine(c.Play());
            }






        }
    }
}
