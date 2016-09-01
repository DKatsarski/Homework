namespace HWSecondTask
{
    using HWSecondTask.Enums;

    public class PersonCreator
    {
        public void CreatePerson(int age)
        {
            Person person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Sex = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Sex = Gender.Female;
            }
        }
    }
}