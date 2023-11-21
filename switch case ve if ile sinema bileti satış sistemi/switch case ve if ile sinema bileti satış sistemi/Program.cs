using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case_ve_if_ile_sinema_bileti_satış_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double bilet_satıs_fiyati, ödenecek_tutar, indirim_tutarı;
            char secim1, secim2;
            Console.Write("Bilet Satış Fiyatı:");
            bilet_satıs_fiyati = Convert.ToDouble(Console.ReadLine());
            Console.Write("1:Normal Bilet 2:İndirimli Bilet\nSeçiminiz(1,2):");
            secim1 = Convert.ToChar(Console.ReadLine());
            if (secim1 =='1')
            {
                Console.Write("Bilet Fiyatı:{0}     İndirim Tutarı:0    Bilet Türü:Normal   Ödenecek Tutar:{0}", bilet_satıs_fiyati);
            }
            else if (secim1 =='2')
            {
                Console.Write("1:Öğrenci    2:Gazi      3:Öğretmen   4:Polis\nSeçiminiz(1,2,3,4):");
            }
            else
            {
                Console.Write("HATALI MENÜ GİRİŞİ YAPTINIZ.");
            }
            secim2 = Convert.ToChar(Console.ReadLine());
            switch (secim2)
            {
                case '1':
                    indirim_tutarı = bilet_satıs_fiyati * 0.5;
                    ödenecek_tutar = bilet_satıs_fiyati - indirim_tutarı;
                    Console.Write("Bilet Fiyatı:{0}     İndirim Oranı:%50      İndirim Tutarı:{1}    Bilet Türü:Öğrenci   Ödenecek Tutar:{2}", bilet_satıs_fiyati, indirim_tutarı, ödenecek_tutar);
                    break;

                case '2':
                    indirim_tutarı = bilet_satıs_fiyati * 0.4;
                    ödenecek_tutar = bilet_satıs_fiyati - indirim_tutarı;
                    Console.Write("Bilet Fiyatı:{0}     İndirim Oranı:%40      İndirim Tutarı:{1}    Bilet Türü:Gazi   Ödenecek Tutar:{2}", bilet_satıs_fiyati, indirim_tutarı, ödenecek_tutar);

                    break;

                case '3':
                    indirim_tutarı = bilet_satıs_fiyati * 0.3;
                    ödenecek_tutar = bilet_satıs_fiyati - indirim_tutarı;
                    Console.Write("Bilet Fiyatı:{0}     İndirim Oranı:%30      İndirim Tutarı:{1}    Bilet Türü:Öğretmen   Ödenecek Tutar:{2}", bilet_satıs_fiyati, indirim_tutarı, ödenecek_tutar);
                    break;

                case '4':
                    indirim_tutarı = bilet_satıs_fiyati * 0.2;
                    ödenecek_tutar = bilet_satıs_fiyati - indirim_tutarı;
                    Console.Write("Bilet Fiyatı:{0}     İndirim Oranı:%20      İndirim Tutarı:{1}    Bilet Türü:Polis   Ödenecek Tutar:{2}", bilet_satıs_fiyati, indirim_tutarı, ödenecek_tutar);
                    break;

                default:
                    Console.Write(" İndirim için HATALI MENÜ GİRİŞ YAPTINIZ.");
                    break;
            }
            Console.ReadKey();

        }
    }
}
