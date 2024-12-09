namespace ConsoleApp22
{
    class Program
    {
        //завдання 1
        static void Square(int size, char symbol)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        //завдання 2
        static bool IsPalindrome(int number)
        {
            string str = number.ToString();
            int len = str.Length;

            for (int i = 0; i < len / 2; i++)
            {
                if (str[i] != str[len - i - 1])
                    return false;
            }
            return true;
        }

        //завдання 3
        static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            int[] result = new int[originalArray.Length];
            int index = 0;

            foreach (int item in originalArray)
            {
                bool isFiltered = false;
                foreach (int filterItem in filterArray)
                {
                    if (item == filterItem)
                    {
                        isFiltered = true;
                        break;
                    }
                }
                if (!isFiltered)
                {
                    result[index++] = item;
                }
            }

            Array.Resize(ref result, index);
            return result;
        }
        static void Main(string[] args)
        {
            //завдання 1
            //int size = 10;
            //char symbol = '+';
            //Square(size, symbol);

            //завдання 2
            //int number = 1221;

            //if (IsPalindrome(number))
            //    Console.WriteLine("Число є паліндромом.");
            //else
            //    Console.WriteLine("Число не паліндром.");


            //завдання 3
            //int[] originalArray = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] filterArray = { 2, 3, 10 };

            //int[] result = FilterArray(originalArray, filterArray);

            //foreach (int item in result)
            //{
            //    Console.Write(item + " ");
            //}

            //завдання 4
            //Website website = new Website();
            //website.InputData();
            //website.DisplayData();


            //завдання 5
            //Magazine magazine = new Magazine();
            //magazine.InputData();
            //magazine.DisplayData();

            //завдання 6
            Store store = new Store();
            store.InputData();
            store.DisplayData();
        }
    }

    //завдання 4
    class Website
    {
        private string name;
        private string url;
        private string description;
        private string ip;

        public void InputData()
        {
            Console.Write("Назва сайту: ");
            name = Console.ReadLine();
            Console.Write("Шлях до сайту: ");
            url = Console.ReadLine();
            Console.Write("Опис сайту: ");
            description = Console.ReadLine();
            Console.Write("IP-адреса: ");
            ip = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Шлях: {url}");
            Console.WriteLine($"Опис: {description}");
            Console.WriteLine($"IP-адреса: {ip}");
        }

        public string GetName() => name;
        public void SetName(string newName) => name = newName;
    }

    //завдання 5
    class Magazine
    {
        private string name;
        private int yearFounded;
        private string description;
        private string phoneNumber;
        private string email;

        public void InputData()
        {
            Console.Write("Назва журналу: ");
            name = Console.ReadLine();
            Console.Write("Рік заснування: ");
            yearFounded = int.Parse(Console.ReadLine());
            Console.Write("Опис журналу: ");
            description = Console.ReadLine();
            Console.Write("Контактний телефон: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Рік заснування: {yearFounded}");
            Console.WriteLine($"Опис: {description}");
            Console.WriteLine($"Телефон: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
        }

        public string GetEmail() => email;
        public void SetEmail(string newEmail) => email = newEmail;
    }

    //завдання 6
    class Store
    {
        private string name;
        private string address;
        private string description;
        private string phoneNumber;
        private string email;
        public void InputData() 
        {
            Console.Write("Назву магазину: ");
            name = Console.ReadLine();
            Console.Write("Адреса: ");
            address = Console.ReadLine();
            Console.Write("Опис профілю магазину: ");
            description = Console.ReadLine();
            Console.Write("Контактний телефон: ");
            phoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            email = Console.ReadLine();
        }
        public void DisplayData() 
        {
            Console.WriteLine($"Назва: {name}");
            Console.WriteLine($"Адреса: {address}");
            Console.WriteLine($"Опис: {description}");
            Console.WriteLine($"Телефон: {phoneNumber}");
            Console.WriteLine($"Email: {email}");
        }

        public string GetPhoneNumber() => phoneNumber;
        public void SetPhoneNumber(string newPhone) => phoneNumber = newPhone;

    }
}
