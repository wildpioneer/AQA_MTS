// See https://aka.ms/new-console-template for more information

{
    // Это сообщение будет выведено на экран
    /*
     Это сообщение будет выведено на экран
     */
    /*
    Console.WriteLine("Hello, World!");
    {
        Console.WriteLine("It's a nice day!");        
    }

    const int MINUTES_IN_HOUR = 60;
    
    string name;

    name = "Bob";
    Console.WriteLine(name);
    
    name = "Bob1";
    Console.WriteLine(name);
    
    name = "Bob2";
    Console.WriteLine(name);
    
    Console.WriteLine(true);
    Console.WriteLine(false);

    Console.WriteLine(-10);
    Console.WriteLine(0);
    Console.WriteLine(10);
    Console.WriteLine(0b10011);
    
    Console.WriteLine(1.24);
    Console.WriteLine(1.24F);
    
    Console.WriteLine('H');
    
    //Console.WriteLine(null);

    Console.WriteLine("It's a \t nice day!");
    Console.WriteLine("It's a \n nice day!");
    Console.WriteLine("It's a '\' nice day!");

    bool flag = true;
    flag = false;

    sbyte sb = 100;

    float a = 3.14F;
    float a1 = 3.14f;

    decimal c = 1005.5M;
    decimal c1 = 1005.5m;

    var d = 10;
    var d1 = 10.2F;
    var d2 = 'D';
    var d3 = "Thank's";

    int j;
    j = 20;

    var j1 = 20;
*/    
    
    
    /*
    Console.WriteLine("Добро пожаловать в C#");
    Console.Write("Надеюсь Вы ");
    Console.Write("постигните нюансы в C#! \n");
    Console.WriteLine("И все будет супер гуд!!!");
    */
    
    /*
    int j;
    j = 20;

    Console.WriteLine("J = " + j);

    string name = "Tom";
    int age = 34;
    double height = 1.7;
    
    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}");
    Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}", name, height, age);
    */

    Console.WriteLine("Введите свое имя:");
    string? name = Console.ReadLine();
    Console.WriteLine($"Ваше имя: {name}");

    Console.WriteLine("Введите свой возраст:");
    string? age_str = Console.ReadLine();
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Ваш возраст: {age}");


    

    /*
    // Решение нашей задачи
    // Подготовка данных
    bool isWhiteBreadFresh = true;
    ushort whiteBreadPrice = 150;
    ushort butterPrice = 230;
    ushort milkPrice = 170;
    float milkFatPercentage = 1.2F;
    */
}