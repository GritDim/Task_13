using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Building
    {
        public int Adres { get; set; }
        public int Dlina { get; set; }
        public int Vysota { get; set; }
        public int Shirina { get; set; }

        public Building(int adres, int dlina, int vysota, int shirina)
        {
            Adres = adres;
            Dlina = dlina;
            Vysota = vysota;
            Shirina = shirina;
        }
        public string GetInfo()
        {
            return $"Адрес - {Adres} \n Длина здания - {Dlina}\n Высота здния - {Vysota}\n Ширина здания - {Shirina}";
        }

    }

    sealed class MultiBuilding:Building
    {
        public int Etagi { get; set; }
        public MultiBuilding(int adres, int dlina, int vysota, int shirina, int etagi)
            : base(adres, dlina, vysota, shirina)
        {
            Etagi = etagi;
        }

        public string GetInfo()
        {
            string result = base.GetInfo();
            return $"{result}\n Этажность здания - {Etagi}";
        }

    }
}
