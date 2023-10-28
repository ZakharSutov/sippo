using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Class1
    {
        public class Item
        {
            public int num { get; set; }

            public int weigth { get; set; }

            public int price { get; set; }

            public Item(int _num, int _weigth, int _price)
            {
                num = _num;
                weigth = _weigth;
                price = _price;
            }

        }

        public class Backpack
        {
            private List<Item> bestItems = null;

            private int maxW;

            private int bestPrice;

            public Backpack(int _maxW)
            {
                maxW = _maxW;
            }

            private int CalcWeigth(List<Item> items)
            {
                int sumW = 0;

                foreach (Item i in items)
                {
                    sumW += i.weigth;
                }

                return sumW;
            }

            private int CalcPrice(List<Item> items)
            {
                int sumPrice = 0;

                foreach (Item i in items)
                {
                    sumPrice += i.price;
                }

                return sumPrice;
            }

            private void CheckSet(List<Item> items)
            {
                if (bestItems == null)
                {
                    if (CalcWeigth(items) <= maxW)
                    {
                        bestItems = items;
                        bestPrice = CalcPrice(items);
                    }
                }
                else
                {
                    if (CalcWeigth(items) <= maxW && CalcPrice(items) > bestPrice)
                    {
                        bestItems = items;
                        bestPrice = CalcPrice(items);
                    }
                }
            }

            public void MakeAllSets(List<Item> items)
            {
                if (items.Count > 0)
                    CheckSet(items);

                for (int i = 0; i < items.Count; i++)
                {
                    List<Item> newSet = new List<Item>(items);

                    newSet.RemoveAt(i);

                    MakeAllSets(newSet);
                }

            }

            public List<Item> GetBestSet()
            {
                return bestItems;
            }
        }
    }
}
