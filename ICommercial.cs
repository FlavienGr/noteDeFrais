using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    public interface ICommercial
    {
        string Name { get; set; }
        string Firstname { get; set; }

        int Powercar { get; set; }

        char Category { get; set; }
        List<INote> Notes { get; set; }
        public List<INote> GetNoteDeFrais();
        void AjouterNoteFrais(Note notedefrais);
        void ToString();
    }
}
