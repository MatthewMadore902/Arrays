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

			int weapon = 2;
			Console.WriteLine();



			Console.WriteLine("Before Arrays");
			int pistolAmmo = 6;
			int shotGunAmmo = 20;
			int lazer = 50;
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
			if (weapon == 2)
			{
				Console.WriteLine("lazer Ammo: " + lazer);
			}

			Console.WriteLine();

			Console.WriteLine("With Arrays");

			int lives = 3;

			int[] ammo; //Declaring what ammo is.
						// int[] means a array of integers.
						//ammo is a array of integers.

			//int[] maxAmmo;
			//maxAmmo[0] = 6;

			ammo = new int[3]; // initialization, telling compiler the size
			ammo[0] = 6;
			ammo[1] = 2;
			ammo[2] = 50;

			string[] weaponName = new string[3];
			weaponName[0] = "pistol";
			weaponName[1] = "shotgun";
			weaponName[2] = "lazer";

			//How do we show ammo wihout hard coding

			/*			Console.WriteLine("Pistol Ammo: " + ammo[0]);
						Console.WriteLine("ShutGun Ammo: " + ammo[1]);
						Console.WriteLine("Lazer Ammo: " + ammo[2]);*/

			if (weapon == 0)
			{
				Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[0]);
			}
			if (weapon == 1)
			{
				Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[1]);
			}
			if (weapon == 2)
			{
				Console.WriteLine(weaponName[weapon] + " Ammo: " + ammo[2]);
			}




			Console.ReadKey();
		}
	}
}
