using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonus_13
{
    class GameCharacter
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }

        public GameCharacter(string _name, int _strength, int _intelligence)
        {
            name = _name;
            strength = _strength;
            intelligence = _intelligence;
        }
        public virtual string Play()
        {
            return ($" Your characters name is: {name}. The strength is: {strength}. The intelligence: {intelligence}");
        }




    }
}
