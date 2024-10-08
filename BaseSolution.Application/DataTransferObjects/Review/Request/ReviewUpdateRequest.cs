﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseSolution.Application.DataTransferObjects.Review.Request
{
    public class ReviewUpdateRequest
    {
        public int Id { get; set; }
        public float Rating { get; set; }
        public string? Comment { get; set; }
        public object EventId { get; set; }
        public object ParticipantId { get; set; }
    }
}
