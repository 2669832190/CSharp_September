namespace _9_13 {
	internal class Program {
		static void Main(string[] args) {
			//设计模式（23种）
			//工厂模式
			Animal animal = Factory.GetAnimal("猫");
			animal.Call();
			Animal animal1 = Factory.GetAnimal("狗");
			animal1.Call();
			//Console.WriteLine("Hello, World!");

			//简单工厂
			Animal animal2;
			again:
            Console.WriteLine("请输入想要生产的动物：");
			string name = Console.ReadLine();
			if ( name == "狗" ) {
				animal2 = new Dog();
			}else if ( name == "猫"){
				animal2 = new Cat();
			}else {
                Console.WriteLine("请重新输入！");
				goto again;
            }
			animal2.Call();
        }
	}
}
