using System.Collections.Generic;

namespace Microedge.Models.Organizations
{
    /// <summary>
    /// DTO for the main organization record from the database.
    /// </summary>
    public class Organization
    {
        /// <summary>
        /// Universally unique, self-deterministic id for this grant, not an existing legacy Id
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// the Id of the record in the GIFTS Online database.
        /// </summary>
        public string LegacyId { get; set; }

        /// <summary>
        /// the Id of the client that this organization belongs to.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The organization name.
        /// </summary>
        public string Name { get; set; }

        public string FunderId { get; set; }

        /// <summary>
        /// List of Addresses used by the organization.
        /// </summary>
        public List<Address> Addresses { get; set; } = new List<Address>();

        /// <summary>
        /// List of Phone Numbers used by the organization.
        /// </summary>
        public List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        /// <summary>
        /// List of Email Addresses used by the organization.
        /// </summary>
        public List<EmailAddress> EmailAddresses { get; set; } = new List<EmailAddress>();

        /// <summary>
        /// List of Online Presences used by the organization.
        /// </summary>
        public List<OnlinePresence> OnlinePresence { get; set; } = new List<OnlinePresence>();
    }
}

