namespace MultiTargetingApp
{
	[Activity(Label = "@string/app_name", MainLauncher = true)]
	public class MainActivity : Activity
	{
		readonly MySharedClass myClass = new();

		protected override void OnCreate(Bundle? savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);

			var textView = FindViewById<TextView>(Resource.Id.textView)!;

			textView.Text = myClass.GreetMe("Matthew");
		}
	}
}