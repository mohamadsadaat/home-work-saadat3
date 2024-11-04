using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_SAADAT_3_Linked_list
{
    internal class NODE<U> //the node class receives any type of data bacuse it is a generic
    {
        public U Data { get; set; }//builder of stored data
        public NODE<U> Next { get; set; }//builder of indicative data
        public NODE() { }
        public NODE(U data)
        {
            this.Data = data;
        }

    }

}
