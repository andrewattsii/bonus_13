using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class Warrior : GameCharacter
    {
        public string weaponType { get; set; }

        public Warrior(string _name, int _strength, int _intelligence, string _weaponType):base(_name,_strength,_intelligence)
        {
            weaponType = _weaponType;
        }

        public override string Play()
        {
            return ($"{base.Play()}\n Weapon type: {weaponType}");
        }
      

    }
}
