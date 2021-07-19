using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHERITANCE
{
    class Program

    {
        class Animal // Animal เป็น คลาสแม่ 
        {
            public string name; //property
            public int age; //property
            public float happiness;//property

            public void PrintBase()  // Method 
            {
                Console.WriteLine("Name:" + name); //คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ
                Console.WriteLine("Age :" + age);//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ
                Console.WriteLine("Happiness" + happiness);//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ
            }
        }
           class Dog: Animal //Dog เป็นคลาสลูกของ Animal
        {
            public int spotCount;//property
            public void Bark() // Method 
            {
                Console.WriteLine("Wuf!");//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ
                base.happiness += 0.1f;
            }
        }
          class Cat : Animal  //Cat เป็นคลาสลูกของ Animal
        {
            public float cuteness;//property
            public void Meow () // Method 
            {
                Console.WriteLine("Meow");//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ
            }
        }
        public static void Main(string[] args) 
        {
            Dog spotty = new Dog(); // Dog spotty=สร้างตัวเเปรเเรียกใช้งานclass Dog
            spotty.name = "spotty";
            spotty.age = 4;
            spotty.happiness = 0.8f;
            spotty.spotCount = 25;
            spotty.PrintBase();
            spotty.Bark();
            Console.WriteLine("New Happiness"+spotty.happiness);//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ

            Console.WriteLine();//คำสั่งสำหรับการแสดงผลข้อมูลต่าง ๆ ออกสู่หน้าจอ

            Cat heisenberg = new Cat();//Cat heisenberg=สร้างตัวเเปรเรียกใช้งานclass Cat
            heisenberg.name = "Hersenberg";
            heisenberg.age = 13;
            heisenberg.happiness = 0.3f;
            heisenberg.cuteness = 0.4f;
            heisenberg.PrintBase();
            heisenberg.Meow();


            Console.ReadKey();
        }
    }
}
