using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_SAADAT_3_Linked_list
{
    internal class linked_list<T>
    {
         int count_l=0;// to find out the number of input or length list
        public NODE<T> Last { set; get; }//builder  //for the head
        public NODE<T> First { set; get; }//builder// for the end
        public linked_list() 
        {
            First = new NODE<T>();
            Last = new NODE<T>();
        }
        public  void AddFirst(T data)// method add  first
        {
            NODE<T> temp = new NODE<T>(data);
            temp.Next = First;  
            if (ISempty())// to find out the first is empty
            {
                Last = temp;//where to tail index gives the first value to added and remains to the end it indicicates the end of the list
            }
            First = temp;
            count_l++;
        }
        public void AddLast(T data)//method add last
        {
            NODE<T> t = new NODE<T>(data);
            if (ISempty())// if it empty it will be added first
            {
                AddFirst(data);//
            }
            Last.Next = t; Last = t;
            count_l++;

        }
        public void Addloction(T data, int l)// method add location 
        {
            if (l > count_l || l < 0)// loation is reverse or out of length
            {
                Console.WriteLine("sorry,the add_on site is not available");
                return;//close;
            }
            NODE<T> t = new NODE<T>(data);   
            NODE<T> move=First;
            l--;
            for(int i=0; i<l; i++)
                move=move.Next;
            t.Next = move.Next;
            move.Next = t;
            count_l++;
        }
        public void Deletefirst() //nethod delete f
        {
            if (ISempty())// if it empty ther is nothing to delete
            {
                Console.WriteLine("sorry,there is no_thing to Delete ");
                return;
            }
            NODE<T> t = First;
            First = First.Next;
            t.Next = null;
            count_l--;
        }
        public void Deletelast()//method delete l
        {
            if (ISempty())// if it empty ther is nothing to delete
            {
                Console.WriteLine("sorry,there is no_thing to Delete ");
                return;
            }
            if(count_l == 1)//if the length is the same it means that ,I will delete the first
            {
                Deletefirst();
                return;
            }
            NODE<T> move = First;
            for(int i=1;i<count_l-1; i++)
            {
                move=move.Next;
            }
            Last = move;
            move.Next = null;
            count_l--;
        }
        public bool ISempty()//returns true or false depending on whether the head is empty or not
        {
            return First == null;
        }
    }
}
