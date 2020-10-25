using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    [Serializable]
    public class RepasMidi:Note
    {
        public double MealCost { get; set; }
        public RepasMidi(DateTime date, ICommercial commercial, double amount): base(date , commercial)
        {
            this.MealCost = amount;
            this.SetMontantARembourser();
        }
        public override decimal CalculMontantARembourser()
        {
            decimal somme = 0;
            if (AgentCommercial.Category == 'A')
            {
                if (this.MealCost > 25)
                    somme = 25;
                else
                    somme = (decimal)(this.MealCost);
            }
            else
            {
                if (AgentCommercial.Category == 'B')
                {
                    if (this.MealCost > 22)
                        somme = 22;
                    else
                        somme = (decimal)(this.MealCost);
                } else
                {
                    if (AgentCommercial.Category == 'C')
                    {
                        if (this.MealCost > 20)
                            somme = 20;
                        else
                            somme = (decimal)(this.MealCost);
                    }
                }
            }
            return somme;
        }
        override public void ToString()
        {
            Console.WriteLine($"Repas midi - Numéro: {Number} Date: {DateNoteFrais.ToShortDateString()} ; Montant à rembourser : {MontantARembourser}; {(Rembourse ? "Remboursé" : "Non remboursé")};");
        }
    }
}
