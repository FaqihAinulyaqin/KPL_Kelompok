﻿using System;
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

public class KuliahMahasiswa1302220063
{
    public class MataKuliah
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public MataKuliah[] courses { get; set; }

    public void ReadJSON(string jsonString)
    {
        KuliahMahasiswa1302220063 data = JsonSerializer.Deserialize<KuliahMahasiswa1302220063>(jsonString);
        courses = data.courses;
    }

    public void PrintData()
    {
        Console.WriteLine("Daftar mata kuliah yang diambil:");
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {courses[i].code} - {courses[i].name}");
        }
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

        string kuliahJson = "{\"courses\": [{\"code\": \"CRI2C4\", \"name\": \"Konstruksi Perangkat Lunak\"}, {\"code\": \"CRI2E4\", \"name\": \"Basis Data\"}, {\"code\": \"CRI3J2\", \"name\": \"Bahasa Inggris: Writing And Speaking\"}, {\"code\": \"CII3B4\", \"name\": \"Pemrograman Berorientasi Objek\"}, {\"code\": \"CRJ2H3\", \"name\": \"Pengalaman Pengguna\"}, {\"code\": \"CRI2F2\", \"name\": \"Proyek Tingkat II\"}, {\"code\": \"CRJ2G3\", \"name\": \"Dasar Jaringan Komputer\"}]}";
        KuliahMahasiswa1302220063 kuliah = new KuliahMahasiswa1302220063();
        kuliah.ReadJSON(kuliahJson);
        kuliah.PrintData();
    }
}