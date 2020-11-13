using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

//https://leetcode.com/problems/add-two-numbers/
namespace LeetCode.Problem
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }



    public static class AddTwoNumber
    {
        public static ListNode Test()
        {

            ListNode l1 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9,new ListNode(9)))))));
            ListNode l2 = new ListNode(9, new ListNode(9, new ListNode(9,new ListNode(9))));
            return AddTwoNumbers(l1, l2);
        }

        static List<int> valuesl1 = new List<int>();
        static List<int> valuesl2 = new List<int>();

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            valuesl1 = new List<int>();
            valuesl2 = new List<int>();

            Process(l1, valuesl1);
            Process(l2, valuesl2);

            var l1Str = Invert(valuesl1);
            var l1Value = BigInteger.Parse(string.Concat(l1Str));

            var l2Str = Invert(valuesl2);
            var l2Value = BigInteger.Parse(string.Concat(l2Str));

            var result = l1Value + l2Value;

            var arrayResult = result.ToString().ToCharArray();
            var inverted = Invert(arrayResult).ToList();


            ListNode ln = new ListNode();
            ConvertToListNode(string.Concat(inverted).ToCharArray(), ref ln);

            return ln;
        }

        private static IEnumerable<string> Invert(List<int> arrayToInvert)
        {
            for (int i = arrayToInvert.Count() - 1; i >= 0; i--)
                yield return arrayToInvert[i].ToString();
        }

        private static void ConvertToListNode(char[] array, ref ListNode listNode, int iteration = 0)
        {
            if (iteration < array.Length)
            {
                listNode.val = (int)Char.GetNumericValue(array[iteration]);


                if (iteration + 1 < array.Length)
                    listNode.next = new ListNode();

                ConvertToListNode(array, ref listNode.next, iteration + 1);
            }
        }


        private static IEnumerable<string> Invert(char[] arrayToInvert)
        {
            for (int i = arrayToInvert.Count() - 1; i >= 0; i--)
                yield return arrayToInvert[i].ToString();
        }



        private static void Process(ListNode ln, List<int> array)
        {
            array.Add(ln.val);
            if (ln.next != null)
                Process(ln.next, array);
        }


    }
}
