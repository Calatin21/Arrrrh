namespace Arrrrh {
    internal class Program {
        static void Main(string[] args) {
            // Ojekte erstellen
            Meer ozean = new() { Name = "Sieben Meere"};
            Insel insel = new() { Name = "Monkey Island" };
            Wald wald = new() { Name = "Zick Zack Wald" };
            Kneipe kneipe = new() { Name = "Zum bunten Papagei" };
            Pirat pirat = new() { Name = "Guybrush" };
            // Objekte in ihre jeweiligen Container packen
            ozean.Island = insel;
            insel.NaturContainer = wald;
            insel.BarContainer = kneipe;
            //Pirat in Container packen und Ausgeben lassen wo er ist
            insel.BarContainer.Container = pirat;
            insel.ZeigDichPirat();
            //Objekte in 3 verschiedene Dateien und Formate speichern
            ozean.SaveBinary();
            ozean.SaveXML();
            ozean.SaveJson();
            //Pirat in einen anderen Container packen und ausgeben lassen
            insel.PiratContainer = pirat;
            insel.BarContainer.Container = null;
            insel.ZeigDichPirat();
            //Alle Objekte auf null setzen und aus Datei laden und Pirat aufenthaltsort ausgeben lassen
            //ozean.LoadBinary();
            //ozean.LoadXML();
            ozean.LoadJson();
            ozean.Island.ZeigDichPirat();

        }
    }
}