namespace Microedge.Models.Organizations
{
    /// <summary>
    /// DTO for the Address portion of a <see cref="Organization"/>.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Whether this specific address information is actively used or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// What kind of address this is.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The status of the address (preferred, do not contact, etc.).
        /// </summary>
        public double Status { get; set; }

        /// <summary>
        /// The address line 1 information.
        /// </summary>
        public string Line1 { get; set; }

        /// <summary>
        /// The address line 2 information.
        /// </summary>
        public string Line2 { get; set; }

        /// <summary>
        /// The address city information.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The address state information.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// The address postal (zip) code information.
        /// </summary>
        public string Postal_Code { get; set; }

        /// <summary>
        /// The address country information.
        /// </summary>
        public string Country { get; set; }
    }
}
