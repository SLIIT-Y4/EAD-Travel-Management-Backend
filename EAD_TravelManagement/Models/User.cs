﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace EAD_TravelManagement.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Name { get; set; } = null!;
        public string NIC { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string ContactNo { get; set; } = null!;
        public string Password { get; set; } = null!;


    }
}
