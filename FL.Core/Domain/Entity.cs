using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FL.Core.Domain
{
   public class Entity
    {
        [System.ComponentModel.DataAnnotations.Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }

        protected Entity(Guid id)
        {
            Id = Guid.NewGuid();
        }

        public Entity()
        {
            
        }
    }
}
