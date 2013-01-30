using System;
using System.Text;

namespace dks.Web.Helpers
{
	public class PageSizer
	{
		private static readonly int[] pageSizes = { 15, 30, 50 };

		private string pageSizerClass;
		private int currentPageSize;
		private string hRef;

		public PageSizer(string href, int currentPageSize, string cssClass)
		{
			hRef = href;
			this.currentPageSize = currentPageSize;
			pageSizerClass = cssClass;
		}

		public static int ValidatePageSize(int? pageSize)
		{
			if (pageSize.HasValue)
			{
				if (Array.IndexOf(pageSizes, pageSize.Value) != -1)
				{
					return pageSize.Value;
				}
			}

			return DefaultPageSize;
		}

		public static int DefaultPageSize
		{
			get
			{
				return pageSizes[0];
			}
		}


		public override string ToString()
		{
			StringBuilder builder;

			builder = new StringBuilder();

			//<div class="page-sizer fr">
			//	<a class="page-numbers " title="show 15 items per page" href="&amp;pagesize=15">15</a>
			//	<a class="page-numbers " title="show 30 items per page" href="&amp;pagesize=30">30</a>
			//	<a class="page-numbers current" title="show 50 items per page" href="&amp;pagesize=50">50</a>
			//	<span class="page-numbers desc">per page</span>
			//</div>

			builder.Append("<div");

			if (!string.IsNullOrWhiteSpace(pageSizerClass))
			{
				builder.Append(" class=\"");
				builder.Append(pageSizerClass);
				builder.Append("\"");
			}

			builder.Append(">");

			foreach (var pageSize in pageSizes)
			{
				if (pageSize == currentPageSize)
				{
					//	<a class="page-numbers current" title="show 50 items per page" href="&amp;pagesize=50">50</a>
					builder.AppendFormat("<span class=\"page-numbers current\" title=\"show {0} items per page\">{0}</span>", pageSize);
				}
				else
				{
					//<a class="page-numbers " title="show 15 items per page" href="&amp;pagesize=15">15</a>
					builder.AppendFormat("<a class=\"page-numbers\" title=\"show {0} items per page\" href=\"{1}\">{0}</a>", pageSize, String.Format(hRef, pageSize));
				}
			}
			builder.Append("<span class=\"page-numbers desc\">per page</span>");
			builder.Append("</div>");

			return builder.ToString();
		}

	}
}