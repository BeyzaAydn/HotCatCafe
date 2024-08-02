using HotCatCafe.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotCatCafe.BLL.ViewModels
{
    public  class CategoryListViewModel
    {
        public int Id { get; set; }
        
        [Display(Name = "Kategori Ad")]
        public string CategoryName { get; set; }
      
        [Display(Name = "Açıklama")]

        public string Description { get; set; }

        [Display(Name = "Aktif")]

        public Active Active{ get; set; }

        [Display(Name = "Durum")]

        public DataStatus Status { get; set; }
    }
}
