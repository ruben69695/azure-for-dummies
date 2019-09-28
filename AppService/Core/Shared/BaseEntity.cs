namespace AppService.Core.Shared
{
    // This can be modified to BaseEntity<TypeId> to support multiple key types (e.g. Guid)
    public abstract class BaseEntity
    {
         public int Id { get; set; }
    }
}