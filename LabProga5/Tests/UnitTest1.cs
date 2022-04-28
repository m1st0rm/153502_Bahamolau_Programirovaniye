using System;
using Xunit;
using task;

namespace Tests
{
    public class UnitTest1
    {
        ClientsBase Base = new ClientsBase(3, 3);
        [Fact]
        public void Test1()
        {
            Base.ChangeInfoAboutRoom(1, 3, 500);
            Assert.Equal(500, Base.GetRoomDailyFee(1));
        }
        [Fact]
        public void Test2()
        {
            Base.ChangeInfoAboutRoom(1, 3, 500);
            bool AreTypesOfRoomSimiliar;
            if (Base.GetRoomType(1) == RoomType.High)
            {
                AreTypesOfRoomSimiliar = true;
            }
            else
            {
                AreTypesOfRoomSimiliar = false;
            }
            Assert.True(AreTypesOfRoomSimiliar);
        }
        [Fact]
        public void Test3()
        {
            Base.ChangeInfoAboutRoom(1, 3, 600);
            Base.BookTheRoom("Mikhail", "Bahamolau", 1, 5);
            Assert.Equal(3000,Base.CostForLivingBySurname("Bahamolau"));
        }
        [Fact]
        public void Test4()
        {
            Base.ChangeInfoAboutRoom(3, 1, 25);
            Base.BookTheRoom("Oleg", "Pivovarow", 3, 10);
            Assert.Equal(250, Base.CostForLivingBySurname("Pivovarow"));
        }
        [Fact]
        public void Test5()
        {
            Base.BookTheRoom("Mikhail", "Bahamolau", 1, 5);
            Base.BookTheRoom("Oleg", "Pivovarow", 3, 10);
            int[] MassToExpect = new int[3] { 0, 2, 0 };
            int[] MassFromMethod;
            MassFromMethod = Base.FreeRooms();
            bool AreArraysSimiliar = true;
            for(int i = 0; i < 3; i++)
            {
                if (MassFromMethod[i] != MassToExpect[i]) { AreArraysSimiliar = false; break; }
            }
            Assert.True(AreArraysSimiliar);
        }
    }
}