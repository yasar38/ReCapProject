using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message) // data-mesaj-işlem sonucu veriyor
        {

        }
        public ErrorDataResult(T data) : base(data, false) // data-işlem sonucu veriyor
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) // mesaj-işlem sonucu veriyor
        {

        }
        public ErrorDataResult() : base(default, false) //işlem sonucu veriyor
        {

        }
    }
}
