using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    internal class ToDoModel
    {
        public DateTime CreationDate{ get; set; } = DateTime.Now;

        private bool _IsDone;
        private string _TaskText;

        public bool IsDone 
        {
            get { return _IsDone; }
            set { _IsDone = value; }
        }
        public string TaskText
        {
            get { return _TaskText; }
            set { _TaskText = value; }
        }
    }
}
