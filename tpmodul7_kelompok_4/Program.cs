using System;
using System.Text.Json;

public class DataMahasiswa1302220063
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON(string jsonString)
    {
        DataMahasiswa1302220063 data = JsonSerializer.Deserialize<DataMahasiswa1302220063>(jsonString);
        nama = data.nama;
        nim = data.nim;
        fakultas = data.fakultas;
    }

    public void PrintData()
    {
        Console.WriteLine($"Nama {nama.depan} {nama.belakang} dengan nim {nim} dari fakultas {fakultas}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string mahasiswaJson = "{\"nama\": {\"depan\": \"Irham\", \"belakang\": \"Baehaqi\"}, \"nim\": 1302220077, \"fakultas\": \"Informatika\"}";
        DataMahasiswa1302220063 mahasiswa = new DataMahasiswa1302220063();
        mahasiswa.ReadJSON(mahasiswaJson);
        mahasiswa.PrintData();
    }
}