using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex, string mother, string father)
        {
            _name = name;
            _sex = sex;
            _mother = mother;
            _father = father;
        }

        public string FathersName()
        {
            return _father == null ? "Unknown" : _father;

        }

        public string MotherName()
        {
            return _mother == null ? "Unknown" : _mother;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            return _mother == otherDog.MotherName();
        }
    }
}
