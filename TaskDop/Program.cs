System.Console.WriteLine("Приходит Вовочка в школу.");
System.Console.WriteLine("Подходит к расписанию.");
System.Console.WriteLine("Расписание Вовочки:");

int HowManyLessons()
{
    int Les = new Random().Next(1,6);
    return Les;
}

int Les1 = HowManyLessons();
int Les2 = HowManyLessons();
int Les3 = HowManyLessons();
int Les4 = HowManyLessons();
int Les5 = HowManyLessons();

System.Console.WriteLine($"Уроков в понедельник: {Les1}");
System.Console.WriteLine($"Уроков во вторник: {Les2}");
System.Console.WriteLine($"Уроков в среду: {Les3}");
System.Console.WriteLine($"Уроков в четверг: {Les4}");
System.Console.WriteLine($"Уроков в пятницу: {Les5}");