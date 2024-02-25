// See https://aka.ms/new-console-template for more information



namespace Arrays
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Sedef";
            students[1] = "Hüseyin";
            students[2] = "Elif";

            string[] students1 = new string[3] {"beyza","cem","İkbal"};
             //iki şekilde de dizi tanımı yapılabilir.
            
            foreach (var student in students1)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3] //çok boyutlu dizi tanımı
            {
                { "İstanbul", "İzmit", "Kocaeli" },
                { "Ankara", "konya", "kırkkale" },
                { "Antalya", "Adana", "Mersin" },
                { "Rize", "Trabzon", "Samsun" },
                { "İzmir", "Muğla", "Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }

                Console.WriteLine("*********");
                
                // GetUpperBround() çok boyutlu dizilerde en yüksek sınırı(indeksini) belirlemek için kullanılır.
            
            }
        }
    }

}
