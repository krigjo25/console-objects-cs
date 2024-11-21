using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace initializing_class
{
    internal class Person : Program
    {
        //  Maximum value of hobbies
        protected private const int n = 10;

        //  intialize field
        protected private string __name__;
        protected private int __birthdate__;
        protected private int __socialnum__;
        protected private string __address__;
        protected private string __county__;


        //  Initializing a data structure
        protected private List<string> items;
        protected private List<string> __hobbies__;

        //  Initialize properties
        public string Name
        {
            get { return __name__; }
            set
            {
                string match = "^[a-z][A-Z]$";
                var regex = new Regex(match);

                //  Ensure the person's letters is only upper or lower case
                if (regex.IsMatch(value))
                {
                    __name__ = value;
                }
            }
        }

        public int SocialNum
        {
            get { return __socialnum__; }
            set
            {
                string match = "^[0-9]$";
                var regex = new Regex(match);

                //  Ensure the person's letters is only upper or lower case
                if (regex.IsMatch(Convert.ToString(value)))
                {
                    __socialnum__ = value;
                }
            }
        }

        internal int Birthdate
        {
            get { return __birthdate__; }
            set
            {
                //  Ensure that the integer is between 0 & 1000
                if(value > 0 || value < 1000)
                {
                    __birthdate__ = value;
                }
            }
        }

        internal string Hobbies
        {
            get { return __hobbies__; }
            set
            {

            }
        }
        internal dynamic SetName(string arg)
        {
            __name__ = arg;

            return 0;
        }

        internal dynamic Socialnum(int arg)
        {
            __socialnum__ = arg;

            return 0;
        }

        internal dynamic GenerateHobbies(string arg)
        {
            Hobbies.Add(arg);
            return 0;
        }

        internal dynamic GenerateBirthday(int arg)
        {

            __birthdate__ = arg;
            return 0;
        }

        internal dynamic CalculateBirthDate(int[] array)
        {
            //  Calculates birthday
            return 0;
        }

    }
}
