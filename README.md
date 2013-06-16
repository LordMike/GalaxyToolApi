GalaxyToolApi
=============

C#.Net Library for the OGame Tool GalaxyTool.
It's currently written for GalaxyTool **5.0.2**, and uses API version **2.6.30**.

Usage
----
    // Prepare client
	GalaxyToolClient client = new GalaxyToolClient(new Uri("http://[DOMAIN]/secret/galaxyplugin.php"), new Uri("http://[OGameUniverseDomain]"), "[TOKEN]");
	bool validConfig = client.Initialize();
	if (!validConfig)
		throw new Exception("GalaxyTool incompatible, maybe the token was wrong?");

	// Build request
	Reports reports = new Reports();
	reports.Header.Language = Language.English;

	Report report = new Report();
	report.Galaxy = 1;
	report.System = 2;
	report.Planet = 3;

	report.MsgId = 12345;
	report.Datetime = ...;

	report.Entries.Add(new AmountEntry("Small Cargo", 5));
	// .... more entries

	report.Scandepth = Scandepth.Fleet;

	reports.Entries.Add(report);

	// Get result
	SubmitResult result = client.SubmitData(reports);
	Console.WriteLine("Was successful: " + result.WasSuccessful);

It is important to set all the required values for each request, as GalaxyTool will otherwise reject it. However, more oftne than not, the returned error messages will help you to quickly pinpoint an issue (or a missing attribute).

You'll find all the possible items that can be reported under the namespace **GalaxyToolApi.Roots**.

Externals
----
I utilize the excellent [RestSharp](https://github.com/restsharp/RestSharp) library to do the requests and responses.

Issues
-----
If you find any issues, report them to me here. I'll try to fix them :)