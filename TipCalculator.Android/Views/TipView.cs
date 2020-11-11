using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using TipCalculator.Android;
using TipCalculator.Core.ViewModels;

[Activity(Label = "@string/app_name")]
public class TipView : MvxActivity<TipViewModel>
{
	protected override void OnCreate(Bundle savedInstanceState)
	{
		base.OnCreate(savedInstanceState);
		this.SetContentView(Resource.Layout.TipPage);
	}
}
