namespace MultiTargetingApp
{
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		readonly MySharedClass myClass = new();

		public override UIWindow? Window { get; set; }

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// create a new window instance based on the screen size
			Window = new UIWindow(UIScreen.MainScreen.Bounds);

			// create a UIViewController with a single UILabel
			var vc = new UIViewController();
			vc.View!.AddSubview(new UILabel(Window!.Frame)
			{
				BackgroundColor = UIColor.White,
				TextAlignment = UITextAlignment.Center,
				Text = myClass.GreetMe("Matthew"),
			});
			Window.RootViewController = vc;

			// make the window visible
			Window.MakeKeyAndVisible();

			return true;
		}
	}
}