using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BackEnd.Models
{
    public class Customer
    {
        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("gender")]
        public string gender { get; set; }

        [BsonElement("phone")]
        public string phone { get; set; }

        [BsonElement("date_of_birth")]
        public DateTime date_of_birth { get; set; }

        [BsonElement("relationship")]
        public string relationship { get; set; }

        [BsonElement("customer_id")]
        public string customer_id { get; set; }

        [BsonElement("email")]
        public string email { get; set; }

        [BsonElement("address")]
        public string address { get; set; }

        [BsonElement("city")]
        public string city { get; set; }

        [BsonElement("district")]
        public string district { get; set; }

        [BsonElement("commune")]
        public string commune { get; set; }

        [BsonElement("place")]
        public string place { get; set; }

        [BsonElement("vaccination_center")]
        public string vaccination_center { get; set; }

        [BsonElement("active")]
        public bool active { get; set; }

        [BsonElement("create_date")]
        public DateTime create_date { get; set; }
    }
}
