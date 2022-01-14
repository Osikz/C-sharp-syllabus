using System;

namespace DragRace
{
    public class Toyota : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 12;
        }

        public int SlowDown()
        {
            return currentSpeed -= 7;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}
