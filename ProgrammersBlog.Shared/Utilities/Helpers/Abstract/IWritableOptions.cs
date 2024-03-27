using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace ProgrammersBlog.Shared.Utilities.Helpers.Abstract
{
    /// <summary>
    /// AppSettings.json'ı dinamik olarak değiştirebilmemiz için yazılan interface
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IWritableOptions<out T> : IOptionsSnapshot<T> where T : class, new()
    {
        void Update(Action<T> applyChanges);
    }
}
