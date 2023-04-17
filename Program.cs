// Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// int[] NumToArray()
// {
//     Console.Write("Input your numbers separated by commas: ");
//     string nums = Console.ReadLine();
    
//     string nums1 = nums.Replace(" ", "");
//     int count = 1;
//     for (int i = 0; i < nums1.Length; i++)
//     {
//         if (nums1[i] == ',') count++;
//     }

//     int[] numArray = new int[count];
//     int indexNumArray = 0;

//     for (int i = 0; i < nums1.Length; i++)
//     {
//         string temp = "";
//         while (nums1[i] != ',')
//         {
//             if (i != nums1.Length - 1)
//             {
//                 temp += nums1[i].ToString();
//                 i++;
//             }

//             else
//             {
//                 temp += nums1[i].ToString();
//                 break;
//             }
//         }
//         numArray[indexNumArray] = Convert.ToInt32(temp);
//         indexNumArray++;
//     }
//     return numArray;
// }

// int[] array = NumToArray();

// Console.Write("Your array: ");
// foreach (int n in array)
//     Console.Write($"{n} ");

// Console.WriteLine();
// Console.WriteLine($"Quantity positive numbers: {array.Where(x => x > 0).Count()}");



////////////////////////////////////////////////////////////////////////////////////
// int num = 0;
// int count = 0;
// while(count < 100)
// {
//     System.Console.Write("Input your number: ");
//     num = Convert.ToInt32(Console.ReadLine());
       
//     if(num > 0)
//     {
//         count++;
//         System.Console.WriteLine($"The count of positive numbers is equal {count}\nFor exit press <0>");
//     }
//     else if(num <0)
//         {
//             System.Console.WriteLine($"The count of positive numbers is equal {count}\nFor exit press <0>");
//         }
    
//     else
//         {
//             System.Console.WriteLine("Game over");
//             break;
//         }

// }

////////////////////////////////////////////////////////////////////////////////////////////


// Task 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


// k1 * x + b1 = k2 * x + b2
// k1 * x - k2 * x = b2 - b1
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)


// Console.WriteLine("Input value b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input value k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input value b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input value k2");
// double k2 = Convert.ToInt32(Console.ReadLine());


// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// System.Console.WriteLine($"Intersection at coordinate point X={x} : Y={y}");
