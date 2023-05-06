using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.CoreLayer.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        string TokenCreate();
    }
}
