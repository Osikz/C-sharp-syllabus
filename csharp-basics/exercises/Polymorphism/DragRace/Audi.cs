using System;

namespace DragRace
{
    public class Audi : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp() 
        {
            return currentSpeed += 10;
        }

        public int SlowDown() 
        {
            return currentSpeed -= 5;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public string StartEngine() 
        {
            return "Rrtrrtrrtr.....";
        }
    }
}