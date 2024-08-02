using HotCatCafe.BLL.Repositories.Abstracts.BaseAbstract;
using HotCatCafe.DAL.Context;
using HotCatCafe.Model.Base;
using HotCatCafe.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace HotCatCafe.BLL.Repositories.Concretes.BaseConcrete
{
    public class DataAccess<T> : IDataAccess<T> where T : BaseEntity
    {
        private readonly HotCatCafeContext _context;
        private readonly DbSet<T> _dbSet;

        public DataAccess(HotCatCafeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        /// <summary>
        /// bu metot parametreden gelen veriyi veri tabanına kaydeder.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<string> Create(T entity)
        {
            if (entity == null)

            {
                return "entity cannot be null";

            }
            try
            {
                entity.Status=DataStatus.Inserted;
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
                return "kayıt işlemi başarılı";

            }
            catch(Exception ex) 
            {

                return "kayıt işlemi esnasında hata oluştu"+ex.Message;
            }
        }

        /// <summary>
        /// bu metot verileri veri tabaından kaldırmaz.Özelliğini pasife çeker.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<bool> Delete(T entity)
        {
            try
            {

                var activeProperty = entity.GetType().GetProperty("Active");// Entity nesnesinin "Active " property özelliğini değişken içine alıyoruz.

                var statusProperty = entity.GetType().GetProperty("Status");//Entity nesnesinin "DataStatus " property özelliğini değişken içine alıyoruz.
                if (activeProperty != null && statusProperty != null)
                {
                    activeProperty.SetValue(entity, Active.Inactive);//Active özelliğini ınactive olarak işaretlenmesi sağlanıyor.

                    statusProperty.SetValue(entity, DataStatus.Deleted);
                    _dbSet.Update(entity);
                   var result= await _context.SaveChangesAsync();
                    return result > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Delete işlemi sırasında hata: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Property özelliği aktif olan verileri liste olarak teslim eder.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public IEnumerable<T> GetActives()
        {

            return _dbSet.Where(entity => EF.Property<Active>(entity, "Active") == Active.Isactive).ToList();
        }

        /// <summary>
        /// Tüm verileri liste halinde teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// Property özelliği pasif olan verileri liste olarak teslim eder.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<T> GetPassive()
        {
            return _dbSet.Where(entity => EF.Property<Active>(entity, "Active") == Active.Inactive).ToList();
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);

            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public async Task<string> Update(T entity)
        {
            string result = "";

            try
            {
                switch (entity.Status)
                {
                    case Model.Enums.DataStatus.Deleted:
                        entity.Status = Model.Enums.DataStatus.Deleted;
                        result = "veri silindi";
                        break;

                    case Model.Enums.DataStatus.Inserted:
                        entity.Status = Model.Enums.DataStatus.Updated;
                        result = "veri eklendi";
                        break;

                    case Model.Enums.DataStatus.Updated:
                        entity.Status = Model.Enums.DataStatus.Updated;
                        result = "Veri Güncellendi";
                        break;

                        //default:
                        //   throw new ArgumentOutOfRangeException(nameof(entity.Status), "Invalid status value."); bu kodu çalışıp açıkla
                }

                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {


                result = "An error occurred while updating the entity.";
            }

            return result;

        }
    }
}
