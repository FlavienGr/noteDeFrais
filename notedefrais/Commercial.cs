using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace notedefrais
{
    
    public class Commercial: ICommercial
    {
        public string Name { get; set; }
        public string Firstname { get; set; }

        public int Powercar { get; set; }

        public char Category { get; set; }

        public List<INote> Notes { get; set; }
        public Commercial(string name, string firstname, int powerCar, char category)
        {
            Name = name;
            Firstname = firstname;
            Powercar = powerCar;
            Category = category;
            Notes = new List<INote>();
        }
        public void AjouterNoteFrais(Note notedefrais)
        {
            Notes.Add(notedefrais);
        }
        public List<INote> GetNoteDeFrais()
        {
            return Notes;
        }
        virtual public void ToString()
        {
            Console.WriteLine($"Nom: {Name} ; Prenom : {Firstname}; Puissance voiture: {Powercar}; Catégorie: {Category};");
        }
    }
}
