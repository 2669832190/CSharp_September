using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2作业 {
    public enum Sexindex { 
        男,
        女
    }
    public struct _Student
    {
        public string _name;
        public Sexindex _sexindex;
        public double[] _doubles;
        public string _maxkm;
        public double _max;
        public double _min;
        public double _pj;
        public double _sum;
    }
    internal class FileName1 {
		public static void Main ( string[] args ) {
            _Student[] students = new _Student[4];
            string[] names = { "小明","小红","小刚","小白"};
            for ( int i = 0; i < names.Length; i++ ) {
                students[i]._name = names[i];
                students[i]._sexindex = Sexindex.男;
                students[i]._doubles = new double[4];
                for ( int j = 0; j < students[i]._doubles.Length; j++ ) {
                    Random random = new Random();
                    students[i]._doubles[j] = random.NextDouble()*100;
                }
                
				for ( int j = 0; j < students[i]._doubles.Length; j++ ) {
                    if ( students[i]._doubles[j] > students[i]._max ) {
                        students[i]._max = students[i]._doubles[j];
                        switch ( j ) {
                            case 0:
                                students[i]._maxkm = "语文";
                                break;
							case 1:
								students[i]._maxkm = "数学";
								break;
							case 2:
								students[i]._maxkm = "英语";
								break;
						}
                    }
                }
                students[i]._min = students[i]._doubles[0];
                for ( int j = 0; j < students[i]._doubles.Length; j++ ) {
                    if ( students[i]._min > students[i]._doubles[j] ) { 
                        
                    }
                }
            }
		}
	}
}
