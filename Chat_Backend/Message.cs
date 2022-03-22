using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chat_Backend
{
    public class Message
    {
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }



    }
}
