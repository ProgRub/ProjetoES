﻿using System;
using ComponentsLibrary.Entities.PrescriptionItems;

namespace ComponentsLibrary.Entities
{
    public class PrescriptionHasPrescriptionItems
    {

        public bool Zombie { get; set; }

        public byte[] TimeStamp { get; set; }
        public int PrescriptionId { get; set; }
        public Prescription Prescription { get; set; }
        public int PrescriptionItemId { get; set; }
        public PrescriptionItem PrescriptionItem { get; set; }
        public TimeSpan RecommendedTime { get; set; }
    }
}