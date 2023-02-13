using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Models.Responce
{
    public class BaseResponceModel<T>
    {
        public string Message { get; set; }
        public T Obj { get; set; }
        public bool IsSuccess { get; set; }
    }
}
