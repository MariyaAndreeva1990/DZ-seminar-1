//Convert.ToInt32(); конверт для преобразования одного значения в другое (Console.ReadLine() это строчные данные типа стринг, и для того, чтобы пользователь мог вводить числа, конвертируем стринговую строку)
Console.Write("Введите число: ");
string input = Console.ReadLine();// string input - ввод строки
int number = Convert.ToInt32(input);
 
int sqr = number * number;

Console.WriteLine(number + "->"+ sqr); // "приклеили" пробел, "приклеили" результат и вывели в одну строку с результато