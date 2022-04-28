using System;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientsBase Base = new ClientsBase(3, 3);
            Base.ChangeInfoAboutRoom(1, 3, 500);
            Base.BookTheRoom("Mikhail", "Bahamolau", 1, 5);
            int[] FreeNumbers = Base.FreeRooms();
            Console.WriteLine("Свободными являются комнаты под номерами : ");
            for (int i = 0; i < 3; i++)
            {
                if (FreeNumbers[i] != 0) { Console.WriteLine($"{FreeNumbers[i]}"); }
            }
            Console.WriteLine($"{Base.CostForLivingBySurname("Bahamolau")}");
        }
    }
}