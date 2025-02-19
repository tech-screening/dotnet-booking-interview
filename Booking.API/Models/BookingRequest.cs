// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using Microsoft.Extensions.Caching.Memory;

namespace Booking.API.Models
{
    public class BookingRequest
    {
        public string Name { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
        
    }
}