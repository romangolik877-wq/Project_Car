using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    public abstract class Сar
    {
        int y;
        int x;
        int _id;
        private float _name;
        internal Double Salary = 50000;
        internal protected string _description = "You can Write what you want in your life";
        public DateTime Create;
        internal static Boolean IsMan = true;

        protected virtual double Calculate(int num1, int num2)
        {
            return 0;
           
        }
    }
}












