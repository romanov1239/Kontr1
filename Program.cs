/*
Написать программу, которая из имеющегося массива строк формирует
 новый массив из строк, длина которых меньше, либо равна 3 символам. 
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте
  выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
  лучше обойтись исключительно массивами.
  */

using System;
using static System.Console;// Чтобы не писать Console - это слово в командах 

WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine());
String[] array = new String[size];
WriteLine("Введите элементы массива:");
for (int i = 0; i < size; i++) {
array[i] = ReadLine();
}
String[] newArray = new String[size];
int index = 0;
for (int i = 0; i < size; i++) {
if (array[i].Length <= 3) {
newArray[index] = array[i];
index++;
}
}
WriteLine("Новый массив из строк, длина которых меньше, либо равна 3 символам:");
for (int i = 0; i < index; i++) {
Write($"{newArray[i]} ");
}