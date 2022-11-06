int[] array = new int[5];
int n =array.Length;

while (n < array.Length) 
{ 
 if ( n/1000 == n/10 && n%10000 == n%10 ) 
 {
    Console.WriteLine(true); 
 }
else{
    Console.WriteLine(false);
}
 }
 



