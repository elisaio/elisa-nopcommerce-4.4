using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.API.ElisaIntegration.Dtos
{
    public class ElisaCartResponseDto
    {
        #region Ctor
        public ElisaCartResponseDto() 
        {
            Errors = new List<string>();
        }

        #endregion

        #region Properties
        [JsonProperty("elisa_cart_id")]
        public Guid ElisaCartId { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        public IList<string> Errors { get; set; }
        #endregion
    }
}
