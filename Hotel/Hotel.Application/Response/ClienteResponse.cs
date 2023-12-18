using Hotel.Application.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Application.Response
{
    public class ClienteResponse : ServiceResult
    {
        public int ClienteId { get; set; }
    }
}
