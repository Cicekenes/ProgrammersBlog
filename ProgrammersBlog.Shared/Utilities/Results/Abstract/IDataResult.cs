using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Utilities.Results.Abstract
{
    //Out kullanılma sebebi list'te olabilir,tek bir objede olabilir.
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }
        
    }
}
