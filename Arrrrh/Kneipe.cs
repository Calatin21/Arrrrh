using System.Runtime.Serialization;

namespace Arrrrh {
    [Serializable]
    public class Kneipe {
        public string Name { get; set; }
        public Pirat Container { get; set; }
        public bool IstPiratDa() {
            bool ergebnis = false;
            if (Container != null) {
                ergebnis = true;
            }
            return ergebnis;
        }
    }
}
