namespace PracticeCSharp2
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class StartUp
    {

        static void Main()
        {
            var tryClass = new SpecialList();

            tryClass.GiveMeListOFNames = "Ivan";
            tryClass.GiveMeListOFNames = "Pesho";
            tryClass.GiveMeListOFNames = "Stamat";
            tryClass.GiveMeListOFNames = "Petran";
            tryClass.GiveMeListOFNames = "Denica";

            Console.WriteLine(tryClass.GiveMeListOFNames);

            for (int i = 32; i < 40; i++)
            {
                tryClass.Age = i.ToString();
            }

            Console.WriteLine(tryClass.Age);

            tryClass.NoReasonHere = true;

            Console.WriteLine(tryClass.NoReasonHere);

            var asdf = TestAndLearn();

            foreach (var item in asdf)
            {
                Console.WriteLine(item.ToString());
            }
        }







        public class SpecialList
        {
            private List<string> namesOfTeachers;
            private string name;

            private List<int> ageOfTeachers;
            private int age;
            public SpecialList()
            {
                this.namesOfTeachers = new List<string>();
                this.ageOfTeachers = new List<int>();

            }

            public string GiveMeListOFNames
            {
                get
                {
                    return String.Join(", ", this.namesOfTeachers.ToArray());

                }
                set
                {
                    this.name = value;
                    this.namesOfTeachers.Add(name);
                }
            }

            public string Age
            {
                get
                {
                    return String.Join(", ", this.ageOfTeachers.ToArray());
                }
                set
                {
                    this.age = int.Parse(value);
                    this.ageOfTeachers.Add(age);
                }
            }


            public bool NoReasonHere { get; set; }
        }



        public static IEnumerable<ThereWeGoClass> TestAndLearn()
        {
            var geniusMate = new SpecialList();



            return geniusMate.GiveMeListOFNames
                .Select(c => new ThereWeGoClass
                {
                    Name = "sdf",
                    Age = "23"
                })
                .ToList();


        }
    }
}
