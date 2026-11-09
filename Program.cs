
//TAsk 1 
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine("EVEN:" + EvenCount(n));
// Console.WriteLine("Odd:" + OddCount(n) );
// Console.WriteLine("Digit:" + DigitCount(n));
// Console.WriteLine("Sum:" + Sumdigit(n) );

// int EvenCount(int n){
//     int count = 0 ;
//      for ( ; n > 0 ; n /= 10)
//     {
//         if((n % 10 ) % 2 ==0)
//          count++;
//     }
//     return count;
// }
//  int OddCount (int n)
// {
//     int count = 0 ;
//     for ( ; n > 0 ; n /= 10)
//     {
//         if((n % 10 ) % 2 !=0)
//           count++;
//     }
//      return count ;
     
// }
//  int DigitCount(int n){
//     int count = 0 ;
//      for ( ; n > 0 ; n /= 10)
//     {
//         count ++ ;
//     }
//      return count ;
//  }
//   int Sumdigit(int n)
// {
//     int sum = 0 ;
//      for( ; n > 0 ; n /=10)
//     {
//         sum += n % 10 ;
//     }
//      return sum ; 
// }
 
 //Task 2 ;
  
//   int a = int.Parse(Console.ReadLine());
//   int b = int.Parse(Console.ReadLine());

//   Console.WriteLine("Add:" + Add(a, b));
//   Console.WriteLine("Subtract:" + Subtract(a, b));
//   Console.WriteLine("Multiply:" + Multiply(a, b));
//   Console.WriteLine("Division:" + Division(a, b)); 

//    int Add (int a , int b)
// {
//     return a + b; 
// }
//  int Subtract ( int a , int b ){
//     return a -b ;
//  }
  
//    int Multiply ( int a , int b)
// {
//     return a * b ;
// }
 
//   int Division ( int a , int b)
// {
//     return a / b ;
// }

//Task 3;

// int n = int.Parse(Console.ReadLine());

//  int min  = MinDigit(n);
//  int max = MaxDigit(n);

//  Console.WriteLine(min + " + " + max + " = " + (min+max));

//  int MinDigit( int n)
// {
//     int min = 9 ;
//      for ( ;  n > 0 ; n/=10){
//         int d = n % 10 ;
//          if( d < min) min = d ;
//      }
//       return min;
// }
 
//   int MaxDigit(int n ){

//      int max = 0 ;
//       for( ; n > 0 ; n /= 10)
//     {
//         int d = n % 10;
//          if(d > max) max= d ;
//     }
//      return max;
//   }

// task 4

// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());

// Console.WriteLine(POW(x , y));

// int POW(int x , int y){
//     int r = 1;
//     for(int i=0 ; i< y ; i++ )
//     {
//         r *= x;

//     }
//      return r;
// }

//Task 5 ;

// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());

// Swap(ref x, ref y);

// Console.WriteLine(x);
// Console.WriteLine(y);

// void Swap(ref int a, ref int b)
// {
//     int temp = a;
//     a = b;
//     b = temp;
// }

//Task 6

// int n = int.Parse(Console.ReadLine());

// Divisor(n);
 
//   int Divisor(int n){
//     for (int i = 1 ; i <= n ; i++)
//     {
//         if( n % i == 0)
//         {
//             Console.Write(i + " ");
//         }
//     }
//      return 0;
//   }


//task 8
// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());
// int c = int.Parse(Console.ReadLine());
// int d = int.Parse(Console.ReadLine());

// Console.WriteLine(MinNumber(a , b , c , d));

// int MinNumber (int a , int b , int c ,int d)
// {
//     int min = a ;
//     if( b < min) min = b ;
//     if (c < min ) min = c ;
//      if (d < min) min = d ;
//      return min ;
// }

//task 9 ;
// int a = int.Parse(Console.ReadLine());
//  int b = int.Parse(Console.ReadLine());

//  Console.WriteLine(Min(a , b ));

//  int Min(int a , int b){
//     if(a < b ){
//         return a;
//     }
//     else
//     {
//         return b ;
//     } 

//     }

//task 10 ;
int a = int.Parse(Console.ReadLine());
 int b = int.Parse(Console.ReadLine());

 Console.WriteLine(Max(a , b ));

 int Max(int a , int b){
    if(a > b ){
        return a;
    }
    else
    {
        return b ;
    } 

    }



 


 
