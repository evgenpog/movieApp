using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace movieApp
{
    public class HelpPage : ContentPage
    {
        public HelpPage()
        {
            Label Info = new Label() { Text = "Программа предназначенна для\n1)Добавления названий просмотренных фильмов\n2)Добавления ваших заметок о них" };
            Info.VerticalTextAlignment = TextAlignment.Center;
            Info.HorizontalTextAlignment = TextAlignment.Center;
            Info.TextColor = Color.Black;
            Info.FontSize = 25;
            Content = Info;
        }
    }
}