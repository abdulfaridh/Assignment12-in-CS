// See https://aka.ms/new-console-template for more information

namespace Interface
{
    class Bicycle : IVehicle
    {
        public int speed;
        public int gear;

        public Bicycle()
        {
            speed = 0;
            gear = 1;
        }

        public void ChangeGear(int newGear)
        {
            gear = newGear;
        }

        public void SpeedUp(int increment)
        {
            speed += increment;
            Console.WriteLine("speed and gear without applying breaks");
            DisplayStatus();
        }

        public void ApplyBrakes(int decrement)
        {
            speed -= decrement;
            if (speed < 0)
            {
                speed = 0;
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"grear : {gear}");
            Console.WriteLine($"speed : {speed}");
        }
    }
}