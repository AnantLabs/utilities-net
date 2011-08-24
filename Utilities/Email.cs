using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

/// <summary>
/// Fluent e-mail creating and sending library.
/// </summary>
public class Email
{
    private SmtpClient _client;
    private bool _useSsl;
    private readonly MailMessage _message;

    private Email()
    {
        _message = new MailMessage();
        _client = new SmtpClient("localhost");
    }

    /// <summary>
    /// Creates new Email instance and sets From property.
    /// </summary>
    public static Email From(string emailAddress, string name = null)
    {
        var email = new Email
        {
            _message = { From = new MailAddress(emailAddress, name) }
        };
        return email;
    }

    /// <summary>
    /// Adds recipient(s). Multiple addresses must be separated with ',' (comma).
    /// </summary>
    public Email To(string emailAddresses)
    {
        _message.To.Add(emailAddresses);
        return this;
    }

    /// <summary>
    /// Adds reciepients.
    /// </summary>
    public Email To(IEnumerable<string> emailAddresses)
    {
        _message.To.AddRange(emailAddresses.Select(s => new MailAddress(s)));
        return this;
    }

    /// <summary>
    /// Adds a carbon copy.
    /// </summary>
    public Email CC(string emailAddress, string name = null)
    {
        _message.CC.Add(new MailAddress(emailAddress, name));
        return this;
    }

    /// <summary>
    /// Adds a blind carbon copy.
    /// </summary>
    public Email BCC(string emailAddress, string name = null)
    {
        _message.Bcc.Add(new MailAddress(emailAddress, name));
        return this;
    }

    /// <summary>
    /// Adds a reply-to address.
    /// </summary>
    public Email ReplyTo(string emailAddress, string name = null)
    {
        _message.ReplyToList.Add(new MailAddress(emailAddress, name));

        return this;
    }

    /// <summary>
    /// Sets the subject.
    /// </summary>
    public Email Subject(string subject)
    {
        _message.Subject = subject;
        return this;
    }

    /// <summary>
    /// Sets the body.
    /// </summary>
    public Email Body(string body, bool isHtml = false)
    {
        _message.Body = body;
        _message.IsBodyHtml = isHtml;
        return this;
    }

    /// <summary>
    /// Sets priority to high.
    /// </summary>
    public Email HighPriority()
    {
        _message.Priority = MailPriority.High;
        return this;
    }

    /// <summary>
    /// Sets priority to low.
    /// </summary>
    public Email LowPriority()
    {
        _message.Priority = MailPriority.Low;
        return this;
    }

    /// <summary>
    /// Adds an attachment.
    /// </summary>
    public Email Attach(Attachment attachment)
    {
        if (!_message.Attachments.Contains(attachment))
            _message.Attachments.Add(attachment);

        return this;
    }

    /// <summary>
    /// Adds attachments.
    /// </summary>
    public Email Attach(IEnumerable<Attachment> attachments)
    {
        _message.Attachments.AddRange(
            attachments.WhereNot(attachment => _message.Attachments.Contains(attachment)));
        return this;
    }

    /// <summary>
    /// Overrides the default client.
    /// </summary>
    public Email UsingClient(SmtpClient client)
    {
        _client = client;
        return this;
    }

    /// <summary>
    /// Overrides the default host (localhost:25).
    /// </summary>
    public Email UsingHost(string host, int port = 25)
    {
        _client = new SmtpClient(host, port);
        return this;
    }

    /// <summary>
    /// Sets that SSL connection will be used.
    /// </summary>
    public Email UseSSL()
    {
        _client.EnableSsl = true;
        return this;
    }

    /// <summary>
    /// Sends email.
    /// </summary>
    public Email Send()
    {
        _client.Send(_message);
        return this;
    }

    /// <summary>
    /// Sends email asynchronously.
    /// </summary>
    /// <param name="callback">Method to call on complete</param>
    /// <param name="token">User token to pass to callback</param>
    public Email SendAsync(SendCompletedEventHandler callback = null, object token = null)
    {
        _client.EnableSsl = _useSsl;
        if (callback != null) _client.SendCompleted += callback;
        _client.SendAsync(_message, token);

        return this;
    }

    /// <summary>
    /// Cancels asynchronous sending.
    /// </summary>
    public Email Cancel()
    {
        _client.SendAsyncCancel();
        return this;
    }
}