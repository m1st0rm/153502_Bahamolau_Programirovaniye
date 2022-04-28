using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class Client
    {
        private string Name;
        private string Surname;
        private int NumberOfRoom;
        private int DaysOfLiving;
        private HotelNumber RoomInfo;

         public Client() {
            this.Name = "Ivan";
            this.Surname = "Ivanov";
            this.NumberOfRoom = 0;
            this.DaysOfLiving = 0;
            RoomInfo = new HotelNumber();
        }
        public void ChangeNameAndSurname(string NewName,string NewSurname)
        {
            this.Name = NewName;
            this.Surname = NewSurname;
        }
        public void ChangeDaysOfLiving (int NewDaysOfLiving)
        {
            this.DaysOfLiving = NewDaysOfLiving;
        }

        public void ChangeNumberOfRoom (int NewNumberOfRoom, HotelNumber NewRoomInfo)
        {
            this.NumberOfRoom = NewNumberOfRoom;
            this.RoomInfo = NewRoomInfo;
        }

        public int GetFinallyCostOfLiving()
        {
            int FinallyCostOfLiving = this.DaysOfLiving * RoomInfo.GetDailyFee();
            return FinallyCostOfLiving;
        }

        public string GetSurnameOfClient()
        {
            return this.Surname;
        }

    }
}
