using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare_points_code_eval
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = "0 1 0 5";
            string[] lost = line.Split();


            int xHere = int.Parse(lost[0]);  //initializing our two x, y, coordinates
            int yHere = int.Parse(lost[1]);
            int xThere = int.Parse(lost[2]);
            int yThere = int.Parse(lost[3]);

            string direction = ""; // initializing string we will return to CodeEval

            //setting string direction based on coordinate math

            if (xHere == xThere && yHere == yThere)
                direction = "here";

            if (xHere == xThere && yHere < yThere)
                direction = "N";

            if (xHere == xThere && yHere > yThere)
                direction = "S";

            if (xHere > xThere && yHere == yThere)
                direction = "W";

            if (xHere < xThere && yHere == yThere)
                direction = "E";

            if (xHere < xThere && yHere < yThere)
                direction = "NE";

            if (xHere < xThere && yHere > yThere)
                direction = "SE";

            if (xHere > xThere && yHere < yThere)
                direction = "SE";

            if (xHere > xThere && yHere < yThere)
                direction = "NW";

            if (xHere > xThere && yHere > yThere)
                direction = "SW";
            //Returning direction to CodeEval
            Console.WriteLine(direction);
        }
    }
}
