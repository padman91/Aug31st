﻿namespace M3Pact.BusinessModel.Admin
{
    public class Measure
    {
        public int MeasureId { get; set; }
        public string MeasureText { get; set; }
        public bool Standard { get; set; }
        public bool Universal { get; set; }
        public int? KPIID { get; set; }
        public string MeasureCode { get; set; }
        public string MeasureUnit { get; set; }
    }
}
