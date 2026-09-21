namespace Collections
{
    internal class Student
    {
        public string  FullName { get; set; }
        public string  Number { get; set; }

        public Student(string fullname,string number) {
        FullName = fullname;
            Number = number;
        }

        public override string ToString() {
            return $"Adı: {FullName} Okul No: {Number}";
        }
    }
}