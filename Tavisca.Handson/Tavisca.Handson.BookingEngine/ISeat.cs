using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tavisca.Handson.BookingEngine
{
    public interface ISeat
    {
         void Book();

         string Range { get; }
    }
}
