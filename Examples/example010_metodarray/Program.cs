int[] array = { 1, 12, 27, 31, 4, 51, 16, 27, 48 };

int n = array.Length;
int find = 27;

int index = 0;

while (index < n)
{
     if(array[index]==find)
     {
         Console.WriteLine(index);
         break;
     }

    index++;
}
