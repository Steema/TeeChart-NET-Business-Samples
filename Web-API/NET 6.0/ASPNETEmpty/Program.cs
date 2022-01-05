var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
  var mimeType = "image/png";
  var chart = new Steema.TeeChart.TChart();
  var series = chart.Chart.Series.Add(new Steema.TeeChart.Styles.Bar());
  chart.Chart.Series[0].FillSampleValues();
  MemoryStream ms = new System.IO.MemoryStream();
  chart.Export.Image.PNG.Save(ms);
  ms.Flush();
  ms.Position = 0;
  return Results.File(ms, contentType: mimeType);
});

app.Run();
