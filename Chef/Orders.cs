using System;
using System.Collections.Generic;
using System.Text;

namespace Chef
{
    public class Orders
    {
        public string orderObj = string.Empty;
        public int id = 0;
        public bool making = false;

        public Orders()
        {
        }

        public Orders(string _Prop, int _Val, bool _making)
        {
            orderObj = _Prop;
            id = _Val;
            making = _making;


        }

        public string orderOb
        {
            get { return orderObj; }
            set { orderObj = value; }
        }
        public int idd
        {
            get { return id; }
            set { id = value; }
        }
        public bool makingg
        {
            get { return making; }
            set { making = value; }
        }

        public bool Item3 { get; internal set; }
        public object item2 { get; internal set; }
        public string Item2 { get; internal set; }
        public object item1 { get; internal set; }
        public string Item1 { get; internal set; }
    }
}