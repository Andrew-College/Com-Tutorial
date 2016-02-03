using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial
{
  [ComVisible(true)]
  [Guid("930D8B20-8B14-4992-97EF-C98081D96169")]
  [InterfaceType(ComInterfaceType.InterfaceIsDual)]
  public interface MainInterFace : BaseInterface
  {
    [DispId(0)]
    void other();
  }


  [ComVisible(true)]
  [Guid("984EFBD7-E7D1-4A56-B383-3B8167CFAC8E")]
  [ProgId("COMExtension")]
  [ClassInterface(ClassInterfaceType.None)]
  public class MainClass : MainInterFace
  {
    private int test;
    public MainClass()
    {
      test = 5;
    }

    public string seeMe(string input)
    {
      Console.WriteLine(input);

      return input + " printed " + test;
    }

    public void other()
    {
      Console.WriteLine("test");
    }
  }
}
