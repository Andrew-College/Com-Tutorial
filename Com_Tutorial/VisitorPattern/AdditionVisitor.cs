using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial.VisitorPattern
{
  // A simple addition visitor.
  // Adds two variables and expels another
  public class AdditionVisitor : BaseVisitor
  {
    object LHO, RHO;
    public override void VisitInitializer(Dictionary<object,object> Environment)
    {
      args = Environment;
      LHO = args[Strings.var1];
      RHO = args[Strings.var2];
    }

    public int add()
    {
      return (int)LHO + (int)RHO;
    }
  }
}
