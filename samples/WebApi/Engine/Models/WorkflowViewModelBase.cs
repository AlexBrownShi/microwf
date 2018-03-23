using System.Collections.Generic;

namespace tomware.Microwf.Engine
{
  public interface IWorkflowResult<T>
  {
    IEnumerable<string> Triggers { get; set; }

    T ViewModel { get; set; }
  }

  public class WorkflowResult<T> : IWorkflowResult<T>
  {
    public IEnumerable<string> Triggers { get; set; }

    public T ViewModel { get; set; }

    public WorkflowResult(IEnumerable<string> triggers, T viewModel)
    {
      this.Triggers = triggers;
      this.ViewModel = viewModel;
    }
  }

  public class AssignableWorkflowViewModel
  {
    public int Id { get; set; }
    public string Type { get; set; }
    public string Assignee { get; set; }
    public string Description { get; set; }
  }
}