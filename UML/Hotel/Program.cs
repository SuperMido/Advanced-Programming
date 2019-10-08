using System;
using System.Collections.Generic;

namespace Hotel
{
    class Hotel
    {
        public List<Room> Rooms;

        SingleRoom SingleRoom;

        Reservation reservation;

        public Hotel()
        {
            Rooms = new List<Room>();

        }


        public void AddSingleRoom(int id)
        {
            Rooms.Add(new SingleRoom(id));
        }

        public void AddDoubleRoom(int id)
        {
            Rooms.Add(new DoubleRoom(id));
        }

        public List<Room> SearchSingleRoom(int numberOfRoom)
        {
            List<Room> result = new List<Room>();

            return result;
        }


        public bool CheckBook(SingleRoom SingleRoom)
        {
            
            return false;
        }

        public void ReturnResult(Guest guest, Hotel hotel)
        {
            Console.WriteLine($"{guest.Search(hotel)}");
        }
        
        public Reservation CreateReservation(int id, Guest guest, List<Room> rooms)
        {
            reservation = new Reservation(id, rooms, guest);
            Console.WriteLine(reservation.ToString());
            return reservation;
        }
    }

    public abstract class Room
    {

        

        protected int Bed;
        protected int ID;
        protected bool IsBooked;
        public double Price;

        public Room(int id)
        {
            ID = id;
            IsBooked = false;
        }
        // public void Book()
        // {
        //     IsBooked = true;
        // }
    }

    class SingleRoom : Room
    {   
        public SingleRoom(int id) :base(id)
        {
            Bed = 1;
            Price = 100;
        }

    }

    class DoubleRoom : Room
    {
        public DoubleRoom(int id) :base(id)
        {
            Bed = 2;
            Price = 150;
        }
    }

    class Reservation
    {
        public int ID;
        public List<Room> RoomsResevered;
        public Guest GuestReserverd;

        public Reservation(int id, List<Room> rooms, Guest guest)
        {
            ID = id;
            foreach (var room in rooms)
            {
                room.IsBooked = true;
            }

            RoomsResevered = rooms;

            GuestReserverd = guest;

        }
    }

    class Guest
    {
        string Name;
        int Age;

        public List<string> Search(Hotel hotel)
        {
            List<string> roomList = new List<string>();
            int n=1;
            foreach ( Room item in hotel.Rooms)
            {
                if (item.IsBooked == false)
                {
                    roomList.Add($"{n}. Room: {item.ID}");
                    n++;
                }
            }
            return roomList;   
        }

        public void Reserve(Hotel hotel, Guest guest, List<Room> rooms)
        {
            
            Console.WriteLine("Please select your room ID: ");
            int a = Convert.ToInt32(Console.ReadLine());
            hotel.CreateReservation(a,guest, rooms);

        }
    }
    class Program
    {
    
        static void Main(string[] args)
        {
            Hotel myHotel = new Hotel();
            Guest myGuest = new Guest();
            List<SingleRoom> mySingleRoom = new List<SingleRoom>();
            
            for (int i=0;i<10;i++)
            {
                mySingleRoom.Add(new SingleRoom(i));
            }
            // Console.Write("Input how many bed you want to search: ");
            int bedNum = Convert.ToInt32(Console.ReadLine());
            myGuest.Search(myHotel);
        }
    }
}
