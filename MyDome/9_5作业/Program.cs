namespace _9_5作业 {
	internal class Program {
		static void Main ( string[] args ) {
			Employee employee = new Employee(101,"张三",40,_Political.中共党员 , 16000);
			Employee employee1 = new Employee(324,"李四",19,_Political.共青团员, 10000);
			Employee employee2 = new Employee(546,"王五",35, 8000);
            Console.WriteLine("a.将三人的信息按照年龄由小到大排序打印，");
            Console.WriteLine("b.将三人的信息按照年龄由大到小排序打印，");
            Console.WriteLine("c.将三人的信息按照税后工资由小到大排序打印，");
            Console.WriteLine("d.将三人的信息按照税后工资由大到小排序打印？");
            Console.Write("请输入（a/b/c/d）确定排序的顺序：");
            string str = Console.ReadLine();
			switch ( str ) {
				case "a":
				case "A":
					Employee.printAgemin_maxlist(employee , employee1 , employee2);
					//Employee.printAgemin_max(employee , employee1 , employee2);
					break;
				case "b":
				case "B":
					Employee.printAgemax_minlist(employee , employee1 , employee2);
					//Employee.printAgemax_min(employee2 , employee1 , employee);
					break;
				case "c":
				case "C":
					Employee.printWagemin_maxlist(employee , employee1 , employee2);
					//Employee.printWagemin_max(employee2 , employee1 , employee);
					break;
				case "d":
				case "D":
					//Employee.printWagemax_minlist(employee , employee1 , employee2);
					Employee.printWagemax_min(employee2 , employee1 , employee);
					break;
			}
			//Console.WriteLine("Hello, World!");
		}
	}
}
