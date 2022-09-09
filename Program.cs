﻿namespace Addre
{
    class AddressPrompt
    {
        AddBookManage book;

        public AddressPrompt()
        {
            book = new AddBookManage();
        }
      
            static void Main(string[] args)
            {
                string selection = "";
                AddressPrompt prompt = new AddressPrompt();

                prompt.displayMenu();
                while (!selection.ToUpper().Equals("Q"))
                {
                    Console.WriteLine("Selection: ");
                    selection = Console.ReadLine();
                    prompt.performAction(selection);
                }
            }

            void displayMenu()
            {
                Console.WriteLine("Main Menu");
                Console.WriteLine("=========");
                Console.WriteLine("A - Add an Address");
                Console.WriteLine("D - Delete an Address");
                Console.WriteLine("E - Edit an Address");
                Console.WriteLine("L - List All Addresses");
                Console.WriteLine("Q - Quit");
            }

            void performAction(string selection)
            {
                string firstname = "";
                string address = "";
                string lastname = "";
                string city = "";
                string state = "";
                int zipcode = 0;
                string email = "";
                long phoneNo = 0;

                switch (selection.ToUpper())
                {
                    case "A":
                        Console.WriteLine("Enter firstName lastname  address  city  state  zipcode  email  phoneno: ");
                        firstname = Console.ReadLine();
                        lastname = Console.ReadLine();
                        address = Console.ReadLine();
                        city = Console.ReadLine();
                        state = Console.ReadLine();
                        zipcode = int.Parse(Console.ReadLine());
                        email = Console.ReadLine();
                        phoneNo = long.Parse(Console.ReadLine());
                        if (book.add(firstname, lastname, address, city, state, zipcode, email, phoneNo))
                        {
                            Console.WriteLine("Address successfully added!");
                        }
                        else
                        {
                            Console.WriteLine("An address is already on file for {0}.", firstname + " " + lastname);
                        }
                        break;
                }
            }
    }
}

