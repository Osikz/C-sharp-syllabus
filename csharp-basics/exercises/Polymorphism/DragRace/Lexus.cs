using System;

namespace DragRace
{
    public class Lexus : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 7;
        }

        public void SlowDown() 
        {
            currentSpeed -= 5;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed += 40;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}