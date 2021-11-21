namespace EmailServiceLibrary.Models
{
    public class EmailServiceOptions
    {
        /// <summary>
        /// SMTP Server Adress
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// SMTP Port, Default 25
        /// </summary>
        public int Port { get; set; }
        /// <summary>
        /// Sender Email Adress
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Sender Account may equal to Sender EMail Adress
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// Senders Name
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Use SSL or TLS
        /// </summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Senders Password
        /// </summary>
        public bool Security { get; set; } = false;
    }
}
