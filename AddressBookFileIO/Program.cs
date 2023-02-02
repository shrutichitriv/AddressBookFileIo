using AddressBookFileIO.MyFileIOOperation;

namespace AddressBookFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Addressbook File IO Program");

            string path = @"C:\Users\HP\source\RFP_244\AddressBookFileIo\AddressBookFileIO\MyFiles\PersonContact.txt";

            PersonInput input = new PersonInput();
            Console.WriteLine("Enter your First Name : ");
            input.fName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            input.lName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            input.address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            input.city = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            input.state = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            input.zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            input.phoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            input.email = Console.ReadLine();

            FileIO.WriteRecordsInFile(path, input);
            Console.WriteLine("Records present in file are : ");
            FileIO.ReadRecordsFromFile(path);
            Console.ReadLine();
        }
    }
}