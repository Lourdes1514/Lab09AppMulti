using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab09AppMulti
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwipeDemo : ContentPage
	{
		public SwipeDemo()
		{
			InitializeComponent();
		}
		void OnSwiped(object sender, SwipedEventArgs e)
		{
			_label.Text = $"You swiped: {e.Direction.ToString()}";
		}
	}
}
