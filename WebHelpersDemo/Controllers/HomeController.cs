using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dks.Web.Extensions;


namespace WebHelpers.Controllers
{
	public class HomeController : Controller
	{
		//
		// GET: /Home/

		public ActionResult Index()
		{

			this.AddNotification("Welcome Guest");	// default is Success
			this.AddNotification(Notifications.Notification.Error, "Error Guest");
			this.AddNotification(Notifications.Notification.Info, "Info Guest");
			this.AddNotification(Notifications.Notification.Warning, "Warning Guest");
			return View();
		}


	}
}
