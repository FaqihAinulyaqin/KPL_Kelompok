using System;
using System.Text.Json;

<<<<<<< HEAD
public class DataMahasiswa_1302220086_PRAKTIKAN
=======
public class DataMahasiswa1302220052
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }
<<<<<<< HEAD
    public Nama nama { get; set; }
    public int nim { get; set; }
=======

    public Nama nama { get; set; }
    public long nim { get; set; }
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
    public string fakultas { get; set; }

    public void ReadJSON(string jsonString)
    {
<<<<<<< HEAD
        DataMahasiswa_1302220086_PRAKTIKAN data = JsonSerializer.Deserialize<DataMahasiswa_1302220086_PRAKTIKAN>(jsonString);
=======
        DataMahasiswa1302220052 data = JsonSerializer.Deserialize<DataMahasiswa1302220052>(jsonString);
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
        nama = data.nama;
        nim = data.nim;
        fakultas = data.fakultas;
    }
<<<<<<< HEAD
    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas{fakultas}");
    }

}

public class KuliahMahasiswa_1302220086_PRAKTIKAN
{
    public class course
=======

    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas {fakultas}");
    }
}

public class KuliahMahasiswa1302220052
{
    public class MataKuliah
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
    {
        public string code { get; set; }
        public string name { get; set; }
    }

<<<<<<< HEAD
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
=======
    public MataKuliah[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        KuliahMahasiswa1302220052 data = JsonSerializer.Deserialize<KuliahMahasiswa1302220052>(jsonString);
        courses = data.courses;
    }

    public void PrintData()
    {
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {courses[i].code} - {courses[i].name}");
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        string faqihJson = "{\"nama\": {\"depan\": \"Muhammad Faqih\", \"belakang\": \"Ainulyaqin\"}, \"nim\": 1302220086, \"fakultas\": \"Informatika\"}";
        DataMahasiswa_1302220086_PRAKTIKAN faqih = new DataMahasiswa_1302220086_PRAKTIKAN();
        faqih.ReadJSON(faqihJson);
        faqih.PrintData();

        Console.WriteLine("");

        string kuliahJson = "{\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, {\"code\": \"CRI3J2\", \"name\": \"Bahasa Inggris: Writing And Speaking\"}, {\"code\": \"CII3B4\", \"name\": \"Pemrograman Berorientasi Objek\"}, {\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, {\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, {\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";
        KuliahMahasiswa_1302220086_PRAKTIKAN kuliah = new KuliahMahasiswa_1302220086_PRAKTIKAN();
=======
        string mahasiswaJson = "{\"nama\": {\"depan\": \"Naufal Ammar\", \"belakang\": \"Zaidan\"}, \"nim\": 1302220052, \"fakultas\": \"Informatika\"}";
        DataMahasiswa1302220052 mahasiswa = new DataMahasiswa1302220052();
        mahasiswa.ReadJSON(mahasiswaJson);
        mahasiswa.PrintData();

        string kuliahJson = "{\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, {\"code\": \"UWJXF2\", \"name\": \"Kewirausahaan\"}, {\"code\": \"CII3B4\", \"name\": \"Pemrograman Berorientasi Objek\"}, {\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, {\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, {\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";
        KuliahMahasiswa1302220052 kuliah = new KuliahMahasiswa1302220052();
>>>>>>> d62c26798223d9c214e2c132a170a9a5da96bc40
        kuliah.ReadJSON(kuliahJson);
        kuliah.PrintData();
    }
}