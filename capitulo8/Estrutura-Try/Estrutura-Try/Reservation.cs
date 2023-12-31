﻿namespace Estrutura_Try
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            CheckOut = checkout;
            CheckIn = checkin;
        }
        public override string ToString()
        {
            return ($"{RoomNumber} - CheckIN: {CheckIn} - CheckOUT: {CheckOut}");
        }
    }
}
