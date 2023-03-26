using Blog_Escola_Dotnet.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public Blog Blog { get; set; }
        public ApplicationUser  Posser { get; set; }
        public string Content { get; set; }
        public Post Parent { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
