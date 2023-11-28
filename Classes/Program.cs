namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };

            PrintArray();
            
            Console.WriteLine();

            Array.Reverse(array);
            PrintArray();
            
            Console.WriteLine();
            
            void PrintArray()
            {
                foreach (var item in array)
                {
                    Console.Write($"{item}\t");
                }
            }
            
            // -=================== Метод без параметров ===================-
            void MethodWithoutParameters()
            {
                // Тело метода
            }

            // -=================== Метод без возвращаемого значения ===================-
            void PrintMessage(string message)
            {
                Console.WriteLine(message);
            }
            
            PrintMessage("Text");
            string tmp = "Taskjdkasdh";
            PrintMessage(tmp);
            
            // -=================== Метод c возвращаемым значенем ===================-
            string GetInfo()
            {
                ///...
                return "Test";
            }

            string result = GetInfo();
            
            Console.WriteLine(result);
            
            // -=================== Метод с параметрами по умолчанию ===================-
            void DisplayGreeting(string greetingMessage, string name = "Гость")
            {
                Console.WriteLine($"{greetingMessage}, {name}!");
            }
            
            DisplayGreeting("Hello");
            DisplayGreeting("Hello", " Alex");
            DisplayGreeting(" Alex", "Hello");
            
            // -=================== Метод с переменным числом аргументов ===================-
            int CalculateSum(params int[] numbers)
            {
                int sum = 0;

                foreach (int num in numbers)
                {
                    sum += num;
                }
                return sum;
            }
            
            int sum1 = CalculateSum(1, 2, 3, 4, 5);
            int sum2 = CalculateSum(); // Пустой вызов

            Console.WriteLine("Sum 1: " + sum1);
            Console.WriteLine("Sum 2: " + sum2);
            
            // -=================== Передача параметров ===================-
            // -=================== По значению

            void SimpleAdd(int x, int y) //По умолчанию аргументы передаются по значению,
            {
                int ans = x + y;
                
                // Вызывающий код не увидит эти изменения, т.к. модифицируется копия исходных данных,
                // х = 10000;
                // у = 88888;
            }

            // -=================== По ссылке
            // -=================== Out
            // Значения выходных параметров должны быть установлены внутри вызываемого метода.
            int OutAdd(int x, int y, out int ans)
            {
                ans = x + y;

                return x * y;
            }

            // Присваивать начальные значения локальным переменным, используемым как выходные параметры, не обязательно
            // при условии, что они впервые используются
            OutAdd(90, 90, out int ans); // - Первый вариант
            
            //int ans;
            //Add(90, 90, out ans); // - Второй вариант
            
            Console.WriteLine("OutAdd: 90 + 90 = {0}", ans);
            
            // Практическое применение в тестировании - возврат данных
            void FillTheseValues(out int a, out string b, out bool c)
            {
                a = 9;
                b = "Enjoy your string.";
                c = true;
            }

            // -=================== Ref
            void ModifyValue(ref int value)
            {
                //value = value * 2;
            }

            int mainValue = 5;      // Если закоментировать - будет ошибка
            Console.WriteLine($"mainValue is {mainValue}");
            ModifyValue(ref mainValue);
            Console.WriteLine($"mainValue now is {mainValue}");            
            
            // -=================== Возврат значений ===================-
            // -=================== Возврат значения
            int GetPersonAge()
            {
                return 25;
            }

            Console.WriteLine($"Age: {GetPersonAge()}");
            
            // -=================== Возврат нескольких значений
            (string, int, string) GetPersonInfo()
            {
                return ("John", 25, "Test");
            }

            var person = GetPersonInfo();
            Console.WriteLine($"Name: {person.Item1}, Age: {person.Item2}");

            // -=================== Сжатый метод
            int ShortAdd(int х, int у) => х + у;

            // -=================== Рекурсивная функция
            int Factorial(int n)
            {
                if (n == 1) return 1;
 
                return n * Factorial(n - 1);
            }

            int factorial4 = Factorial(4);  // 24
            int factorial5 = Factorial(5);  // 120
            int factorial6 = Factorial(6);  // 720
 
            Console.WriteLine($"Факториал числа 4 = {factorial4}");
            Console.WriteLine($"Факториал числа 5 = {factorial5}");
            Console.WriteLine($"Факториал числа 6 = {factorial6}");
        }
    }
}