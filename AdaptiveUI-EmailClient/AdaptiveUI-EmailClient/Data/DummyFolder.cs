using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace AdaptiveUI_EmailClient.Data
{
	class DummyFolder : Folder
	{
		public DummyFolder()  
		{
			loadData("Trash");
			
		}

		private async void loadData(string folder)
		{
			Uri dataUri = new Uri("ms-appx:///Data/mock"+folder+".json");
			StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(dataUri);
			string jsonString = await FileIO.ReadTextAsync(file);
			Email[] temp = JsonConvert.DeserializeObject<Email[]>(jsonString);
			foreach(Email e in temp)
			{
				this.Emails.Add(e);
			}
			this.Name = folder;
		}
	}
}
