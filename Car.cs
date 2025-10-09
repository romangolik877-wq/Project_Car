using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Сar
    {
        public Сar()
        {

        }
        public Сar(int x)
        {
            Console.WriteLine("from Without Pra Cost");
        }
        public Сar(double y)
        {
            
        }
        private int Id;
        internal string Name;
        protected  DateTime CreateDate;
        protected internal double Price;
 
        
    }
    
}
    








