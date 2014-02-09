namespace MyGame.Data.Repositories
{
    internal interface IRepository<T>
    {
        T Get();

        void Update(T entity);

        void Delete(T entity);

        void Create(T entity);
    }
}