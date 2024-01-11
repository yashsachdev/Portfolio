// See https://aka.ms/new-console-template for more information

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
        else if(arr[i] > second && arr[i] != first)
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


int[] arr = new int[6] { 12, 35, 1, 10, 34, 1 };
int n = arr.Length;
CheckSecondLargest(arr, n);

Console.WriteLine("Hello Mono World");
string[] animals = new string[3];
animals[0] = "deer";
animals[1] = "moose";
CheckLargest(animals, 3, "Lion");
