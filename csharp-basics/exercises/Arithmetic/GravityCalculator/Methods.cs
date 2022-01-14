using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityCalculator
{
    public class Methods
    {
        public static double FinalPositionCalculator(double gravity, double initVelocity, double initPos,
            double fallingTime)
        {
            return Math.Round(0.5 * gravity * Math.Pow(fallingTime, 2)
                              + initVelocity * fallingTime
                              + initPos, 2);
        }
    }
}
