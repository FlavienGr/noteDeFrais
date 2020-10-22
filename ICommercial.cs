using System;
using System.Collections.Generic;
using System.Text;

namespace notedefrais
{
    public interface ICommercial
    {
        public string Name { get; set; }
        public string Firstname { get; set; }

        public int Powercar { get; set; }

        public char Category { get; set; }

        public List<INote> GetNoteDeFrais();
        void AjouterNoteFrais(Note notedefrais);
        void ToString();
    }
}
