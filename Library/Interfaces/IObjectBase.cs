using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IObjectBase
    {
        #region Methods

        bool Save();
        bool Validate();
        
        #endregion
    }
}
