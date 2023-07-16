using EasyMicroservices.CommentMicroservice.Database.Schemas;
using EasyMicroservices.Cores.Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.CommentsMicroservice.Database.Entities
{
    public class CommentEntity : CommentSchema, IIdSchema<long>
    {
        public long Id { get; set; }
    }
}
