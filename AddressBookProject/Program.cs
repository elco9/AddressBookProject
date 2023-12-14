namespace AddressBookProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook janAdressebog = new("Jan");
            janAdressebog.AddAddress(new Address("Hans Peter Nielsen", "Birkehøj 5", "2134123456"));
            janAdressebog.AddAddress(new Address("Jens Peter Larsen", "Poppelhøj 6", "2345619481"));
            Console.WriteLine(janAdressebog);
            AddressBook boAdressebog = new("Bo");
            boAdressebog.AddAddress(new Address("Niels Peter Hansen", "Bøgehøj 7", "213412345636"));
            boAdressebog.AddAddress(new Address("Lars Peter Jensen", "Fyrrehøj 8", "2345679801"));
            Console.WriteLine(boAdressebog);

            AddressBook samletAdresseBog = AddressBook.SamletAdresseBog(janAdressebog, boAdressebog);
            
            Console.WriteLine(samletAdresseBog);
        }
    }
}
