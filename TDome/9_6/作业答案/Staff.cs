using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业答案
{
    public enum politicalOutlook
    {
        群众,
        团员,
        党员,
        预备党员
    }

    //员工类
    public class Staff
    {
        //编号不输入，自动增加
        //静态属性: 属于类 不属于对象
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public politicalOutlook PO { get; set; }
        public double GrossPay { get; set; }
        public double AfterTaxSalary { get; set; }

        public Staff(int iD, string name, int age, politicalOutlook pO, double grossPay)
        {
            ID = iD;
            Name = name;
            Age = age;
            PO = pO;
            GrossPay = grossPay;
            //计算税后工资
            if(GrossPay <= 5000)
            {
                AfterTaxSalary = GrossPay;
            }else if(GrossPay <= 8000)
            {
                AfterTaxSalary = GrossPay - (GrossPay - 5000) * 0.03;
            }else if(GrossPay <= 17000)
            {
                AfterTaxSalary = GrossPay - (GrossPay - 8000) * 0.1 - 3000 * 0.03;
            }
        }

        public Staff(int iD, string name, int age, double grossPay) : this(iD, name, age, politicalOutlook.群众, grossPay) { }

        public void printStaffInfo()
        {
            Console.WriteLine($"员工编号{ID},姓名{Name},年龄{Age},政治面貌{PO},税前工资{GrossPay},税后工资{AfterTaxSalary}");
        }
    }
}
