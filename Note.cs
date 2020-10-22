using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    public class Note : INote
    {
        public ICommercial AgentCommercial { get; set; }
        public Decimal MontantARembourser { get; set; }
        public bool Rembourse { get; set; }
        public int Number { get; set; }

        DateTime DateNoteFrais { get; set; }

        
        public Note(DateTime dateNoteFrais, ICommercial c)
        {
            this.Rembourse = false;
            this.DateNoteFrais = dateNoteFrais;
            this.AgentCommercial = c;
            this.Number = 1;

            this.SetNoteInCommercial();
        }
        public void SetMontantARembourser()
        {
            this.MontantARembourser = CalculMontantARembourser();
        }

        virtual public decimal CalculMontantARembourser() { return 0; }

        private void SetNoteInCommercial()
        {
            AgentCommercial.AjouterNoteFrais(this);
        }
        public void SetGiveMoneyBack()
        {
            this.Rembourse = true;
        }
        private int GetNumber()
        {
            return Number;
        }
        virtual public void ToString()
        {
            Console.WriteLine($"Numéro: {Number} Date: {DateNoteFrais.ToShortDateString()} ; Montant à rembourser : {MontantARembourser}; {(Rembourse ? "Remboursé" : "Non remboursé")};");
        }
    }
}
