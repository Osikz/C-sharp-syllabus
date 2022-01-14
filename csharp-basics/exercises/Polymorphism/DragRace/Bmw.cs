using System;

namespace DragRace
{
    public class Bmw : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            return currentSpeed += 12;
        }

        public int SlowDown() 
        {
            return currentSpeed -= 8;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public int UseNitrousOxideEngine()
        {
            return currentSpeed += 50;
        }

        public string StartEngine() 
        {
            return "Rrrrrrr.....";
        }
    }
}