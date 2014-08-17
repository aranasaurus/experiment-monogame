using System;
using System.Drawing;
using MonoMac.Foundation;
using MonoMac.AppKit;
using MonoMac.ObjCRuntime;
using experiment.monogame;

namespace expirementmonogame
{
	public partial class AppDelegate : NSApplicationDelegate
	{
		Game1 game;
		public AppDelegate ()
		{
		}

		public override void FinishedLaunching(MonoMac.Foundation.NSObject notification) {
			game = new Game1 ();
			game.Run ();
		}

		public override bool ApplicationShouldTerminateAfterLastWindowClosed(NSApplication sender) {
			return true;
		}
	}
}

