
using System;
using System.Collections.Generic;
using System.Threading;


namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List<T>
            // Dictionary<K,V>
            // HashSet<T>
            // Queue<T>
            // Stack<T>
            // LinkedList<T>
            // SortedSet<T>
            Student s1 = new Student("Ali Öğüt", "OGR001");
            Student s2 = new Student("Ayşe Demir", "OGR002");
            Student s3 = new Student("Mehtap Deniz", "OGR003");
            Student s4 = new Student("Tolga Keser", "OGR004");
            Student s5 = new Student("Sezer Keskin", "OGR005");
            //List<Student> students = new List<Student>();
            //Console.WriteLine(students);
            //students.Add(s1); 
            //students.Add(s2);
            //students.Add(s3);
            //Console.WriteLine(students[2]);
            //students.AddRange(new[] {s4,s5});
            //Console.WriteLine(students[4]);
            //students.Add(s1);
            //Console.WriteLine(students[5]);
            //students.Insert(0, s5);
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students.Count);
            //students.Remove(s1);
            //Console.WriteLine(students.Count);
            //students.RemoveAt(4);
            //Console.WriteLine(students.Count);
            //bool varMi=students.Contains(s1);
            //Console.WriteLine(students.Contains(s1));
            //Console.WriteLine(students.IndexOf(s2));
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //students.Reverse();
            //Console.WriteLine("Ters Çevirme İşlemi");
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.WriteLine("Sıralama İşlemi");
            //students.Sort((a,b)=>a.FullName.CompareTo(b.FullName));
            //foreach (Student student in students)
            //{
            //    Console.WriteLine(student);
            //}

            //for (int i = 0; i < students.Count; i++)
            //{
            //    Console.WriteLine(students[i]);
            //}
            //   Dictionary<String,String> students = new Dictionary<String,String>();
            //   students.Add(s1.Number,s1.FullName);
            //   students.Add(s2.Number,s2.FullName);
            //   students.Add(s3.Number,s3.FullName);
            //   students.Add(s4.Number,s4.FullName);           
            //   students[s5.Number] = s5.FullName;

            //   students.TryGetValue("OGR005", out string studentName);
            //   Console.WriteLine(students.ContainsKey("OGR001"));
            //   Console.WriteLine(students.ContainsValue("Tolga Keser"));
            //   Console.WriteLine(studentName);

            //   students[s5.Number] = s3.FullName;
            //   Console.WriteLine(students[s5.Number]);
            //   Dictionary<int,string> users= new Dictionary<int,string>();
            //   users.Add(1, "User1");
            //   Console.WriteLine(users.Count);
            //   users[1] = "User2";
            //users.Remove(1);
            //   Console.WriteLine(users.Count);

            //   foreach (KeyValuePair<string,string>  student in students)
            //   {
            //       Console.WriteLine($"{student.Key}- {student.Value}");
            //   }

            //   foreach (string key in students.Keys)
            //   {
            //       Console.WriteLine(key);
            //       Console.WriteLine(students[key]);
            //   }

            //   foreach (string value in students.Values)
            //   {
            //       Console.WriteLine(value);

            //   }

            //   foreach (var item in students)
            //   {
            //       Console.WriteLine($"{item.Key} - {item.Value}");
            //   }

            // HashSet<Student> s = new HashSet<Student>();
            // Console.WriteLine(s.Add(s1));
            // Console.WriteLine(s.Add(s2));
            // Console.WriteLine(s.Add(s3));
            // HashSet<Student> ss2=new HashSet<Student>();
            // Console.WriteLine(ss2.Add(s1));
            // Console.WriteLine(ss2.Add(s4));
            // Console.WriteLine(ss2.Add(s5));
            // Console.WriteLine("ilk"+s.Count);
            // Console.WriteLine(string.Join(",", s));
            //s.ExceptWith(ss2); 
            // Console.WriteLine("fark " + s.Count);

            // Console.WriteLine(string.Join(",", s));

            // s.IntersectWith(ss2);
            // Console.WriteLine("kesişim " + s.Count);
            // Console.WriteLine(string.Join(",", s));


            // s.UnionWith(ss2);
            // Console.WriteLine("birleşim " + s.Count);
            // Console.WriteLine(string.Join(",", s));


            // Console.WriteLine(s.Contains(s2));

            //Queue<string> kuyruk = new Queue<string>();
            //kuyruk.Enqueue("Ali");
            //kuyruk.Enqueue("Ali2");
            //kuyruk.Enqueue("Ali3");
            //kuyruk.Enqueue("Ali4");
            //kuyruk.Enqueue("Ali5");
            //kuyruk.Enqueue("Ali6");
            //int count = 0;
            //while (kuyruk.Count > 0)
            //{
            //    count++;
            //    string aday = kuyruk.Dequeue();
            //    Console.WriteLine($"{aday} ile ilgili işlemler devam ediyor");
            //    Thread.Sleep(1000);
            //    if (count % 3 == 0)
            //    {
            //        kuyruk.Enqueue(aday + (count * 2));
            //    }

            //}
            ////Console.WriteLine(kuyruk.Count);

            //Stack<Student> stack = new Stack<Student>();
            ////Console.WriteLine(stack.Peek());
            //stack.Push(s1);
            //stack.Push(s2);
            //stack.Push(s3);
            //stack.Push(s4);
            //stack.Push(s5);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            LinkedList<Student> list = new LinkedList<Student>();
            list.AddLast(s1);
            list.AddFirst(s2);

            // Sıralı liste, index'le erişim → List<T>
            // Hızlı key-value arama → Dictionary<TKey,TValue>
            // Tekrarsız eleman, hızlı "var mı" kontrolü → HashSet<T>
            // Sıra (FIFO) → Queue<T>
            // Yığın (LIFO), geri alma → Stack<T>
           

        }
    }
}
