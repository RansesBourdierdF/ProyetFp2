using System;

namespace Hotel.Application.Dtos.Base
{
    public abstract class DtoBase
    {

        [JsonProperty("CambiarUser")]
        public int ChangeUser { get; set; }

        [JsonProperty("cambiarDate")]
        public DateTime CambiarFecha { get; set; }
    }
}


