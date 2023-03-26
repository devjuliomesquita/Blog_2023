using Blog_Escola_Dotnet.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_Data.Entities
{
    public class Blog
    {
        public int Id { get; set; }
        public ApplicationUser Creator { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Published { get; set; }
        public bool Approved { get; set; }
        public ApplicationUser Approver { get; set; }
        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
