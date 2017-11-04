namespace TemplateMethod.AuditExample.Abstraction
{
    public interface IMessageAuditor
    {
        void Audit(string messageType, string userName, string correlationId, string messageBody);
    }
}
