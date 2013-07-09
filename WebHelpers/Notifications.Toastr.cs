using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace dks.Web.Extensions
{

	// Requires toastr.js to be included.


	public static class Notifications
	{

		public enum Notification
		{
			Success,
			Info,
			Warning,
			Error
		}

		[Serializable]
		private struct NotificationMessage
		{
			public Notification notification;
			public String message;
		}

		private static readonly string notificationKey = "_Notifications_toastr";


		public static HtmlString RenderToasts(this HtmlHelper helper)
		{
			var notifications = helper.ViewContext.TempData[notificationKey] as List<NotificationMessage>;
			if (notifications != null && notifications.Count > 0)
			{
				StringBuilder sb;

				sb = new StringBuilder();
				sb.AppendLine("<script type=\"text/javascript\">");

				foreach (var notification in notifications)
				{
					switch (notification.notification)
					{
						case Notification.Info:
							sb.AppendFormat("\ttoastr.info('{0}');\n", notification.message);
							break;
						case Notification.Warning:
							sb.AppendFormat("\ttoastr.warning('{0}');\n", notification.message);
							break;
						case Notification.Success:
							sb.AppendFormat("\ttoastr.success('{0}');\n", notification.message);
							break;
						case Notification.Error:
							sb.AppendFormat("\ttoastr.error('{0}');\n", notification.message);
							break;

					}
				}
				sb.AppendLine("</script>");

				return new HtmlString(sb.ToString());
			}


			return new HtmlString("");
		}

		public static void AddNotification(this Controller controller, String message)
		{
			AddNotification(controller, Notification.Success, message);
		}


		public static void AddNotification(this Controller controller, Notification notification, String message)
		{
			if (!string.IsNullOrWhiteSpace(message))
			{
				var notifications = controller.TempData[notificationKey] as List<NotificationMessage>;
				if (notifications == null)
				{
					notifications = new List<NotificationMessage>();
					controller.TempData[notificationKey] = notifications;
				}

				notifications.Add(new NotificationMessage() { notification = notification, message = message });
			}
		}

	}
}