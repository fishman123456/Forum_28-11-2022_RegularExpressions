// Пользователь вводит номер телефона в формате "8-912-345-67-89",
// проверить его на правильность ввода, если пользователь будет вводить не правильно
// использовать регулярные выражения
using System.Text.RegularExpressions;
using static System.Console;



string s = "456-435-2318"; // TODO формат номера телефона

Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");


WriteLine("Введите номер телефона:");
string tel = ReadLine();
//regex = new Regex(phonePattern);
WriteLine(regex.IsMatch(tel) ? "Верно" : "Не верно");


