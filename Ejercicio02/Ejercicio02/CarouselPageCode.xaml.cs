﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio02
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPageCode : CarouselPage
    {
        public CarouselPageCode()
        {
            InitializeComponent();
            Thickness padding;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                case Device.Android:
                    padding = new Thickness(0, 40, 0, 0);
                    break;
                default:
                    padding = new Thickness();
                    break;
            }

            var redContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "Red",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Red,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                }
            };
            var greenContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "green",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Green,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                }
            };
            var blueContentPage = new ContentPage
            {
                Padding = padding,
                Content = new StackLayout
                {
                    Children = {
                    new Label {
                        Text = "blue",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new BoxView {
                        Color = Color.Blue,
                        WidthRequest = 200,
                        HeightRequest = 200,
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
                }
            };

            Children.Add(redContentPage);
            Children.Add(greenContentPage);
            Children.Add(blueContentPage);

        }
    }
}


