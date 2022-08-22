using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Janus_API.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        [DataType("decimal(38,8)")]
        public decimal UnitPrice { get; set; }
        [DataType("decimal(38,8)")]
        public decimal Quantity { get; set; }
        [DataType("decimal(38,8)")]
        public decimal Fee1 { get; set; }
        [DataType("decimal(38,8)")]
        public decimal Fee2 { get; set; }
        [DataType("decimal(38,8)")]
        public decimal Total { get; set; }
        public TransactionType TransactionType { get; set; }
        public int TransactionTypeId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Asset Asset { get; set; }
        public int? AssetId { get; set; }

    }
}
