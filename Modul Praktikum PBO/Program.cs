using System;
using VGA;
using LAPTOP;
using PROCESSOR;


namespace program
{
    public class compile
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();
            laptop1 = new Vivobook();
            laptop1.vga = new VGA.Nvidia();
            laptop1.processor = new CoreI5();

            Laptop laptop2 = new Laptop();
            laptop2 = new IdeaPad();
            laptop2.vga = new VGA.AMD();
            laptop2.processor = new Ryzen();

            Predator predator = new Predator();
            predator = new Predator();
            predator.vga = new VGA.AMD();
            predator.processor = new CoreI7();

            Console.WriteLine("=====> Soal 1");
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Console.WriteLine("\n=====> Soal 2"); // akan terjadi eror 
            //laptop1.Ngoding();

            Console.WriteLine("\n=====> Soal 3");
            Console.WriteLine(laptop1.vga.merk);
            Console.WriteLine(laptop1.processor.merk);
            Console.WriteLine(laptop1.processor.tipe    );

            Console.WriteLine("\n=====> Soal 4");
            predator.BermainGame();

            Console.WriteLine("\n=====> Soal 5"); // akan terjadi eror
            ACER acer = new ACER();
            acer = new Predator();
            //acer.BermainGame( );

            Console.ReadLine();
        }
    }
}

namespace VGA
{
    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    public class AMD : Vga
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
}

namespace LAPTOP
{
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");

        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }

    }
public class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "Asus";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            merk = "Acer";
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }

    }
    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}
namespace PROCESSOR
{
    public class Processor
    {
        public string merk;
        public string tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }
    public class AMD : Processor
    {
        public AMD()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMD
    {
        public Ryzen()
        {
            tipe = "Rayzen";
        }
    }
    public class Athlon : AMD
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}