﻿
void Fillarray(int[] arr){
    Random rand = new Random();
    for (int i = 0; i<arr.Length; i++){
    arr[i] = rand.Next(100,1000);}}

void Printarray(int[] arr){
    System.Console.WriteLine(string.Join(" ", arr));}

int Length (string text) {
    System.Console.Write(text);
    int arlen = Convert.ToInt32(System.Console.ReadLine());
    return arlen;}

int Count(int[] array){
    int num = 0;
    for (int i = 0; i<array.Length; i++){
        if (array[i]%2 == 0){num =num + 1;}}
    return num;}

int num = Length("input array length: ");
int[] array = new int [num];

Fillarray(array);
Printarray(array);
System.Console.WriteLine(Count(array));

