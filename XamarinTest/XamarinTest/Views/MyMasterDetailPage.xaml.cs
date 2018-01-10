using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinTest.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MyMasterDetailPage : MasterDetailPage
	{
		public MyMasterDetailPage ()
		{
			InitializeComponent ();
            Detail=new NavigationPage(new MyDetailPage());
            Master=new MyMasterPage();
		}
	}
}