#region 员工类

public enum _Political {
	群众, 中共党员, 中共预备党员, 共青团员
}
public class Employee {
	/// <summary>
	/// 编号
	/// </summary>
	public int Id {
		get;
		set;
	}
	/// <summary>
	/// 姓名
	/// </summary>
	public string Name { get; set; }
	/// <summary>
	/// 税后工资
	/// </summary>
	public double AfterTaxWages { get; set; }
	/// <summary>
	/// 年龄
	/// </summary>
	public int _Age;
	public int Age {
		get { return _Age; }
		set {
			if ( value > 18 && value <= 60 ) {
				_Age = value;
			} else {
				Console.WriteLine("年龄不合法！！！");
			}
		}
	}
	/// <summary>
	/// 税前工资
	/// </summary>
	public double _PreTaxWages;
	public double PreTaxWages {
		get { return _PreTaxWages; }
		set {
			if ( value > 1 && value <= 17000 ) {
				_PreTaxWages = value;
			} else {
				Console.WriteLine("工资不合法！！！");
			}
		}
	}
	/// <summary>
	/// 政治面貌
	/// </summary>
	public _Political Political { get; set; }
	/// <summary>
	/// 对税后工资进行计算并赋值
	/// </summary>
	/// <param name="preTaxWages">税前工资</param>
	public void AfterTaxWagesH ( double preTaxWages ) {
		double aftertaxwages = 0;
		if ( preTaxWages > 5000 && preTaxWages <= 8000 ) {
			aftertaxwages = preTaxWages - ( preTaxWages - 5000 ) * 0.03;
		} else if ( preTaxWages > 8000 && preTaxWages <= 17000 ) {
			aftertaxwages = preTaxWages - ( preTaxWages - 5000 ) * 0.1;
		} else if ( preTaxWages <= 5000 ) {
			aftertaxwages = preTaxWages;
		}
		this.AfterTaxWages = aftertaxwages;
	}
	/// <summary>
	/// 构造函数1-群众
	/// </summary>
	/// <param name="Id"></param>
	/// <param name="Name"></param>
	/// <param name="_Age"></param>
	/// <param name="_PreTaxWages"></param>
	/*public Employee ( int Id , string Name , int _Age , double _PreTaxWages ) {
		this.Id = Id;
		this.Name = Name;
		this._Age = _Age;
		Political = _Political.群众;
		this._PreTaxWages = _PreTaxWages;
		AfterTaxWagesH(this.PreTaxWages);
	}*/
	/// <summary>
	/// 构造函数2-政治面貌
	/// </summary>
	/// <param name="Id"></param>
	/// <param name="Name"></param>
	/// <param name="_Age"></param>
	/// <param name="Political"></param>
	/// <param name="_PreTaxWages"></param>
	public Employee ( int Id , string Name , int _Age , _Political Political , double _PreTaxWages ) {
		this.Id= Id;
		this.Name = Name;
		this._Age = _Age;
		this.Political = Political;
		this._PreTaxWages = _PreTaxWages;
		AfterTaxWagesH(this.PreTaxWages);
	}
	/// <summary>
	/// 构造函数链
	/// </summary>
	/// <param name="Id"></param>
	/// <param name="Name"></param>
	/// <param name="_Age"></param>
	/// <param name="_PreTaxWages"></param>
	public Employee ( int Id , string Name , int _Age , double _PreTaxWages ) : this(Id , Name , _Age , _Political.群众 , _PreTaxWages) { }
	/// <summary>
	/// 打印信息
	/// </summary>
	public static void print ( Employee employee ) {
		Console.WriteLine("员工编号：" + employee.Id + ",\t姓名：" + employee.Name + ",\t年龄：" + employee._Age + ",\t政治面貌：" + employee.Political + " ,\t税前工资：" + employee._PreTaxWages + " ,\t税后工资：" + employee.AfterTaxWages + "。");
	}
	/// <summary>
	/// 由年龄从小到大排序打印
	/// </summary>
	/// <param name="e1"></param>
	/// <param name="e2"></param>
	/// <param name="e3"></param>
	public static void printAgemin_max ( Employee e1 , Employee e2 , Employee e3 ) {
		Employee[] employees = { e1,e2,e3};
		for ( int j = 0; j < employees.Length; j++ ) {
			for ( int i = 0; i < employees.Length - 1; i++ ) {
				if ( employees[i]._Age > employees[i + 1]._Age ) {
					Employee temp = employees[i];
					employees[i] = employees[i + 1];
					employees[i + 1] = temp;
				}
			}
		}
		foreach ( Employee employee in employees ) {
			print(employee); Console.WriteLine();
		}
	}
	/// <summary>
	/// 由年龄从大到小排序打印
	/// </summary>
	/// <param name="e1"></param>
	/// <param name="e2"></param>
	/// <param name="e3"></param>
	public static void printAgemax_min ( Employee e1 , Employee e2 , Employee e3 ) {
		Employee[] employees = { e1,e2,e3};
		for ( int j = 0; j < employees.Length; j++ ) {
			for ( int i = 0; i < employees.Length - 1; i++ ) {
				if ( employees[i]._Age < employees[i + 1]._Age ) {
					Employee temp = employees[i];
					employees[i] = employees[i + 1];
					employees[i + 1] = temp;
				}
			}
		}
		foreach ( Employee employee in employees ) {
			print(employee); Console.WriteLine();
		}
	}
	/// <summary>
	/// 由税后工资从小到大排序打印
	/// </summary>
	/// <param name="e1"></param>
	/// <param name="e2"></param>
	/// <param name="e3"></param>
	public static void printWagemin_max ( Employee e1 , Employee e2 , Employee e3 ) {
		Employee[] employees = { e1,e2,e3};
		for ( int j = 0; j < employees.Length; j++ ) {
			for ( int i = 0; i < employees.Length - 1; i++ ) {
				if ( employees[i].AfterTaxWages > employees[i + 1].AfterTaxWages ) {
					Employee temp = employees[i];
					employees[i] = employees[i + 1];
					employees[i + 1] = temp;
				}
			}
		}
		foreach ( Employee employee in employees ) {
			print(employee); Console.WriteLine();
		}
	}
	/// <summary>
	/// 由税后工资从大到小排序打印
	/// </summary>
	/// <param name="e1"></param>
	/// <param name="e2"></param>
	/// <param name="e3"></param>
	public static void printWagemax_min ( Employee e1 , Employee e2 , Employee e3 ) {
		Employee[] employees = { e1,e2,e3};
		for ( int j = 0; j < employees.Length; j++ ) {
			for ( int i = 0; i < employees.Length - 1; i++ ) {
				if ( employees[i].AfterTaxWages < employees[i + 1].AfterTaxWages ) {
					Employee temp = employees[i];
					employees[i] = employees[i + 1];
					employees[i + 1] = temp;
					/*employees[i].Id = i+1;
					employees[i+1].Id = i+2;*/
				}
			}
		}
		foreach ( Employee employee in employees ) {
			print(employee); Console.WriteLine();
		}
	}




