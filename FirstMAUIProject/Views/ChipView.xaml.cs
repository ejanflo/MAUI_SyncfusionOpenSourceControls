using PropertyChanged;
using System.Windows.Input;

namespace FirstMAUIProject.Views;

[AddINotifyPropertyChangedInterface]
public partial class ChipView : ContentView
{
	public ChipView()
	{
		InitializeComponent();
        ActionCommand = new Command(HandleAction);
    }

    private ICommand actionCommand;
    private string result;

    public ICommand ActionCommand
    {
        get { return actionCommand; }
        set { actionCommand = value; }
    }

    public string Result
    {
        get { return result; }
        set { result = value; }
    }

    private void HandleAction()
    {
        Result = "Result";
    }
}