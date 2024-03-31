using System;
using System.Text.Json;

public class DataMahasiswa1302220077
{
    public class Nama
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public Nama nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public DataMahasiswa1302220077() { }

    public static DataMahasiswa1302220077 FromJsonString(string jsonString)
    {
        return JsonSerializer.Deserialize<DataMahasiswa1302220077>(jsonString);
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
        string jsonString = "{\"nama\": {\"depan\": \"Helmy\", \"belakang\": \"Farikh Alfarizhi\"}, \"NIM\": 1302220077, \"fakultas\": \"Informatika\"}";

        DataMahasiswa1302220077 mahasiswa = DataMahasiswa1302220077.FromJsonString(jsonString);

        mahasiswa.PrintData();
    }
}
