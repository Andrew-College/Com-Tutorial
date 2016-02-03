using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial
{ 
  // In spite of being part of the exposed interface, it is not visible to the COM
  [ComVisible(true)]
  [Guid("3B4122E6-F51B-4B69-B074-57EB48395D94")]
  [InterfaceType(ComInterfaceType.InterfaceIsDual)]
  public interface BaseInterface
  {
    [DispId(0)]
    string seeMe(string input);
  }
}
