using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ammo System");
			//We wish to store ammo of all weapons
			//pistole = 6/6
			//shotgun 20/20
			//.....

			int weapon = 0;



			Console.WriteLine("Before Arrays");
			int pistolAmmo = 6;
			int shotGunAmmo = 20;
			//.....

			// how do we show ammo for the current weapon
			//without hard coding

			if (weapon == 0)
			{
				Console.WriteLine("Pistol Ammo: " + pistolAmmo);
			}
			if (weapon == 1)
			{
				Console.WriteLine("ShutGun Ammo: " + shotGunAmmo);
			}

			Console.WriteLine("Arrays");
			
			Console.ReadKey();
		}
	}
}
