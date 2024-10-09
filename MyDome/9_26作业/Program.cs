namespace _9_26作业 {
	internal class Program {
		static void Main(string[] args) {
			Thread.CurrentThread.Name = "主线程";
			Stash stash = Stash.GetStash(0);

			Thread[] production = new Thread[5];
			Thread[] consumption = new Thread[3];


			stash.add(production , stash);
			stash.remove(consumption , stash);

/*
			for ( int i = 0; i < consumption.Length; i++ ) {
				consumption[i] = new Thread(stash.Removenum);
				consumption[i].Name = "消费   " + ( i + 1 );
				consumption[i].Start();
			}*/
		}
	}
}




/*
 *
							1.写一个单例的仓库类，仓库中有产品，用int表示产品的数量
							有一个生产方法和消费方法
							生产时，将产品数量增加，但是仓库最多容纳30个产品，满了就不能再生产
							消费时，将产品数量减少，没有产品时不能消费
							（生产和消费需要时间）

							创建多个线程用于生产，多个线程用于消费，要保证线程安全

 */