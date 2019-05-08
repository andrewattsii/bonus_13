using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Wizard:GameCharacter
    {
        public int spellNumber { get; set; }

        public Wizard(string _name, int _strength,int _intelligence, int _spellNumber) : base(_name, _strength, _intelligence)
        {
            spellNumber = _spellNumber;
        }
        public override string Play()
        {
            return ($"{base.Play()}\n Magical Energy: {spellNumber}");
        }
    }
}
