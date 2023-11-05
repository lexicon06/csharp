using System;
using System.Text;


namespace SteamCalculator{
    public delegate void ShowPrice(decimal price);

    class Argentina
    {
        public static void CalcArgentina(decimal money){
            Console.WriteLine("Original Price: ARS$ {0}", money.ToString("G29"));
            decimal taxRate = 1.05m;
            decimal taxAmount = money * taxRate;
            decimal total = money + taxAmount;
            Console.WriteLine("Peronian Price: ARS$ {0}", total.ToString("G29"));
        }
        public static void Main(string[] args){
            ShowPrice sp = CalcArgentina;
            sp(2500.00m);
        }

    }

}