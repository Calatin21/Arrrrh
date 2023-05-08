namespace Arrrrh {
    [Serializable]
    public class Insel {
        public string Name { get; set; }
        public Wald NaturContainer { get; set; }
        public Kneipe BarContainer { get; set; }
        public Pirat PiratContainer { get; set; }
        public void ZeigDichPirat() {
            string ort = "";
            if (NaturContainer.IstPiratDa()) {
                ort = NaturContainer.Name;
            }
            else if (BarContainer.IstPiratDa()) {
                ort = BarContainer.Name;
            }
            else if (this.IstPiratDa()) {
                ort = this.Name;
            }
            Console.WriteLine(ort);
        }
        public bool IstPiratDa() {
            bool ergebnis = false;
            if (PiratContainer != null) {
                ergebnis = true;
            }
            return ergebnis;
        }
    }
}
