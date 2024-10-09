using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04单例模式
{
    //配置信息类
    //整个项目中只能有一个对象
    //任何时候任何地方访问这个对象获取到的都是同一个对象
    internal class Config
    {

        //1. 不让new  私有构造函数
        private Config() { }

        //2. 类的实例对象
        private static Config _instance = null;

        //创建一个锁 用于保证线程安全
        private static readonly object lockObject = new object();

        //第一次获取这个对象时被创建
        //3. 静态的获取方法
        public static Config GetConfig()
        {
            //先判断一次 如果为空 再去竞争锁 创建对象 不为空 就直接返回
            if(_instance == null)
            {
                //加锁 保证了线程安全 但是导致运行效率很慢
                lock (lockObject)
                {
                    //如果实例对象是空的 创建一个
                    if (_instance == null)
                    {
                        _instance = new Config();
                    }
                }
            }
            return _instance;
        }
    }
}
