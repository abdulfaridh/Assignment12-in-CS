// See https://aka.ms/new-console-template for more information

namespace Interface
{
    class Assignment12
    {
        static void Main()
        {
            Bicycle myBike = new Bicycle();
            Console.WriteLine("enter the gear you want to ride:");
            int gear = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the speed you want to move:");
            int speed = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the speed you want to apply break");
            int breaks = int.Parse(Console.ReadLine());
            Console.WriteLine("speed and gear before moving:");
            myBike.DisplayStatus();
            myBike.ChangeGear(gear);
            myBike.SpeedUp(speed);
            myBike.ApplyBrakes(3);
            Console.WriteLine("speed and gear with applying breaks:");
            myBike.DisplayStatus();
        }
    }
}