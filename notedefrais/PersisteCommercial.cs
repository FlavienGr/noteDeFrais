using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace notedefrais
{
    
    public class PersisteCommercial
    {
        public PersisteCommercial()
        {
               
        }
        static public void Sauve(ServiceCommercial sc, string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(file, sc);
        }
        static public ServiceCommercial Charge(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            return (ServiceCommercial)bf.Deserialize(file);
        }
    }
}
