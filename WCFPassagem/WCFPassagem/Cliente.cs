﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WCFPassagem
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public string Nome{ get; set; }

        [DataMember]
        public string CPF{ get; set; }
    }
}
