﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PoetryApp.Models;

namespace PoetryApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayBotPage : ContentPage
    {
        public PlayBotPage()
        {
            InitializeComponent();
			MessagesList.ItemsUpdatingScrollMode = ItemsUpdatingScrollMode.KeepLastItemInView;
        }
	}
}