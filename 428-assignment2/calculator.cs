using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _428_assignment2
{
    public enum PostType { Regular,Xpress,Priority}
    public class calculator
    {
        public static float Compute(string from,string to,float length,float width,float height,float weight,PostType type)
        {
            if (string.IsNullOrEmpty(from))
            {
                throw new Exception("invalid from");
            }
            if (string.IsNullOrEmpty(to))
            {
                throw new Exception("invalid to");
            }
            if (length<=0)
            {
                throw new Exception("invalid length");
            }
            if (width<=0)
            {
                throw new Exception("invalid width");
            }
            if (height<=0)
            {
                throw new Exception("invalid height");
            }
            if (weight<=0)
            {
                throw new Exception("invalid weight");
            }
            if ((int)type<0||(int)type>2)
            {
                throw new Exception("invalid type");
            }



            return 0;
        }
    }
}
