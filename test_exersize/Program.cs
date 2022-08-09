//вводим строковый массив
string[] array1 = new string[5] {"Hello", "2", "Mom", "Peace", "Jam"};
// выводим его на печать
Console.Write("[" + string.Join(", ", array1) + "]" +  "->" + "[");

// вводим еще один массив, равный длине первого массива
string[] array2 = new string[array1.Length];

// создаем метод для проверки элементов первого массива
void SearchedArray(string[] array1, string[] array2)
{
  int count = 0; // вводим переменную, для счетчика индексов второго массива
  for (int i = 0; i < array1.Length; i++) // проходим по всем элементам массива
  {
    if (array1[i].Length <= 3)   // если элемент меньше или равен трем символам
    {
      array2[count] = array1[i];  //то мы записываем его во торой массив
      count ++;
    }
   
  }
}

SearchedArray(array1, array2);

Console.WriteLine(string.Join(", ", array2) + "]");  //выводи на печать получившийся массив
