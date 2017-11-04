using System.Security.Principal;
using System.Threading;

namespace TemplateMethod.AuditExample.Abstraction
{
    public abstract class MessageProcessor
    {
        private readonly IMessageAuditor _auditor;

        public MessageProcessor(IMessageAuditor auditor)
        {
            _auditor = auditor;
        }

        // Template Methods that must be overriden by subclasses

        protected abstract string messageType { get; }

        public void ProcessMessage(Message message)
        {
            var principal = Thread.CurrentPrincipal;

            if (authorize(message, principal))
            {
                doWork(message);
                audit(message, principal);
            }
        }

        protected abstract bool authorize(Message message,  IPrincipal principal);

        protected abstract void doWork(Message message);

        private void audit(Message message, IPrincipal principal)
        {
            _auditor.Audit(messageType, principal.Identity.Name, message.CorrelationId, message.Body.ToString());
        }
    }

    public class Message
    {
        public string CorrelationId { get; set; }
        public object Body { get; set; }
    }
}