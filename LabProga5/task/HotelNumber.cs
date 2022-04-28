using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public enum RoomType { Standart, Medium, High, Luxe, VIP };
    public class HotelNumber
    {
        private RoomType TypeOfRoom;
        private int DailyFee;
        private bool IsRoomFree;

        public HotelNumber()
        {
            this.TypeOfRoom = RoomType.Standart;
            this.DailyFee = 25;
            this.IsRoomFree = true;
        }

        public RoomType GetTypeOfRoom()
        {
            return this.TypeOfRoom;
        }
        
        public int GetDailyFee()
        {
            return this.DailyFee;
        }

        public bool IsRoomFreeOrNot()
        {
            return this.IsRoomFree;
        }
        public void ChangeTypeOfRoom(int NumberOfNumberType)
        {
            if (NumberOfNumberType == 1)
            {
                this.TypeOfRoom = RoomType.Standart;
            }
            else if (NumberOfNumberType == 2)
            {
                this.TypeOfRoom = RoomType.Medium;
            }
            else if (NumberOfNumberType == 3)
            {
                this.TypeOfRoom = RoomType.High;
            }
            else if (NumberOfNumberType == 4)
            {
                this.TypeOfRoom = RoomType.Luxe;
            }
            else
            {
                this.TypeOfRoom = RoomType.VIP;
            }
        }
        public void ChangeDailyFeeOfRoom(int NewDailyFee)
        {
            this.DailyFee = NewDailyFee;
        }

        public void ChangeStatusOfRoom(bool Status)
        {
            this.IsRoomFree = Status;
        }
    }
}
