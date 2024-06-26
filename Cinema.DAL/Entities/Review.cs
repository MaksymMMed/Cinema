﻿using Cinema.DAL.Utilities.Interfaces.TrackChanges;
using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Review : ICreatedBy
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CreatedById { get; set; }
        public Guid MovieId { get; set; }
        public string Comment { get; set; }
        public int Rank { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedByName { get; set; }
        public Movie Movie { get; set; }
        public AspNetUser CreatedBy { get; set; }

    }
}
