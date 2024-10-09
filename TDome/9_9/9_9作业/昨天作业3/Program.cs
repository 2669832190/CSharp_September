using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业3
{
    //硬盘的规范
    public abstract class HardDriveStandard
    {
        public abstract string Memory { get; }
        public abstract void Read();
        public abstract void Write();
    }
    public class MobileHardDrive : HardDriveStandard
    {
        public override string Memory { get; } = "2t";

        public override void Read()
        {
            Console.WriteLine($"正在读移动硬盘,内存是{Memory}");
        }

        public override void Write()
        {
            Console.WriteLine($"正在写移动硬盘,内存是{Memory}");
        }
    }
    public class USB : HardDriveStandard
    {
        public override string Memory { get; } = "128G";

        public override void Read()
        {
            Console.WriteLine($"正在读U盘,内存是{Memory}");
        }

        public override void Write()
        {
            Console.WriteLine($"正在写U盘,内存是{Memory}");
        }
    }

    public class MP3 : HardDriveStandard
    {
        public override string Memory { get; } = "64G";

        public override void Read()
        {
            Console.WriteLine($"正在读MP3,内存是{Memory}");
        }

        public override void Write()
        {
            Console.WriteLine($"正在写MP3,内存是{Memory}");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3可以放音乐");
        }
    }

    //电脑
    public class Computer
    {
        //能装硬盘
        public HardDriveStandard HardDrive { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Computer com = new Computer();
            //装硬盘
            com.HardDrive = new MobileHardDrive();
            //读硬盘
            com.HardDrive.Read();
            //写硬盘
            com.HardDrive.Write();
            //换硬盘
            com.HardDrive = new MP3();
            com.HardDrive.Read();
            com.HardDrive.Write();
        }
    }
}
