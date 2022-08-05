using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamiiProjectOptimal.ApiPagesObjects.TeacherProfileSetUpApiPage
{
    public partial class RequestTeacherProfileSetUpApi
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public Instrument[] Instruments { get; set; }
        public Address TeachingAddress { get; set; }
        public bool TeachingAddressAlsoResidential { get; set; }
        public bool IncludesOnlineLesson { get; set; }
        public long OnlineVideoLink { get; set; }
        public bool IsShowPriceGuide { get; set; }
        public TeacherLocation[] TeacherLocations { get; set; }
        public string TimeZoneNameMoment { get; set; }
    }

    public partial class Instrument
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public partial class TeacherLocation
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public long TeacherId { get; set; }
        public bool HasLesson { get; set; }
        public bool IsDeleted { get; set; }
    }

    public partial class Address
    {
        public long Id { get; set; }
        public object StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public long? PostCode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Location { get; set; }
    }

    public partial class ResponseTeacherProfileSetUpApi
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public bool IncludesOnlineLesson { get; set; }
        public long OnlineVideoLink { get; set; }
        public bool IsShowPriceGuide { get; set; }
        public long TimeZone { get; set; }
        public object TimeZoneNameMoment { get; set; }
        public Instrument[] Instruments { get; set; }
        public Address TeachingAddress { get; set; }
        public bool TeachingAddressAlsoResidential { get; set; }
        public TeacherLocation[] TeacherLocations { get; set; }
        public bool Success { get; set; }
        public object ErrorString { get; set; }
    }

    public partial class InstrumentResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    public partial class TeacherLocationResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public long TeacherId { get; set; }
        public bool HasLesson { get; set; }
        public bool IsDeleted { get; set; }
    }

    public partial class AddressResponse
    {
        public long Id { get; set; }
        public object StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public long? PostCode { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string Location { get; set; }
    }
}
