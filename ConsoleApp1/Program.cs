// See https://aka.ms/new-console-template for more information
using LatihanOOP;

using System;
using System.Collections.Generic;

//static void MyName(string nama = null, string namaPanggilan = null)
//{
//    if (nama == null)
//    {
//        Console.WriteLine("Maaf Gak ada Namanya");
//    } else
//    {
//        Console.WriteLine($"Halo Nama Saya {nama}, Panggilan {namaPanggilan}");

//    }

//}

//static int MyAge(int age)
//{
//    if (age == 0)
//    {
//        return 0;
//    }
//    else
//    {
//        return age;
//    }

//}


//MyName("Gede Dana","Dana");
//var printAge = MyAge(5);
//Console.WriteLine($"Umur saya adalah {printAge}");


namespace LatihanOOP
{
    class vehicle : MyEmployee
    {
        
        public string _typeVehicel;

        public vehicle(string namaPegawai, DateTime tanggalMulaiBekerja, string hooby, string typeVehicel)  
            : base(namaPegawai, tanggalMulaiBekerja, hooby)
        {
            _typeVehicel = typeVehicel;
         
        }

        public string MyVehicelTyope()
        {
            return $"My Employee Vehicel Mostly using {_typeVehicel}";
        }
    }
    class MyEmployee
    {
        private string _name;
        private string _hobby;
        private DateTime _dateStartWork;
        public MyEmployee(string namaPegawai, DateTime tanggalMulaiBekerja, string hooby)
        {
            _name = namaPegawai;
            _dateStartWork = tanggalMulaiBekerja;
            _hobby = hooby;
        }

        public string MyNameEmployee()
        {
            return $"Nama Pegawai Ini adalah {_name}";
        }

        public string TanggalMulaiKerja()
        {
            var dateTimeToString = _dateStartWork;
            var dateTimeNow = DateTime.Today;

            double year = (dateTimeNow - dateTimeToString).Days / 365;
            var convertYearsToString = year.ToString();

            return $"Saya Telah Bekerja Selama {convertYearsToString} Tahun";
        }
        public string MyHobby()
        {
            return $"Hobby Dengan Pegawai {_name} adalah {_hobby}";
        }


    };




    internal static class PrintMain
    {

        private static void Main(string[] arguments)
        {

            var childObj = new vehicle("Wahyu", DateTime.Today.AddYears(-5), "Swim", "Car");
            var callMyHboy = childObj.MyHobby();
            var callTypeEmployee = childObj.MyVehicelTyope();

            Console.WriteLine(callMyHboy);
            Console.WriteLine(callTypeEmployee);
        }
    }

}


