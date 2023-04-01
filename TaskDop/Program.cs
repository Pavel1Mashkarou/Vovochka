int LesMin = 4;
int LesMax = 6;
System.Console.WriteLine("Приходит Вовочка в школу.");
System.Console.WriteLine("Подходит к расписанию.");
System.Console.WriteLine("Расписание Вовочки:");

int HowManyLessons(int LesMin, int LesMax)
{
    int Les = new Random().Next(LesMin, LesMax);
    return Les;
}

int Les1 = HowManyLessons(LesMin,LesMax);
int Les2 = HowManyLessons(LesMin,LesMax);
int Les3 = HowManyLessons(LesMin,LesMax);
int Les4 = HowManyLessons(LesMin,LesMax);
int Les5 = HowManyLessons(LesMin,LesMax);

// Сделали расписание
System.Console.WriteLine($"Уроков в понедельник: {Les1}");
System.Console.WriteLine($"Уроков во вторник: {Les2}");
System.Console.WriteLine($"Уроков в среду: {Les3}");
System.Console.WriteLine($"Уроков в четверг: {Les4}");
System.Console.WriteLine($"Уроков в пятницу: {Les5}");

System.Console.WriteLine("Посмотрел Вовочка расписание и пошёл на уроки.");

int[] Marks(int Les)
{
    int[] Mark = new int[Les];
    for (int a = 0; a < Mark.Length; a++)
    {
        Mark[a] = new Random().Next(1, 6);
    }
    return Mark;
}

int[] Mark1 = Marks(Les1);
System.Console.Write("Отметки в понедельник [");
for (int i = 0; i < Mark1.Length; i++)
{
    System.Console.Write(Mark1[i]+" ");
}
System.Console.WriteLine("]");

int[] Mark2 = Marks(Les2);
System.Console.Write("Отметки во вторник [");
for (int i = 0; i < Mark2.Length; i++)
{
    System.Console.Write(Mark2[i]+" ");
}
System.Console.WriteLine("]");

int[] Mark3 = Marks(Les3);
System.Console.Write("Отметки в среду [");
for (int i = 0; i < Mark3.Length; i++)
{
    System.Console.Write(Mark3[i]+" ");
}
System.Console.WriteLine("]");

int[] Mark4 = Marks(Les4);
System.Console.Write("Отметки в четверг [");
for (int i = 0; i < Mark4.Length; i++)
{
    System.Console.Write(Mark4[i]+" ");
}
System.Console.WriteLine("]");

int[] Mark5 = Marks(Les5);
System.Console.Write("Отметки в пятницу [");
for (int i = 0; i < Mark5.Length; i++)
{
    System.Console.Write(Mark5[i]+" ");
}
System.Console.WriteLine("]");
