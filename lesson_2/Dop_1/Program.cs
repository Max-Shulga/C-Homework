//Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).

Random num =  new Random();
int RandomNum = num.Next(20,99);
Console.Write("Input integer number: ");
int d = Convert.ToInt32(Console.ReadLine());
string multiple = (RandomNum % d == 0)? "is divisible": "is not divisible";
Console.WriteLine(" {1} {2} ", RandomNum, d, multiple);
