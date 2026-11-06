using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace C_252410103014_FELIX_JERICHO_M_B
{
    public class Agen
    {
        public string idAgen;
        public string namaAgen;
        public int stokAgen;

        public Agen(string idAgen, string namaAgen, int stokAgen)
        {
            this.idAgen = idAgen;
            this.namaAgen = namaAgen;
            this.stokAgen = stokAgen;
        }

        public void TampilInfo()
        {
            Console.WriteLine($"Agen {namaAgen} memiliki id Agen {idAgen} dan memiliki stok {stokAgen}");
        }
    }

    abstract class ProdukGalon
    {
        private string idProduk;
        private string namaProduk;
        private int stokGudang;

        public ProdukGalon(string idProduk, string namaProduk, int stokGudang)
        {
            this.idProduk = idProduk;
            this.namaProduk = namaProduk;
            this.stokGudang = stokGudang;
        }

        public int StokGudang
        {
            get { return stokGudang; }
            set { stokGudang = value; }
        }

        public void KurangiStok(int jumlah)
        {
            if (jumlah < 0)
            {
                Console.WriteLine("stok tidak boleh negatif");
            }

            else
            {
                StokGudang -= jumlah;
            }
        }

        abstract int HitungBiaya(int jumlah);
        {

        }
    }

    class GalonAkua : ProdukGalon
    {
        public string harga = "Rp.20.000";
        public GalonAkua(string idProduk, string namaProduk, int stokGudang) : base(idProduk, namaProduk, stokGudang)
        {
        }
    }

    class GalonBerkeran : ProdukGalon
        {
        public string harga = "Rp.12.000";
        public GalonBerkeran(string idProduk, string namaProduk, int stokGudang) : base(idProduk, namaProduk, stokGudang)
        {
        }
    }
    interface DapatDidistribusikan
    {
        public void KirimPaket();
    }

    class DistribusiGalon
            {

            }


    class SindikatGalon
            {
                ProdukGalon.List<ProdukGalon> daftarProduk;
            }

    class Program
    {
        static void Main()
        {
            Agen agen1 = new Agen("A001", "Felix", 100);
            agen1.TampilInfo();
            
            Agen agen2 = new Agen("A002", "Jericho", 50);
            agen2.TampilInfo();
        }
    }
}





















