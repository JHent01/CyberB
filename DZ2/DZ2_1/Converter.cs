using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2_1
{
    internal class Converter
    {

       private double usd, eur, kron,grn;


        public Converter(double usd,double eur,double kron )
        { 
            this.usd = usd;
            this.eur = eur;
            this.kron = kron;
            Console.Write("Введiть суму(грн):");
            this.grn= double.Parse(Console.ReadLine());
        }
        public double ConvertInUsd()
        {
            double resul;
            Console.Write("Введiть номер розрахунку  (1 - З USD  в GRN , 2 - З GRN в USD) ");
            int currency = int.Parse(Console.ReadLine());
            switch (currency)
            {
                case 1: return resul = usd * grn; 
                case 2: return resul = grn / usd; 
                
            }
           
           
            return grn;
        }
        public double ConvertInEur()
        {
           
            double resul;
            Console.Write("Введiть номер розрахунку  (1 - З EUR  в GRN , 2 - З GRN в EUR) ");
            int currency = int.Parse(Console.ReadLine());
            switch (currency)
            {
                case 1: return resul = eur * grn;
                case 2: return resul = grn / eur;
            }
            
            return grn;
        }
        public double ConvertInKron()
        {
            
            double resul;
            Console.Write("Введiть номер розрахунку  (1 - З USD  в KRON , 2 - З GRN в KRON) ");
            int currency = int.Parse(Console.ReadLine());
            switch (currency)
            {
                case 1: return resul = kron * grn;
                case 2: return resul = grn / kron;
            }
            
            return grn;
        }

        public double ConvertConsole()
        {
            
            Console.Write("Введiть номер валюты (1 - USD, 2 - EUR, 2 - KRON) ");
            int currency = int.Parse(Console.ReadLine());
            switch (currency)
            {
                case 1: return ConvertInUsd(); 
                case 2: return ConvertInEur();
                case 3: return ConvertInKron();
            }
            return 0;
        }

    }
}
