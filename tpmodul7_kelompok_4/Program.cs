using System;
using System.Text.Json;

public class DataMahasiswa_1302220086_PRAKTIKAN
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
    public Nama nama { get; set; }
    public int nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa_1302220086_PRAKTIKAN data = JsonSerializer.Deserialize<DataMahasiswa_1302220086_PRAKTIKAN>(jsonString);
        nama = data.nama;
        nim = data.nim;
        fakultas = data.fakultas;
    }
    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas{fakultas}");
    }

}

public class KuliahMahasiswa_1302220086_PRAKTIKAN
{
    public class course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public course[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        KuliahMahasiswa_1302220086_PRAKTIKAN data = JsonSerializer.Deserialize<KuliahMahasiswa_1302220086_PRAKTIKAN>(jsonString);
        courses = data.courses;
    }
    public void PrintData()
    {
        for(int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine("============================");
            Console.WriteLine($"Code: {courses[i].code}");
            Console.WriteLine($"name: {courses[i].name}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string faqihJson = "{\"nama\": {\"depan\": \"Muhammad Faqih\", \"belakang\": \"Ainulyaqin\"}, \"nim\": 1302220086, \"fakultas\": \"Informatika\"}";
        DataMahasiswa_1302220086_PRAKTIKAN faqih = new DataMahasiswa_1302220086_PRAKTIKAN();
        faqih.ReadJSON(faqihJson);
        faqih.PrintData();

        Console.WriteLine("");

        string kuliahJson = "{\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, {\"code\": \"CRI3J2\", \"name\": \"Bahasa Inggris: Writing And Speaking\"}, {\"code\": \"CII3B4\", \"name\": \"Pemrograman Berorientasi Objek\"}, {\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, {\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, {\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";
        KuliahMahasiswa_1302220086_PRAKTIKAN kuliah = new KuliahMahasiswa_1302220086_PRAKTIKAN();
        kuliah.ReadJSON(kuliahJson);
        kuliah.PrintData();
    }
}