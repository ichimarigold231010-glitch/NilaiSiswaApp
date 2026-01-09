int nilai;
string nama;

Console.WriteLine("Aplikasi Nilai Siswa");

Console.WriteLine("Nama Siswa: ");
nama = Console.ReadLine();

Console.WriteLine("Nilai: ");
nilai = int.Parse(Console.ReadLine());

if (nilai >= 75)
{
    Console.WriteLine("Selamat. Lulus!");
}
else
{
    Console.WriteLine("Maaf, belum lulus:(");
}
