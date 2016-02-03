using Com_Tutorial.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial
{
  // Opens the Interface to the COM server
  [ComVisible(true)]
  // Where in the Registry the COM will be stored
  [Guid("930D8B20-8B14-4992-97EF-C98081D96169")]
  [InterfaceType(ComInterfaceType.InterfaceIsDual)]
  public interface MainInterFace : BaseInterface
  {
    //This will be found
    [DispId(1)]
    string other(string input);

    [DispId(2)]
    int addEnvironment();
  }


  [ComVisible(true)]
  // Where in the Registry the COM will be stored
  [Guid("984EFBD7-E7D1-4A56-B383-3B8167CFAC8E")]
  // How Excel will reference the COM
  [ProgId("Com_Tutorial")]
  [ClassInterface(ClassInterfaceType.None)]
  public class MainClass : MainInterFace
  {
    public int test;
    private static Dictionary<object, IVisitable> visitThese = new Dictionary<object,IVisitable>();
    private static Dictionary<object, object> Environment = new Dictionary<object, object>();

    public MainClass()
    {
      test = 5;
      Initialize();
    }

    public string seeMe(string input)
    {
      Console.WriteLine(input);
      return input + test;
    }

    public string other(string input)
    {
      Console.WriteLine("test");

      return input + " printed " + test;
    }

    public void Initialize()
    {
      // Create a visitable Class
      Maths mathVisitable = new Maths();
      visitThese[Strings.maths] = mathVisitable;

      // Populate the Environment
      Environment[Strings.var1] = 5;
      Environment[Strings.var2] = 3;
    }

    public int addEnvironment()
    {
      // This example visitor add the Environments variables together, and produces a result variable
      AdditionVisitor aVisitor = new AdditionVisitor();

      aVisitor.VisitInitializer(Environment);

      foreach (IVisitable visitMe in visitThese.Values)
      {
        visitMe.Accept(aVisitor);
      }

      return (int)Environment[Strings.result];
    }
  }
}
