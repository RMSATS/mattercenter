using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Legal.MatterCenter.Utility;
using System.Net.Mime;

namespace System.Net.Mail
{
    public class MailMessage
    {
        public MailMessage() {
            Headers.Add(ServiceConstants.Mail_Message_Receiver_Header, "value");
        }

        public string Subject = "Test subject";
        public MailAddress Sender = new MailAddress();
        public MailAddressCollection To = new MailAddressCollection();
        public MailAddress From = new MailAddress();
        public MailAddressCollection Bcc = new MailAddressCollection();
        public MailAddressCollection CC = new MailAddressCollection();
        public IList<Attachment> Attachments = new List<Attachment>();
        public System.Text.Encoding BodyEncoding;
        public bool IsBodyHtml = true;
        public Dictionary<string, string> Headers = new Dictionary<string, string>();
        public string Body = "Test body";
        public System.IO.Stream ContentStream;
        public IList<AlternateView> AlternateViews = new List<AlternateView>();

    }

    public class AlternateView
    {
        public AlternateView (){ }
        public AlternateView(System.IO.Stream ignore) { }


        public string ContentId = "id";
        public ContentType ContentType;
        public TransferEncoding TransferEncoding = new TransferEncoding();
    }

    public class MailAddressCollection : List<Object>
    {
        public MailAddressCollection() { }

    }

    public class Attachment
    {
        public Attachment(System.IO.Stream ignore, ContentType ignore2) { }
        public ContentDisposition ContentDisposition = new ContentDisposition("ignore");
        public string Name = "My Name";
        public string ContentId = "id";
        public TransferEncoding TransferEncoding = new TransferEncoding();
    }

    public class ContentDisposition
    {
        public string FileName = "Filename.test";
        public long Size = 123;
        public DateTime CreationDate = new DateTime();
        public DateTime ModificationDate = new DateTime();
        public DateTime ReadDate = new DateTime();
        public string DispositionType = "type";
        public string Inline = "inline";
        public ContentDisposition(string ignore)
        {
        }

       

    }

    public class MailAddress
    {
        public MailAddress(string ignore) { }
        public MailAddress() { }

        public string Address = "123 NE Pike St";
        public string DisplayName = "My Name";
    }



    public class ContentType
    {
        public string CharSet = "Something";
        public string MediaType = "Another something";
        public string Boundary = "boundary";

        public ContentType(string ignore)
        {
        }

    }


}
