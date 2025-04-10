using System.Diagnostics;
using System.Globalization;
using Syncfusion.Maui.Toolkit.SegmentedControl;

namespace FirstMAUIProject.Views;
public partial class SegmentedControlView : ContentView
{
    CultureInfo phculture = new CultureInfo("en-PH");
    public SegmentedControlView()
	{
		InitializeComponent(); 
        priceLabel.Text = $"{(2560).ToString("C", phculture)}";
    }

    private void segmentedControl_SelectionChanged(object sender, Syncfusion.Maui.Toolkit.SegmentedControl.SelectionChangedEventArgs e)
    {
        var item = e.NewValue as SfSegmentItem;

		if (item.Text == "43")
            priceLabel.Text = $"{(2560).ToString("C", phculture)}";
        else if (item.Text == "44")
            priceLabel.Text = $"{(2760).ToString("C", phculture)}";
        else if (item.Text == "45")
            priceLabel.Text = $"{(2960).ToString("C", phculture)}";
    }
}