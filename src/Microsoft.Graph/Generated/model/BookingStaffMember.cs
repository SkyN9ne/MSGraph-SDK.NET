// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Booking Staff Member.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<BookingStaffMember>))]
    public partial class BookingStaffMember : BookingStaffMemberBase
    {
    
        ///<summary>
        /// The BookingStaffMember constructor
        ///</summary>
        public BookingStaffMember()
        {
            this.ODataType = "microsoft.graph.bookingStaffMember";
        }

        /// <summary>
        /// Gets or sets availability is affected by personal calendar.
        /// True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member's availability in their personal calendar in Microsoft 365, before making a booking.
        /// </summary>
        [JsonPropertyName("availabilityIsAffectedByPersonalCalendar")]
        public bool? AvailabilityIsAffectedByPersonalCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name is suitable for human-readable interfaces.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets email address.
        /// The email address of the staff member. This can be in the same Microsoft 365 tenant as the business, or in a different email domain. This email address can be used if the sendConfirmationsToOwner property is set to true in the scheduling policy of the business. Required.
        /// </summary>
        [JsonPropertyName("emailAddress")]
        public string EmailAddress { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// The role of the staff member in the business. Possible values are: guest, administrator, viewer, externalGuest, unknownFutureValue, scheduler and member. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: scheduler, member. Required.
        /// </summary>
        [JsonPropertyName("role")]
        public BookingStaffRole? Role { get; set; }
    
        /// <summary>
        /// Gets or sets time zone.
        /// The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.
        /// </summary>
        [JsonPropertyName("timeZone")]
        public string TimeZone { get; set; }
    
        /// <summary>
        /// Gets or sets use business hours.
        /// True means the staff member's availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member's workingHours property setting.
        /// </summary>
        [JsonPropertyName("useBusinessHours")]
        public bool? UseBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets working hours.
        /// The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.
        /// </summary>
        [JsonPropertyName("workingHours")]
        public IEnumerable<BookingWorkHours> WorkingHours { get; set; }
    
    }
}

