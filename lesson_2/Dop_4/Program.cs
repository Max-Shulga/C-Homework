Console.WriteLine("Input month numer: ");
int MonthsNum = Convert.ToInt32(Console.ReadLine());
string Session = " ,session";
string Holiday = "holiday";
string Semester1 = "first semester";
string Semester2 = "second semester";
string Winter = "Winter";
string Sprin = "Sprin";
string Summer = "Summer";
string Autum = "Autum";

while(MonthsNum <=0|| MonthsNum > 12)
{
    Console.WriteLine("Input correct number of month: ");
    int MonthsNum2 = Convert.ToInt32(Console.ReadLine());
    MonthsNum = MonthsNum2;
}

if(MonthsNum == 12||MonthsNum == 1||MonthsNum == 2)
{
    Console.Write(Winter + ", ");
}

if(MonthsNum == 3||MonthsNum == 4||MonthsNum == 5)
{
    Console.Write(Sprin + ", ");
}

if(MonthsNum == 6||MonthsNum == 7||MonthsNum == 8)
{
    Console.Write(Summer + ", ");
}

if(MonthsNum == 9||MonthsNum == 10||MonthsNum == 11)
{
    Console.Write(Autum + ", ");
}

if(MonthsNum >= 9 && MonthsNum <= 12 || MonthsNum == 1)
{
    Console.Write(Semester1);
}

if(MonthsNum >= 2 && MonthsNum <= 6)
{
    Console.Write(Semester2);
}

if(MonthsNum == 1||MonthsNum == 6)
{
    Console.Write(Session);
}

if(MonthsNum == 7||MonthsNum == 8)
{
    Console.Write(Holiday);
}