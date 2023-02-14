// Принимает на вход цифру, обозначающую день недели, проверяет, является ли этот день выходным
Console.WriteLine("Введите число от 1 до 7");
int n = Convert.ToInt32(Console.ReadLine());
if (n >=1 && n <= 5)
    Console.WriteLine("Указанный вами день, к сожалению, не выходной");
else 
    Console.WriteLine("Ура, выходной");

