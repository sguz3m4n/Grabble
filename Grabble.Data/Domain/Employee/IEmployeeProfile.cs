using Newtonsoft.Json;

namespace Grabble.Data.Domain.Employee
{
    public interface IEmployeeProfile
    {
        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonRequired]
        string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonRequired]
        string Lastname { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonRequired]
        int Age { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonRequired]
        string NRN { get; set; }

        /// <summary>
        /// Gets or sets the first name
        /// </summary>
        [JsonRequired]
        string TIN { get; set; }
    }
}
