﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class MessageEventArgs : EventArgs
    {
        public string Sender { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
