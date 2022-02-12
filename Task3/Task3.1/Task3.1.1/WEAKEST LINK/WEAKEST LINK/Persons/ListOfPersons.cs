using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEAKEST_LINK
{
    public class ListOfPersons
    {
        private List<int> _list;

        public ListOfPersons(int n)
        {
            _list = new List<int>(Enumerable.Range(1, n));
        }

        public void DeletePerson(int currentNum)
        {
            _list.RemoveAt(currentNum - 1);
        }

        public void ShowProcess(int num)
        {
            int i = 1;
            int currentNum = num;
            while (_list.Count >= num)
            {
                DeletePerson(currentNum);
                currentNum += num - 1;
                if (currentNum > _list.Count)
                {
                    currentNum -= _list.Count;
                }
                Console.WriteLine($"Раунд {i}. Вычеркнут человек. Людей осталось: {_list.Count}");
                i++;
            }
        }

        public void PrintList()
        {
            foreach (var item in _list)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
