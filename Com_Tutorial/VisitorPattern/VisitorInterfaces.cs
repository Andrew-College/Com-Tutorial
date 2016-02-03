using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com_Tutorial.VisitorPattern
{
  // Visitors are classes that add new functionality to an existing classes
  // without requiring modification of the original class
  public interface IVisitor
  {

  }

  // Visitable classes are classes that can be expanded with visitors
  public interface IVisitable
  {
    void Accept(IVisitor visitor);
  }
}
