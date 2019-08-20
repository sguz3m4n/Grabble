using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Grabble.Data.Domain.Grabbler
{
    [Table("Familiar")]
    [JsonObject("Familiar")]
    public class Familiar : BaseEntity
    {
        #region Constructor

        public Familiar()
        {
            this.FamiliarGuid = Guid.NewGuid();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the familiar GUID
        /// </summary>
        public Guid FamiliarGuid { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [JsonRequired]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// Gets or sets the email
        /// </summary>
        [JsonRequired]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the phone number
        /// </summary>
        [JsonRequired]
        [Phone]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email that should be re-validated. Used in scenarios when a familiar is already registered and wants to change an email address.
        /// </summary>
        [JsonRequired]
        public string EmailToRevalidate { get; set; }

        /// <summary>
        /// Gets or sets the flight id
        /// </summary>
        public int FlightId { get; set; }


        #endregion

    }
}
