using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Shift_ManagementSystem.Services
{
    public class Returns
    {
        public int ID { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }
    }
}
