using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.Drawing;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.Shape;
using DevExpress.XtraReports.UI;
using System.Drawing;

namespace RoodFluweel.Printing.BL.Pdf;

public class TicketReport : XtraReport
{
	private IContainer? components = null;

	private XRLabel? xrLabel4;

	private XRLabel? label11;

	private DetailBand? Detail1;

	private XRShape? shape1;

	private XRLabel? label8;

	private XRLabel? label1;

	private XRLabel? xrLabel7;

	private XRLabel? xrLabel8;

	private XRLabel? xrLabel2;

	private XRLabel? xrLabel3;

	private XRLabel? xrLabel5;

	private XRLabel? xrLabel6;

	private XRLabel? label10;

	private XRLabel? label9;

	private XRLabel? label12;

	private XRLabel? label13;

	private XRLabel? label5;

	private XRLabel? label7;

	private XRLabel? label4;

	private TopMarginBand? TopMargin;

	private DetailBand? Detail;

	private XRLabel? label6;

	private DetailReportBand? DetailReport;

	private BottomMarginBand? BottomMargin;

	private XRLabel? label3;

	private XRLabel? label2;

	private ReportHeaderBand? ReportHeader;

	public TicketReport()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			((IDisposable)components).Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		ShapeRectangle shape = new ShapeRectangle();
		xrLabel4 = new XRLabel();
		label11 = new XRLabel();
		Detail1 = new DetailBand();
		shape1 = new XRShape();
		label5 = new XRLabel();
		xrLabel7 = new XRLabel();
		xrLabel8 = new XRLabel();
		xrLabel3 = new XRLabel();
		label1 = new XRLabel();
		xrLabel2 = new XRLabel();
		xrLabel6 = new XRLabel();
		label7 = new XRLabel();
		label12 = new XRLabel();
		label4 = new XRLabel();
		label8 = new XRLabel();
		label10 = new XRLabel();
		TopMargin = new TopMarginBand();
		xrLabel5 = new XRLabel();
		Detail = new DetailBand();
		label13 = new XRLabel();
		label6 = new XRLabel();
		DetailReport = new DetailReportBand();
		BottomMargin = new BottomMarginBand();
		label3 = new XRLabel();
		label2 = new XRLabel();
		label9 = new XRLabel();
		ReportHeader = new ReportHeaderBand();
		((ISupportInitialize)this).BeginInit();
		xrLabel4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.Show.LocationName")
		});
		xrLabel4.Dpi = 254f;
		xrLabel4.LocationFloat = new PointFloat(95.50774f, 575.6042f);
		xrLabel4.Name = "xrLabel4";
		xrLabel4.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel4.SizeF = new SizeF(694.2667f, 58.42f);
		xrLabel4.Text = "xrLabel4";
		label11.Dpi = 254f;
		label11.Font = new DXFont("Times New Roman", 16f);
		label11.LocationFloat = new PointFloat(795.9794f, 324.1906f);
		label11.Name = "label11";
		label11.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label11.SizeF = new SizeF(145.5209f, 82.23248f);
		label11.StylePriority.UseFont = false;
		label11.Text = "Rij";
		Detail1.Controls.AddRange(new XRControl[15]
		{
			shape1, label8, label1, xrLabel7, xrLabel8, xrLabel2, xrLabel3, xrLabel4, xrLabel5, xrLabel6,
			label10, label9, label11, label12, label13
		});
		Detail1.Dpi = 254f;
		Detail1.HeightF = 669.2466f;
		Detail1.KeepTogether = true;
		Detail1.Name = "Detail1";
		Detail1.PageBreak = PageBreak.BeforeBand;
		shape1.Dpi = 254f;
		shape1.LocationFloat = new PointFloat(14f, 14.07593f);
		shape1.Name = "shape1";
		shape1.Shape = shape;
		shape1.SizeF = new SizeF(1120.459f, 142.875f);
		label5.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.City")
		});
		label5.Dpi = 254f;
		label5.LocationFloat = new PointFloat(716.6626f, 258.6333f);
		label5.Name = "label5";
		label5.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label5.SizeF = new SizeF(634.9999f, 58.42001f);
		label5.Text = "label5";
		xrLabel7.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Name")
		});
		xrLabel7.Dpi = 254f;
		xrLabel7.LocationFloat = new PointFloat(95.50773f, 324.1907f);
		xrLabel7.Name = "xrLabel7";
		xrLabel7.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel7.SizeF = new SizeF(668.8668f, 58.42f);
		xrLabel7.Text = "xrLabel7";
		xrLabel8.Angle = 270f;
		xrLabel8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.Show.ShowName")
		});
		xrLabel8.Dpi = 254f;
		xrLabel8.LocationFloat = new PointFloat(1392.521f, 14.07585f);
		xrLabel8.Name = "xrLabel8";
		xrLabel8.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel8.SizeF = new SizeF(70.37952f, 497.9692f);
		xrLabel8.StylePriority.UseFont = false;
		xrLabel8.Text = "xrLabel6";
		xrLabel3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.SeatName")
		});
		xrLabel3.Dpi = 254f;
		xrLabel3.Font = new DXFont("Times New Roman", 16f);
		xrLabel3.LocationFloat = new PointFloat(946.6046f, 406.4232f);
		xrLabel3.Name = "xrLabel3";
		xrLabel3.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel3.SizeF = new SizeF(187.8542f, 82.23248f);
		xrLabel3.StylePriority.UseFont = false;
		xrLabel3.Text = "xrLabel3";
		label1.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Organisation.BusinessName")
		});
		label1.Dpi = 254f;
		label1.LocationFloat = new PointFloat(14f, 24.6f);
		label1.Name = "label1";
		label1.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		label1.SizeF = new SizeF(620.1833f, 58.41998f);
		label1.Text = "xrLabel1";
		xrLabel2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.RowName")
		});
		xrLabel2.Dpi = 254f;
		xrLabel2.Font = new DXFont("Times New Roman", 16f);
		xrLabel2.LocationFloat = new PointFloat(946.6046f, 324.1906f);
		xrLabel2.Name = "xrLabel2";
		xrLabel2.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel2.SizeF = new SizeF(187.8544f, 82.23254f);
		xrLabel2.StylePriority.UseFont = false;
		xrLabel2.Text = "xrLabel2";
		xrLabel6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.Show.ShowName")
		});
		xrLabel6.Dpi = 254f;
		xrLabel6.Font = new DXFont("Times New Roman", 20f);
		xrLabel6.LocationFloat = new PointFloat(86.72492f, 234.0209f);
		xrLabel6.Name = "xrLabel6";
		xrLabel6.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel6.SizeF = new SizeF(1047.734f, 90.16997f);
		xrLabel6.StylePriority.UseFont = false;
		xrLabel6.Text = "xrLabel6";
		label7.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Country")
		});
		label7.Dpi = 254f;
		label7.LocationFloat = new PointFloat(526.1627f, 317.0533f);
		label7.Name = "label7";
		label7.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label7.SizeF = new SizeF(825.4998f, 58.42001f);
		label7.Text = "label7";
		label12.Dpi = 254f;
		label12.Font = new DXFont("Times New Roman", 16f);
		label12.LocationFloat = new PointFloat(795.9794f, 406.4232f);
		label12.Name = "label12";
		label12.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label12.SizeF = new SizeF(145.5209f, 82.23248f);
		label12.StylePriority.UseFont = false;
		label12.Text = "Stoel";
		label4.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Street2")
		});
		label4.Dpi = 254f;
		label4.LocationFloat = new PointFloat(526.1627f, 200.2132f);
		label4.Name = "label4";
		label4.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label4.SizeF = new SizeF(825.4999f, 58.42001f);
		label4.Text = "label4";
		label8.Angle = 270f;
		label8.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Name")
		});
		label8.Dpi = 254f;
		label8.LocationFloat = new PointFloat(1206.125f, 14.07593f);
		label8.Name = "label8";
		label8.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label8.SizeF = new SizeF(74.08313f, 550.545f);
		label8.Text = "label2";
		label10.Angle = 270f;
		label10.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.SeatName")
		});
		label10.Dpi = 254f;
		label10.LocationFloat = new PointFloat(1304.021f, 14.07585f);
		label10.Name = "label10";
		label10.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		label10.SizeF = new SizeF(69.97913f, 196.0034f);
		label10.Text = "xrLabel3";
		TopMargin.Dpi = 254f;
		TopMargin.HeightF = 0f;
		TopMargin.Name = "TopMargin";
		TopMargin.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
		TopMargin.TextAlignment = TextAlignment.TopLeft;
		xrLabel5.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.Show.ShowDate")
		});
		xrLabel5.Dpi = 254f;
		xrLabel5.Font = new DXFont("Times New Roman", 9.75f);
		xrLabel5.LocationFloat = new PointFloat(95.50774f, 503.5552f);
		xrLabel5.Name = "xrLabel5";
		xrLabel5.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		xrLabel5.SizeF = new SizeF(694.2667f, 61.06567f);
		xrLabel5.StylePriority.UseFont = false;
		xrLabel5.StylePriority.UseTextAlignment = false;
		xrLabel5.Text = "xrLabel5";
		xrLabel5.TextAlignment = TextAlignment.TopLeft;
		Detail.Dpi = 254f;
		Detail.HeightF = 0f;
		Detail.KeepTogetherWithDetailReports = true;
		Detail.Name = "Detail";
		Detail.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
		Detail.TextAlignment = TextAlignment.TopLeft;
		label13.Dpi = 254f;
		label13.LocationFloat = new PointFloat(14f, 83.02006f);
		label13.Name = "label13";
		label13.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label13.SizeF = new SizeF(995.6786f, 58.41997f);
		label13.Text = "[Organisation.Street], [Organisation.Zip] [Organisation.City]";
		label6.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Zip")
		});
		label6.Dpi = 254f;
		label6.LocationFloat = new PointFloat(526.1627f, 258.6333f);
		label6.Name = "label6";
		label6.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label6.SizeF = new SizeF(166.6875f, 58.42001f);
		label6.Text = "label6";
		DetailReport.Bands.AddRange(new Band[1] { Detail1 });
		DetailReport.DataMember = "Tickets";
		DetailReport.Dpi = 254f;
		DetailReport.Level = 0;
		DetailReport.Name = "DetailReport";
		BottomMargin.Dpi = 254f;
		BottomMargin.HeightF = 0f;
		BottomMargin.Name = "BottomMargin";
		BottomMargin.Padding = new PaddingInfo(0, 0, 0, 0, 254f);
		BottomMargin.TextAlignment = TextAlignment.TopLeft;
		label3.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Street")
		});
		label3.Dpi = 254f;
		label3.LocationFloat = new PointFloat(526.1627f, 141.7934f);
		label3.Name = "label3";
		label3.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label3.SizeF = new SizeF(825.4999f, 58.41995f);
		label3.Text = "label3";
		label2.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Customer.Name")
		});
		label2.Dpi = 254f;
		label2.LocationFloat = new PointFloat(526.1627f, 83.37331f);
		label2.Name = "label2";
		label2.Padding = new PaddingInfo(5, 5, 0, 0, 254f);
		label2.SizeF = new SizeF(825.4999f, 58.42f);
		label2.Text = "label2";
		label9.Angle = 270f;
		label9.DataBindings.AddRange(new XRBinding[1]
		{
			new XRBinding("Text", null, "Tickets.RowName")
		});
		label9.Dpi = 254f;
		label9.LocationFloat = new PointFloat(1304.021f, 234.0209f);
		label9.Name = "label9";
		label9.Padding = new PaddingInfo(4, 4, 0, 0, 254f);
		label9.SizeF = new SizeF(69.97913f, 278.0242f);
		label9.Text = "xrLabel2";
		ReportHeader.Controls.AddRange(new XRControl[6] { label2, label3, label4, label5, label6, label7 });
		ReportHeader.Dpi = 254f;
		ReportHeader.HeightF = 494.5358f;
		ReportHeader.KeepTogether = true;
		ReportHeader.Name = "ReportHeader";
		base.Bands.AddRange(new Band[5] { Detail, TopMargin, BottomMargin, ReportHeader, DetailReport });
		Dpi = 254f;
		base.Margins = new DXMargins(0, 0, 0, 0);
		base.PageHeight = 800;
		base.PageWidth = 1500;
		base.PaperKind = 0;
		base.ReportUnit = ReportUnit.TenthsOfAMillimeter;
		base.ShowPrintMarginsWarning = false;
		base.ShowPrintStatusDialog = false;
		base.SnapGridSize = 31.75f;
		base.Version = "12.1";
		((ISupportInitialize)this).EndInit();
	}
}
