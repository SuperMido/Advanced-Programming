using System;
using System.Text;

namespace Builder
{
    class House
    {
        private int mFloors;
        private bool mLivingRoom;
        private bool mBedRoom;
        private bool mBathRoom;
        private bool mSwimmingPool;

        public House (HouseBuilder builder)
        {
            this.mFloors = builder.Floors;
            this.mLivingRoom = builder.LivingRoom;
            this.mBedRoom = builder.BedRoom;
            this.mBathRoom = builder.BathRoom;
            this.mSwimmingPool = builder.SwimmingPool;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.Append($"The house has {this.mFloors} floor(s).\n");
            sb.Append("---------------------------\n");
            sb.Append($"Living Room: \t{this.mLivingRoom}\n");
            sb.Append($"Bed Room: \t{this.mBedRoom}\n");
            sb.Append($"Bath Room: \t{this.mBathRoom}\n");
            sb.Append($"Swimming Pool: \t{this.mSwimmingPool}");
            return sb.ToString();
        }
    }

    class HouseBuilder
    {
        public int Floors;
        public bool LivingRoom;
        public bool BedRoom;
        public bool BathRoom;
        public bool SwimmingPool;

        public HouseBuilder (int floor)
        {
            this.Floors = floor;
        }

        public HouseBuilder AddLivingRoom()
        {
            this.LivingRoom = true;
            return this;
        }

        public HouseBuilder AddBedRoom()
        {
            this.BedRoom = true;
            return this;
        }

        public HouseBuilder AddBathRoom()
        {
            this.BathRoom = true;
            return this;
        }

        public HouseBuilder AddSwimmingPool()
        {
            this.SwimmingPool = true;
            return this;
        }

        public House Build()
        {
            return new House(this);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var myHouse = new HouseBuilder(3).AddBathRoom()
                                             .AddBedRoom()
                                            //  .AddLivingRoom()
                                             .AddSwimmingPool()
                                             .Build();

            Console.WriteLine(myHouse.GetDescription());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
