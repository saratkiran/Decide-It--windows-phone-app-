using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Decisions
{
    public partial class App
    {
        private bool phoneApplicationInitialized;

        public App()
        {
            UnhandledException += OnUnhandledException;

            InitializeComponent();

            InitializePhoneApplication();
        }

        public PhoneApplicationFrame RootFrame
        {
            get;
            private set;
        }

        private static void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            if(Debugger.IsAttached)
                Debugger.Break();
        }

        private static void OnUnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if(Debugger.IsAttached)
                Debugger.Break();
        }

        private void InitializePhoneApplication()
        {
            if(phoneApplicationInitialized)
                return;
            RootFrame = new PhoneApplicationFrame();

            RootFrame.Navigated += CompleteInitializePhoneApplication;
            RootFrame.NavigationFailed += OnNavigationFailed;

            phoneApplicationInitialized = true;
        }

        private void CompleteInitializePhoneApplication(object sender, NavigationEventArgs e)
        {
            RootVisual = RootFrame;

            RootFrame.Navigated -= CompleteInitializePhoneApplication;
        }
    }
}