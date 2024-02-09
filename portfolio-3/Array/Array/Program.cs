// See https://aka.ms/new-console-template for more information

using System.Buffers;

static void CheckLargest(string[] arr, int n, string k)
{

    if (arr.Length < n)
    {
        int len = arr.Length;
        if (len > 0 && arr[len - 1] == null)
        {
            arr[len - 1] = k;
        }
        else
        {
            Console.WriteLine("Array is Full: {0}", arr.Length);
        }
    }
    else
    {
        Console.WriteLine($"Array is Full: {arr.Length}");
    }
}
static bool SortedArray(int[] arr, int n)
{
    //Native approach
    for(int i=0; i <= arr.Length; i++)
    {
        for(int j=i+1; j < arr.Length;j++)
        {
            if (arr[i] > arr[j])
            {
                return false;
            }
        }
    }
    return true;
}
static void CheckSecondLargest(int[] arr, int n)
{
    int first = int.MinValue;
    int second = int.MinValue;
    //1 . if aa[i] > first then
    //first = a[i];
    //second = first;
    for (int i = 0; i < n; i++)
    {
        if (arr[i] > first)
        {
            second = first;
            first = arr[i];
        }
        else if (arr[i] > second && arr[i] != first)
        {
            second = arr[i];
        }
    }
    if (second == int.MinValue)
        Console.WriteLine("There is no second largest"
                        + " element\n");
    else
        Console.WriteLine("The second largest element"
                        + " is " + second);
    // 2. if first <=a[i] <= second
    //second = a[i] ;
}

static void ReverseArray(int[] arr, int start,int end)
{
    start = 0;
    end = arr.Length - 1;
    int temp = 0;
    for(int i =start; i <= end;i++)
    {
        temp = arr[start];
        arr[start] = arr[end];
        arr[end] = temp;
        start++;
        end--;
    }
}
static void PrintArray(int[] arr, int size)
{
    for(int i = 0;i<size;i++)
    {
        Console.WriteLine(arr[i]+" ");
    }
}
static int RemoveDuplicatesArray(int[] arr,int size)
{
    int res = 1;
    for (int i = 1; i < size; i++)
    {
        if (arr[res - 1] != arr[i])
            arr[res] = arr[i];
        res++;
    }
    return res;
}
static void moveZerosToEnd(int[] arr,int n)
{
    int count = 0;
    for(int i=0;i<n;i++)
    {
        if (arr[i]!=0)
        {
            arr[count++] = arr[i];
        }
    }
    for(int i=count;i<n;i++)
    {
        arr[i] = 0;
    }
}
static void moveArraytoD(int[] arr,int n,int d)
{
    int[] temp = new int[d];
    for (int i = 0; i < d; i++)
    {
        temp[i] = arr[i];
    }
    for (int i = d; i < n; i++)
    {
        arr[i - d] = arr[i];
    }
    for (int i = 0; i < d; i++)
    {
        arr[n - d + i] = temp[i];
    }
}
static void MoveArrayUsingReversed(int[] arr,int n)
{
    ReverseArray();
}
static void EvenOdd(int[] arr6, int n)
{
    int count = 0;
    int[] temp = new int[5];
    for (int i = 0; i < n; i++)
    {
        if (arr6[i] % 2 == 0)
        {
            temp[count] = arr6[i];
            count++;
        }
    }
    for (int i = count; i < n; i++)
    {
        if (arr6[i] % 2 != 0)
        {
            temp[i] = arr6[i];
        }
    }
}
int[] arr6 = new int[] { 54, 43, 2, 5, 14, 17, 18, 19 };
int n = arr6.Length;
/*
static void */


/*static void ReverseArray(int end, int start, int[] arr)
{
    int temp;
    if (end < start)
    {
        temp = arr[start];
        arr[start] = end;
        arr[end] = temp;

        

    }
}*/

int[] arr5 = new int[] { 54, 43, 2, 5, 14, 17, 18, 19 };
int n5 = 5;
int d = 2;

moveArraytoD((int[])arr5, n5, d);
Console.WriteLine("After rotation ---");
for(int i=0;i<n5;i++)
{
    Console.WriteLine( "array :" + arr5[i]);
}





int[] arr4 = new int[] { 10, 20, 20, 30, 30, 30 }; 
 int n2 = 6;

n2 = RemoveDuplicatesArray(arr4, n2);
for (int i = 0; i < n2; i++)
{
    Console.WriteLine(arr4[i]+" ");
}


int[] arr1 = new int[] { 7, 2, 30, 10 };
int n1 = 4;
if(SortedArray(arr1, n1) == true)
{
    Console.WriteLine("Array is Sorted");
}
else
{
    Console.WriteLine( "Not sorted");
}

int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6 };
PrintArray(arr2, arr2.Length);
ReverseArray(arr2,0, arr2.Length);
PrintArray(arr2, arr2.Length);

int[] arr = new int[6] { 12, 35, 1, 10, 34, 1 };
int n = arr.Length;
 CheckSecondLargest(arr, n);

Console.WriteLine("Hello Mono World");
string[] animals = new string[3];
animals[0] = "deer";
animals[1] = "moose";
CheckLargest(animals, 3, "Lion");
