void Fillarray(int[] arr, int len, int min, int max){
    Random rand = new Random();
    for (int i = 0; i<len; i++){
    arr[i] = rand.Next(min,max);}}

void Printarray(int[] arr){
    System.Console.WriteLine(string.Join(" ", arr));}

int Maxnum (string text) {
    System.Console.Write(text);
    int max = Convert.ToInt32(System.Console.ReadLine());
    return max;}

int Minnum (string text) {
    System.Console.Write(text);
    int min = Convert.ToInt32(System.Console.ReadLine());
    return min;}

int Length (string text) {
    System.Console.Write(text);
    int arlen = Convert.ToInt32(System.Console.ReadLine());
    return arlen;}

int Diff (int[] array) {
    int min = array[0];
    int max = array[0];
    for (int i = 0; i<array.Length; i++){
        if (array[i]>max){max = array[i];}
        else if (array[i]<min){min = array[i];}}
    return max-min;}

int arlen = Length("input length: ");
int minnum = Minnum("input minimal number: ");
int maxnum = Maxnum("input maximum number: ")+1;
int[] array = new int[arlen];
Fillarray(array, arlen, minnum, maxnum);
Printarray(array);
System.Console.WriteLine(Diff(array));