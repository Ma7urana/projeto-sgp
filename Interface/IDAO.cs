using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_sgp_WPFversion.Interface
{
    ///<summary>
    ///     Interface (contrato)  para classes DAO
    /// </summary>
    /// <Typeparam name="T"></Typeparam>
    interface IDAO<T>
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> List();

        T GetById(int id);
    }
}
