using System;

public class Program
{
    public static void Main()
    {
        int jumlahPenumpang = 0;
        int jumlahMinibusTeralokasi = 0;

        Console.WriteLine("Input jumlah keluarga : ");
        int jumlahKeluarga = int.Parse(Console.ReadLine());

        Console.WriteLine("Input anggota keluarga : ");
        string[] anggotaKeluarga = Console.ReadLine().Split(' ');

        if (anggotaKeluarga.Length != jumlahKeluarga)
        {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }

        int iterator = 0;

        while (iterator < jumlahKeluarga)
        {
            jumlahPenumpang += int.Parse(anggotaKeluarga[iterator]);
            iterator++;
        }

        if (jumlahPenumpang % 4 == 0)
        {
            jumlahMinibusTeralokasi = jumlahPenumpang / 4;
        }
        else if (jumlahPenumpang > 0)
        {
            jumlahMinibusTeralokasi = (jumlahPenumpang / 4) + 1;
        }

        Console.WriteLine("Minimum bus required is : " + jumlahMinibusTeralokasi);
    }
}