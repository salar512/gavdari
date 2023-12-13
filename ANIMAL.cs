using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gave_dari
{
    internal class Animal
    {
        public string name { set; get; }
        public double vazn { set; get; }
        public double charbi { set; get; }
        public int age { set; get; }

        public int MaxAge = 25;
        public double madfo { set; get; }
        public string bimari { set; get; }
        public string noebimari { set; get; }
        public double MeghdarShir { set; get; }
        public double meghdarGosht { set; get; }
        public string color { set; get; }
        public double daramdAZharGave { get; set; }
        public double daramdcool { get; set; }

        public void show()
        {
            Console.WriteLine("name=\n{0},vazn(k)=\n{1},charbi(k)=\n{2},age=\n{3},MaxAge=\n25, madfo(k)=\n{4},bimari=\n5},noebimari=\n{6},MeghdarShir(k)=\n{7},meghdarGosht(k)=\n{8},color=\n{9}", name, vazn, charbi, age, madfo, bimari, noebimari, MeghdarShir, meghdarGosht, color);
            
        }
        
    }
}

  

   

