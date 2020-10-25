using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    [Serializable]
    public class FraisTransport: Note
    {
        public int Distance { get; set; }
        public FraisTransport(DateTime date, ICommercial commercial, int distance): base(date, commercial)
        {
            Distance = distance;
            this.SetMontantARembourser();
        }
        public override decimal CalculMontantARembourser() 
        {
            decimal somme = 0;
            if(AgentCommercial.Powercar < 5)
            {
                somme = (decimal)(Distance * 0.1);
            } else
            {
                if (AgentCommercial.Powercar >= 5 && AgentCommercial.Powercar <= 10)
                {
                    somme = (decimal)(Distance * 0.2);
                }
                else
                {
                    if (AgentCommercial.Powercar > 10)
                    {
                        somme = (decimal)(Distance * 0.3);
                    }
                }
            }
            return somme;
        }
        override public void ToString()
        {
            Console.WriteLine($"Transport - Numéro: {Number} Date: {DateNoteFrais.ToShortDateString()} ; Montant à rembourser : {MontantARembourser}; {(Rembourse ? "Remboursé" : "Non remboursé")}; {(Distance > 1 ? Distance + " kms" : Distance + " km")};");
        }
    }
}
