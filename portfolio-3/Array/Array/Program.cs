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

Console.WriteLine("Hello Mono World");
string[] animals = new string[3];
animals[0] = "deer";
animals[1] = "moose";
CheckLargest(animals, 3, "Lion");
