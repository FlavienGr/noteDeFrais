using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    [Serializable]
    public class ServiceCommercial
    {
        public List<ICommercial> Commercials;
        public ServiceCommercial()
        {
            Commercials = new List<ICommercial>();
        }
        public void AjouterCommercial(ICommercial commercial)
        {
            Commercials.Add(commercial);
        }
        public void AjouterNote(ICommercial commercial, DateTime date, int distance)
        {
            new FraisTransport(date,commercial, distance);
        }
        public void AjouterNote(ICommercial commercial, DateTime date, double amount)
        {
            new RepasMidi(date, commercial, amount);
        }
        public void AjouterNote(ICommercial commercial, DateTime date, double amount, int region)
        {
            new FraisNuite(date, commercial, amount, region);
        }
        public int NombreFraisNonRembourser()
        {
            int nb = 0;
            foreach(ICommercial commercial in Commercials)
            {
                foreach (INote note in commercial.Notes)
                {
                    if (!note.Rembourse)
                    {
                        nb++;
                    }
                }
            }
            return nb;
        }
    }
}
