namespace Microedge.Models.Organizations
{
    /// <summary>
    /// DTo for the Phone Number portion of a <see cref="Organization"/>.
    /// </summary>
    public class PhoneNumber
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
        /// The phone number.
        /// </summary>
        public string Number { get; set; }

        /// <summary>
        /// The phone extension.
        /// </summary>
        public string Ext { get; set; }
    }
}
