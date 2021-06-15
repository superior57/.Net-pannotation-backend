﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Pannotation.Models.ResponseModels.Songsheet
{
    public class CartSongsheetResponseModel : SongsheetBaseResponseModel
    {
        [JsonProperty("instruments")]
        public List<string> Instruments { get; set; }

        [JsonProperty("genres")]
        public List<string> Genres { get; set; }
    }
}
