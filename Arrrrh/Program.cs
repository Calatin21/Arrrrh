namespace Arrrrh {
    internal class Program {
        static void Main(string[] args) {
            Meer ozean = new() { Name = "Sieben Meere"};
            //Insel insel = new() { Name = "Monkey Island" };
            //Wald wald = new() { Name = "Zick Zack Wald" };
            //Kneipe kneipe = new() { Name = "Zum bunten Papagei" };
            //Pirat pirat = new() { Name = "Guybrush" };
            //ozean.Island = insel;
            //insel.NaturContainer = wald;
            //insel.BarContainer = kneipe;
            //insel.BarContainer.Container = pirat;
            //insel.ZeigDichPirat();
            //ozean.SaveBinary();
            //ozean.SaveXML();
            //ozean.SaveJson();



            //ozean.LoadBinary();
            //ozean.LoadXML();
            ozean.LoadJson();
            ozean.Island.ZeigDichPirat();

        }
    }
}