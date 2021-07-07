using System;

namespace lecture_8_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class MotoSharingService
    {

    }
    class User
    {
        Guid guid = Guid.NewGuid();
        string login = default;
        string password = default;
        string name = default;
        string lastName = default;
        DateTime dateOfBirthday = new DateTime();
        readonly int numOfTrip = default;

        public User(string nam, string lastNam) { name = nam;lastName = lastNam; } 

        void ChangePassword(string newPassword)
        {
            password = newPassword;
        }
        void GetHistoryTrip()
        {

        }
    }
    class Motorcycle
    {
        Guid guid = Guid.NewGuid();
        string manyfacturer = default;
        string model = default;
        DateTime yearOfIssue = new DateTime();
        int mileage = default;
    }
    class History
    {
        Guid guid = Guid.NewGuid();
        DateTime dateTimeBeginnig = new DateTime();
        DateTime dateTimeСompletion = new DateTime();
        int distance = default;
        Motorcycle motorcycle = new Motorcycle();
        int cost = default;
    }
}
