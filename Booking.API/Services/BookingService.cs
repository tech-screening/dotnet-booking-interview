// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Text;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Booking.API.Services
{
    public interface IBookingService
    {
        Task<string> CreateBooking(string name, string row, string column);
    }

    public class BookingService : IBookingService
    {
        private readonly string[,] _seatingChart;

        public BookingService()
        {
            _seatingChart = new string[10, 10]; // Example size, can be adjusted
        }

        public async Task<string> CreateBooking(string name, string row, string column)
        {
            int rowIndex = int.Parse(row);
            int columnIndex = int.Parse(column);

            _seatingChart[rowIndex, columnIndex] = name;

            return await Task.FromResult($"Booking confirmed for {name} at row {row}, column {column}.");
        }
    }
}