using Microsoft.VisualBasic;
using System;
/*
// README.md를 읽고 아래에 코드를 작성하세요.
//1.
Player player = new Player();
player.Health = 100;
player.Health = -999;

class Player
{
    public int Health;
}

//2.
Player player = new Player();
player.SetHealth(100);
Console.WriteLine(player.GetHealth());
class Player
{
    private int _health;

    public void SetHealth(int value)
    {
        if(value >=0 && value <= 100)
        {
            _health = value;
        }

    }
    public int GetHealth()
    {
        return _health;
    }
}


//3.
Person person = new Person();
person.Name = "홍길동";
Console.WriteLine(person.Name);

class Person
{
    private string _name;

    public string Name
    {
        get { return _name; } 
        set { _name = value; }
    }
}


//4.
Developer dev = new Developer();
dev.Name = "김개발";
dev.Age = 25;
Console.WriteLine($"{dev.Name}, {dev.Age}세");

class Developer
{
    public string Name { get; set; }
    public int Age { get; set; }
}



//5.
Player player = new Player();
Console.WriteLine($"이름: {player.Name}");
Console.WriteLine($"레벨: {player.Level}");
Console.WriteLine($"최대 체력: {player.MaxHealth}");

class Player
{
    public string Name { get; set; } = "플레이어";
    public int Level { get; set; } = 1;
    public int MaxHealth { get; set; } = 100;
}

//6.
Car car = new Car();
car.Name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.Name}, {car.Color}");

class Car
{
    private string _name;
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Color { get; set; }



//7.
Product product = new Product();
Console.WriteLine(product.Manufacturer);

class Product
{
    public string Manufacturer
    {
        get { return "한국전자"; }
    }
}



//8.
Page page = new Page();
Console.WriteLine(page.Message);
page.UpdateMessage("업데이트된 메시지");
Console.WriteLine(page.Message );

class Page
{
    public string Message { get; private set; } = "읽기 전용 메시지";

    public void UpdateMessage(string newMessage)
    {
        Message = newMessage; 
    }


//9.
SecureData data = new SecureData();
data.Password = "secret123";
Console.WriteLine(data.Validate("secret123"));
class SecureData
{
    public string _password;

    public string Password
    {
        set { _password = value; }
    }

    public bool Validate(string input)
    {
        return _password == input;
    }
}


//10.
Circle circle = new Circle();
circle.Radius = 5;
Console.WriteLine($"반지름: {circle.Radius}");
Console.WriteLine($"넓이: {circle.Area}");
Console.WriteLine($"둘레: {circle.Circumference}");

class Circle
{
    public double Radius { get; set; }

    public double Area => 3.14159 * Radius * Radius;
    public double Circumference => 2 * 3.14159 * Radius;
}


//11.
Counter counter = new Counter();
counter.Count = 10;
counter.Increase();
Console.WriteLine($"카운트: {counter.Count}");

class Counter
{
    public int _count;

    public int Count 
    {
        get => _count;
        set => _count = value;
    }

    public void Increase() => _count++;
}


//12.
Player player = new Player();
player.Health = 150;
Console.WriteLine($"체력: {player.Health}");

player.Health = -50;
Console.WriteLine($"체력: {player.Health}");

class Player
{
    public int _health;

    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > 100)
            {
                _health = 100;
            }
            else
            {
                _health = value;
            }

        }

    }
}


//13.
Person person = new Person();
person.Name= "홍길동";
person.BirthYear = 2000;
Console.WriteLine($"{person.Name}님의 나이: {person.Age}세");

class Person
{
    private  int _birthYear;

    public string Name {  get; set; }

    public int BirthYear
    {
        set
        {
            if (value >= 1900)
            {
                _birthYear = value;
            }
        }
    }

    public int Age
    {
        get {  return DateAndTime.Now.Year - _birthYear; }
    }
}


//14.
Course course1 = new Course();
course1.Id = 1;
course1.Title = "C# 기초";
Console.WriteLine($"{course1.Id} - {course1.Title}");

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}


//15.
Course course = new Course { Id = 2, Title = "Unity 게임 개발" };
Console.WriteLine($"{course.Id} - {course.Title}");

Course[] courses =
{
    new Course {Id = 1, Title = "C# 기초"},
    new Course {Id = 2, Title = "C# 중급"},
    new Course {Id = 3, Title = "Unity  입문"}
};

foreach (var c in courses)
{
    Console.WriteLine($"{c.Id}. {c.Title}");
}

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
}


//16.
Customer customer = new Customer
{
    Id = 1,
    Name = "김철수",
    Email = "kim@example.com",
    City = "서울"
};

Console.WriteLine($"고객 #{customer.Id}");
Console.WriteLine($"이름: {customer.Name}");
Console.WriteLine($"이메일: {customer.Email}");
Console.WriteLine($"도시: {customer.City}");


class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}


//17.
Console.WriteLine($"게임: {GameSettings.GameTitle}");
Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IssoundEnabled}");

GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");

class GameSettings
{
    public static string GameTitle { get; set; } = "My Game";
    public static int MaxPlayers{ get; set; } = 4;
    public static bool IssoundEnabled { get; set; } = true;
}
*/

//18.
Monster monster = new Monster("고블린");
monster.Level = 5;
monster.Attack = 15;

Console.WriteLine($"이름: {monster.Name}");
Console.WriteLine($"레벨: {monster.Level}");
Console.WriteLine($"체력: {monster.Health}");
Console.WriteLine($"공격력: {monster.Attack}");
Console.WriteLine($"방어력: {monster.defense}");
Console.WriteLine($"생존: {monster.IsAlive}");

monster.TakeDamage(50);
Console.WriteLine($"50 대미지 후 체력: {monster.Health}");

class Monster
{
    public int _health;

    private const int k_MaxHealth = 200;

    public int Health
    {
        get { return _health; }
        set
        {
            if (value < 0)
            {
                _health = 0;
            }
            else if (value > k_MaxHealth)
            {
                _health = k_MaxHealth;
            }
            else
            {
                _health = value;
            }
        }
    }

    public int Level { get; set; } = 1;
    public int Attack { get; set; } = 10;

    public string Name { get; private set; }

    public bool IsAlive => Health > 0;
    public int defense => Level * 2;

    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        int actualDamage = damage - defense;
        if (actualDamage > 0)
        {
            Health -= actualDamage;
        }
    }
}
