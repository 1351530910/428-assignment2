using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecse428_AssignmentB
{
    public class DataSheet
    {
        public static string[] data =
        {
            "0.49,14,24.5,9,15.6,0.3,3",
            "0.8,14,24.5,9,15.6,3,5",
            "0.98,14,24.5,9,15.6,1,5",
            "2.4,14,24.5,9,15.6,1,5",
            "0.98,24.5,38,9,15.6,0.3,1",
            "2.4,24.5,38,9,15.6,1,5",
            "0.98,14,38,15.6,27,0.3,1",
            "2.4,14,38,15.6,27,1,5",
            "0.98,14,24.5,9,15.6,0.3,3"
        };
        public static float[,] values;
        public static void init()
        {
            values = new float[9, 7];
            for (int i = 0; i < 9; i++)
            {
                string[] div = data[i].Split(',');
                for (int j = 0; j < 7; j++)
                {
                    values[i, j] = float.Parse(div[j]);
                }
            }
        }
        public static float getprice(float lenght, float width, float weight)
        {
            for (int i = 0; i < 9; i++)
            {
                if (lenght >= values[i, 1] && lenght < values[i, 2] && width >= values[i, 3] && width < values[i, 4] && weight >= values[i, 5] && weight < values[i, 6])
                {
                    return values[i, 0];
                }
            }
            return 0;
        }
    }
}
