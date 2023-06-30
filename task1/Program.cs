int[] Fillarray(string  text) {
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;}

int Count(int[] arr){
    int count = 0;
    int i = 0;
    while (i < arr.Length){
        if (arr[i]>0) {count = count + 1;}
        i++;}
    return count;}


int[] array = Fillarray("input array, split with space");
System.Console.WriteLine(Count(array));