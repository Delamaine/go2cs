// package main -- go2cs converted at 2018 August 14 00:22:20 UTC
// Original source: C:\Projects\go2cs\src\Tests\Behavioral\StructPromotion.go
using fmt = go.fmt_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        public partial struct Person
        {
            public @string name;
            public int32 age;
        }

        public static @bool IsAdult(this Person p)
        {
            return p.age >= 18;
        }

        public partial struct Employee
        {
            public @string position;
        }

        public static @bool IsManager(this Employee e)
        {
            return e.position == "manager";
        }

        public partial struct Record
        {
            public ref Person Person => ref Person_val;
            public ref Employee Employee => ref Employee_val;
        }

        private static void Main()
        {
            var person = Person{name:"Michał",age:29};
            fmt.Println(person); // {Michał 29}
            var record = Record{};
            record.name = "Michał";
            record.age = 29;
            record.position = "software engineer";

            fmt.Println(record); // {{Michał 29} {software engineer}}
            fmt.Println(record.name); // Michał
            fmt.Println(record.age); // 29
            fmt.Println(record.position); // software engineer
            fmt.Println(record.IsAdult()); // true
            fmt.Println(record.IsManager()); // false
        }
    }
}
