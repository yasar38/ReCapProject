using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message) // data-mesaj-işlem sonucu veriyor
        {

        }
        public SuccessDataResult(T data) : base(data, true) // data-işlem sonucu veriyor
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) // mesaj-işlem sonucu veriyor
        {

        }
        public SuccessDataResult() : base(default, true) //işlem sonucu veriyor
        {

        }
    }
}
