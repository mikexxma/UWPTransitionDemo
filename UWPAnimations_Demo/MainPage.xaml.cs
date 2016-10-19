using System;
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
using Windows.UI.Xaml.Shapes;
using System.Reflection;
using System.Diagnostics;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPAnimations_Demo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public static class Hello
    {
        public static string name = "111";

        public static void hello12(Type type, string m)
        {
            MemberInfo[] lists = type.GetMembers();
            Debug.WriteLine(lists, m);
        }
        public static void hello12()
        {
            Debug.WriteLine("123");
        }
    }
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            Hello.hello12(typeof(Hello),"123");
            this.InitializeComponent();
           
        }

        private void transitionBt_Click(object sender, RoutedEventArgs e)
        {
            if (rectangleItems.Items.Count > 0)
            {
                rectangleItems.Items.RemoveAt(0);
            }

            if (rectangleItems.Items.Count == 0)
            {
                for (int i = 0; i < 9; i++)
                {
                    Rectangle rect = new Rectangle();
                    var greenBrush = new SolidColorBrush(Windows.UI.Colors.Green);
                    rect.Fill = greenBrush;
                    rect.Margin = new Thickness(3, 3, 3, 3);
                    rectangleItems.Items.Add(rect);
                }                
            }

       
        }

    }
}
