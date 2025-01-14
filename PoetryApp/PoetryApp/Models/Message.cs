﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace PoetryApp.Models
{
	public class Message : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		// This method is called by the Set accessor of each property.
		// The CallerMemberName attribute that is applied to the optional propertyName
		// parameter causes the property name of the caller to be substituted as an argument.
		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}


		public string Text { get => _text; set { _text = value; NotifyPropertyChanged("Text"); } }
		string _text;
		public bool isPlayer { get; set; }
		public string FromName { get; set; }
		public string ScoreText { get => _scoreText; set { _scoreText = value; NotifyPropertyChanged("ScoreText"); } }
		string _scoreText;
		public double Score {
			get { return _score; }
			set
			{
				ScoreText = value.ToString();

				if (value > 0)
					ScoreColor = Color.Green;
				else if (value > -2)
					ScoreColor = Color.Brown;
				else ScoreColor = Color.Red;

				_score = value;
			}
		}
		double _score;
		public Color ScoreColor { get { return _scoreColor; } set { _scoreColor = value; NotifyPropertyChanged("ScoreColor"); } }
		Color _scoreColor = Color.Black;

		public LayoutOptions HorizontalOptions { get; set; }
		public int column { get; set; }

		public Message(string from, string text, bool isplayer = false)
		{
			Text = text;
			FromName = from;
			isPlayer = isplayer;

			if (isplayer)
			{
				HorizontalOptions = LayoutOptions.End;
				column = 1;
			}
			else
			{
				HorizontalOptions = LayoutOptions.Start;
				column = 0;
			}

			//Score = 0;
			ScoreText = "???";
		}
	}
}
