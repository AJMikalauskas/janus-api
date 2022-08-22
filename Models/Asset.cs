using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Janus_API.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Description { get; set; }
        public string Exchange { get; set; }
        // Navigation Property
        public AssetType AssetType { get; set; }
        public int AssetTypeId { get; set; }
        public User User { get; set; }
        public int UserId { get;set;}
        public List<Transaction> Transactions { get; set; }
        // Link?, Exchange?, DateCreated?, DateAdded?
    }
}
