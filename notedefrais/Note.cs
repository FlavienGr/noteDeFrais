using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    [Serializable]
    public class Note : INote
    {
        public ICommercial AgentCommercial { get; set; }
        public Decimal MontantARembourser { get; set; }
        public bool Rembourse { get; set; }
        public int Number { get; set; }

        public DateTime DateNoteFrais { get; set; }

        
        public Note(DateTime dateNoteFrais, ICommercial c)
        {
            this.Rembourse = false;
            this.DateNoteFrais = dateNoteFrais;
            this.AgentCommercial = c;
            

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
            Number = AgentCommercial.GetNoteDeFrais().Count;
        }
        public void SetGiveMoneyBack()
        {
            this.Rembourse = true;
        }
        public int GetNumber()
        {
            return Number;
        }
        public decimal GetMontantARembourser()
        {
            return this.MontantARembourser;
        }
        virtual public void ToString()
        {
            Console.WriteLine($"Numéro: {Number} Date: {DateNoteFrais.ToShortDateString()} ; Montant à rembourser : {MontantARembourser}; {(Rembourse ? "Remboursé" : "Non remboursé")};");
        }
    }
}
