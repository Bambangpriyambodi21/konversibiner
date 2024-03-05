using System.Collections;

internal class Program
{
    static void Conv(int desimal)
    {
        if (desimal == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            int sisaBagi = desimal % 2;
            int hasilBagi = desimal / 2;
            if (hasilBagi == 0)
            {
                Console.WriteLine(Convert.ToString(sisaBagi)); 
            }
            else
            {
                Console.WriteLine(Convert.ToString(sisaBagi));
                Conv(hasilBagi); 
            }
        }
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Masukkan angka : ");
        int angka = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Bilangan Biner: ");
        Conv(angka);
    }
}