	public static void printAgemin_maxlist ( Employee e1 , Employee e2 , Employee e3 ) {
		List<Employee> employees = new List<Employee>{ e1, e2, e3 };
		employees.Sort((x,y)=>x._Age -y._Age);
		/*for (int i = 0; i<employees.Count;i++ ) {
			employees[i].Id=i+1;
		}*/
		employees.ForEach( employee => print(employee));
	}
	public static void printAgemax_minlist ( Employee e1 , Employee e2 , Employee e3 ) {
		List<Employee> employees = new List<Employee>{ e1, e2, e3 };
		employees.Sort(( x , y ) => y._Age - x._Age);
		employees.ForEach(employee => print(employee));
	}
	public static void printWagemin_maxlist ( Employee e1 , Employee e2 , Employee e3 ) {
		List<Employee> employees = new List<Employee>{ e1, e2, e3 };
		employees.Sort(( x , y ) => (int)(x.AfterTaxWages - y.AfterTaxWages));
		employees.ForEach(employee => print(employee));
	}
	public static void printWagemax_minlist ( Employee e1 , Employee e2 , Employee e3 ) {
		List<Employee> employees = new List<Employee>{ e1, e2, e3 };
		employees.Sort(( x , y ) => (int)( y.AfterTaxWages - x.AfterTaxWages ));
		employees.ForEach(employee => print(employee));
	}
}

#endregion