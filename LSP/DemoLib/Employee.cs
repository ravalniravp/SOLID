using System.Linq.Expressions;

namespace DemoLib;
public class Employee : BaseEmployee, IEmployee, IManaged
{
    public IEmployee Manager { get; set; }

    public virtual void AssignManager(IEmployee manager)
    {
        Manager = Manager;
    }
}
