using System.IO;

namespace vaja6 {

  // Enumerator za tip poklica
    public enum Poklic { Bojevnik, Carovnik, Menih, Tat, Lovec, Duhoven };

  public int x = 666;

	// Se en komentar
    class Igralec {
        public int id;
        public string u_ime;
        public string u_geslo;
        public static int stIg = 1;

        private Igralec() {
            u_ime = "";
            u_geslo = "";
            id = stIg;
            stIg++;
        }
		// omogoča vpis podatkov v igralec

        public int Id {
            get
            {
                return id;
            }
        }
		// vrne st. id

        public string U_ime {
            get
            {
                return u_ime;
            }
            set
            {
                u_ime = value.Trim();
            }
        }
		//spremeni ime in vrne novo ime

        public string U_geslo
        {
            get
            {
                return u_geslo;
            }
            set
            {
                u_geslo = value.Trim();
            }
        }
		//spremeni geslo

        public static int StIg
        {
            get { return stIg; }
        }
    }
    class vaja { 
        public static void main(String[] args)
        {

        }
    }
}
