using System;

class Program
{
    static bool IsAnagram(string str1, string str2)
    {
        str1 = str1.Replace(" ", "").ToLower();
        str2 = str2.Replace(" ", "").ToLower();

        // Memeriksa apakah kedua string adalah anagram
        char[] charArray1 = str1.ToCharArray();
        Array.Sort(charArray1);

        char[] charArray2 = str2.ToCharArray();
        Array.Sort(charArray2);

        return new string(charArray1) == new string(charArray2);
    }

    static void Main()
    {
        // Memasukkan input dari pengguna untuk kata pertama dan kedua
        Console.Write("Masukkan kata pertama (dipisahkan oleh koma): ");
        string kataPertamaInput = Console.ReadLine();

        Console.Write("Masukkan kata kedua (dipisahkan oleh koma): ");
        string kataKeduaInput = Console.ReadLine();

        string[] kataPertamaArray = kataPertamaInput.Split(',');
        string[] kataKeduaArray = kataKeduaInput.Split(',');

        for (int i = 0; i < Math.Min(kataPertamaArray.Length, kataKeduaArray.Length); i++)
        {
            Console.Write(IsAnagram(kataPertamaArray[i], kataKeduaArray[i]) ? "1" : "0");
        }

        Console.WriteLine();
    }
}
