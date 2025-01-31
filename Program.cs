﻿// Знакомство с яз.программирования. Семинар-9. РЕКУРСИИ.
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// РЕКУРСИЯ - метод(функция), вызывающий сам себя внутри своей реализации.


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-1. Запросить у пользователя значение N и написать программу, кот. выведет все натуральные числа от 1 до N (решить с пом. рекурсии).

/*
void ShowNums(int num)                               // рекурсия в войдовском методе
{
    if(num > 1)ShowNums(num - 1);
    Console.Write(num + " ");
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);                                         //решено
*/
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/*
void ShowNums(int num)                               
{
    if(num > 1)
    {
        ShowNums(num - 1);        
    }
    
    Console.Write(num + " ");
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/

/*
void ShowNums(int num)                               
{
    Console.Write(num + " ");
    if(num > 1)
    {
        ShowNums(num - 1);        
    }
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/

/*
void ShowNums(int num)                               
{
    Console.Write(num + " ");
    if(num > -10)
    {
        ShowNums(num - 1);        
    }
    Console.Write(num + " ");
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-2. Программа принимает на вход число и возвращает сумму его цифр (решить с пом. рекурсии).

/*
int GetSumOfDigits(int num)
{
    if(num != 0)
    {
        return GetSumOfDigits(num / 10) + num % 10;
    }
    return 0;
}

//Console.Write(GetSumOfDigits(3476));

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int res = GetSumOfDigits(n);
Console.Write(res);                                 // решено
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-1(самост). Задать значение M и N и написать программу, кот. выведет все натуральные числа в промежутке от M до N включительно.
/*
void MnnnN(int m, int n)
{
    Console.Write(m + " ");
    if(m < n)MnnnN(m+1,n);
    if(m > n)MnnnN(m-1,n);
}

Console.Write("введите число 1: ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2: ");
int nn = Convert.ToInt32(Console.ReadLine());

MnnnN(mm, nn);                                   // решено
*/


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// ЗАДАЧА-2(самост). Написать программу, кот. принимает на вход два числа A и В и возводит число A в степень B.(2 в -3 степени это 1:2 в 3 степени, т.е. 1:8 или 1/8 )

/*                           
void AexpB(int a, int b)                   /// !!! что здесь происходит ??? непонятно совсем.
{
    Console.Write(a);
    if (b > 0)AexpB(a+a, b-1);
}

Console.Write("введите число 1: ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2: ");
int nn = Convert.ToInt32(Console.ReadLine());

AexpB(mm, nn);
*/

/*
double AexpB(int a, int b)                   
{
    if (b > 0)return AexpB(a, b-1) * a;
    if (b < 0)return AexpB(a, b+1) / a;
    return 1;
}

Console.Write("введите число 1: ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2: ");
int nn = Convert.ToInt32(Console.ReadLine());

double res = AexpB(mm, nn);
Console.Write(res);                               // решено
*/

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//HOMEWORK
//HOMEWORK
//HOMEWORK

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
void ShowNums(int num)                               
{
    Console.Write(num + " ");
    if(num > 2)ShowNums(num - 1);
}

Console.Write("введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(n);                                         // решено
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с пом. рекурсии.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

//(m+n) * (m - n + 1)/2 находит колич.чисел в промежутке от M до N, если M > N.

/*
int SumNNN(int m, int n)                           // Решение аналогично семинарскому( ЗАДАЧА-2(самост)) и строки по отдельности работают,
{                                                  // но вместе - не работают. Хотя, вариант, что пользователь может
    if(m <= n)return SumNNN(m+1,n) + m;            // ввести сначала большее число, потом меньшее, тоже следует рассматривать. 
    //if(m >= n)return SumNNN(m-1,n) + m;          // Значит, без второй строчки задача будет недорешена. Непонятно, почему неработает.
    return 0;
}

Console.Write("введите число 1: ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2: ");
int nn = Convert.ToInt32(Console.ReadLine());

int res = SumNNN(mm, nn);
Console.Write($"сумма натуральных элементов от {mm} до {nn} равна : {res}");     // недорешено
*/

/*
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Ackerm(int m, int n)                          
{                                                  
    if(m == 0)
    {
		return n + 1;
	}
	if(m > 0 && n == 0)
	{
		return Ackerm(m - 1, 1);
	}
	return Ackerm(m - 1, Ackerm(m, n - 1));
}

Console.Write("введите число 1: ");
int mm = Convert.ToInt32(Console.ReadLine());

Console.Write("введите число 2: ");
int nn = Convert.ToInt32(Console.ReadLine());

int res = Ackerm(mm, nn);
Console.Write($"функция Аккермана равна : {res}");
*/
		

////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////

//ненужное(просто попробовал кое-что самостоятельно порешать)

/*
void F(int n)                            
{
    if(n > 2)F((n - 2)*( n+1 ));
    Console.Write(n + " ");
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

F(n);
*/

/*
void F(int n)                            
{
    Console.Write(n + " ");
    if(n < 5)
    {
        F(n + 1);
        F(n + 3);
    }
    //Console.Write(n + " ");
    
}

Console.Write("введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

F(n);
*/

/*
//нахождение F(n) при F(1)=1 и F(2)=1, n > 2(c#)         текст задачи: ""Чему равно значение функции F(8) при F(1)= 1  и  F(2)= 1, если n > 2 ?"

int F(int n)                                             //СИНТАКСИС УСЛОВИЯ:  Если переменная n больше 2, выполнить и отправить на консоль "F(n - 2) * (n + 1)",           
{                                                        //                    Иначе - отправить на консоль "1".
    if(n > 2)return F(n - 2) * (n + 1);                          
    return 1;                                            //Метод "F" принимает "int переменную", и после работы возвращает результат тоже в виде "int переменной"
}                                                        //РАБОТА МЕТОДА:                                                   
                                                         // принимает на вход число "8" и проверяет верно ли условие: n > 2(8 > 2) - верно!                                                      
                                                         // если верно, значит выполняется вычисление "F(n - 2) * (n + 1)", где n = 8
                                                         //                                            F(8)=F(8-2)*(8+1)=F(6)*9  F(6)неизвестно, следовательно происходит переход к поиску F(6)
Console.Write("введите число: ");                        //                                            проверка на соответствие условию: 6 > 2 - верно!
int b = Convert.ToInt32(Console.ReadLine());             // если верно, значит выполняется вычисление  F(6)=F(6-2)*(6+1)=F(4)*7  F(4)неизвестно, следовательно происходит переход к поиску F(4)
                                                         //                                            проверка на соответствие условию: 4 > 2 - верно!
Console.Write(F(b));                                     // если верно, значит выполняется вычисление  F(4)=F(4-2)*(4+1)=F(2)*5  F(2)=1 следовательно 1*5=5  F(4)=5
                                                         // Скорее всего, РАБОТА МЕТОДА прописано неверно.Метод ,обращаясь сам к себе не выискивает неизвестные значения, как прописано,
                                                         // а последовательно вычисляет все значения, указанные диапазоном условий и "на обратном пути" к запрашиваемому использует уже известные значения.
*/







