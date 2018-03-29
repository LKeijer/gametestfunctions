using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapons dagger = new Weapons(1);    //Instantiates a new Dagger weapon.
            Weapons longsword = new Weapons(3); //Instantiates a new Long Sword weapon.
            Weapons greatsword = new Weapons(4);// Same
            Weapons shortsword = new Weapons(2);// Same

            ArrayList weaponList = new ArrayList(); 
            weaponList.Add(longsword);
            weaponList.Add(greatsword);
            weaponList.Add(dagger);
            weaponList.Add(shortsword);

            Weapons st1 = weaponList[0] as Weapons;     //Casts the weapon stored in the weaponList back to a weapon so its properties can be read.
            Weapons st2 = weaponList[1] as Weapons;
            Weapons st3 = weaponList[2] as Weapons;
            Weapons st4 = weaponList[3] as Weapons;

            Console.WriteLine(st1.name);    //Long Sword
            Console.WriteLine(st2.name);    //Great Sword
            Console.WriteLine(st3.name);    //Dagger
            Console.WriteLine(st4.name);    //Short Sword

            Console.WriteLine("______________________________________________________");

            weaponList.Sort();  //Sorts the arrayList based on damage, lowest damage on top.

            Weapons st11 = weaponList[0] as Weapons;    //Casts the weapon stored in the weaponList back to a weapon so its properties can be read.
            Weapons st22 = weaponList[1] as Weapons;
            Weapons st33 = weaponList[2] as Weapons;
            Weapons st44 = weaponList[3] as Weapons;

            Console.WriteLine(st11.name);   
            Console.WriteLine(st22.name);   
            Console.WriteLine(st33.name);   
            Console.WriteLine(st44.name);   

            Console.ReadKey();
        }
    }

    public class Weapons : IComparable
    {
        public string name          { get; set; }
        public int damage           { get; set; }
        public int durability       { get; set; }
        public decimal goldValue    { get; set; }
        public int weight           { get; set; }

        public Weapons(int number)
        {
            switch (number)
            {
                case 1:
                    name = "Dagger";
                    damage = 5;
                    durability = 10;
                    goldValue = 10;
                    weight = 1;
                    break;

                case 2:
                    name = "Short Sword";
                    damage = 8;
                    durability = 15;
                    goldValue = 15;
                    weight = 2;
                    break;
                case 3:
                    name = "Long Sword";
                    damage = 10;
                    durability = 20;
                    goldValue = 30;
                    weight = 5;
                    break;
                case 4:
                    name = "Great Sword";
                    damage = 20;
                    durability = 50;
                    goldValue = 100;
                    weight = 12;
                    break;
            }
            
        }
        public int CompareTo(object obj) //This is the comparer used by the Sort() method call.
        {
            Weapons wp2 = (Weapons)obj; //Casts the object sent as a parameter into a Weapons type for comparison.
            return wp2.damage.CompareTo(this.damage);   //Compares current Weapons type damage with given Weapons type damage.
                                                        //If current item has less damage than the 2nd item, return -1.
                                                        //If equal return 0;
                                                        //If equal return 1;
        }

        
    }
}