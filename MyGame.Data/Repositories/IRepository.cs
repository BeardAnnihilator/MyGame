namespace MyGame.Data.Repositories
{
    internal interface IRepository<T> where T : class
    {
        T Get();

        void Update(T entity);
    }
}