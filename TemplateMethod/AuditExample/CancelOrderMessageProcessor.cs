using System.Security.Principal;
using TemplateMethod.AuditExample.Abstraction;

namespace TemplateMethod.AuditExample
{
    public class CancelOrderMessageProcessor : MessageProcessor

    {
        public CancelOrderMessageProcessor(IMessageAuditor auditor) : base(auditor) { }

        protected override string messageType
        {
            get
            {
                return "CancelOrder";
            }
        }

        protected override bool authorize(Message message, IPrincipal principal)
        {
            // go check whether the IPrincipal user is the same user who placed the order

            // referenced by the contents of the message

            return true;
        }

        protected override void doWork(Message message)
        {
            // find the order number and cancel the order in the backend system
        }
    }
}
