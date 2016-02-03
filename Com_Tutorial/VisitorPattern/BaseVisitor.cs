using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial.VisitorPattern
{
  public abstract class BaseVisitor : IVisitor
  {
    // Environment variables that can be passed through the Class
    public Dictionary<object, object> args;
    // Setup class for every visitor
    public abstract void VisitInitializer(Dictionary<object,object> args);
  }
}
