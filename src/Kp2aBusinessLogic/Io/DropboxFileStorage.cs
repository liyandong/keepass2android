using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using KeePassLib.Serialization;
using Keepass2android.Javafilestorage;

namespace keepass2android.Io
{
	public class DropboxFileStorage: JavaFileStorage
	{
		public DropboxFileStorage(Context ctx, IKp2aApp app) :
			base(new Keepass2android.Javafilestorage.DropboxFileStorage(ctx), app)
		{
		}

		public override IEnumerable<string> SupportedProtocols { get { yield return "dropbox"; } }
	}
}