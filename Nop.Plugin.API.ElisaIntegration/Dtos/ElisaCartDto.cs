using System.Collections.Generic;

namespace Nop.Plugin.API.ElisaIntegration.Dtos
{
    /// <summary>
    /// Represents a API response dto of elisa cart
    /// </summary>
    public class ElisaCartDto
    {
        #region Ctor
        public ElisaCartDto() 
        {
            Items = new List<CartItems>();
        }
        #endregion

        #region Properties
        public string ElisaReference { get; set; }

        public IList<CartItems> Items { get; set; }

        #region Nested class
        public class CartItems
        {
            public int Id { get; set; }
            public int ParentId { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }
            public string AttributeXML { get; set; }
        }
        #endregion

        #endregion
    }
}
