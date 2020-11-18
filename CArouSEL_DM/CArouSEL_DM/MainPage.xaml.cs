using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CArouSEL_DM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var holerikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                           Text = "Flegmatik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            },
                        new Image {Source = "flegmatik.jpg" },
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var SangvinikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                           Text = "Flegmatik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            },
                        new Image {Source = "flegmatik.jpg"},

                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var MelanholikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                           Text = "Flegmatik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            },
                        new Image {Source = "flegmatik.jpg"},
                        
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            var FlegmatikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.Wheat,
                    Children =
                    {
                        new Label
                        {
                           Text = "Flegmatik",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            },
                        new Image {Source = "flegmatik.jpg"},
                        new Button
                        {
                            Text = "Тест",
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Button)),
                            BackgroundColor = Color.Gray,
                            TextColor = Color.Orange,
                            WidthRequest = 160,
                            HeightRequest = 60,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.EndAndExpand
                        }
                    }
                }
            };
            Children.Add(holerikPage);
            Children.Add(SangvinikPage);
            Children.Add(MelanholikPage);
            Children.Add(FlegmatikPage);
        }
    }
}