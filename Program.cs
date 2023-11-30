// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
// public class Task64 {    
//     static int[] numbers = new int[2];
//     public static void inputNumber(int index){
//         string stringNumber = Console.ReadLine();
//         bool isNumber = int.TryParse(stringNumber, out numbers[index]);
//         if(!isNumber){
//             Console.WriteLine("Введено не число");  
//             return; 
//         } 
//     }
//     public static string PrintNumbers(int start, int end){
//         if(start > end){
//             Console.WriteLine("Стартовое значение должно быть меньше крайнего");  
//             return "";
//         } 
//         if(start == end) return start.ToString();
//         return (start + "\t" + PrintNumbers(start + 1, end));
//     }
//     static public void Main(string[] args) {
//         Console.Write("Введите число M:" + "\t");
//         inputNumber(0);
//         Console.Write("Введите число N:" + "\t");
//         inputNumber(1);
//         Console.WriteLine(PrintNumbers(numbers[0], numbers[1]));
//     }
// }

//--------------------------------------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// public class Task66 {    
//     static int[] numbers = new int[2];
//     static int sumNum = 0;
//     public static void inputNumber(int index){
//         string stringNumber = Console.ReadLine();
//         bool isNumber = int.TryParse(stringNumber, out numbers[index]);
//         if(!isNumber){
//             Console.WriteLine("Введено не число");  
//             return; 
//         } 
//     }
//     public static int SumNumbers(int start, int end){
//         if(start > end){
//             Console.WriteLine("Стартовое значение должно быть меньше крайнего");  
//             return 0; 
//         } 
//         if(start == end) return sumNum += start;
//         return (start + SumNumbers(start + 1, end));
//     }
//     static public void Main(string[] args) {
//         Console.Write("Введите число M:" + "\t");
//         inputNumber(0);
//         Console.Write("Введите число N:" + "\t");
//         inputNumber(1);
//         Console.WriteLine(SumNumbers(numbers[0], numbers[1]));
//     }
// }

//-----------------------------------------------------------------------------------

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// public class Task68 {    
//     static int[] numbers = new int[2];
//     static int akermanResult = 0;
//     public static void inputNumber(int index){
//         string stringNumber = Console.ReadLine();
//         bool isNumber = int.TryParse(stringNumber, out numbers[index]);
//         if(!isNumber){
//             Console.WriteLine("Введено не число");  
//             return; 
//         } 
//     }
//     public static int Akerman(int n, int m){
//         if(n == 0){
//             return m + 1;
//         }else if(m == 0){
//             return Akerman(n - 1,  1);
//         }else{
//             return Akerman(n - 1, Akerman(n, m - 1));
//         } 
//     }
//     static public void Main(string[] args) {
//         Console.Write("Введите число N:" + "\t");
//         inputNumber(0);
//         Console.Write("Введите число M:" + "\t");
//         inputNumber(1);
//         akermanResult = Akerman(numbers[0], numbers[1]);
//         Console.Write(akermanResult);
//     }
// }
