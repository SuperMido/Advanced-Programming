using System;

namespace Decorator
{
    interface IMacbook
    {
        int GetCost();
        int GetRam();
        string GetChip();
        string GetDescription();
    }

    class MacAir : IMacbook
    {
        public int GetCost()
        {
            return 720;
        }

        public int GetRam()
        {
            return 4;
        }

        public string GetChip()
        {
            return "i3";
        }

        public string GetDescription()
        {
            return $"Macbook Air: {GetChip()}\t\tRam: {GetRam()}\t\tCost: {GetCost()}";
        }
    }

    class MacNew : IMacbook
    {
        private readonly IMacbook mMacbook;

        public MacNew(IMacbook macbook)
        {
            mMacbook = macbook;
        }

        public int GetCost()
        {
            return mMacbook.GetCost() + 190;
        }

        public int GetRam()
        {
            return mMacbook.GetRam() + 4;
        }

        public string GetChip()
        {
            return "i5";
        }

        public string GetDescription()
        {
            return $"Macbook New: {GetChip()}\t\tRam: {GetRam()}\t\tCost: {GetCost()}";
        }
    }

    class MacPro : IMacbook
    {
        private readonly IMacbook mMacbook;

        public MacPro(IMacbook macbook)
        {
            mMacbook = macbook;
        }

        public int GetCost()
        {
            return mMacbook.GetCost() + 320;
        }

        public int GetRam()
        {
            return mMacbook.GetRam() + 8;
        }

        public string GetChip()
        {
            return "i7";
        }

        public string GetDescription()
        {
            return $"Macbook Pro: {GetChip()}\t\tRam: {GetRam()}\t\tCost: {GetCost()}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================== Macbook Shop =====================");
            var myMacAir = new MacAir();
            Console.WriteLine(myMacAir.GetDescription());

            var myMacNew = new MacNew(myMacAir);
            Console.WriteLine(myMacNew.GetDescription());

            var myMacPro = new MacPro(myMacNew);
            Console.WriteLine(myMacPro.GetDescription());

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
