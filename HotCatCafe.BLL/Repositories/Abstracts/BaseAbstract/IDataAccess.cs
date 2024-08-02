using HotCatCafe.Model.Base;

namespace HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract
{
    public interface IDataAccess<T> where T : BaseEntity
    {
        //Tüm Entitylerde uygulanması muhtemel CRUD işlemleri burada yer alacaktır.

        //Create
        Task<string> Create(T entity);

        //List
        IEnumerable<T> GetAll();

        //Update
        Task<string> Update(T entity);

        //Delete
        Task<bool> Delete(T entity);

        //GetById

        Task<T> GetById(int id);
        
        //Get active entities

        IEnumerable<T> GetActives();

        //Get passive entities

        IEnumerable<T> GetPassive();



    }
}
