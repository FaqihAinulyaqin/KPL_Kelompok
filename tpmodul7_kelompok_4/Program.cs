using Microsoft.VisualBasic;
using System;
using System.Text.Json;
using static DataMahasiswa1302220052;

public class DataMahasiswa1302220052
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
        DataMahasiswa1302220052 data = JsonSerializer.Deserialize<DataMahasiswa1302220052>(jsonString);
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
        string jsonString = "{\"nama\": {\"depan\": \"Naufal Ammar\", \"belakang\": \"Zaidan\"}, \"nim\": 1302220052, \"fakultas\": \"Informatika\"}";

        
        DataMahasiswa1302220052 mahasiswa = new DataMahasiswa1302220052();
        mahasiswa.ReadJSON(jsonString);

        mahasiswa.PrintData();
    }
}