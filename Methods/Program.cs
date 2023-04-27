namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Add();
            //Add();

            //var result = Add2();
            //Console.WriteLine(result);


            int number1 = 20;
            int number2 = 100;
            
            var sonuc = Add3(  number1, number2);

            Console.WriteLine(sonuc);
            Console.WriteLine(number1);

            //Console.WriteLine(Multiply(2,4));
            //Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));
            // ref keywordu değer tip olan bir veri tipini referans olarak göstererek

            //Sonucu değiştirmememize yarar. 
            /*
             Örneğin : Bir kredi hesaplama yaparken bir kredi oranı var. Müşterinin tipine göre 
            diyelim bir indirim kazandı, mainimin içerisinde parametre olarak vermiş olduğum değerleri
            ben metodumun içerisinde değişebileceğini düşünüyorsak bu bizim için geçerli bir iş süreci ise

                onu ref olarak gönderiyoruz.

               def'in  bir diğer alternatifi out 'dur . Kısaca değer tipi referans tip gibi gönderdim. 


                out bir değer atanmasına bağımlı değil Lâkin ref bir değer atanmadığında kızar. 
            14. Kod satırındaki atama için ref 20 değerinin atanmasını istiyor out da böyle bir zorunluluk yok.

             */ 

        }

        //static void Add()
        //{
        //    Console.WriteLine("added!!!");
        //}

        //static int Add2(int number1 = 20, int number2 = 30)
        //{
        //    var result = number1 + number2;
        //    return result;
        //}


        static int Add3( int number1, int number2)
        {

            number1 = 30;

            return number1 + number2;


        }

        //static int Multiply(int number1, int number2)
        //{
        //    return number1 * number2;

            
        //}
        //ikisinin imzası farklı olduğu için program bana kızmayacak buna OverLoad denir.
       // static int Multiply(int number1, int number2,int number3)
        //{
        //    return number1 * number2 * number3;


        //}



        //Birden fazla aynı tipte parametre göndereceksek params kullanıp istediğimiz kadar değer yazabiliriz.
        //params'ın başına int number diye de ayriyeten bir değer atayabiliriz önce 
        // atadığımız değer çalışır sonra params 

    // fonksiyon içerisinde kullanırken return numbers.Sum yazıyoruz.

        //static int Add4(params int[] numbers)
        //{
        //    return numbers.Sum();
        //}


       
        




    }
}