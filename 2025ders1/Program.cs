// See https://aka.ms/new-console-template for more information


//Tapsiriqlar 

//******************************************************************************
//1)
//Console.WriteLine("İki ədədin cəmini hesablayan proqram");
//Console.Write("Birinci ədədi daxil edin: ");
//int BirinciSay=int.Parse(Console.ReadLine());
//Console.Write("İkinci ədədi daxil edin: ");
//int IkinciSay = int.Parse(Console.ReadLine());
//Console.WriteLine($"Cavab {BirinciSay}x{IkinciSay}={BirinciSay*IkinciSay}");
//******************************************************************************

//2)
//******************************************************************************
//Console.WriteLine("Bir sayi yazin: ");

//int SayiTekCut = int.Parse(Console.ReadLine());

//if (SayiTekCut % 2 == 0)
//{
//    Console.WriteLine("Girilien sayi cutddur");
//}
//else if (SayiTekCut % 2 == 1)
//{
//    Console.WriteLine("Girilien sayi tekdir");
//}
//else
//{
//    Console.WriteLine("Girilen sayi deyil");
//}
//******************************************************************************

//3)
//******************************************************************************
//Console.WriteLine("Bir sayi yazin: ");

//int SayiMenfiMusbet = int.Parse(Console.ReadLine());

//if (SayiMenfiMusbet > 0)
//{
//    Console.WriteLine("Girilen sayi musbetdir.");
//}
//else if (SayiMenfiMusbet < 0)
//{
//    Console.WriteLine("Girilen sayi menfidir.");
//}
//else
//{
//    Console.WriteLine("Girilen sayi sifirdir.");
//}
//******************************************************************************

//4)
//******************************************************************************
//Console.WriteLine("Yas kateqoriyasi");
//Console.Write("Yasinizi girin: ");
//byte yasyoxlamasi = byte.Parse(Console.ReadLine());

//if (yasyoxlamasi >= 0 && yasyoxlamasi <= 12)
//{
//    Console.WriteLine("Yas kateqoruyasina esasen");
//    Console.WriteLine("0-12/ Usaq");
//    Console.WriteLine("Siz usaq yas kateqoriyasina aidsiniz.");
//}
//else if (yasyoxlamasi >= 13 && yasyoxlamasi <= 19)
//{
//    Console.WriteLine("Yas kateqoruyasina esasen");
//    Console.WriteLine("13-19/ Yeniyetme");
//    Console.WriteLine("Siz yeniyetme yas kateqoriyasina aidsiniz.");
//}
//else if (yasyoxlamasi >= 20)
//{
//    Console.WriteLine("Yas kateqoruyasina esasen");
//    Console.WriteLine("20 ve daha artiq/ Boyuk");
//    Console.WriteLine("Siz boyuk yas kateqoriyasina aidsiniz.");
//}
//******************************************************************************

//5)
//******************************************************************************
//Console.WriteLine("Eded qarsilastirmasi");
//Console.Write("Ilk sayini yazin : ");
//double Ilksayi=double.Parse( Console.ReadLine());
//Console.Write("Ikinci sayini yazin : ");
//double Ikincisayi = double.Parse(Console.ReadLine());

//if (Ilksayi > Ikincisayi)
//{
//    Console.WriteLine($"Girdiyiniz ilk sayi daha boyukdur {Ilksayi}>{Ikincisayi}");
//}
//else if (Ilksayi < Ikincisayi)
//{
//    Console.WriteLine($"Girdiyiniz ikinci sayi daha boyukdur {Ilksayi}<{Ikincisayi}");
//}
//else
//{
//    Console.WriteLine($"Girdiyiniz her iki sayida eynidir {Ilksayi}={Ikincisayi}");
//}
//******************************************************************************

//6)
//******************************************************************************
//Console.WriteLine("Hefte gunlerinin sira sayina gore adlandirilmasi (Teleb olunan sayi 1-7)");
//Console.Write("Bir sayi girin: ");
//byte HefteGunSayi=byte.Parse(Console.ReadLine());

