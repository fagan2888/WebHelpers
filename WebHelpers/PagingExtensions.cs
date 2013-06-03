using dks.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace dks.Web.Extensions
{
	public static class PageNavigation
	{
		public static HtmlString SimplePageSizer(this HtmlHelper helper, string href, int currentPageSize, int pageCount, string cssClass)
		{
			if (pageCount == 0 || pageCount == 1)
			{
				return new HtmlString("");
			}

			PageSizer pageSizer = new PageSizer(href, currentPageSize, cssClass);

			return new HtmlString(pageSizer.ToString());
		}


		public static HtmlString SimplePager(this HtmlHelper helper, int currentPage, int pageCount, string urlTemplate, string pagerClass)
		{
			if (pageCount == 0 || pageCount == 1)
			{
				return new HtmlString("");
			}

			PageNumbers pager = new PageNumbers(currentPage, pageCount, urlTemplate, pagerClass);

			return new HtmlString(pager.ToString());

		}
	}
}