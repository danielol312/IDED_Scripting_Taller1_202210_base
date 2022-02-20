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

            return result;
        }

        internal static int CountDictionaryRegistriesWithValueType(Dictionary<int, EValueType> sourceDict, EValueType type)
        {
            return 0;
        }

        internal static Dictionary<int, EValueType> SortDictionaryRegistries(Dictionary<int, EValueType> sourceDict)
        {
            Dictionary<int, EValueType> result = new Dictionary<int, EValueType>();

            return result;
        }

        internal static Queue<Ticket>[] ClassifyTickets(List<Ticket> sourceList)
        {
            Queue<Ticket>[] result = null;

            return result;
        }

        internal static bool AddNewTicket(Queue<Ticket> targetQueue, Ticket ticket)
        {
            bool result = true;

            return result;
        }        
    }
}
