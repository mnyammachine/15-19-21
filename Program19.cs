// Принимает на вход пятизначное число, проверяет, является ли оно полиндромом
Console.WriteLine("Введите 5значное число от 10000 до 99999");
string? number = Console.ReadLine();
void CheckingNumber(string number){
  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"число: {number} - палиндром.");
  }
  else Console.WriteLine($"число: {number} - НЕ палиндром.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введите правильное число");