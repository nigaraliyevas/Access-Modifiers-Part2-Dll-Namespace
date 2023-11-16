namespace Access_Modifiers_Part2_Dll_Namespace.Models
{
    internal class Gun
    {
        private string _shootMode;
        private int _bulletNumber;
        public string RefillGun;
        public string ShooterMode
        {
            get
            {
                return _shootMode;
            }
            set
            {
                while (value!= "Single".ToLower() && value!= "Multi".ToLower())
                {
                    Console.WriteLine("Please enter right...");
                    value= Console.ReadLine().ToLower();
                }
                _shootMode = value;
            }
        }
        public int Bullet
        {
            get=> _bulletNumber;  //Does it work like arrow func in JS ?
            set
            {
                int clipSize = 30;
                int bulletsInClip = default;
                if (value <= clipSize)
                {
                    bulletsInClip = value;
                    _bulletNumber = bulletsInClip;
                }
                else
                {
                    Console.WriteLine("HEEY MAN, HOLD ON! THAT'S TOO MANY BULLETS FOR THE CLIP. REDUCE THE NUMBER :D");
                    _bulletNumber = value;
                }
                if (_bulletNumber > 30)
                    return;
                else
                {
                    if (_shootMode == "Single".ToLower())
                    {
                        while (_bulletNumber > 0)
                        {
                            _bulletNumber--;
                            if (_bulletNumber == 0) { Console.WriteLine($"BANG!! Nice single shot.Refill the gun"); return; }
                            Console.WriteLine($"BANG!! Nice single shot. Still you've {_bulletNumber}");
                        }
                    }
                    else
                    {
                        int multiShoot = 3;
                        if (_bulletNumber == 1 || _bulletNumber == 2)
                        {
                            Console.WriteLine("Please add more bullets for multi shoot");
                            return;
                        }
                        while (_bulletNumber > 0)
                        {
                            _bulletNumber -= multiShoot;
                            if (_bulletNumber <= 0 || _bulletNumber < 3) { Console.WriteLine($"BANG!! Nice multi shot.Refill the gun"); return; }
                            Console.WriteLine($"BANG!! Nice multi shot. Still you've {_bulletNumber}");

                        }
                    }
                }
            }
        }
    }

}
