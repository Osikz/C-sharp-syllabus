using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            return currentSpeed += 7;
        }

        public int SlowDown() 
        {
            return currentSpeed -= 5;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public int UseNitrousOxideEngine() 
        {
            return currentSpeed += 40;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}