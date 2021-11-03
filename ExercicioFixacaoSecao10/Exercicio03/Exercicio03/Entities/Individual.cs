using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) 
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnualIncome < 20000.0)
            {
                tax = AnualIncome * 15 / 100;
            }
            else
            {
                tax = AnualIncome * 25 / 100;
            }

            return tax - (HealthExpenditures * 50 / 100);
        }
    }
}
