namespace ANS_SEIS_TV
{
    partial class Report1
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report1));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            this.dataSource1 = new Telerik.Reporting.SqlDataSource();
            this.pageHeaderSection = new Telerik.Reporting.PageHeaderSection();
            this.invoiceInfoPanel = new Telerik.Reporting.Panel();
            this.invoiceHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceNumberHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceNrTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceDateTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.invoiceTotalTextBox1 = new Telerik.Reporting.TextBox();
            this.pagesHeaderTextBox = new Telerik.Reporting.TextBox();
            this.pagesTextBox = new Telerik.Reporting.TextBox();
            this.detailSection1 = new Telerik.Reporting.DetailSection();
            this.itemNrTextBox = new Telerik.Reporting.TextBox();
            this.itemDescriptionTextBox = new Telerik.Reporting.TextBox();
            this.qtyTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalTextBox = new Telerik.Reporting.TextBox();
            this.pageFooterSection1 = new Telerik.Reporting.PageFooterSection();
            this.pageFooterTextBox = new Telerik.Reporting.TextBox();
            this.companyLogoPictureBox = new Telerik.Reporting.PictureBox();
            this.reportHeaderSection = new Telerik.Reporting.ReportHeaderSection();
            this.CompanyInfoPanel = new Telerik.Reporting.Panel();
            this.companyNameTextBox = new Telerik.Reporting.TextBox();
            this.groupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.itemsHeaderPanel = new Telerik.Reporting.Panel();
            this.ItemNoHeaderTextBox = new Telerik.Reporting.TextBox();
            this.descriptionHeaderTextBox = new Telerik.Reporting.TextBox();
            this.qtyHeaderTextBox = new Telerik.Reporting.TextBox();
            this.unitPriceHeaderTextBox = new Telerik.Reporting.TextBox();
            this.lineTotalHeaderTextBox = new Telerik.Reporting.TextBox();
            this.groupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.subTotalPanel = new Telerik.Reporting.Panel();
            this.subTotalLabelTextBox = new Telerik.Reporting.TextBox();
            this.subTotalTextBox = new Telerik.Reporting.TextBox();
            this.totalPanel = new Telerik.Reporting.Panel();
            this.totalLabelTextBox = new Telerik.Reporting.TextBox();
            this.totalTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dataSource1
            // 
            this.dataSource1.ConnectionString = "ANS_SEIS_TV.Properties.Settings.ANS_SEIS_TVConnectionString3";
            this.dataSource1.Name = "dataSource1";
            this.dataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@TransactionID", System.Data.DbType.Int32, null)});
            this.dataSource1.SelectCommand = "dbo.sp_CurrentBorrowed";
            this.dataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // pageHeaderSection
            // 
            this.pageHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Inch(0.39429250359535217D);
            this.pageHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceInfoPanel});
            this.pageHeaderSection.Name = "pageHeaderSection";
            this.pageHeaderSection.Style.BorderColor.Default = System.Drawing.Color.Gray;
            this.pageHeaderSection.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // invoiceInfoPanel
            // 
            this.invoiceInfoPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.invoiceHeaderTextBox,
            this.invoiceNumberHeaderTextBox,
            this.invoiceNrTextBox,
            this.invoiceDateHeaderTextBox,
            this.invoiceDateTextBox,
            this.invoiceTotalHeaderTextBox,
            this.invoiceTotalTextBox1,
            this.pagesHeaderTextBox,
            this.pagesTextBox});
            this.invoiceInfoPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.invoiceInfoPanel.Name = "invoiceInfoPanel";
            this.invoiceInfoPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(14.700400352478027D), Telerik.Reporting.Drawing.Unit.Cm(1.0015029907226563D));
            // 
            // invoiceHeaderTextBox
            // 
            this.invoiceHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.invoiceHeaderTextBox.Name = "invoiceHeaderTextBox";
            this.invoiceHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.5999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(1.0007009506225586D));
            this.invoiceHeaderTextBox.Style.Font.Bold = true;
            this.invoiceHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(24D);
            this.invoiceHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(0D);
            this.invoiceHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceHeaderTextBox.Value = "INVOICE";
            // 
            // invoiceNumberHeaderTextBox
            // 
            this.invoiceNumberHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.9000000953674316D), Telerik.Reporting.Drawing.Unit.Cm(0.00070207274984568357D));
            this.invoiceNumberHeaderTextBox.Name = "invoiceNumberHeaderTextBox";
            this.invoiceNumberHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.9999997615814209D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.invoiceNumberHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceNumberHeaderTextBox.Style.Font.Bold = true;
            this.invoiceNumberHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceNumberHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.invoiceNumberHeaderTextBox.Value = "INVOICE #";
            // 
            // invoiceNrTextBox
            // 
            this.invoiceNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.899599552154541D), Telerik.Reporting.Drawing.Unit.Cm(0.5015023946762085D));
            this.invoiceNrTextBox.Name = "invoiceNrTextBox";
            this.invoiceNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0004007816314697D), Telerik.Reporting.Drawing.Unit.Cm(0.49919861555099487D));
            this.invoiceNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceNrTextBox.Value = null;
            // 
            // invoiceDateHeaderTextBox
            // 
            this.invoiceDateHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.900200366973877D), Telerik.Reporting.Drawing.Unit.Cm(0.0012026882031932473D));
            this.invoiceDateHeaderTextBox.Name = "invoiceDateHeaderTextBox";
            this.invoiceDateHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.8005998134613037D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.invoiceDateHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceDateHeaderTextBox.Style.Font.Bold = true;
            this.invoiceDateHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceDateHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.invoiceDateHeaderTextBox.Value = "DATE";
            // 
            // invoiceDateTextBox
            // 
            this.invoiceDateTextBox.Format = "{0:d}";
            this.invoiceDateTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(6.900200366973877D), Telerik.Reporting.Drawing.Unit.Cm(0.5015023946762085D));
            this.invoiceDateTextBox.Name = "invoiceDateTextBox";
            this.invoiceDateTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7997996807098389D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.invoiceDateTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceDateTextBox.Value = null;
            // 
            // invoiceTotalHeaderTextBox
            // 
            this.invoiceTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7010002136230469D), Telerik.Reporting.Drawing.Unit.Cm(0.0012034956598654389D));
            this.invoiceTotalHeaderTextBox.Name = "invoiceTotalHeaderTextBox";
            this.invoiceTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3992006778717041D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.invoiceTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.invoiceTotalHeaderTextBox.Style.Font.Bold = true;
            this.invoiceTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.invoiceTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.invoiceTotalHeaderTextBox.Value = "TOTAL";
            // 
            // invoiceTotalTextBox1
            // 
            this.invoiceTotalTextBox1.Format = "{0:C2}";
            this.invoiceTotalTextBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7017011642456055D), Telerik.Reporting.Drawing.Unit.Cm(0.50150299072265625D));
            this.invoiceTotalTextBox1.Name = "invoiceTotalTextBox1";
            this.invoiceTotalTextBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.3984994888305664D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.invoiceTotalTextBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.invoiceTotalTextBox1.Value = null;
            // 
            // pagesHeaderTextBox
            // 
            this.pagesHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.100400924682617D), Telerik.Reporting.Drawing.Unit.Cm(0.0012034956598654389D));
            this.pagesHeaderTextBox.Name = "pagesHeaderTextBox";
            this.pagesHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.5999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.pagesHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.pagesHeaderTextBox.Style.Font.Bold = true;
            this.pagesHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.pagesHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Bottom;
            this.pagesHeaderTextBox.Value = "PAGE";
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.100400924682617D), Telerik.Reporting.Drawing.Unit.Cm(0.50150299072265625D));
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.599998950958252D), Telerik.Reporting.Drawing.Unit.Cm(0.5D));
            this.pagesTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.pagesTextBox.Value = "{[PageNumber]} of {[PageCount]}";
            // 
            // detailSection1
            // 
            this.detailSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30426740646362305D);
            this.detailSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemNrTextBox,
            this.itemDescriptionTextBox,
            this.qtyTextBox,
            this.unitPriceTextBox,
            this.lineTotalTextBox});
            this.detailSection1.Name = "detailSection1";
            this.detailSection1.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.detailSection1.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            this.detailSection1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            // 
            // itemNrTextBox
            // 
            this.itemNrTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.itemNrTextBox.Name = "itemNrTextBox";
            this.itemNrTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7999997138977051D), Telerik.Reporting.Drawing.Unit.Cm(0.77263861894607544D));
            this.itemNrTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.itemNrTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.itemNrTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemNrTextBox.Value = null;
            // 
            // itemDescriptionTextBox
            // 
            this.itemDescriptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8001999855041504D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.itemDescriptionTextBox.Name = "itemDescriptionTextBox";
            this.itemDescriptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.460200309753418D), Telerik.Reporting.Drawing.Unit.Cm(0.77263861894607544D));
            this.itemDescriptionTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.itemDescriptionTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.itemDescriptionTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.itemDescriptionTextBox.Value = null;
            // 
            // qtyTextBox
            // 
            this.qtyTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.2606000900268555D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.qtyTextBox.Name = "qtyTextBox";
            this.qtyTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4394005537033081D), Telerik.Reporting.Drawing.Unit.Cm(0.77263861894607544D));
            this.qtyTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.qtyTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.qtyTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.qtyTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.qtyTextBox.Value = "=Fields.[Quantity]";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Format = "{0:C2}";
            this.unitPriceTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7002019882202148D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.77263861894607544D));
            this.unitPriceTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.unitPriceTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.unitPriceTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.unitPriceTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.unitPriceTextBox.Value = null;
            // 
            // lineTotalTextBox
            // 
            this.lineTotalTextBox.Format = "{0:C2}";
            this.lineTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.820601463317871D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.lineTotalTextBox.Name = "lineTotalTextBox";
            this.lineTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.77263861894607544D));
            this.lineTotalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            this.lineTotalTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.lineTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.lineTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalTextBox.Value = null;
            // 
            // pageFooterSection1
            // 
            this.pageFooterSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(1.1022830009460449D);
            this.pageFooterSection1.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageFooterTextBox,
            this.companyLogoPictureBox});
            this.pageFooterSection1.Name = "pageFooterSection1";
            // 
            // pageFooterTextBox
            // 
            this.pageFooterTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.700400352478027D), Telerik.Reporting.Drawing.Unit.Cm(1.0999990701675415D));
            this.pageFooterTextBox.Name = "pageFooterTextBox";
            this.pageFooterTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.1995010375976562D), Telerik.Reporting.Drawing.Unit.Cm(0.49989983439445496D));
            this.pageFooterTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.pageFooterTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageFooterTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.pageFooterTextBox.Value = "Thank you for your business!";
            // 
            // companyLogoPictureBox
            // 
            this.companyLogoPictureBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.companyLogoPictureBox.MimeType = "image/png";
            this.companyLogoPictureBox.Name = "companyLogoPictureBox";
            this.companyLogoPictureBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7606019973754883D), Telerik.Reporting.Drawing.Unit.Cm(2.8000001907348633D));
            this.companyLogoPictureBox.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.ScaleProportional;
            this.companyLogoPictureBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.companyLogoPictureBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.companyLogoPictureBox.Value = ((object)(resources.GetObject("companyLogoPictureBox.Value")));
            // 
            // reportHeaderSection
            // 
            this.reportHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.50060147047042847D);
            this.reportHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.CompanyInfoPanel});
            this.reportHeaderSection.Name = "reportHeaderSection";
            this.reportHeaderSection.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.5D);
            // 
            // CompanyInfoPanel
            // 
            this.CompanyInfoPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.companyNameTextBox});
            this.CompanyInfoPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.CompanyInfoPanel.Name = "CompanyInfoPanel";
            this.CompanyInfoPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7606019973754883D), Telerik.Reporting.Drawing.Unit.Cm(0.50060147047042847D));
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(4.7606019973754883D), Telerik.Reporting.Drawing.Unit.Cm(0.49999994039535522D));
            this.companyNameTextBox.Style.Font.Bold = true;
            this.companyNameTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.companyNameTextBox.Value = null;
            // 
            // groupHeaderSection
            // 
            this.groupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D);
            this.groupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.itemsHeaderPanel});
            this.groupHeaderSection.Name = "groupHeaderSection";
            this.groupHeaderSection.PrintOnEveryPage = true;
            this.groupHeaderSection.Style.Padding.Top = Telerik.Reporting.Drawing.Unit.Cm(0.5D);
            // 
            // itemsHeaderPanel
            // 
            this.itemsHeaderPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.ItemNoHeaderTextBox,
            this.descriptionHeaderTextBox,
            this.qtyHeaderTextBox,
            this.unitPriceHeaderTextBox,
            this.lineTotalHeaderTextBox});
            this.itemsHeaderPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.itemsHeaderPanel.Name = "itemsHeaderPanel";
            this.itemsHeaderPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.920000076293945D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.itemsHeaderPanel.Style.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.itemsHeaderPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.itemsHeaderPanel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // ItemNoHeaderTextBox
            // 
            this.ItemNoHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.00050061539513990283D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.ItemNoHeaderTextBox.Name = "ItemNoHeaderTextBox";
            this.ItemNoHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.7994992733001709D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.ItemNoHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.ItemNoHeaderTextBox.Style.Font.Bold = true;
            this.ItemNoHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.ItemNoHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.ItemNoHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.ItemNoHeaderTextBox.Value = "No";
            // 
            // descriptionHeaderTextBox
            // 
            this.descriptionHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(2.8001999855041504D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.descriptionHeaderTextBox.Name = "descriptionHeaderTextBox";
            this.descriptionHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(5.46019983291626D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.descriptionHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.descriptionHeaderTextBox.Style.Font.Bold = true;
            this.descriptionHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.descriptionHeaderTextBox.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.descriptionHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.descriptionHeaderTextBox.Value = "DESCRIPTION";
            // 
            // qtyHeaderTextBox
            // 
            this.qtyHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.2606000900268555D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.qtyHeaderTextBox.Name = "qtyHeaderTextBox";
            this.qtyHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(1.4394005537033081D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.qtyHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.qtyHeaderTextBox.Style.Font.Bold = true;
            this.qtyHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.qtyHeaderTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.qtyHeaderTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.qtyHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.qtyHeaderTextBox.Value = "QTY";
            // 
            // unitPriceHeaderTextBox
            // 
            this.unitPriceHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7002010345458984D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.unitPriceHeaderTextBox.Name = "unitPriceHeaderTextBox";
            this.unitPriceHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.unitPriceHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.unitPriceHeaderTextBox.Style.Font.Bold = true;
            this.unitPriceHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.unitPriceHeaderTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.unitPriceHeaderTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.unitPriceHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.unitPriceHeaderTextBox.Value = "UNIT PRICE";
            // 
            // lineTotalHeaderTextBox
            // 
            this.lineTotalHeaderTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.799901962280273D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.lineTotalHeaderTextBox.Name = "lineTotalHeaderTextBox";
            this.lineTotalHeaderTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.59969890117645264D));
            this.lineTotalHeaderTextBox.Style.Color = System.Drawing.Color.DimGray;
            this.lineTotalHeaderTextBox.Style.Font.Bold = true;
            this.lineTotalHeaderTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            this.lineTotalHeaderTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.lineTotalHeaderTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.lineTotalHeaderTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.lineTotalHeaderTextBox.Value = "LINE TOTAL";
            // 
            // groupFooterSection
            // 
            this.groupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.7999998331069946D);
            this.groupFooterSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalPanel,
            this.totalPanel});
            this.groupFooterSection.Name = "groupFooterSection";
            this.groupFooterSection.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.groupFooterSection.Style.BorderStyle.Top = Telerik.Reporting.Drawing.BorderType.Solid;
            this.groupFooterSection.Style.BorderWidth.Top = Telerik.Reporting.Drawing.Unit.Point(2D);
            // 
            // subTotalPanel
            // 
            this.subTotalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.subTotalLabelTextBox,
            this.subTotalTextBox});
            this.subTotalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.subTotalPanel.Name = "subTotalPanel";
            this.subTotalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.920000076293945D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.subTotalPanel.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalPanel.Style.BorderStyle.Bottom = Telerik.Reporting.Drawing.BorderType.Solid;
            // 
            // subTotalLabelTextBox
            // 
            this.subTotalLabelTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7002019882202148D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.subTotalLabelTextBox.Name = "subTotalLabelTextBox";
            this.subTotalLabelTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.subTotalLabelTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalLabelTextBox.Style.Font.Bold = true;
            this.subTotalLabelTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalLabelTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.subTotalLabelTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalLabelTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalLabelTextBox.Value = "Sub Total";
            // 
            // subTotalTextBox
            // 
            this.subTotalTextBox.Format = "{0:C2}";
            this.subTotalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.820601463317871D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.subTotalTextBox.Name = "subTotalTextBox";
            this.subTotalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.subTotalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.subTotalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.subTotalTextBox.Style.Font.Bold = true;
            this.subTotalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.subTotalTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.subTotalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.subTotalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.subTotalTextBox.Value = null;
            // 
            // totalPanel
            // 
            this.totalPanel.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.totalLabelTextBox,
            this.totalTextBox});
            this.totalPanel.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0.8999975323677063D));
            this.totalPanel.Name = "totalPanel";
            this.totalPanel.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.920600891113281D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.totalPanel.Style.BackgroundColor = System.Drawing.Color.Silver;
            // 
            // totalLabelTextBox
            // 
            this.totalLabelTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(9.7002010345458984D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.totalLabelTextBox.Name = "totalLabelTextBox";
            this.totalLabelTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0994994640350342D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.totalLabelTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.totalLabelTextBox.Style.Font.Bold = true;
            this.totalLabelTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.totalLabelTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.totalLabelTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.totalLabelTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.totalLabelTextBox.Value = "TOTAL";
            // 
            // totalTextBox
            // 
            this.totalTextBox.Format = "{0:C2}";
            this.totalTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(12.820601463317871D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3.0999999046325684D), Telerik.Reporting.Drawing.Unit.Cm(0.89999997615814209D));
            this.totalTextBox.Style.BorderColor.Default = System.Drawing.Color.Silver;
            this.totalTextBox.Style.BorderStyle.Left = Telerik.Reporting.Drawing.BorderType.Solid;
            this.totalTextBox.Style.Font.Bold = true;
            this.totalTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(11D);
            this.totalTextBox.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Cm(0.30000001192092896D);
            this.totalTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.totalTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.totalTextBox.Value = null;
            // 
            // Report1
            // 
            this.Culture = new System.Globalization.CultureInfo("en-US");
            this.DataSource = this.dataSource1;
            group1.GroupFooter = this.groupFooterSection;
            group1.GroupHeader = this.groupHeaderSection;
            group1.Name = "group";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.groupHeaderSection,
            this.groupFooterSection,
            this.pageHeaderSection,
            this.detailSection1,
            this.pageFooterSection1,
            this.reportHeaderSection});
            this.Name = "Invoice1";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(1D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule1.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule1.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.TextItemBase)),
            new Telerik.Reporting.Drawing.TypeSelector(typeof(Telerik.Reporting.HtmlTextBox))});
            styleRule2.Style.Padding.Left = Telerik.Reporting.Drawing.Unit.Point(2D);
            styleRule2.Style.Padding.Right = Telerik.Reporting.Drawing.Unit.Point(2D);
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.920000076293945D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dataSource1;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection;
        private Telerik.Reporting.Panel invoiceInfoPanel;
        private Telerik.Reporting.TextBox invoiceHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceNumberHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceNrTextBox;
        private Telerik.Reporting.TextBox invoiceDateHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceDateTextBox;
        private Telerik.Reporting.TextBox invoiceTotalHeaderTextBox;
        private Telerik.Reporting.TextBox invoiceTotalTextBox1;
        private Telerik.Reporting.TextBox pagesHeaderTextBox;
        private Telerik.Reporting.TextBox pagesTextBox;
        private Telerik.Reporting.DetailSection detailSection1;
        private Telerik.Reporting.TextBox itemNrTextBox;
        private Telerik.Reporting.TextBox itemDescriptionTextBox;
        private Telerik.Reporting.TextBox qtyTextBox;
        private Telerik.Reporting.TextBox unitPriceTextBox;
        private Telerik.Reporting.TextBox lineTotalTextBox;
        private Telerik.Reporting.PageFooterSection pageFooterSection1;
        private Telerik.Reporting.TextBox pageFooterTextBox;
        private Telerik.Reporting.PictureBox companyLogoPictureBox;
        private Telerik.Reporting.ReportHeaderSection reportHeaderSection;
        private Telerik.Reporting.Panel CompanyInfoPanel;
        private Telerik.Reporting.TextBox companyNameTextBox;
        private Telerik.Reporting.GroupHeaderSection groupHeaderSection;
        private Telerik.Reporting.Panel itemsHeaderPanel;
        private Telerik.Reporting.TextBox ItemNoHeaderTextBox;
        private Telerik.Reporting.TextBox descriptionHeaderTextBox;
        private Telerik.Reporting.TextBox qtyHeaderTextBox;
        private Telerik.Reporting.TextBox unitPriceHeaderTextBox;
        private Telerik.Reporting.TextBox lineTotalHeaderTextBox;
        private Telerik.Reporting.GroupFooterSection groupFooterSection;
        private Telerik.Reporting.Panel subTotalPanel;
        private Telerik.Reporting.TextBox subTotalLabelTextBox;
        private Telerik.Reporting.TextBox subTotalTextBox;
        private Telerik.Reporting.Panel totalPanel;
        private Telerik.Reporting.TextBox totalLabelTextBox;
        private Telerik.Reporting.TextBox totalTextBox;
    }
}