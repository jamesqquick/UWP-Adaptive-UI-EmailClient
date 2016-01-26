using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveUI_EmailClient.Data
{
	class Email : BindableBase
	{
		private string subject;
		public string Subject
		{
			get
			{
				return subject;
			}
			set {
				subject = value;
				OnPropertyChanged("Subject");
			}
		}

		private string senderEmail;
		public string SenderEmail
		{
			get {
				return senderEmail;
			}
			set {
				senderEmail = value;
				OnPropertyChanged("SenderEmail");
			}
		}
		
		private string sender;

		public string Sender
		{
			get
			{
				return sender;
			}
			set
			{
				sender = value;
				OnPropertyChanged("Sender");
			}
		}
		private string body;

		public string Body
		{
			get
			{
				return body;
			}
			set
			{
				body = value;
				OnPropertyChanged("Body");
			}
		}
		private string shortBody;
		public string ShortBody
		{
			get { return shortBody; }
			set
			{
				shortBody = value;
				OnPropertyChanged("ShortBody");
			}
		}

		private string date;

		public string Date
		{
			get { return date; }
			set
			{
				date = value;
				OnPropertyChanged("Date");
			}
		}
		private string time;
		public string Time
		{
			get
			{
				return time;
			}
			set
			{
				time = value;
				OnPropertyChanged("Time");
			}
		}
	}
}
