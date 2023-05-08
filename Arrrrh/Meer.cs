using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace Arrrrh {
    internal class Meer {
        public string Name { get; set; }
        public Insel Island { get; set; }
        public void SaveBinary() {
            FileStream fileOutputStream = new FileStream(@"Insel.bit", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter binFttr = new BinaryFormatter();
            binFttr.Serialize(fileOutputStream, Island);
            Console.WriteLine("Datei geschrieben ...");
            fileOutputStream.Close();
        }

        public void LoadBinary() {
            FileStream fileInputStream = new FileStream(@"Insel.bit", FileMode.Open, FileAccess.Read);
            BinaryFormatter binFttr = new BinaryFormatter();
            Island = null;
            Island = (Insel)binFttr.Deserialize(fileInputStream);
            fileInputStream.Close();
        }
        public void SaveXML() {
            FileStream fs = new FileStream(@"Insel.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new(typeof(Insel));
            xml.Serialize(fs, Island);
            Console.WriteLine("Datei geschrieben ...");
            fs.Close();
        }

        public void LoadXML() {
            FileStream fs = new FileStream(@"Insel.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new(typeof(Insel));
            Island = null;
            Island = (Insel)xml.Deserialize(fs);
            fs.Close();
        }
        public void SaveJson() {
            FileStream fs = new FileStream(@"Insel.json", FileMode.OpenOrCreate, FileAccess.Write);
            JsonSerializer.Serialize(fs, Island);
            Console.WriteLine("Datei geschrieben ...");
            fs.Close();
        }

        public void LoadJson() {
            FileStream fs = new FileStream(@"Insel.json", FileMode.Open, FileAccess.Read);
            Island = null;
            Island = JsonSerializer.Deserialize(fs, Json);
            fs.Close();
        }
    }
}
