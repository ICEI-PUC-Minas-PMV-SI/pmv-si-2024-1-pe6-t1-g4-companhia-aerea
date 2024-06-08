﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dtos.FlightAggregate
{
    public class FlightIntineraryDtoCreateResult
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public bool Available { get; set; }
        public DateTime LeaveDate { get; set; }
        public DateTime ArriveDate { get; set; }
        public Guid LeaveIATAId { get; set; }
        public Guid ArriveIATAId { get; set; }
    }
}
