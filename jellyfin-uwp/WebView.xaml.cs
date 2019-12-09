﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace jellyfin_uwp
{
    /// <summary>
    /// Webview page
    /// </summary>
    public sealed partial class WebView : Page
    {
        public WebView()
        {
            this.InitializeComponent();

            JellyfinWebView.Navigate(new Uri(MainPage.globalSettingsStore.AppURL));
        }

        private void ChangeURL_Click(object sender, RoutedEventArgs e)
        {
            MainPage.jfFrame.Navigate(typeof(AppSettings));
        }
    }
}
