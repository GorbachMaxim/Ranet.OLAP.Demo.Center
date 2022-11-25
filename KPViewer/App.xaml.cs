﻿#if !SILVERLIGHT
using System;
#endif

namespace KPIViewer.Demo
{
	public partial class App
	{
		protected override void OnApplicationStartup()
		{
			base.OnApplicationStartup();

#if SILVERLIGHT
      RootVisual = new KPIViewerModule();
#else
			StartupUri = new Uri("ApplicationWindow.xaml", UriKind.RelativeOrAbsolute);
#endif
		}
	}
}