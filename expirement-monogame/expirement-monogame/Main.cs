using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoMac.AppKit;
using MonoMac.Foundation;
using experiment.monogame;

namespace expirement.monogame {
	static class Program {
		static void Main (string[] args)
		{
			NSApplication.Init ();

			using (var p = new NSAutoreleasePool ()) {
				NSApplication.SharedApplication.Delegate = new AppDelegate ();
				NSApplication.Main (args);
			}
		}
	}

	class AppDelegate : NSApplicationDelegate {
	}
}
namespace experiment.monogame {

	public class Game1 : Game {
		GraphicsDeviceManager graphics;

		public Game1() {
			graphics = new GraphicsDeviceManager (this);
			Content.RootDirectory = "Content";
			graphics.IsFullScreen = false;
		}

		protected override void Initialize ()
		{
			base.Initialize ();
		}

		protected override void Update(GameTime gameTime) {
			base.Update (gameTime);
		}

		protected override void Draw(GameTime gameTime) {
			graphics.GraphicsDevice.Clear (Color.DarkRed);

			base.Draw (gameTime);
		}
	}
}

