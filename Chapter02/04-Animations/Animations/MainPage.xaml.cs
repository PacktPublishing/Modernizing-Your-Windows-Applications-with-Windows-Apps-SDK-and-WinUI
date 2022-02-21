﻿using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Animations
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void OnTriggerLinearAnimation(object sender, RoutedEventArgs e)
        {
            EllipseAnimation.Begin();
            EllipseAnimation.Completed += EllipseAnimation_Completed;
        }

        private void EllipseAnimation_Completed(object sender, object e)
        {
            Debug.WriteLine("Animation completed");
        }

        private void OnTriggerKeyFrameAnimation(object sender, RoutedEventArgs e)
        {
            EllipseKeyFrameAnimation.Begin();
        }
    }
}