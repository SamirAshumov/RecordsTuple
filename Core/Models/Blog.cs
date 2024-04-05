using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Blog
    {
        private static int _id = 0; 
        private string _title;
        private string _description;

        public int Id { get { return _id; } set { _id = value; } }
        public string Title 
        {
            get
            {
                return _title;
            } 

            set
            {
                if( value.Length > 5)
                {
                    _title = value;
                }                
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                if (value.Length > 8)
                {
                    _description = value;
                }
            }
        }



        public Comment[] Comments = new Comment[0];
        public Comment[] FilteredComments = new Comment[0];

        public Blog(string title, string description)
        {
            _id++;
            Id = _id;
            Title = title;
            Description = description;
            Console.WriteLine("\nBlog yaradildi!\n");
        }

        public override string ToString()
        {
            return $"Title: {Title}   Description: {Description}";
        }

        public Comment GetComment(int commentId)
        {
            for (int i  = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    return Comments[i];
                }
            }

            return null;
        }

        public Comment[] GetAllComments()
        {
            return Comments;
        }

        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length+1);
            Comments[Comments.Length-1] = comment;

        }

        public void RemoveComment(int commentId)
        {
            for (int i = 0; i < Comments.Length;i++)
            {
                if (Comments[i].Id != commentId)
                {
                    Array.Resize(ref FilteredComments, FilteredComments.Length+1);
                    FilteredComments[FilteredComments.Length-1] = Comments[i];
                }
            } 

            Comments = FilteredComments;
            
        }

        public void UpdateComment(int commentId, Comment comment)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    Comments[i] = comment;
                }
            }
        }
    }
}
