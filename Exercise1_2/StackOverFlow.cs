using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_2
{
    public class StackOverFlow
    {
        public string Title;
        public string Description;
        public DateTime TimeDateCreated;
        public int upvote =0;
        public int downvote =0;

        public void Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            TimeDateCreated = DateTime.Now;
            
            
        }

        public int Upvoting()
        {
            upvote++;
            return upvote;

        }
        public int Downvoting()
        {
            downvote++;
            return downvote;

        }
    }
}
