namespace Microedge.Models.Organizations
{
    /// <summary>
    /// DTO for the Online Presence portion of a <see cref="Organization"/>.
    /// </summary>
    public class OnlinePresence
    {
        /// <summary>
        /// Whether this specific online presenece information is actively used or not.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// What kind of presence this is (www, facebook, twitter, etc.).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The status of the presence (preferred, do not contact, etc.).
        /// </summary>
        public double Status { get; set; }

        /// <summary>
        /// The link text that will be presented in the UI.
        /// </summary>
        public string Display { get; set; }

        /// <summary>
        /// The web address of the link.
        /// </summary>
        public string Address { get; set; }
    }
}
