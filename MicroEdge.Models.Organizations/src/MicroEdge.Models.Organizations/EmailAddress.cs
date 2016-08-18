namespace Microedge.Models.Organizations
{
    /// <summary>
    /// DTO for the Email Address portion of a <see cref="Organization"/>.
    /// </summary>
    public class EmailAddress
    {
        /// <summary>
        /// Whether this specific email information is actively used or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The type of email address this is.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The status of the email address (preferred, do not contact, etc.).
        /// </summary>
        public double Status { get; set; }

        /// <summary>
        /// The actual email address.
        /// </summary>
        public string Email { get; set; }
    }
}
