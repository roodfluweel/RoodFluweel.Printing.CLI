using DevExpress.XtraPrinting;
using RoodFluweel.Printing.Model;
using Serilog;
using Serilog.Context;

namespace RoodFluweel.Printing.BL.Pdf;

public class Printer
{
	public string? PrinterName { get; set; }

	public string? TemplatePath { get; set; }

	public void GetPdf(TicketBundle data, string filePath)
	{
		Log.Information("Printer.GetPdf({ticketBundleId}, {filePath})", data.BundleId, filePath);
		TicketReport ticketReport = CreateReport(data);
		Console.WriteLine("TicketReport created");

		Console.WriteLine("Exporting to PDF...");
		ticketReport.ExportToPdf(filePath);
		Console.WriteLine("Exported to PDF: " + filePath);
		Console.WriteLine("");
	}

	public MemoryStream GetPdf(TicketBundle data)
	{
		using (LogContext.PushProperty("ticketBundleId", data.BundleId))
		{
			Log.Information("Printer.GetPdf(data) : MemoryStream");
		}
		TicketReport ticketReport = CreateReport(data);
		MemoryStream memoryStream = new MemoryStream();
		ticketReport.ExportToPdf(memoryStream);
		return memoryStream;
	}

	public TicketReport CreateReport(TicketBundle data)
	{
		using (LogContext.PushProperty("ticketBundleId", data.BundleId))
		{
			Log.Information("Printer.CreateReport(data) : TicketReport");
			TicketReport ticketReport = new TicketReport();
			if (!string.IsNullOrEmpty(TemplatePath))
			{
				try
				{
					ticketReport.LoadLayout(TemplatePath);
				}
				catch (FileNotFoundException exception)
				{
					Log.Warning(exception, "file not found, continue with default report");
				}
			}
			List<TicketBundle> list = new List<TicketBundle>();
			list.Add(data);
			ticketReport.DataSource = list;
			PdfExportOptions pdf = ticketReport.ExportOptions.Pdf;
			pdf.Compressed = true;
			pdf.ImageQuality = PdfJpegImageQuality.Low;
			pdf.NeverEmbeddedFonts = "Tahoma;Courier New";
			pdf.DocumentOptions.Application = "Roodfluweel";
			pdf.DocumentOptions.Author = "http://www.roodfluweel.be";
			pdf.DocumentOptions.Subject = "Tickets";
			pdf.DocumentOptions.Title = "Tickets";
			return ticketReport;
		}
	}
}