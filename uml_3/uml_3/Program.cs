using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_3
{
    //Kimlik Bilgisi
    public interface Identifiable
    {
        Guid Id { get; }
    }

    //Deneyim Paylaşımı
    public interface Experienced
    {
        void DeneyimPaylas();
    }

    //Aşı Sınıfı
    public class Vaccine
    {
        public string Ad { get; set; }
        public string Tip { get; set; }

        public Vaccine(string ad, string tip)
        {
            Ad = ad;
            Tip = tip;
        }
    }

    // Evcil hayvan bilgisi sınıfı
    public class PetInformation
    {
        public List<string> Ozellikler { get; set; }
        public List<Vaccine> Asilar { get; set; }

        public PetInformation()
        {
            Ozellikler = new List<string>();
            Asilar = new List<Vaccine>();
        }
    }

    //Hayvan Sınıfı
    public class Animal
    {
        public string Tur { get; set; }
        public string Irk { get; set; }
        public bool Etcil { get; set; }

        public Animal(string tur, string irk, bool etcil)
        {
            Tur = tur;
            Irk = irk;
            Etcil = etcil;
        }
    }

    //Sahip Sınıfı
    public class Owner : Experienced
    {
        public string Ad { get; set; }

        public Owner(string ad)
        {
            Ad = ad;
        }

        public void DeneyimPaylas()
        {
            Console.WriteLine($"Sahip {Ad} deneyimini paylaşıyor.");
        }
    }

    // Evcil Hayvan sınıfı 
    public class Pet : Identifiable
    {
        public Guid Id { get; private set; }
        public string Ad { get; set; }
        public int Yas { get; set; }
        public Owner Sahip { get; set; }
        public Animal Tur { get; set; }
        public PetInformation Bilgi { get; set; }

        public Pet(string ad, int yas, Owner sahip, Animal tur)
        {
            Ad = ad;
            Yas = yas;
            Sahip = sahip;
            Tur = tur;
            Bilgi = new PetInformation();
        }

        public void Besle()
        {
            Console.WriteLine($"{Ad} besleniyor.");
        }

        public bool OtculMu()
        {
            return !Tur.Etcil;
        }
    }

    //Örnek Kullanım
    class Program
    {
        static void Main(string[] args)
        {
            Owner sahip = new Owner("Sıla KOZİK");
            Animal hayvan = new Animal("Köpek", "Golden Retriever", true);
            Pet evcilHayvan = new Pet("Lessy", 4, sahip, hayvan);

            evcilHayvan.Bilgi.Ozellikler.Add("Sadık");
            evcilHayvan.Bilgi.Ozellikler.Add("Enerjik");
            evcilHayvan.Bilgi.Asilar.Add(new Vaccine("Kuduz", "Yıllık"));

            Console.WriteLine($"Evcil Hayvan ID: {evcilHayvan.Id}");
            Console.WriteLine($"Adı: {evcilHayvan.Ad}");
            Console.WriteLine($"Sahibi: {evcilHayvan.Sahip.Ad}");
            Console.WriteLine($"Hayvan Türü: {evcilHayvan.Tur.Tur}, Irk: {evcilHayvan.Tur.Irk}");
            Console.WriteLine($"Etçil mi: {evcilHayvan.Tur.Etcil}");
            Console.WriteLine($"Otçul mu: {evcilHayvan.OtculMu()}");

            Console.WriteLine("Özellikler:");
            foreach(var ozellik in evcilHayvan.Bilgi.Ozellikler)
            {
                Console.WriteLine("- " + ozellik);
            }

            Console.WriteLine("Aşılar:");
            foreach (var asi in evcilHayvan.Bilgi.Asilar)
            {
                Console.WriteLine($"- {asi.Ad} ({asi.Tip})");
            }

            evcilHayvan.Besle();
            sahip.DeneyimPaylas();

            Console.WriteLine("Çıkmak için bir tuşa basın...");
            Console.ReadLine();
        }
    }
}
