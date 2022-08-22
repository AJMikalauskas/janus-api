using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Janus_API.Models
{
    public class AssetType
    {
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR(50)")]
        public string Name { get; set; }
        [Column(TypeName = "VARCHAR(150)")]
        public string Description { get; set; }
        public List<Asset> Assets { get; set; }
    }
}