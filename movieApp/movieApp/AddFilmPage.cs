using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace movieApp
{
    public class AddFilmPage : ContentPage
    {
        Label addf, Newname;
        Entry Name;
        public AddFilmPage()
        {
            //string s;
            StackLayout add = new StackLayout();
            
            addf = new Label { Text = "Введите название фильма:", TextColor = Color.Black };
            Name = new Entry { };
            Name.TextChanged += NameChan;
            Newname = new Label { TextColor = Color.Red };
            
                       
            add.Children.Add(addf);
            add.Children.Add(Name);
            add.Children.Add(Newname);
            Content = add;
        }
        private void NameChan(object sender, TextChangedEventArgs e)
        {
            Newname.Text = Name.Text;
        }
    }
 
}