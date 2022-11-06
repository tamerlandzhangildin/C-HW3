int[] array = new int[5];
int n = array.Length;
for (int i = 0; i<(n/2); i++)
{
  if (array[i] == array[n-i-1] ){
    Console.WriteLine(true);
  }
else {
 Console.WriteLine(false);
} 
}