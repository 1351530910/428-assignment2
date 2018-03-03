using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _428_assignment2
{
    public enum PostType { Regular,Xpress,Priority}
    public class package
    {
        public string from { get; set; }
        public string to { get; set; }
        public float length { get; set; }
        public float width { get; set; }
        public float height { get; set; }
        public float weight { get; set; }
        public PostType type { get; set; }
        public package(string from, string to, float length, float width, float height, float weight, PostType type)
        {
            this.from = from;
            this.to = to;
            this.length = length;
            this.width = width;
            this.height = height;
            this.weight = weight;
            this.type = type;
        }
        public package(package model)
        {
            this.from = model.from;
            this.to = model.to;
            this.length = model.length;
            this.width = model.width;
            this.height = model.height;
            this.weight = model.weight;
            this.type = model.type;
        }
    }
    public class calculator
    {
        static string PostalHead = "abceghjklmnprstvxy";
        static List<char> postalheadlist = PostalHead.ToString().ToList();
        public static string getPrice(package package)
        {
            //throw new NotImplementedException();
            if (validate(package)!=null)
            {
                return validate(package);
            }

            float sum = DataSheet.getprice(package.length, package.width, package.weight);
            int distance = postalheadlist.IndexOf(package.from[0]);
            distance = Math.Abs(postalheadlist.IndexOf(package.to[0]) - distance);
            sum += distance +8;
            sum *= (1+(int)package.type/2.0f);

            return sum.ToString();
        }
        private static string validate(package package)
        {
            //data validation
            if (string.IsNullOrEmpty(package.from))
            {
                return "invalid from";
            }

            if (package.from.Length != 6 || !(char.IsLetter(package.from[0]) && char.IsLetter(package.from[2]) && char.IsLetter(package.from[4]) && char.IsDigit(package.from[1]) && char.IsDigit(package.from[3]) && char.IsDigit(package.from[5])))
            {
                return "invalid from";
            }

            if (string.IsNullOrEmpty(package.to))
            {
                return "invalid to";
            }

            if (package.to.Length != 6 || !(char.IsLetter(package.to[0]) && char.IsLetter(package.to[2]) && char.IsLetter(package.to[4]) && char.IsDigit(package.to[1]) && char.IsDigit(package.to[3]) && char.IsDigit(package.to[5])))
            {
                return "invalid to";
            }

            if (!postalheadlist.Contains(char.ToLower(package.from[0])))
            {
                return "invalid from";
            }
            if (!postalheadlist.Contains(char.ToLower(package.to[0])))
            {
                return "invalid to";
            }

            if (package.length >= 38 || package.length < 14)
            {
                return "invalid length";
            }
            if (package.height >= 50||package.height<15)
            {
                return "invalid height";
            }
            if (package.weight>=5 || package.weight<0.3)
            {
                return "invalid weight";
            }
            if (package.width>=27||package.width<9)
            {
                return "invalid width";
            }

            return null;
        }
        
    }
}
