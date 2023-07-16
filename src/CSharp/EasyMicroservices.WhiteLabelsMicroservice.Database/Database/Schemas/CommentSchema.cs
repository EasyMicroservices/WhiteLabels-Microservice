using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.CommentMicroservice.Database.Schemas
{
    public class CommentSchema
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModifiationTime { get; set; }
    }
}
