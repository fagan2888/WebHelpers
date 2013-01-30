using System.Collections.Generic;
using System.Text;

namespace dks.Web.Helpers
{

	// todo: ensure that we don't generate start and end page numbers out of range
	public class PageNumbers
	{
		private int _pageLinks = 5;
		private const string _prev = @"prev";
		private const string _next = @"next";
		private const string _dots = @"&hellip;";


		int currentPage;
		int pageCount;
		string urlTemplate;
		string cssClass;

		// given [currentPage], pageCount=100, we should have links like
		// [1] 2 3 4 5 ... 100 next
		// prev 1 [2] 3 4 5 ... 100 next
		// prev 1 2 [3] 4 5 ... 100 next
		// prev 1 2 3 [4] 5 ... 100 next
		// prev 1 ... 3 4 [5] 6 7 ... 100 next
		// prev 1 ... 4 5 [6] 7 8 ... 100 next
		// prev 1 ... 5 6 [7] 7 9 ... 100 next
		// ...
		// prev 1 ... 92 93 [94] 95 96 ... 100 next
		// prev 1 ... 93 94 [95] 96 97 ... 100 next
		// prev 1 ... 94 95 [96] 97 98 ... 100 next
		// prev 1 ... 96 [97] 98 99 100 next
		// prev 1 ... 96 97 [98] 99 100 next
		// prev 1 ... 96 97 98 [99] 100 next
		// prev 1 ... 96 97 98 99 [100]

		public PageNumbers(int currentPage, int pageCount, string urlTemplate, string cssClass)
		{
			this.currentPage = currentPage;
			this.pageCount = pageCount;
			this.urlTemplate = urlTemplate;
			this.cssClass = cssClass;
		}

		public override string ToString()
		{
			int _pagePrePostLinks;

			// fix number of pages to show
			if (_pageLinks < 5)
			{
				_pageLinks = 5;
			}
			if (_pageLinks % 2 == 0)
			{
				_pageLinks += 1;
			}
			_pagePrePostLinks = (_pageLinks - 1) / 2;



			if (currentPage < 0) currentPage = 1;
			if (pageCount < 0) pageCount = 0;

			var pager = new PagerBuilder(urlTemplate);
			pager.PagerClass = cssClass;
			pager.CurrentPage = currentPage;

			int start;
			int end;

			if (currentPage < _pageLinks)
			{
				start = 1;
				end = _pageLinks;
			}
			else if (currentPage > pageCount - _pageLinks + 1)
			{
				start = pageCount - _pageLinks + 1;
				end = pageCount;
			}
			else
			{
				start = currentPage - _pagePrePostLinks;
				end = currentPage + _pagePrePostLinks;
			}

			if (currentPage > 1)
			{
				pager.AddPage(_prev, currentPage - 1, @"page-numbers prev");

				if (start > 1)
				{
					pager.AddPage("1", 1, @"page-numbers");
					if (start > 2)
					{
						pager.AddPage(_dots, -1, @"page-numbers dots");
					}
				}
			}


			for (var i = start; i <= end; i++)
			{
				if (i == currentPage)
					pager.AddPage(i.ToString(), i, @"page-numbers current");
				else
					pager.AddPage(i.ToString(), i, @"page-numbers");
			}

			if (currentPage < pageCount)
			{
				if (end < pageCount)
				{
					if (end < pageCount - 1)
					{
						pager.AddPage(_dots, -1, @"page-numbers dots");
					}
					pager.AddPage(pageCount.ToString(), pageCount, @"page-numbers");
				}
				pager.AddPage(_next, currentPage + 1, @"page-numbers next");
			}

			return pager.ToString();

		}

		private class PagerBuilder
		{
			private class PagerLink
			{
				public string Title { get; set; }
				public int PageNo { get; set; }
				public string Class { get; set; }
			}

			private readonly string _urlTemplate;
			private readonly List<PagerLink> _pagerLinks = new List<PagerLink>();


			public PagerBuilder(string urlTemplate)
			{
				_urlTemplate = urlTemplate;
			}

			public string PagerClass { get; set; }



			public void AddPage(string title, int pageNo)
			{
				AddPage(title, pageNo, string.Empty);
			}

			public void AddPage(string title, int pageNo, string itemClass)
			{

				var link = new PagerLink
				{
					PageNo = pageNo,
					Title = title,
					Class = itemClass
				};

				_pagerLinks.Add(link);
			}



			public override string ToString()
			{
				var builder = new StringBuilder();

				builder.Append("<div");

				if (!string.IsNullOrEmpty(PagerClass))
				{
					builder.Append(" class=\"");
					builder.Append(PagerClass);
					builder.Append("\"");
				}

				builder.Append(">");

				foreach (var link in _pagerLinks)
				{

					if (link.PageNo > 0 && link.PageNo != CurrentPage)
					{
						builder.Append("<a href=\"");
						builder.AppendFormat(_urlTemplate, link.PageNo);
						builder.Append("\">");

						builder.Append("<span");
						if (!string.IsNullOrEmpty(link.Class))
						{
							builder.Append(" class=\"");
							builder.Append(link.Class);
							builder.Append("\"");
						}
						builder.Append(">");

						builder.Append(link.Title);
						builder.Append("</span>");

						builder.Append("</a>");
					}
					else
					{
						builder.Append("<span");
						if (!string.IsNullOrEmpty(link.Class))
						{
							builder.Append(" class=\"");
							builder.Append(link.Class);
							builder.Append("\"");
						}
						builder.Append(">");

						builder.Append(link.Title);
						builder.Append("</span>");
					}
				}

				builder.Append("</div>");

				return builder.ToString();

			}


			public int CurrentPage { get; set; }
		}

	}

}