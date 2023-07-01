void Fillarray(double[] arr, int len, int min, int max){
    Random rand = new Random();
    for (int i = 0; i<len; i++){
    arr[i] = Math.Round(rand.Next(min,max)+rand.NextDouble(),2);}}

void Printarray(double[] arr){
    System.Console.WriteLine(string.Join(" ", arr));}

int Input (string text) {
    System.Console.Write(text);
    int num = Convert.ToInt32(System.Console.ReadLine());
    return num;}

double Diff (double[] array) {
    double min = array[0];
    double max = array[0];
    for (int i = 0; i<array.Length; i++){
        if (array[i]>max){max = array[i];}
        else if (array[i]<min){min = array[i];}}
    return Math.Round(max-min, 2);}

int arlen = Input("input length: ");
int minnum = Input("input minimal number: ");
int maxnum = Input("input maximum number: ");
double[] array = new double[arlen];

Fillarray(array, arlen, minnum, maxnum);
Printarray(array);
System.Console.WriteLine(Diff(array));


