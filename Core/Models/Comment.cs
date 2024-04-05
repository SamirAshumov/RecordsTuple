using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        private static int _id;

        public int Id { get; set; }

        public string Content { get; set; }


        public override string ToString()
        {
            return $"ID: {Id}   Content: {Content}";
        }

        public Comment(string content)
        {
            _id++;
            Id = _id;
            Content = content;

            Console.WriteLine("Comment yaradildi!");
        }




    }
}
