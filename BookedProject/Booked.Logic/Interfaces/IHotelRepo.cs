﻿using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
    public interface IHotelRepo
    {
        Hotel GetHotelByID(int id);
        IEnumerable<Hotel> GetAllHotel();
        IEnumerable<Hotel> GetAllWebsiteHotel(string sort);
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void RemoveHotelByID(int id);
        IEnumerable<Hotel> GetAllHotelBySearch(string search, string sort);
    }
}
