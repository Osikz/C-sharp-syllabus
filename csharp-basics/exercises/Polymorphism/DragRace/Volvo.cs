using System;

namespace DragRace
{
    public class Volvo : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 9;
        }

        public int SlowDown()
        {
            return currentSpeed -= 8;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string StartEngine()
        {
            return "Brtrtrtrtrtrrrrrr...";
        }
    }
}
