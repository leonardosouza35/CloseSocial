﻿using Flunt.Notifications;

namespace CloseSocial.Domain.Entities
{
    public abstract class Entity : Notifiable
    {
        public int Id { get; set; }                
    }
}
