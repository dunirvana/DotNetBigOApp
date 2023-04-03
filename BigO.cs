
public class BigO
{
  private int[] myArray;
  private int[] reverseArray;

  public BigO()
  {
    var arrayLength = 30;

    myArray = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
      myArray[i] = i;
    }
    reverseArray = myArray.Reverse().ToArray();
  }

  private void Print(object text)
  {
#if DEBUG    
    Console.WriteLine(text);
#endif    
  }

  public void O1()
  {
    Print("\r\n**O(1)**");

    int element = myArray[2];         // acesso ao terceiro elemento do array
    Print(element);       // exibe o valor do terceiro elemento (3) no console
  }

  public void On()
  {
    Print("\r\n**O(n)**");

    for (int i = 0; i < myArray.Length; i++)  // loop para percorrer todos os elementos do array
    {
      Print(myArray[i]);        // exibe cada elemento no console
    }
  }

  public void On2()
  {
    Print("\r\n**O(n^2)**");

    int[,] myMatrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // declaração e inicialização de uma matriz
    for (int i = 0; i < myMatrix.GetLength(0); i++) // loop para percorrer as linhas da matriz
    {
      for (int j = 0; j < myMatrix.GetLength(1); j++) // loop para percorrer as colunas da matriz
      {
        Print(myMatrix[i, j]); // exibe cada elemento da matriz no console
      }
    }
  }

  public void OlogN()
  {
    Print("\r\n**O(log n)**");
    Print(OlogNProcessar());
  }

  private int OlogNProcessar()
  {
    int[] myArray = { 1, 3, 5, 7, 9 }; // declaração e inicialização de um array ordenado
    int target = 7; // valor que deseja-se buscar no array
    int min = 0; // índice do primeiro elemento do array
    int max = myArray.Length - 1; // índice do último elemento do array
    while (min <= max) // loop para buscar o elemento no array
    {
      int mid = (min + max) / 2; // índice do elemento central do array

      if (myArray[mid] == target) // se o elemento central for igual ao valor buscado, retorna o índice
      {
        return mid;
      }
      else if (myArray[mid] < target) // se o elemento central for menor que o valor buscado, atualiza o índice mínimo
      {
        min = mid + 1;
      }
      else // se o elemento central for maior que o valor buscado, atualiza o índice máximo
      {
        max = mid - 1;
      }
    }
    return -1; // valor não encontrado no array
  }

  public void OnLogN()
  {
    Print("\r\n**O(n log n)**");    

    Print($"Array original: {string.Join(",", reverseArray)}");

    MergeSort(reverseArray, 0, reverseArray.Length -1);

    Print($"Array ordenado: {string.Join(",", reverseArray)}");
  }

  private void MergeSort(int[] array, int left, int right)
  {
    if (left < right)
    {
      int mid = (left + right) / 2;
      MergeSort(array, left, mid);
      MergeSort(array, mid + 1, right);
      Merge(array, left, mid, right);
    }
  }

  private void Merge(int[] array, int left, int mid, int right)
  {
    int[] temp = new int[array.Length];
    int i, j, k;

    i = left;
    j = mid + 1;
    k = left;

    while (i <= mid && j <= right)
    {
      if (array[i] <= array[j])
      {
        temp[k] = array[i];
        i++;
      }
      else
      {
        temp[k] = array[j];
        j++;
      }
      k++;
    }

    while (i <= mid)
    {
      temp[k] = array[i];
      i++;
      k++;
    }

    while (j <= right)
    {
      temp[k] = array[j];
      j++;
      k++;
    }

    for (int x = left; x <= right; x++)
    {
      array[x] = temp[x];
    }
  }

}