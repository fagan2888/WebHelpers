WebHelpers
==========

Paging - like stackoverflow

<style type="text/css">
	.pager
	{
		margin-top: 20px;
		margin-bottom: 20px;
	}

	.page-sizer
	{
		margin-top: 20px;
		margin-bottom: 20px;
	}

	.page-numbers
	{
		font-family: 'Helvetica Neue',Helvetica,Arial,sans-serif;
		border: 1px solid #ccc;
		color: #808185;
		display: block;
		float: left;
		font-size: 130%;
		margin-right: 3px;
		padding: 4px 4px 3px;
		text-decoration: none;
	}

		.page-numbers.desc
		{
			border: none;
		}

		.page-numbers:hover
		{
			text-decoration: none;
		}

		.page-numbers.next, .page-numbers.prev
		{
			border: 1px solid #fff;
		}

		.page-numbers.current
		{
			background-color: #808185;
			border: 1px solid #808185;
			color: #fff;
			font-weight: bold;
		}

		.page-numbers.dots
		{
			border: 1px solid #fff;
		}


	.fl
	{
		float: left;
	}

	.fr
	{
		float: right;
	}
</style>


Paging
------


    @Html.SimplePager(CurrentPage, PageCount, Url, CssClass);
    // Url: {0} gets replaced with selected page
	// CssClass: class assigned to wrapping div

    @Html.SimplePager(CurrentPage, PageCount, "/Home/?page={0}", "pager");

<div class="pager"><span class="page-numbers current">1</span><a href="/Home/?page=2"><span class="page-numbers">2</span></a><a href="/Home/?page=3"><span class="page-numbers">3</span></a><a href="/Home/?page=4"><span class="page-numbers">4</span></a><a href="/Home/?page=5"><span class="page-numbers">5</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=2"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=1"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers current">2</span><a href="/Home/?page=3"><span class="page-numbers">3</span></a><a href="/Home/?page=4"><span class="page-numbers">4</span></a><a href="/Home/?page=5"><span class="page-numbers">5</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=3"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=2"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><a href="/Home/?page=2"><span class="page-numbers">2</span></a><span class="page-numbers current">3</span><a href="/Home/?page=4"><span class="page-numbers">4</span></a><a href="/Home/?page=5"><span class="page-numbers">5</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=4"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=3"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><a href="/Home/?page=2"><span class="page-numbers">2</span></a><a href="/Home/?page=3"><span class="page-numbers">3</span></a><span class="page-numbers current">4</span><a href="/Home/?page=5"><span class="page-numbers">5</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=5"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=4"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=3"><span class="page-numbers">3</span></a><a href="/Home/?page=4"><span class="page-numbers">4</span></a><span class="page-numbers current">5</span><a href="/Home/?page=6"><span class="page-numbers">6</span></a><a href="/Home/?page=7"><span class="page-numbers">7</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=6"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=5"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=4"><span class="page-numbers">4</span></a><a href="/Home/?page=5"><span class="page-numbers">5</span></a><span class="page-numbers current">6</span><a href="/Home/?page=7"><span class="page-numbers">7</span></a><a href="/Home/?page=8"><span class="page-numbers">8</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=7"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=6"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=5"><span class="page-numbers">5</span></a><a href="/Home/?page=6"><span class="page-numbers">6</span></a><span class="page-numbers current">7</span><a href="/Home/?page=8"><span class="page-numbers">8</span></a><a href="/Home/?page=9"><span class="page-numbers">9</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=8"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=7"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=6"><span class="page-numbers">6</span></a><a href="/Home/?page=7"><span class="page-numbers">7</span></a><span class="page-numbers current">8</span><a href="/Home/?page=9"><span class="page-numbers">9</span></a><a href="/Home/?page=10"><span class="page-numbers">10</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=9"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=8"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=8"><span class="page-numbers">8</span></a><span class="page-numbers current">9</span><a href="/Home/?page=10"><span class="page-numbers">10</span></a><a href="/Home/?page=11"><span class="page-numbers">11</span></a><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=10"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=9"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=8"><span class="page-numbers">8</span></a><a href="/Home/?page=9"><span class="page-numbers">9</span></a><span class="page-numbers current">10</span><a href="/Home/?page=11"><span class="page-numbers">11</span></a><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=11"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=10"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=8"><span class="page-numbers">8</span></a><a href="/Home/?page=9"><span class="page-numbers">9</span></a><a href="/Home/?page=10"><span class="page-numbers">10</span></a><span class="page-numbers current">11</span><a href="/Home/?page=12"><span class="page-numbers">12</span></a><a href="/Home/?page=12"><span class="page-numbers next">next</span></a></div><br />
<div class="pager"><a href="/Home/?page=11"><span class="page-numbers prev">prev</span></a><a href="/Home/?page=1"><span class="page-numbers">1</span></a><span class="page-numbers dots">&hellip;</span><a href="/Home/?page=8"><span class="page-numbers">8</span></a><a href="/Home/?page=9"><span class="page-numbers">9</span></a><a href="/Home/?page=10"><span class="page-numbers">10</span></a><a href="/Home/?page=11"><span class="page-numbers">11</span></a><span class="page-numbers current">12</span></div>
<br /><br />

Page Size
----

    @Html.SimplePageSize(Url, CurrentPagesize, PageCount, Css);
    // Url: {0} gets replaced with selected pagesize
	// CssClass: class assigned to wrapping div

    @Html.SimplePageSizer("/Home/?pagesize={0}", CurrentPagesize, PageCount, "page-sizer");
    

<div class="page-sizer"><span class="page-numbers current" title="show 15 items per page">15</span><a class="page-numbers" title="show 30 items per page" href="/Home/?pagesize=30">30</a><a class="page-numbers" title="show 50 items per page" href="/Home/?pagesize=50">50</a><span class="page-numbers desc">per page</span></div><br /><br />
<div class="page-sizer"><a class="page-numbers" title="show 15 items per page" href="/Home/?pagesize=15">15</a><span class="page-numbers current" title="show 30 items per page">30</span><a class="page-numbers" title="show 50 items per page" href="/Home/?pagesize=50">50</a><span class="page-numbers desc">per page</span></div><br /><br />
<div class="page-sizer"><a class="page-numbers" title="show 15 items per page" href="/Home/?pagesize=15">15</a><a class="page-numbers" title="show 30 items per page" href="/Home/?pagesize=30">30</a><span class="page-numbers current" title="show 50 items per page">50</span><span class="page-numbers desc">per page</span></div>




