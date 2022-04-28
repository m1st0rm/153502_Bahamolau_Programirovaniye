using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class ClientsBase
    {
        private List<Client> AllClients = new List<Client>();
        private List<HotelNumber> AllRooms = new List<HotelNumber>();
        private int CountOfClients;
        private int CountOfRooms;
        private int CurrentClient = 0;

        public ClientsBase(int CountOfClients, int CountOfRooms)
        {
            this.CountOfClients = CountOfClients;
            this.CountOfRooms = CountOfRooms;
            for(int i = 0; i < this.CountOfClients; i++)
            {
                AllClients.Add(new Client());
            }
            for (int i = 0; i < this.CountOfRooms; i++)
            {
                AllRooms.Add(new HotelNumber());
            }
        }
        public void ChangeInfoAboutRoom(int NumberOfRoom, int NumberOfNumberType, int NewDailyFee)
        {
            AllRooms[NumberOfRoom - 1].ChangeTypeOfRoom(NumberOfNumberType);
            AllRooms[NumberOfRoom - 1].ChangeDailyFeeOfRoom(NewDailyFee);
        }
        public bool BookTheRoom(string Name,string Surname,int NumberOfRoom,int DaysOfLiving)
        {
            bool Status = false;
            if (AllRooms[NumberOfRoom-1].IsRoomFreeOrNot() == false)
            {
                return false;
            }
            else
            {
                AllClients[CurrentClient].ChangeNameAndSurname(Name, Surname);
                AllRooms[NumberOfRoom - 1].ChangeStatusOfRoom(Status);
                AllClients[CurrentClient].ChangeNumberOfRoom(NumberOfRoom,AllRooms[NumberOfRoom-1]);
                AllClients[CurrentClient].ChangeDaysOfLiving(DaysOfLiving);
                CurrentClient++;
                return true;
            }
        }
        public int[] FreeRooms()
        {
            int[] AvailableRooms = new int[CountOfRooms];
            for (int i = 0; i < CountOfRooms; i++)
            {
                if (AllRooms[i].IsRoomFreeOrNot() == true) {
                    AvailableRooms[i] = i + 1;
                }
                else
                {
                    AvailableRooms[i] = 0;
                }
            }
            return AvailableRooms;
        }

        public int CostForLivingBySurname(string Surname)
        {
            for(int i = 0; i < CountOfClients; i++)
            {
                if (AllClients[i].GetSurnameOfClient() == Surname)
                {
                    return AllClients[i].GetFinallyCostOfLiving();
                }
            }
            return 0;
        }

        public int GetRoomDailyFee(int NumberOfRoom)
        {
            return AllRooms[NumberOfRoom - 1].GetDailyFee();
        }

        public RoomType GetRoomType(int NumberOfRoom)
        {
            return AllRooms[NumberOfRoom - 1].GetTypeOfRoom();
        }
    }
}