namespace Settings.Domain.Contracts;
public interface IUnitOfWork
{
    Task SaveChangesAsync();
}