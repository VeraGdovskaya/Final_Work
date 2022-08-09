
string[] array1 = new string[5] {"Hello", "2", "Mom", "Peace", "Jam"};

Console.Write("[" + string.Join(", ", array1) + "]" +  "->" + "[");

string[] array2 = new string[array1.Length];


void SearchedArray(string[] array1, string[] array2)
{
  int count = 0; 
  for (int i = 0; i < array1.Length; i++)
  {
    if (array1[i].Length <= 3)  
    {
      array2[count] = array1[i];  
      count ++;
    }
   
  }
}

SearchedArray(array1, array2);

Console.WriteLine(string.Join(", ", array2) + "]");  
