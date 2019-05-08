using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class MagicUsingCharacter:GameCharacter
    {
        public int magicalEnergy { get; set; }

        public MagicUsingCharacter(string _name, int _strength, int _intelligence, int _magicalEnergy) : base(_name, _strength, _intelligence)
        {
            magicalEnergy = _magicalEnergy;
        }
        public override string Play()
        {
            return ($"{base.Play()}\n Magical Energy: {magicalEnergy}");
        }

    }
}
