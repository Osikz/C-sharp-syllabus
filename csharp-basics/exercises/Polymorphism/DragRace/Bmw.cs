using System;

namespace DragRace
{
    public class Bmw : ICar, IBoostable
    {
        private int currentSpeed = 0;

        public void SpeedUp() 
        {
            currentSpeed += 12;
        }

        public void SlowDown() 
        {
            currentSpeed -= 8;
        }

        public string ShowCurrentSpeed() 
        {
            return currentSpeed.ToString();
        }

        public void UseNitrousOxideEngine()
        {
            currentSpeed += 50;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}