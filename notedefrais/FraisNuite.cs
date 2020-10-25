using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    [Serializable]
    public class FraisNuite:Note
    {
        public int Region { get; set; }
        public double MealCost { get; set; }
        public FraisNuite(DateTime date, ICommercial commercial, double amount, int region) : base(date, commercial)
        {
            this.MealCost = amount;
            Region = region;
            this.SetMontantARembourser();
        }
        public override decimal CalculMontantARembourser()
        {
            decimal somme = 0;
            decimal coef = GetCoef();
            if (AgentCommercial.Category == 'A')
            {
                if (this.MealCost > 65)
                    somme = 65;
                else
                    somme = (decimal)(this.MealCost);
            }
            else
            {
                if (AgentCommercial.Category == 'B')
                {
                    if (this.MealCost > 55)
                        somme = 55;
                    else
                        somme = (decimal)(this.MealCost);
                } else
                {
                    if (AgentCommercial.Category == 'C')
                    {
                        if (this.MealCost > 50)
                            somme = 50;
                        else
                            somme = (decimal)(this.MealCost);
                    }
                }
            }
            return (decimal)(somme * coef);
        }
        private decimal GetCoef()
        {
            decimal coef = 0;
            if (Region == 1)
                coef = 0.90m;
            else if (Region == 2)
                coef = 1;
            else if (Region == 3)
                coef = 1.15m;
            return coef;
        }
        override public void ToString()
        {
            Console.WriteLine($"Nuité - Numéro: {Number} Date: {DateNoteFrais.ToShortDateString()} ; Montant à rembourser : {MontantARembourser}; {(Rembourse ? "Remboursé" : "Non remboursé")}; Region {Region};");
        }
    }
}
