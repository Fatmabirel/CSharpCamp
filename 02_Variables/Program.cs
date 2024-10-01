using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
        Console.OutputEncoding = Encoding.UTF8;
        #region Double Değişkenler
        //double number;
        //number = 4.85;  // console ekranında "," şeklindee gözükür.
        //Console.WriteLine(number);
           

        Console.WriteLine("#### Fiyat Listesi ####");
        Console.WriteLine();

        double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
        applePrice = 14.85;
        orangePrice = 20.95;
        strawberryPrice = 45;
        potatoPrice = 9.74;
        tomatoPrice = 6.88;

        Console.WriteLine("--- Elma Birim Fiyatı:" + applePrice + "₺");
        Console.WriteLine("--- Portakal Birim Fiyatı:" + orangePrice + "₺");
        Console.WriteLine("--- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
        Console.WriteLine("--- Patates Birim Fiyatı:" + potatoPrice + "₺");
        Console.WriteLine("--- Domates Birim Fiyatı:" + tomatoPrice + "₺");

        double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
        appleGram = 1.245;
        orangeGram = 2.650;
        strawberryGram = 0.750;
        potatoGram = 4.859;
        tomatoGram = 3.745;

        double appleTotalPrice = appleGram * applePrice;
        double orangeTotalPrice = orangeGram * orangePrice;
        double strawberryTotalPrice = strawberryGram * strawberryPrice;
        double potatoTotalPrice = potatoGram * potatoPrice;
        double tomatoTotalPrice = tomatoGram * tomatoPrice;

        Console.WriteLine();
        Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + "₺" +applePrice +" - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice + "₺");
        Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + "₺" +orangePrice +" - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + "₺");
        Console.WriteLine("Alınan Ürün: Çilek - " + "Birim Fiyat: " + "₺" + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + "₺");
        Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + "₺" + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + "₺");
        Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + "₺" + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + "₺");

        double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + +potatoTotalPrice + tomatoTotalPrice;
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "₺");
        #endregion

        #region Char Değişkenler
        char symbol;
        symbol = 'a'; // Char formatı '' içinde yazılır
        Console.WriteLine(symbol);
        #endregion 

        #region Klavyeden Veri Girişleri String Değişkenler

        Console.WriteLine("##### CSharp Hava Yolları Yolcu Bilgisi #####");
        Console.WriteLine();

        string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

        Console.Write("Yolcu Adı: ");
        passengerName = Console.ReadLine();

        Console.Write("Yolcu Soyadı: ");
        passengerSurname = Console.ReadLine();

        Console.Write("İlçe Bilgisi: ");
        passengerDistrict = Console.ReadLine();

        Console.Write("Şehir Bilgisi: ");
        passengerCity = Console.ReadLine();

        Console.Write("Yolcu Yaş: ");
        passengerAge = Console.ReadLine();

        Console.Write("Yolcu TC Kimlik No: ");
        passengerIdentityNumber = Console.ReadLine();

        Console.WriteLine("-----------------------");
        Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +  " - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname + " " + passengerDistrict + " / " + passengerCity + " " + passengerAge);

        #endregion

        #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

        int shoesPrice, computerPrice, chairPrice, televisionPrice;
        shoesPrice = 1000;
        computerPrice = 20000;
        chairPrice = 5000;
        televisionPrice = 12000;

        int shoesCount, computerCount, chairCount, televisionCount;

        Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
        shoesCount = int.Parse(Console.ReadLine()); // Int türüne dönüşüm yapar

        Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
        computerCount = int.Parse(Console.ReadLine());

        Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
        chairCount = int.Parse(Console.ReadLine());

        Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
        televisionCount = int.Parse(Console.ReadLine());

        int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + televisionCount * televisionPrice;

        Console.WriteLine();
        Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);


        #endregion

        #region Klavyeden Ondalıklı Sayı İşlemleri

        double exam1, exam2, exam3, result;

        Console.WriteLine("Lütfen birinci sınav notunu giriniz: ");
        exam1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci sınav notunu giriniz: ");
        exam2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen üçüncü sınav notunu giriniz: ");
        exam3 = double.Parse(Console.ReadLine());

        result = (exam1 + exam2 + exam3) / 3;
        Console.WriteLine();
        Console.WriteLine("Sınav ortalamanız: " + result);

            #endregion

        #region Klavyeden Karakter Girişi

        char gender;
        Console.Write("Lütfen cinsiyet seçiniz: ");
        gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

        #endregion

        Console.Read();

        }
    }
}
