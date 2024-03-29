﻿using System;
using System.Collections.Generic;

namespace M3Pact.DomainModel.DomainModels
{
    public partial class ClientConfig
    {
        public int ClientConfigId { get; set; }
        public int? ClientId { get; set; }
        public int? AttributeId { get; set; }
        public string AttributeValue { get; set; }
        public string RecordStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public Attribute Attribute { get; set; }
        public Client Client { get; set; }
    }
}
