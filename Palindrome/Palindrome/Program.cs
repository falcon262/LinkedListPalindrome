namespace Palindrome
{

    //Definition for singly-linked list.
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


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1))))));
        }

        static List<int> list2 = new List<int>();

        static ListNode PrintOut(ListNode list)
        {
            if (list.next != null)
            {
                list2.Add(list.val);
                return PrintOut(list.next);
            }
            else
            {
                list2.Add(list.val);
                return list;
            }

        }
        static bool IsPalindrome(ListNode head)
        {
            PrintOut(head);
            List<int> list = new List<int>();

            foreach (var item in list2)
            {
                list.Add(item);
            }

            list2.Reverse();

            if (list.SequenceEqual(list2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}