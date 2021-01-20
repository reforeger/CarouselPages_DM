using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CArouSEL_DM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : CarouselPage
    {
        Button btn1, btn2, btn3, btn4;
        public MainPage()
        {
            btn1 = new Button();
            btn1.Text = "Тест на темперамент";
            btn1.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn1.BackgroundColor = Color.BlueViolet;
            btn1.TextColor = Color.White;
            btn1.WidthRequest = 160;
            btn1.HeightRequest = 60;
            btn1.Margin = 5;
            btn1.VerticalOptions = LayoutOptions.CenterAndExpand;
            btn1.Clicked += btn1_Clicked;

            btn2 = new Button();
            btn2.Text = "Тест на темперамент";
            btn2.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn2.BackgroundColor = Color.BlueViolet;
            btn2.TextColor = Color.White;
            btn2.WidthRequest = 160;
            btn2.HeightRequest = 60;
            btn2.Margin = 5;
            btn2.VerticalOptions = LayoutOptions.CenterAndExpand;
            btn2.Clicked += btn2_Clicked;

            btn3 = new Button();
            btn3.Text = "Тест на темперамент";
            btn3.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn3.BackgroundColor = Color.BlueViolet;
            btn3.TextColor = Color.White;
            btn3.WidthRequest = 160;
            btn3.HeightRequest = 60;
            btn3.Margin = 5;
            btn3.VerticalOptions = LayoutOptions.CenterAndExpand;
            btn3.Clicked += btn3_Clicked;

            btn4 = new Button();
            btn4.Text = "Тест на темперамент";
            btn4.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button));
            btn4.BackgroundColor = Color.BlueViolet;
            btn4.TextColor = Color.White;
            btn4.WidthRequest = 160;
            btn4.HeightRequest = 60;
            btn4.Margin = 5;
            btn4.VerticalOptions = LayoutOptions.CenterAndExpand;
            btn4.Clicked += btn4_Clicked;


            var holerikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Image {Source = "flegmatik.PNG" },
                        new Label
                        {
                           Text = "Флегматик — один из четырёх типов темперамента в классификации Гиппократа." +
                           " Человека флегматического темперамента можно охарактеризовать как медлительного, спокойного," +
                           " с устойчивыми стремлениями и более или менее постоянным настроением," +
                           " со слабым внешним выражением душевных состояний",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            TextColor = Color.Black,
                            },
                        btn1

                    }
                }
            };
            var SangvinikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Image {Source = "holerik.PNG"},
                        new Label
                        {
                           Text = "Холерик — это субъект, обладающий одним из четырёх основных типов темперамента, характеризующийся высоким уровнем психической активности," +
                           " энергичностью действий, резкостью, стремительностью, силой движений, их быстрым темпом, порывистостью." +
                           " Холерик вспыльчив, нетерпелив, подвержен эмоциональным срывам, всегда бывает агрессивным.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            TextColor = Color.Black,
                            },
                        btn2
                    }
                }
            };
            var MelanholikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Image {Source = "melanholik.PNG"},
                        new Label
                        {
                           Text = "Меланхолик" +
                           " — один из четырёх типов темперамента в классификации Гиппократа, характеризующийся инертностью нервной системы," +
                           " слабостью процессов возбуждения и торможения при их неуравновешенности (характерно преобладание процессов торможения)," +
                           " повышенной чувствительностью и высокой реактивностью психики.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            TextColor = Color.Black,
                            },
                        btn3
                    }
                }
            };
            var FlegmatikPage = new ContentPage
            {
                Content = new StackLayout
                {
                    BackgroundColor = Color.White,
                    Children =
                    {
                        new Image {Source = "sangvinik.PNG"},
                        new Label
                        {
                           Text = "Сангвиник — это личность, характеризующаяся высокой психической активностью, энергичностью, работоспособностью," +
                           " быстротой и живостью движений, разнообразием и богатством мимики, быстрым темпом речи." +
                           " Сангвиник стремится к частой смене впечатлений, легко и быстро отзывается на окружающие события, общителен.",
                            FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                            TextColor = Color.Black,
                            },
                        btn4
                    }
                }
            };
            Children.Add(holerikPage);
            Children.Add(SangvinikPage);
            Children.Add(MelanholikPage);
            Children.Add(FlegmatikPage);
        }
        private void btn1_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            Browser.OpenAsync(halflife);
        }
        private void btn2_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            Browser.OpenAsync(halflife);
        }
        private void btn3_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            Browser.OpenAsync(halflife);
        }
        private void btn4_Clicked(object sender, EventArgs e)
        {
            Uri halflife = new Uri("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
            Browser.OpenAsync(halflife);
        }
    }
}