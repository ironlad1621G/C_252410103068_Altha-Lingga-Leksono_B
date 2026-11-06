
namespace MAFIAGALON
{
    public class Sindikat
    {

        public string Agen;

        public Sindikat(string Agen)
        {
            this.Agen = Agen;
        }

        public void TampilInfo()
        {
            Console.WriteLine("Nama Agen Naungan" + Agen);
        }
    }
    public class AGen : Sindikat
    {
        public string NamaAgen;
        public string IdAgen;
        public int StokAgen;

        public AGen(string NamaAgen, int StokAgen, string idAgen, string Agen) : base(Agen)
        {
            this.NamaAgen = NamaAgen;
            this.StokAgen = StokAgen;
            this.IdAgen = idAgen;
            this.Agen = Agen;
        }

        public void TampilInfo()
        {
            Console.WriteLine($"Nama Agen  {NamaAgen}");
            Console.WriteLine($"stok Agen {StokAgen}");
            Console.WriteLine($"id Agen {IdAgen}");
            Console.WriteLine("SIGMAHESOYAM");
        }
    }
    public class ProdukGalon
    {
        private string IdProduk;
        private string NamaProduk;
        private int StokGudang;



        public string NAMAproduk
        {
            get { return NamaProduk; }
            set;

        }
        public string Idproduk
        {
            get { return Idproduk; }
            set;
        }
        public int STOKGUDANG
        {
            get { return StokGudang; }
            set;
        }

        public ProdukGalon(string Idproduk, string NAMAproduk, int STOKGUDANG)
        {
            this.IdProduk = Idproduk;
            this.NAMAproduk = NAMAproduk;
            this.STOKGUDANG = STOKGUDANG;

        }

        public virtual void HitungBiaya(int jumlah)
        {
            int harga = (STOKGUDANG * 200000);
            {
                Console.WriteLine($"yayayay {harga}" );
            }
           
        }


        public void KurangiStok(int jumlah)
        {

            if (jumlah < 0)
            {
                Console.WriteLine("NGUAWUR LOHYA BANGKRUT");
            }
            else
            {
                Console.WriteLine("Lanjut dah");
            }
        }
    }
    public abstract class GalonAkua : ProdukGalon
    {
        public int Harga;
        public string? Jenis;

        public GalonAkua(int Harga, string Jenis, string Idproduk, string NAMAproduk, int STOKGUDANG) : base(Idproduk, NAMAproduk, STOKGUDANG)
        {
            this.Harga = Harga;
            this.Jenis = Jenis;
            this.Idproduk = Idproduk;
            this.NAMAproduk = NAMAproduk;

        }
        public class GalonBerkeran : ProdukGalon
        {
            public int Harga;
            public string Jenis;

            public GalonBerkeran(int Harga, string Jenis, string Idproduk, string NAMAproduk, int STOKGUDANG) : base(Idproduk, NAMAproduk, STOKGUDANG)
            {
                this.Harga = Harga;
                this.Jenis = Jenis;
                this.Idproduk = Idproduk;
                this.NAMAproduk = NAMAproduk;
                this.STOKGUDANG = STOKGUDANG;
            }
        }
    }
    public class DistribusiGalon
    {
        public AGen Agen;
        public ProdukGalon produkGalon;
        
        public class DistribusikanGalon(AGen Agen, ProdukGalon produkgalon)
        {}

        public void KirimPaket()
        {
            
        } 

    }

    class Program
    {
        static void main(String[] args)
        {
            AGen agen1 = new AGen("LALAD", 1000, "25", "yaitudah");
            AGen agen2 = new AGen("NEIL", 42, "44", "kitabalassmsesterdepan");

            ProdukGalon produkGalon1 = new ProdukGalon("1", "GalonAkua", 100);
            ProdukGalon produkGalon2 = new ProdukGalon("2", "GalonBerkeran", 5);



        }
    }
}



