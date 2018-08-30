using FluentValidator;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloseSocial.Domain.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; set; }                
    }
}
