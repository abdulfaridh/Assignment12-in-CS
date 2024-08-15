// See https://aka.ms/new-console-template for more information

namespace Interface
{
    interface IVehicle
    {
        void ChangeGear(int gear);
        void SpeedUp(int increment);
        void ApplyBrakes(int decrement);
    }
}