﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture9
{
    internal class Asmuo
    {
        protected readonly string _vardas;
        protected readonly string _pavarde;

        public Asmuo(string vardas, string pavarde)
        {
            _vardas = vardas;
            _pavarde = pavarde;
            Console.WriteLine("GetInfo() metodas, kuris iskvieciamas asmens sukurimo metu:");
            GetInfo();
        }

        public string GetName()
        {
            Console.WriteLine($"Vardas: {_vardas}");
            return _vardas;
        }

        public string GetSurName()
        {
            Console.WriteLine($"Pavarde: {_pavarde}");
            return _pavarde;
        }

        public virtual void GetInfo() // uzdejus 'virtual', mes galesime perrasyti jo implementacija vaikineje klaseje
        {
            Console.WriteLine($"Vardas: {_vardas}; Pavarde: {_pavarde}");
        }
    }

    internal class Studentas : Asmuo
    {
        protected string _studNumeris;

        public Studentas(string studNumeris, string vardas, string pavarde) : base(vardas, pavarde)
        {
            _studNumeris = studNumeris;
        }

        public string GiveNumber()
        {
            return _studNumeris;
        }

        public string ChangeNumber(string newNumber) // nebutinas string - gali buti ir void, vis vien issaugo
        {
            _studNumeris = newNumber;
            return _studNumeris;
        }

        public Studentas(string vardas, string pavarde) : base(vardas, pavarde)
        {
        }

        public override void GetInfo() // metodu perrasymas - kai vaikineje klaseje islaikome ta pati metodo pavadinima (kaip ir buvo tevineje klaseje)
        {
            base.GetInfo(); //iskvieciamas tevinis metodas ir toliau vykdoma, kas papildomai vaikiniame metode. perrašomas ir/ar praplečiamas metodas. tevinis pasislepia
            Console.WriteLine($"{this} {_vardas} {_pavarde} {_studNumeris}");
        }
    }
}