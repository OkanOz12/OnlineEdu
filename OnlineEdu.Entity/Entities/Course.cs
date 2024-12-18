using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Entity.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public CourseCategory Category { get; set; } //Category sınıfına erişebilmemiz için yol vermiş oldum.

        public decimal Price { get; set; }
        public bool IsShown { get; set; } //Anasayfa da gösterilme değeri. True ya da false olarak set ettiğim değeri gösterir admin tarafında.
    }
}
