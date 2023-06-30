void Fillarray(double[] arr, int len, int min, int max){
    Random rand = new Random();
    for (int i = 0; i<len; i++){
    arr[i] = Math.Round(rand.Next(min,max)+rand.NextDouble(),2);}}

void Printarray(double[] arr){
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

double Diff (double[] array) {
    double min = array[0];
    double max = array[0];
    for (int i = 0; i<array.Length; i++){
        if (array[i]>max){max = array[i];}
        else if (array[i]<min){min = array[i];}}
    return Math.Round(max-min, 2);}

int arlen = Length("input length: ");
int minnum = Minnum("input minimal number: ");
int maxnum = Maxnum("input maximum number: ");
double[] array = new double[arlen];

Fillarray(array, arlen, minnum, maxnum);
Printarray(array);
System.Console.WriteLine(Diff(array));



/*
//генерация массива из 5 чисел, дробные
double[] array = new double[5];
Random rand = new Random();
for (int i = 0; i<5; i++){
    array[i] = Math.Round(rand.Next(1,22)+rand.NextDouble(),1);
}
System.Console.WriteLine(string.Join("  ", array));
*/
