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

System.Console.WriteLine("Инициализация отметок, полученных на уроках:");

double G1 = IsGood(Mark1);
System.Console.WriteLine($"{G1}% двоек и единиц");

if (G1 >= 80)
{
    System.Console.WriteLine("Вовочка плохо старался на уроках. Необходимо посидеть ещё на одном уроке.");
    Les1 = Les1 + 1;
}
else 
{
    System.Console.WriteLine("Вовочка хорошо провёл день. Дополнительных уроков не требуется.");
}


int[] Mark2 = Marks(Les2);
System.Console.Write("Отметки во вторник [");
for (int i = 0; i < Mark2.Length; i++)
{
    System.Console.Write(Mark2[i]+" ");
}
System.Console.WriteLine("]");

System.Console.WriteLine("Инициализация отметок, полученных на уроках:");

double G2 = IsGood(Mark2);
System.Console.WriteLine($"{G2}% двоек и единиц");

if (G2 >= 80)
{
    System.Console.WriteLine("Вовочка плохо старался на уроках. Необходимо посидеть ещё на одном уроке.");
    Les2 = Les2 + 1;
}
else 
{
    System.Console.WriteLine("Вовочка хорошо провёл день. Дополнительных уроков не требуется.");
}

int[] Mark3 = Marks(Les3);
System.Console.Write("Отметки в среду [");
for (int i = 0; i < Mark3.Length; i++)
{
    System.Console.Write(Mark3[i]+" ");
}
System.Console.WriteLine("]");

System.Console.WriteLine("Инициализация отметок, полученных на уроках:");

double G3 = IsGood(Mark3);
System.Console.WriteLine($"{G3}% двоек и единиц");

if (G3 >= 80)
{
    System.Console.WriteLine("Вовочка плохо старался на уроках. Необходимо посидеть ещё на одном уроке.");
    Les3 = Les3 + 1;
}
else 
{
    System.Console.WriteLine("Вовочка хорошо провёл день. Дополнительных уроков не требуется.");
}

int[] Mark4 = Marks(Les4);
System.Console.Write("Отметки в четверг [");
for (int i = 0; i < Mark4.Length; i++)
{
    System.Console.Write(Mark4[i]+" ");
}
System.Console.WriteLine("]");

System.Console.WriteLine("Инициализация отметок, полученных на уроках:");

double G4 = IsGood(Mark4);
System.Console.WriteLine($"{G4}% двоек и единиц");

if (G4 >= 80)
{
    System.Console.WriteLine("Вовочка плохо старался на уроках. Необходимо посидеть ещё на одном уроке.");
    Les4 = Les4 + 1;
}
else 
{
    System.Console.WriteLine("Вовочка хорошо провёл день. Дополнительных уроков не требуется.");
}

int[] Mark5 = Marks(Les5);
System.Console.Write("Отметки в пятницу [");
for (int i = 0; i < Mark5.Length; i++)
{
    System.Console.Write(Mark5[i]+" ");
}
System.Console.WriteLine("]");

System.Console.WriteLine("Инициализация отметок, полученных на уроках:");

double G5 = IsGood(Mark5);
System.Console.WriteLine($"{G5}% двоек и единиц");

if (G5 >= 80)
{
    System.Console.WriteLine("Вовочка плохо старался на уроках. Необходимо посидеть ещё на одном уроке.");
    Les5 = Les5 + 1;
}
else 
{
    System.Console.WriteLine("Вовочка хорошо провёл день. Дополнительных уроков не требуется.");
}

double IsGood (int[] Mark)
{
    int a = 0;
    double G = 0;
    double G1 = 0;
    while (a < Mark.Length) 
    {
        if (Mark[a] == 2 || Mark[a] == 1) G = G + 1;
        a++;
    }
    G1 = G/Mark.Length*100;
    
    return G1;
}

double T1 = Time (Les1);
double T2 = Time (Les2);
double T3 = Time (Les3);
double T4 = Time (Les4);
double T5 = Time (Les5);

double Time ( int Les )
{
    double CountTimeBreak = Les -1;
    double time = Les * 45/60 + CountTimeBreak*15/60; 
    return time;
}

System.Console.WriteLine($"Вовочка просидит на уроках в понедельник {T1} часов.");
System.Console.WriteLine($"Вовочка просидит на уроках во вторник {T2} часов.");
System.Console.WriteLine($"Вовочка просидит на уроках в среду {T3} часов.");
System.Console.WriteLine($"Вовочка просидит на уроках в четверг {T4} часов.");
System.Console.WriteLine($"Вовочка просидит на уроках в пятницу {T5} часов.");

double TO = T1+T2+T3+T4+T5;

System.Console.WriteLine($"Общее время учёбы Вовочки за неделю - {TO} часов.");

