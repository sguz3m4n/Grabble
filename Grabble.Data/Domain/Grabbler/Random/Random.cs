using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Grabble.Data.Domain.Grabbler
{
    [Table("Random")]
    [JsonObject("Random")]
    public  class Random:BaseEntity
    {
        #region Constructor
        public Random()
        {

        }
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the random GUID
        /// </summary>
        public Guid RandomGuid { get; set; }

        /// <summary>
        /// Gets or sets the passport
        /// </summary>
        [JsonRequired]
        public string PassportNumber { get; set; }

        /// <summary>
        /// Gets or sets the username
        /// </summary>
        [JsonRequired]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        [JsonRequired]
        public string Firstname { get; set; }


        /// <summary>
        /// Gets or sets the firstname
        /// </summary>
        [JsonRequired]
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
        /// Gets or sets the email that should be re-validated. Used in scenarios when a random is already registered and wants to change an email address.
        /// </summary>
        [JsonRequired]
        public string EmailToRevalidate { get; set; }

        #endregion
    }
}
