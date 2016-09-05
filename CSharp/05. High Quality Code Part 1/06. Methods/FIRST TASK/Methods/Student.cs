namespace Methods
{
    using System;

    using Contracts;

    class Student : IStudent
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public string DateOfBirth { get; set; }

        public string HomeTown { get; set; }

        public string Hobby { get; set; }

        public string Score { get; set; }

        // probably extract this method
        public bool IsOlderThan(IStudent other)
        {
            DateTime firstStudentDate = DateTime.Parse(this.DateOfBirth.Substring(this.DateOfBirth.Length - 10));
            DateTime secondStudentDate = DateTime.Parse(other.DateOfBirth.Substring(other.DateOfBirth.Length - 10));

            bool isOlder = firstStudentDate < secondStudentDate;

            return isOlder;
        }
    }
}
