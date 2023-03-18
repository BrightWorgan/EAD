using System.ComponentModel.DataAnnotations;

namespace Api.Models
{
    // enums
    public enum Shops
    {
        Tesco, DunneStores, SuperValu,MarksAndSpenscers, Aldi, Lidl, HollandAndBarret, Boots, GameStop
    }

    public enum ShopLocation 
    {
        Carlow, Cavan, Clare, Cork, Donegal, Dublin, Galway, Kerry, Kildare, Kilkenny, Laois, Leitrim, Limerick, Longford, Louth, Mayo, Meath, Monaghan, Offaly, Roscommon, Sligo, Tipperary, Waterford, Westmeath, Wexford, Wicklow 
    }

    public class Shop
    {
        // attributes
        [Key]
        public Guid ShopId { get; set; }

        [Required]
        public Shops ShopName { get; set; }

        [Required]
        public ShopLocation location { get; set; }
    }
}
