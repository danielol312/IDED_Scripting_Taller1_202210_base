using System.Collections.Generic;

namespace TestProject1
{
    internal class TestMethods
    {
        int mayor;
        internal enum EValueType
        {
            Two,
            Three,
            Five,
            Seven,
            Prime
        }

        internal static Stack<int> GetNextGreaterValue(Stack<int> sourceStack)
        {
            Stack<int> result = new Stack<int>();
            result.Push(5);
            result.Push(6);
            result.Push(3);
            result.Push(26);

            int[] array = result.ToArray();
            int[] resultArray = new int[array.Length];

            int mayor = 0;
            int posicion = 0;

            //Conseguir el primer mayor
            for (int i = 0; i < array.Length; i++)
            {
                if (mayor < array[i])
                {
                    mayor = array[i];
                    posicion = i;
                }
            }

            while (resultArray[array.Length] != -1)
            {
                for (int x = 0; x < posicion; x++)
                {
                    resultArray[x] = mayor;
                    resultArray[posicion] = -1;

                    mayor = 0;
                }

                for (int y = posicion; y < array.Length; y++)
                {
                    if (mayor < array[y])
                    {
                        mayor = array[y];
                        posicion = y;
                    }
                }
            }

            for (int i = 0; i < resultArray.Length; i++)
            {
                result.Push(resultArray[i]);
            }

            return result;
        }

        internal static Dictionary<int, EValueType> FillDictionaryFromSource(int[] sourceArr)
        {
            
            
            
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
            int [] arreglo= {1, 4, 2, 3, 5};

            for (int i = 0; i < sourceArr.Length; i++)
            {
                if (sourceArr[i] % 2 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Two);
                }
                else if (sourceArr[i] % 3 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Three);
                }
                else if (sourceArr[i] % 5 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Five);
                }
                else if (sourceArr[i] % 7 == 0)
                {
                    result.Add(sourceArr[i], EValueType.Seven);
                }
                else if (sourceArr[i] % i == 0)
                {
                    result.Add(sourceArr[i], EValueType.Prime);
                }
            }
            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            //recorrer el diccionario entregándole como key un valor del arreglo y como value el que entregaba el método
            int count = 0;

            for (int i = 0; i < sourceDict.Count; i++)
            {
                if (sourceDict[i].Equals(type))
                {
                    count++;
                }
            }

            return count;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();
            //crear un arreglo de dos dimensiones {key} {value}
            int[,] matriz = new int [sourceDict.Count,2];
            {
                {Dictionary[i],FillDictionaryFromSource.diccionario[i]}
            }


            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;
            for (int i = 0; i < sourceList.Count; i++)
             {
                 if (sourceList[i].ERequestType==Subscription)
                 {
                     result[0].Append(sourceList[i]);
                 }
                 if (sourceList[i].ERequestType.Payment)
                 {
                     result[1].Append(sourceList[i]);
                 }
                 if (sourceList[i].ERequestType.Cancellation)
                 {
                     result[2].Append(sourceList[i]);
                 }
             }

             result.Sort(sourceList.Payment);
             result.Reverse(sourceList.Payment);
             result.Sort(sourceList.Subscription);
             result.Reverse(sourceList.Subscription);
             result.Sort(sourceList.Cancellation);
             result.Reverse(sourceList.Cancellation);

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = true;

            return result;
        }        
    }
}
