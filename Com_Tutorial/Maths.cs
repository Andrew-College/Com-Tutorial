using Com_Tutorial.VisitorPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial
{
  // This is an example class.
  // All of its functionality is built up via its visitors
  public class Maths : IVisitable
  {
    public void Accept(IVisitor visitor)
    {
      AdditionVisitor addVisitor = visitor as AdditionVisitor;

      if (addVisitor != null)
        addVisitor.args[Strings.result] =  addVisitor.add();
    }
  }
}
