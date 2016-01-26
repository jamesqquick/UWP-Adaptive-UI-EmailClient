using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveUI_EmailClient.Data
{
	class Folder
	{
		public Folder()
		{
			emails = new ObservableCollection<Email>();
		}

		private ObservableCollection<Email> emails;
		public ObservableCollection<Email> Emails
		{
			get { return emails; }
			set
			{
				emails = value;
			}
		}

		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
	}
}
