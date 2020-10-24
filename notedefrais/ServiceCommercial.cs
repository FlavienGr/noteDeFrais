using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
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
