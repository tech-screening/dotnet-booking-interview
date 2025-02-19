// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using FluentAssertions;
using Booking.API.Controllers;
using Booking.API.Models;

namespace Booking.Tests
{

    public class BookingControllerTests
    {
        private readonly BookingController _controller;

        public BookingControllerTests()
        {
            _controller = new BookingController();
        }

        [Fact]
        public async Task ValidInputs_ReturnsExpectedResults()
        {
            var request = new BookingRequest { Name = "testFromController", Row = "2", Column = "3" };
            var result = await _controller.CreateBooking(request);
            var resultValue = result.Value.Result;
            
            resultValue.Should().Be("Booking confirmed for testFromController at row 2, column 3.");
        }
    }
}