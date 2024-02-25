// See https://aka.ms/new-console-template for more information

namespace Strings
{
    class Program
    {
        public static void Main(string[] args)
        {
           //Intro();
           
           string sentence = "My name is Sedef Mert";

           var result =  sentence.Length; // kaç karakterden oluştuğunu verir.
           var result2 = sentence.Clone(); //string değerin bir referansını daha oluşturur.
           sentence = "my name is Sedef"; // cümle değişse de result değişmez bu durumda.

           bool result3 = sentence.EndsWith("ğ"); 
           bool result4 = sentence.StartsWith("my name");

           var result5 = sentence.IndexOf("name"); //kaçıncı karakterden başladığını gösterir.bulamadığında -1.
           var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğun karakterini gösterir.
           var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar.
           var result8 = sentence.Insert(0, "Hello,"); // cümlenin başına(0) Hello, ifadesini ekler.
           var result9 = sentence.Substring(3,4);// 3. karakterden itibaren 4 karakter  alır.
           var result10 = sentence.ToLower(); //küçük karaktere çevirir.
           var result11 = sentence.ToUpper();// büyük karaktere çevirir.
           var result12 = sentence.Replace(" ", "-"); //bir karakteri başka bir karakterle değiştirir
           var result13 = sentence.Remove(2,4); //2. karakterden itibaren 4 karakter siler.
           
           
           Console.WriteLine(result6);
        }

        private static void Intro() // refactor
        {
            string city = "Ankara";

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";

            Console.WriteLine(string.Format("{0} {1}",city,city2));
        }
    }

}
