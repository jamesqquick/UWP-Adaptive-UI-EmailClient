using AdaptiveUI_EmailClient.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AdaptiveUI_EmailClient
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
		
		//Inbox button click handler
		private void HamburgerButton_Click(object sender, RoutedEventArgs e)
		{
			MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
		}

		private void BackButton_Click(object sender, RoutedEventArgs e)
		{
			//Back button is only visible in PhoneState then is hidden after being clicked
			ListGrid.Visibility = Visibility.Visible;
			DetailsStack.Visibility = Visibility.Collapsed;
		}


		private void Page_Loaded(object sender, RoutedEventArgs e)
		{
			//Make an initial email selection
			EmailList.SelectedIndex = 0;

			//Manually set current Visual State
			if (ApplicationView.GetForCurrentView().VisibleBounds.Width < 650)
				VisualStateManager.GoToState(this, "SmallPhone", false);
			else if (ApplicationView.GetForCurrentView().VisibleBounds.Width < 650)
				VisualStateManager.GoToState(this, "Phone", false);
			else if (ApplicationView.GetForCurrentView().VisibleBounds.Width < 1000)
				VisualStateManager.GoToState(this, "Small", false);
			else if (ApplicationView.GetForCurrentView().VisibleBounds.Width < 1150)
				VisualStateManager.GoToState(this, "Medium", false);
			else
				VisualStateManager.GoToState(this, "Large", false);
		}


		private void EmailList_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//Only hide/reveal if in smallest VisualState "PhoneState"
			//Check for PhoneState or Compare Width
			if (ApplicationView.GetForCurrentView().VisibleBounds.Width < 975)
			{
				ListGrid.Visibility = Visibility.Collapsed;
				DetailsStack.Visibility = Visibility.Visible;
			}
		}
		
		private void PrevButton_Click(object sender, RoutedEventArgs e)
		{
			if (!(EmailList.SelectedIndex == 0))
			{
				EmailList.SelectedIndex = EmailList.SelectedIndex - 1;
			}	
		}

		private void NextButton_Click(object sender, RoutedEventArgs e)
		{
			if (!(EmailList.SelectedIndex == EmailList.Items.Count-1))
			{
				EmailList.SelectedIndex = EmailList.SelectedIndex + 1;
			}
		}

		//Trash button click handler
		private void MenuButton2_Click(object sender, RoutedEventArgs e)
		{

		}
		//starred button click handler
		private void MenuButton3_Click(object sender, RoutedEventArgs e)
		{

		}

		//Inbox button click handler
		private void MenuButton1_Click(object sender, RoutedEventArgs e)
		{

		}

	}
}