//switch (HefteGunSayi)
//{
//		case 1:
//		Console.WriteLine("Bu heftenin Bazar ertesi gunudur.");
//		break;
//		case 2:
//        Console.WriteLine("Bu heftenin Cersenbe axsami gunudur.");
//		break;
//		case 3:
//        Console.WriteLine("Bu heftenin Cersenbe gunudur.");
//		break;
//		case 4:
//        Console.WriteLine("Bu heftenin Cume axsami gunudur.");
//		break;
//		case 5:
//        Console.WriteLine("Bu heftenin Cume gunudur.");
//		break;
//		case 6:
//        Console.WriteLine("Bu heftenin Senbe gunudr.");
//		break;
//		case 7:
//        Console.WriteLine("Bu heftenin Bazar gunudur.");
//		break;
//		default:
//        Console.WriteLine("Yalniz 1-7 arasi say girin");
//		break;

//}
//******************************************************************************

//7)

//Console.WriteLine("Hansi teqvim ilinin sicrayis ili olmasinin yoxlanilmasi");
//Console.WriteLine("Bir il daxil edin:");
//int il = int.Parse(Console.ReadLine());

//// Sıçrayış ili yoxlama qaydası
//bool SicrayisIlSert1 = il % 4 == 0 ;
//bool SicrayisIlSert2 = il % 100 != 0;
//bool SicrayisIlSert3 = il % 400 == 0;

//// Gün sayını təyin etmək
//if ((SicrayisIlSert1 && !SicrayisIlSert2) || SicrayisIlSert3)
//{
//    Console.WriteLine($"{il} ili sıcrayıs ilidir. İlde 365 gun var.");
//}
//else
//{
//    Console.WriteLine($"{il} ili sısrayıs ili deyil. İlde 364 gun var.");
//}
//******************************************************************************

//8)
//******************************************************************************
//Console.WriteLine("Istifadeci giris paneli");
//Console.WriteLine("Parolu daxil edin.");
//string Parol= Console.ReadLine();
//string DogruParol = "12345";
//if (Parol == DogruParol)
//{ Console.WriteLine("Giris ugurludur."); }
//else { Console.WriteLine("Yanlis parol."); }
//******************************************************************************

//9)
//******************************************************************************
//Console.WriteLine("Tereflerin olculerine esasen ucbucagin yoxlanilmasi");
//Console.Write("Birinici terefin olcusu: ");
//double Teref1=double.Parse( Console.ReadLine());
//Console.Write("Ikinci terefin olcusu: ");
//double Teref2 = double.Parse(Console.ReadLine());
//Console.Write("Ucuncu terefin olcusu: ");
//double Teref3 = double.Parse(Console.ReadLine());

//bool sert1 = (Teref1 + Teref2) > Teref3;
//bool sert2 = (Teref1 + Teref3) > Teref2;
//bool sert3 = (Teref2 + Teref3) > Teref1;

//if (sert1 && sert2 && sert3)
//{
//    Console.WriteLine("Bu olculerle ucbucaq qurmaq mumkundur.");
//}
//else
//{
//    Console.WriteLine("Bu olculerle ucbucaq qurmaq mumkun deyil.");
//}
//******************************************************************************

//10)
//******************************************************************************
//Console.WriteLine("Dord reqemli bir tam ededin reqemlerinin ceminin hesablanmasi");
//Console.Write("Reqem daxil edin: ");
//int GirilenEded=int.Parse( Console.ReadLine());
//int toplam = 0;
//int GirilenSiraDord = 0;
//int GirilenSiraUc = 0;
//int GirilenSiraIki = 0;
//int GirilenSiraBir = 0;

//GirilenSiraDord = GirilenEded % 10;
//toplam += GirilenSiraDord;
//GirilenEded/=10;

//GirilenSiraUc=GirilenEded % 10;
//toplam += GirilenSiraUc;
//GirilenEded /= 10;

//GirilenSiraIki=GirilenEded % 10;
//toplam += GirilenSiraIki;
//GirilenEded /= 10;

//GirilenSiraBir=GirilenEded % 10;
//toplam += GirilenSiraBir;
//Console.WriteLine($"Toplam {GirilenSiraBir}+{GirilenSiraIki}+{GirilenSiraUc}+{GirilenSiraDord}={toplam}");
//******************************************************************************
