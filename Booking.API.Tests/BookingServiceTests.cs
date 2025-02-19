// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Booking.API.Services;

namespace Booking.Tests
{

    public class BookingServiceTests
    {
        private readonly IBookingService _BookingService;

        public BookingServiceTests()
        {
            _BookingService = new BookingService();
        }

        [Fact]
        public async Task ValidInputs_ReturnsExpectedResults()
        {
            var result = await _BookingService.CreateBooking("test", "1", "3");
            Assert.Equal("Booking confirmed for test at row 1, column 3.", result);
        }

    }
}