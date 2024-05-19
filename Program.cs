var list  = new List<int>();
var counter = 0;

Console.WriteLine("How many numberss do you want the list to consist of 0-1000");
int temp = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < temp; i++)
{
    list.Add(i);
}

Console.WriteLine("Wich number do you want to search for");
temp = Convert.ToInt32(Console.ReadLine());

int left = 0, right = list.Count - 1;

while (left <= right)
{
    int mid = left + (right - left) / 2;
    if (mid == temp)
    {
        Console.WriteLine(mid + " is the number you were looking for and it was found in " + counter + " tries");
        break;
    }
    if (mid < temp)
    {
        left = mid + 1;
    }
    else
    {
        right = mid - 1;
    }

    counter++;
}
 