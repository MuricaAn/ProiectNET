﻿namespace Proiect.Models.Base
{
    public interface IBaseEntity
    {
        Guid Id { get; set; }
        DateTime? DateCreated { get; set; }
    }
}
