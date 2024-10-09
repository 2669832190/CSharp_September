using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9作业 {
	internal class HardDisk {
		public static void maina() {
			HardDisks prtableHardDisk = new PortableHardDisk();
			HardDisks flashDrive = new FlashDrive();
			HardDisks mp3 = new MP3();
			prtableHardDisk.parint();
			prtableHardDisk.ReadWrite();
            Console.WriteLine();
            flashDrive.parint();
			flashDrive.ReadWrite();
			Console.WriteLine();
			mp3.parint();
			mp3.ReadWrite();
			MP3 mP3 = mp3 as MP3;
			mP3.music();
			Console.WriteLine();
			Computer comparer = new Computer();
		}
	}
	public abstract class HardDisks {
		public abstract string Name { get; set; }
		public abstract string Capacity { get; set; }
		public abstract void ReadWrite();
		public abstract void ComputerRW ();

		public void parint () {
            Console.WriteLine(Name + "内存为：" + Capacity);
        }
		
	}
	public class PortableHardDisk : HardDisks {
		public override string Name { get; set; } = "移动硬盘";

		public override string Capacity { get; set; } = "2T" ;
		public override void ReadWrite () {
            Console.WriteLine("移动硬盘读写");
        }
		public override void ComputerRW () {
            Console.WriteLine("电脑插入移动硬盘！");
        }
	}
	public class FlashDrive : HardDisks {
		public override string Name { get; set; } = "U盘";
		public override void ComputerRW () {
            Console.WriteLine("U盘插入电脑");
        }

		public override string Capacity { get; set; } = "128G";
		public override void ReadWrite () {
			Console.WriteLine("U盘读写");
		}
	}
	public class MP3 : HardDisks {
		public override string Name { get; set; } = "MP3";
		public override void ComputerRW () {
			Console.WriteLine("MP3插入电脑");
		}
		public override string Capacity { get; set; } = "64G";
		public override void ReadWrite () {
			Console.WriteLine("MP3读写");
		}
		public void music () {
            Console.WriteLine("MP3放音乐");
        }
	}

	public class Computer {
		public Computer() {
			HardDisks hardDisks = new PortableHardDisk();
			hardDisks.ComputerRW();
			hardDisks.ReadWrite();
		}
	}
}
