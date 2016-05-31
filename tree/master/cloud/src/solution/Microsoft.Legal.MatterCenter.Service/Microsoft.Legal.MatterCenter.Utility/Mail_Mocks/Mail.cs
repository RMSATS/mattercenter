using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace System.Net.Mail
{
    public class MailMessage
    {
        public string Subject = "Test subject";
        public IList<MailAddress> To = new List<MailAddress>();
        public MailAddress From = new MailAddress();
        public IList<MailAddress> CC = new List<MailAddress>();
        public IList<Attachment> Attachments = new List<Attachment>();
        public System.Text.Encoding BodyEncoding;
        public bool IsBodyHtml = true;

    }

    public class Attachment
    {
        public string Name = "My Name";
    }

    public class ContentDisposition
    {
        public string FileName = "Filename.test";
        public long Size = 123;
        public DateTime CreationDate = new DateTime();
        public DateTime ModificationDate = new DateTime();
        public DateTime ReadDate = new DateTime();

        public ContentDisposition(string ignore)
        {

        }

       

    }

    public class MailAddress
    {
        public string Address = "123 NE Pike St";
        public string DisplayName = "My Name";
    }


    public class TransferEncoding
    {
    }

    public class ContentType
    {
        public string CharSet = "Something";
        public string MediaType = "Another something";

        public ContentType(string ignore)
        {
        }

    }


}
