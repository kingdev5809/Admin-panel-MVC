namespace CrudMVCByKING.Models
{
    public class AuditTrailRecord
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Action { get; set; }
        public string? EntityType { get; set; }
        public string? OldValues { get; set; }
        public string? NewValues { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
