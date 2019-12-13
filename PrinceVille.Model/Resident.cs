using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamper.Model
{
   public class Resident
    {
        public int ResidentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FlatNo { get; set; }
        public string MobileNo { get; set; }
        public string Occupation { get; set; }
        public string WorkingPlace { get; set; }
        public string OfficePhone { get; set; }
        public string Email { get; set; }
        public string Blog { get; set; }
        public string Twitter { get; set; }
        [StringLength(1, MinimumLength = 1)]
        public string Gender { get; set; }
        public string ImageSource { get; set; }
        public string Bio { get; set; }
    }
}
