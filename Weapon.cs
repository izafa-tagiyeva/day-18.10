using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Weapon
    {

        public bool atis_modu;
        private int _tutum;
        public int tutum
        {
            get { return _tutum; }
            set
            {

                if (value > 0)
                {
                    _tutum = value;
                }
                else { Console.WriteLine("please make sure that number is greater than zero"); }

            }
        }


        private int _say;
        public int say
        {
            get { return _say; }
            set
            {
                if (value > 0)
                {
                    _say = value;
                }
                else { Console.WriteLine("please make sure that number is greater than zero"); }
            }
        }
        public Weapon()
        {

        }

        public Weapon(int tutum, int say, bool atis_modu)
        {

            this._tutum = tutum;
            this._say = say;
            this.atis_modu = atis_modu;
        }




        //informasi alamq ucun metod
        public void GetInfo(int tutum, int say, bool atis_modu)
        {
            Console.WriteLine($"gullenin tutumu:{tutum}, sayi:{say}");
            if (atis_modu)
            {
                Console.WriteLine("atis modu: tekli");
            }
            else { Console.WriteLine("atis modu: umumi"); }
        }




        //Shoot() -  metodu hər çağırıldıqda fire moduna gore ya 1 güllə atır yada avtomatik gulleni bosaldir.(Ekranda bunu bildirir)

        public void Shoot(bool atis_modu)
        {
            if (atis_modu)
            {
                _say = _say - 1;
                Console.WriteLine("1 gulle azaldi");
            }
            else
            {
                _say = 0;
                Console.WriteLine("hamisi bitdi");
            }
        }

        //GetRemainBulletCount() - darağın tam dolması üçün lazım olan güllə sayını qaytarır.

        public int GetRemainBulletCount(int _say, int _tutum)
        {
            int lazim_olan = _tutum - _say;
            return lazim_olan;

        }
        // Reload() - darağı yenidən doldurur.
        public int Reload()
        {
            _say = _tutum;
            return _say;
        }

        //ChangeFireMode() - Atış modunu dəyişir.
        public bool ChangeFireMode(bool atis_modu)
        {
            if (atis_modu)
            {
                return atis_modu = false;
            }
            else { return atis_modu = true; }
        }


    }
}
