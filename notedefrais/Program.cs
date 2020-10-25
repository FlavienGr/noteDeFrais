using System;
namespace notedefrais
{
    class Program
    {
        static void Main(string[] args)
        {

            //ServiceCommercial sc = new ServiceCommercial();
            //ICommercial commercial = new Commercial("Alan", "Bod", 8, 'A');
            //sc.AjouterCommercial(commercial);


            //sc.AjouterNote(commercial, new DateTime(2020, 10, 22), 250);
            //sc.AjouterNote(commercial, new DateTime(2020, 10, 22), 35d);
            //sc.AjouterNote(commercial, new DateTime(2020, 10, 22), 80, 2);

            //PersisteCommercial.Sauve(sc, "service.sr");

            ServiceCommercial sc = PersisteCommercial.Charge("service.sr");

            Console.WriteLine(sc.Commercials.Count);
        }
    }
}
