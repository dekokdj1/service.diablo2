using System;

namespace Service.Diablo2.Entities.Models
{
    public class Diablo2Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemTypeId { get; set; }
        public decimal? MinDamage { get; set; }
        public decimal? MaxDamage { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateModified { get; set; }
        public ItemType ItemType { get; set; }
    }
}
