using NotafiThree.Model.PersonalityData;
using System;

namespace NotafiThree.Scripts
{
    internal class GeneratorCodeAccepted
    {
        private readonly User _user;
        private string _code;

        public string Code => _code;

        public GeneratorCodeAccepted() : this(null)
        {

        }

        public GeneratorCodeAccepted(User user)
        {
            _user = user;
        }

        public void GenerateCode(int min = 0, int max = 100000)
        {
            if(min > max)
            {
                throw new ArgumentException();
            }

            if(min < 0 || max < 0)
            {
                throw new ArgumentException();
            }

            Random rand = new Random();
            int number = rand.Next(min, max);

            string result = "";

            if(number < 10)
            {
                result += "00000" + number;
            }
            else if(number < 100)
            {
                result += "0000" + number;
            }
            else if (number < 1000)
            {
                result += "000" + number;
            }
            else if (number < 10000)
            {
                result += "00" + number;
            }
            else if (number < 100000)
            {
                result += "0" + number;
            }
            else if (number < 1000000)
            {
                result += number;
            }

            _code = result;
        }
    }
}
