using System;

namespace Task_with_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students student = new Students("Baxseli", "Nazarov", "AP204", 90, true);
            student.FirstStudent();
            Students student1 = new Students("Baxseli", "Nazarov", "AP204", 90, true);
            student1.allVariable();
            student1.Condition();
            Students student2 = new Students("Bahadur", "Umarov", "AP204", 79, false);
            student2.allVariable();
            student2.Condition();
        }
    }
    class Students
    {
        public string Name;
        public string Surname;
        public string Group;
        public int Point;
        public bool Graduated;
        public Students(string Ad, string Soyad, string Qrup, int Qiymet, bool Mezun)
        {
            Name = Ad;
            Surname = Soyad;
            Group = Qrup;
            Point = Qiymet;
            Graduated = Mezun;
        }
        public void FirstStudent()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}");
        }
        public void allVariable()
        {
            Console.Write($"Name: {Name}, Surname: {Surname}, Group: {Group}, Point: {Point},");
            if (Graduated == true)
            {
                Console.WriteLine(" Bu telebe mezun oldu");
            }
            else
            {
                Console.WriteLine(" Bu telebe mezun ola bilmedi");
            }
        }
        public void Condition()
        {
            if (Point > 80)
            {
                Console.WriteLine("Novbeti imtahana buraxilir");
            }
            else
            {
                Console.WriteLine("Novbeti imtahana buraxilmir");
            }
        }
    }
}
