namespace CrudApp
{
    partial class CRUDForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUDForm));
            ButtonC = new Button();
            label1 = new Label();
            ButtonR = new Button();
            ButtonU = new Button();
            ButtonD = new Button();
            PanelCreate = new Panel();
            LabelCreate = new Label();
            ButtonCreate = new Button();
            TextContact = new TextBox();
            LabelContact = new Label();
            Licensed = new CheckBox();
            DOB = new DateTimePicker();
            LabelLicense = new Label();
            LabelDOB = new Label();
            TextName = new TextBox();
            LabelName = new Label();
            errorProvider1 = new ErrorProvider(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            ListDetails = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            LabelRead = new Label();
            ButtonRead = new Button();
            tabPage3 = new TabPage();
            panel2 = new Panel();
            TextContact2 = new TextBox();
            LabelContact2 = new Label();
            Licensed2 = new CheckBox();
            DOB2 = new DateTimePicker();
            LabelLicense2 = new Label();
            LabelDOB2 = new Label();
            TextCustName = new TextBox();
            LabelCustName = new Label();
            TextCustID = new TextBox();
            LabelCustID = new Label();
            ButtonSearch = new Button();
            TextID = new TextBox();
            LabelID = new Label();
            LabelUpdate = new Label();
            ButtonUpdate = new Button();
            tabPage4 = new TabPage();
            panel3 = new Panel();
            TextLicensed = new TextBox();
            TextDOB = new TextBox();
            TextContact3 = new TextBox();
            LabelContact3 = new Label();
            LabelLicensed2 = new Label();
            LabelDOB3 = new Label();
            TextCustName2 = new TextBox();
            LabelCustName2 = new Label();
            TextCustID2 = new TextBox();
            LabelCustID2 = new Label();
            ButtonSearch2 = new Button();
            TextID2 = new TextBox();
            LabelID2 = new Label();
            ButtonDelete = new Button();
            label4 = new Label();
            PanelCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonC
            // 
            ButtonC.Location = new Point(34, 149);
            ButtonC.Margin = new Padding(4);
            ButtonC.Name = "ButtonC";
            ButtonC.Size = new Size(130, 50);
            ButtonC.TabIndex = 0;
            ButtonC.Text = "&C - Create";
            ButtonC.TextAlign = ContentAlignment.MiddleLeft;
            ButtonC.UseVisualStyleBackColor = false;
            ButtonC.Click += ButtonC_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 41);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(770, 39);
            label1.TabIndex = 1;
            label1.Text = "Performing CRUD operations on Access Database";
            // 
            // ButtonR
            // 
            ButtonR.Location = new Point(34, 209);
            ButtonR.Margin = new Padding(4);
            ButtonR.Name = "ButtonR";
            ButtonR.Size = new Size(130, 50);
            ButtonR.TabIndex = 2;
            ButtonR.Text = "&R - Read";
            ButtonR.TextAlign = ContentAlignment.MiddleLeft;
            ButtonR.UseVisualStyleBackColor = true;
            ButtonR.Click += ButtonR_Click;
            // 
            // ButtonU
            // 
            ButtonU.Location = new Point(34, 269);
            ButtonU.Margin = new Padding(4);
            ButtonU.Name = "ButtonU";
            ButtonU.Size = new Size(130, 50);
            ButtonU.TabIndex = 3;
            ButtonU.Text = "&U - Update";
            ButtonU.TextAlign = ContentAlignment.MiddleLeft;
            ButtonU.UseVisualStyleBackColor = true;
            ButtonU.Click += ButtonU_Click;
            // 
            // ButtonD
            // 
            ButtonD.Location = new Point(34, 329);
            ButtonD.Margin = new Padding(4);
            ButtonD.Name = "ButtonD";
            ButtonD.Size = new Size(130, 50);
            ButtonD.TabIndex = 4;
            ButtonD.Text = "&D - Delete";
            ButtonD.TextAlign = ContentAlignment.MiddleLeft;
            ButtonD.UseVisualStyleBackColor = true;
            ButtonD.Click += ButtonD_Click;
            // 
            // PanelCreate
            // 
            PanelCreate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelCreate.BorderStyle = BorderStyle.FixedSingle;
            PanelCreate.Controls.Add(LabelCreate);
            PanelCreate.Controls.Add(ButtonCreate);
            PanelCreate.Controls.Add(TextContact);
            PanelCreate.Controls.Add(LabelContact);
            PanelCreate.Controls.Add(Licensed);
            PanelCreate.Controls.Add(DOB);
            PanelCreate.Controls.Add(LabelLicense);
            PanelCreate.Controls.Add(LabelDOB);
            PanelCreate.Controls.Add(TextName);
            PanelCreate.Controls.Add(LabelName);
            PanelCreate.Location = new Point(16, 16);
            PanelCreate.Name = "PanelCreate";
            PanelCreate.Size = new Size(762, 456);
            PanelCreate.TabIndex = 5;
            // 
            // LabelCreate
            // 
            LabelCreate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelCreate.BackColor = Color.FromArgb(255, 255, 192);
            LabelCreate.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCreate.Location = new Point(2, 0);
            LabelCreate.Name = "LabelCreate";
            LabelCreate.Size = new Size(756, 38);
            LabelCreate.TabIndex = 6;
            LabelCreate.Text = "C = CREATE";
            LabelCreate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonCreate
            // 
            ButtonCreate.BackColor = Color.FromArgb(255, 192, 128);
            ButtonCreate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonCreate.Location = new Point(169, 274);
            ButtonCreate.Name = "ButtonCreate";
            ButtonCreate.Size = new Size(200, 50);
            ButtonCreate.TabIndex = 10;
            ButtonCreate.Text = "Create Record";
            ButtonCreate.UseVisualStyleBackColor = false;
            ButtonCreate.Click += ButtonCreate_Click;
            // 
            // TextContact
            // 
            TextContact.Location = new Point(169, 211);
            TextContact.MaxLength = 50;
            TextContact.Name = "TextContact";
            TextContact.Size = new Size(302, 26);
            TextContact.TabIndex = 9;
            TextContact.GotFocus += Control_GotFocus;
            TextContact.KeyPress += Control_KeyPress;
            TextContact.LostFocus += Control_LostFocus;
            // 
            // LabelContact
            // 
            LabelContact.AutoSize = true;
            LabelContact.Location = new Point(18, 214);
            LabelContact.Name = "LabelContact";
            LabelContact.Size = new Size(129, 18);
            LabelContact.TabIndex = 8;
            LabelContact.Text = "Contact Number :";
            // 
            // Licensed
            // 
            Licensed.AutoSize = true;
            Licensed.Location = new Point(169, 169);
            Licensed.Name = "Licensed";
            Licensed.Size = new Size(52, 22);
            Licensed.TabIndex = 7;
            Licensed.Text = "Yes";
            Licensed.UseVisualStyleBackColor = true;
            Licensed.KeyPress += Control_KeyPress;
            // 
            // DOB
            // 
            DOB.CustomFormat = "dd - MMM - yyyy";
            DOB.Format = DateTimePickerFormat.Custom;
            DOB.Location = new Point(169, 122);
            DOB.Name = "DOB";
            DOB.Size = new Size(302, 26);
            DOB.TabIndex = 6;
            DOB.KeyPress += Control_KeyPress;
            // 
            // LabelLicense
            // 
            LabelLicense.AutoSize = true;
            LabelLicense.Location = new Point(18, 171);
            LabelLicense.Name = "LabelLicense";
            LabelLicense.Size = new Size(124, 18);
            LabelLicense.TabIndex = 4;
            LabelLicense.Text = "Driving License :";
            // 
            // LabelDOB
            // 
            LabelDOB.AutoSize = true;
            LabelDOB.Location = new Point(18, 125);
            LabelDOB.Name = "LabelDOB";
            LabelDOB.Size = new Size(103, 18);
            LabelDOB.TabIndex = 2;
            LabelDOB.Text = "Date of Birth :";
            // 
            // TextName
            // 
            TextName.Location = new Point(169, 76);
            TextName.MaxLength = 50;
            TextName.Name = "TextName";
            TextName.Size = new Size(302, 26);
            TextName.TabIndex = 1;
            TextName.GotFocus += Control_GotFocus;
            TextName.KeyPress += Control_KeyPress;
            TextName.LostFocus += Control_LostFocus;
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(18, 79);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(130, 18);
            LabelName.TabIndex = 0;
            LabelName.Text = "Customer Name :";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(176, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(804, 526);
            tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(224, 224, 224);
            tabPage1.Controls.Add(PanelCreate);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(796, 495);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "    C - Create    ";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(224, 224, 224);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(796, 495);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "    R - Read    ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(ListDetails);
            panel1.Controls.Add(LabelRead);
            panel1.Controls.Add(ButtonRead);
            panel1.Location = new Point(16, 16);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 453);
            panel1.TabIndex = 6;
            // 
            // ListDetails
            // 
            ListDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ListDetails.BackColor = Color.FromArgb(255, 192, 255);
            ListDetails.BorderStyle = BorderStyle.FixedSingle;
            ListDetails.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            ListDetails.FullRowSelect = true;
            ListDetails.Location = new Point(9, 122);
            ListDetails.MultiSelect = false;
            ListDetails.Name = "ListDetails";
            ListDetails.Size = new Size(743, 319);
            ListDetails.TabIndex = 11;
            ListDetails.UseCompatibleStateImageBehavior = false;
            ListDetails.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Customer Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Date of Birth";
            columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Licensed";
            columnHeader4.TextAlign = HorizontalAlignment.Center;
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Contact Number";
            columnHeader5.Width = 160;
            // 
            // LabelRead
            // 
            LabelRead.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelRead.BackColor = Color.FromArgb(255, 255, 192);
            LabelRead.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelRead.Location = new Point(2, 0);
            LabelRead.Name = "LabelRead";
            LabelRead.Size = new Size(756, 38);
            LabelRead.TabIndex = 6;
            LabelRead.Text = "R = READ";
            LabelRead.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonRead
            // 
            ButtonRead.BackColor = Color.FromArgb(255, 192, 128);
            ButtonRead.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonRead.Location = new Point(11, 57);
            ButtonRead.Name = "ButtonRead";
            ButtonRead.Size = new Size(200, 50);
            ButtonRead.TabIndex = 10;
            ButtonRead.Text = "Read All Records";
            ButtonRead.UseVisualStyleBackColor = false;
            ButtonRead.Click += ButtonRead_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(224, 224, 224);
            tabPage3.Controls.Add(panel2);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(796, 495);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "    U - Update    ";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(TextContact2);
            panel2.Controls.Add(LabelContact2);
            panel2.Controls.Add(Licensed2);
            panel2.Controls.Add(DOB2);
            panel2.Controls.Add(LabelLicense2);
            panel2.Controls.Add(LabelDOB2);
            panel2.Controls.Add(TextCustName);
            panel2.Controls.Add(LabelCustName);
            panel2.Controls.Add(TextCustID);
            panel2.Controls.Add(LabelCustID);
            panel2.Controls.Add(ButtonSearch);
            panel2.Controls.Add(TextID);
            panel2.Controls.Add(LabelID);
            panel2.Controls.Add(LabelUpdate);
            panel2.Controls.Add(ButtonUpdate);
            panel2.Location = new Point(16, 16);
            panel2.Name = "panel2";
            panel2.Size = new Size(762, 453);
            panel2.TabIndex = 7;
            // 
            // TextContact2
            // 
            TextContact2.Location = new Point(149, 287);
            TextContact2.MaxLength = 50;
            TextContact2.Name = "TextContact2";
            TextContact2.Size = new Size(302, 26);
            TextContact2.TabIndex = 23;
            TextContact2.GotFocus += Control_GotFocus;
            TextContact2.KeyPress += Control_KeyPress;
            TextContact2.LostFocus += Control_LostFocus;
            // 
            // LabelContact2
            // 
            LabelContact2.AutoSize = true;
            LabelContact2.Location = new Point(13, 290);
            LabelContact2.Name = "LabelContact2";
            LabelContact2.Size = new Size(129, 18);
            LabelContact2.TabIndex = 22;
            LabelContact2.Text = "Contact Number :";
            // 
            // Licensed2
            // 
            Licensed2.AutoSize = true;
            Licensed2.Location = new Point(149, 245);
            Licensed2.Name = "Licensed2";
            Licensed2.Size = new Size(52, 22);
            Licensed2.TabIndex = 21;
            Licensed2.Text = "Yes";
            Licensed2.UseVisualStyleBackColor = true;
            Licensed2.KeyPress += Control_KeyPress;
            // 
            // DOB2
            // 
            DOB2.CustomFormat = "dd - MMM - yyyy";
            DOB2.Format = DateTimePickerFormat.Custom;
            DOB2.Location = new Point(149, 198);
            DOB2.Name = "DOB2";
            DOB2.Size = new Size(302, 26);
            DOB2.TabIndex = 19;
            DOB2.KeyPress += Control_KeyPress;
            // 
            // LabelLicense2
            // 
            LabelLicense2.AutoSize = true;
            LabelLicense2.Location = new Point(13, 247);
            LabelLicense2.Name = "LabelLicense2";
            LabelLicense2.Size = new Size(124, 18);
            LabelLicense2.TabIndex = 20;
            LabelLicense2.Text = "Driving License :";
            // 
            // LabelDOB2
            // 
            LabelDOB2.AutoSize = true;
            LabelDOB2.Location = new Point(13, 201);
            LabelDOB2.Name = "LabelDOB2";
            LabelDOB2.Size = new Size(103, 18);
            LabelDOB2.TabIndex = 18;
            LabelDOB2.Text = "Date of Birth :";
            // 
            // TextCustName
            // 
            TextCustName.Location = new Point(149, 149);
            TextCustName.Name = "TextCustName";
            TextCustName.Size = new Size(302, 26);
            TextCustName.TabIndex = 17;
            TextCustName.GotFocus += Control_GotFocus;
            TextCustName.KeyPress += Control_KeyPress;
            TextCustName.LostFocus += Control_LostFocus;
            // 
            // LabelCustName
            // 
            LabelCustName.AutoSize = true;
            LabelCustName.Location = new Point(13, 152);
            LabelCustName.Name = "LabelCustName";
            LabelCustName.Size = new Size(130, 18);
            LabelCustName.TabIndex = 16;
            LabelCustName.Text = "Customer Name :";
            // 
            // TextCustID
            // 
            TextCustID.BackColor = Color.White;
            TextCustID.Location = new Point(149, 106);
            TextCustID.Name = "TextCustID";
            TextCustID.ReadOnly = true;
            TextCustID.Size = new Size(72, 26);
            TextCustID.TabIndex = 15;
            TextCustID.TextAlign = HorizontalAlignment.Center;
            TextCustID.GotFocus += Control_GotFocus;
            TextCustID.KeyPress += Control_KeyPress;
            TextCustID.LostFocus += Control_LostFocus;
            // 
            // LabelCustID
            // 
            LabelCustID.AutoSize = true;
            LabelCustID.Location = new Point(13, 109);
            LabelCustID.Name = "LabelCustID";
            LabelCustID.Size = new Size(103, 18);
            LabelCustID.TabIndex = 14;
            LabelCustID.Text = "Customer ID :";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(149, 59);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(86, 30);
            ButtonSearch.TabIndex = 13;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // TextID
            // 
            TextID.Location = new Point(50, 61);
            TextID.Name = "TextID";
            TextID.Size = new Size(72, 26);
            TextID.TabIndex = 12;
            TextID.TextAlign = HorizontalAlignment.Center;
            TextID.GotFocus += Control_GotFocus;
            TextID.KeyPress += Control_KeyPress;
            TextID.LostFocus += Control_LostFocus;
            // 
            // LabelID
            // 
            LabelID.AutoSize = true;
            LabelID.Location = new Point(13, 65);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(31, 18);
            LabelID.TabIndex = 11;
            LabelID.Text = "ID :";
            // 
            // LabelUpdate
            // 
            LabelUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelUpdate.BackColor = Color.FromArgb(255, 255, 192);
            LabelUpdate.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelUpdate.Location = new Point(2, 0);
            LabelUpdate.Name = "LabelUpdate";
            LabelUpdate.Size = new Size(756, 38);
            LabelUpdate.TabIndex = 6;
            LabelUpdate.Text = "U = UPDATE";
            LabelUpdate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.BackColor = Color.FromArgb(255, 192, 128);
            ButtonUpdate.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUpdate.Location = new Point(149, 333);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(200, 50);
            ButtonUpdate.TabIndex = 24;
            ButtonUpdate.Text = "Update Record";
            ButtonUpdate.UseVisualStyleBackColor = false;
            ButtonUpdate.Click += ButtonUpdate_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(224, 224, 224);
            tabPage4.Controls.Add(panel3);
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(796, 495);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "    D - Delete    ";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(TextLicensed);
            panel3.Controls.Add(TextDOB);
            panel3.Controls.Add(TextContact3);
            panel3.Controls.Add(LabelContact3);
            panel3.Controls.Add(LabelLicensed2);
            panel3.Controls.Add(LabelDOB3);
            panel3.Controls.Add(TextCustName2);
            panel3.Controls.Add(LabelCustName2);
            panel3.Controls.Add(TextCustID2);
            panel3.Controls.Add(LabelCustID2);
            panel3.Controls.Add(ButtonSearch2);
            panel3.Controls.Add(TextID2);
            panel3.Controls.Add(LabelID2);
            panel3.Controls.Add(ButtonDelete);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(16, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(762, 453);
            panel3.TabIndex = 7;
            // 
            // TextLicensed
            // 
            TextLicensed.BackColor = Color.White;
            TextLicensed.Location = new Point(149, 244);
            TextLicensed.Name = "TextLicensed";
            TextLicensed.ReadOnly = true;
            TextLicensed.Size = new Size(302, 26);
            TextLicensed.TabIndex = 35;
            TextLicensed.GotFocus += Control_GotFocus;
            TextLicensed.KeyPress += Control_KeyPress;
            TextLicensed.LostFocus += Control_LostFocus;
            // 
            // TextDOB
            // 
            TextDOB.BackColor = Color.White;
            TextDOB.Location = new Point(149, 198);
            TextDOB.Name = "TextDOB";
            TextDOB.ReadOnly = true;
            TextDOB.Size = new Size(302, 26);
            TextDOB.TabIndex = 33;
            TextDOB.GotFocus += Control_GotFocus;
            TextDOB.KeyPress += Control_KeyPress;
            TextDOB.LostFocus += Control_LostFocus;
            // 
            // TextContact3
            // 
            TextContact3.BackColor = Color.White;
            TextContact3.Location = new Point(149, 287);
            TextContact3.MaxLength = 50;
            TextContact3.Name = "TextContact3";
            TextContact3.ReadOnly = true;
            TextContact3.Size = new Size(302, 26);
            TextContact3.TabIndex = 37;
            TextContact3.GotFocus += Control_GotFocus;
            TextContact3.KeyPress += Control_KeyPress;
            TextContact3.LostFocus += Control_LostFocus;
            // 
            // LabelContact3
            // 
            LabelContact3.AutoSize = true;
            LabelContact3.Location = new Point(13, 290);
            LabelContact3.Name = "LabelContact3";
            LabelContact3.Size = new Size(129, 18);
            LabelContact3.TabIndex = 36;
            LabelContact3.Text = "Contact Number :";
            // 
            // LabelLicensed2
            // 
            LabelLicensed2.AutoSize = true;
            LabelLicensed2.Location = new Point(13, 247);
            LabelLicensed2.Name = "LabelLicensed2";
            LabelLicensed2.Size = new Size(124, 18);
            LabelLicensed2.TabIndex = 34;
            LabelLicensed2.Text = "Driving License :";
            // 
            // LabelDOB3
            // 
            LabelDOB3.AutoSize = true;
            LabelDOB3.Location = new Point(13, 201);
            LabelDOB3.Name = "LabelDOB3";
            LabelDOB3.Size = new Size(103, 18);
            LabelDOB3.TabIndex = 32;
            LabelDOB3.Text = "Date of Birth :";
            // 
            // TextCustName2
            // 
            TextCustName2.BackColor = Color.White;
            TextCustName2.Location = new Point(149, 149);
            TextCustName2.Name = "TextCustName2";
            TextCustName2.ReadOnly = true;
            TextCustName2.Size = new Size(302, 26);
            TextCustName2.TabIndex = 31;
            TextCustName2.GotFocus += Control_GotFocus;
            TextCustName2.KeyPress += Control_KeyPress;
            TextCustName2.LostFocus += Control_LostFocus;
            // 
            // LabelCustName2
            // 
            LabelCustName2.AutoSize = true;
            LabelCustName2.Location = new Point(13, 152);
            LabelCustName2.Name = "LabelCustName2";
            LabelCustName2.Size = new Size(130, 18);
            LabelCustName2.TabIndex = 30;
            LabelCustName2.Text = "Customer Name :";
            // 
            // TextCustID2
            // 
            TextCustID2.BackColor = Color.White;
            TextCustID2.Location = new Point(149, 106);
            TextCustID2.Name = "TextCustID2";
            TextCustID2.ReadOnly = true;
            TextCustID2.Size = new Size(72, 26);
            TextCustID2.TabIndex = 29;
            TextCustID2.TextAlign = HorizontalAlignment.Center;
            TextCustID2.GotFocus += Control_GotFocus;
            TextCustID2.KeyPress += Control_KeyPress;
            TextCustID2.LostFocus += Control_LostFocus;
            // 
            // LabelCustID2
            // 
            LabelCustID2.AutoSize = true;
            LabelCustID2.Location = new Point(13, 109);
            LabelCustID2.Name = "LabelCustID2";
            LabelCustID2.Size = new Size(103, 18);
            LabelCustID2.TabIndex = 28;
            LabelCustID2.Text = "Customer ID :";
            // 
            // ButtonSearch2
            // 
            ButtonSearch2.Location = new Point(149, 59);
            ButtonSearch2.Name = "ButtonSearch2";
            ButtonSearch2.Size = new Size(86, 30);
            ButtonSearch2.TabIndex = 27;
            ButtonSearch2.Text = "Search";
            ButtonSearch2.UseVisualStyleBackColor = true;
            ButtonSearch2.Click += ButtonSearch2_Click;
            // 
            // TextID2
            // 
            TextID2.Location = new Point(50, 61);
            TextID2.Name = "TextID2";
            TextID2.Size = new Size(72, 26);
            TextID2.TabIndex = 26;
            TextID2.TextAlign = HorizontalAlignment.Center;
            TextID2.GotFocus += Control_GotFocus;
            TextID2.KeyPress += Control_KeyPress;
            TextID2.LostFocus += Control_LostFocus;
            // 
            // LabelID2
            // 
            LabelID2.AutoSize = true;
            LabelID2.Location = new Point(13, 65);
            LabelID2.Name = "LabelID2";
            LabelID2.Size = new Size(31, 18);
            LabelID2.TabIndex = 25;
            LabelID2.Text = "ID :";
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = Color.FromArgb(255, 192, 128);
            ButtonDelete.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDelete.Location = new Point(149, 333);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(200, 50);
            ButtonDelete.TabIndex = 38;
            ButtonDelete.Text = "Delete Record";
            ButtonDelete.UseVisualStyleBackColor = false;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(2, 0);
            label4.Name = "label4";
            label4.Size = new Size(756, 38);
            label4.TabIndex = 6;
            label4.Text = "D = DELETE";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // CRUDForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1008, 681);
            Controls.Add(tabControl1);
            Controls.Add(ButtonD);
            Controls.Add(ButtonU);
            Controls.Add(ButtonR);
            Controls.Add(label1);
            Controls.Add(ButtonC);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1024, 720);
            Name = "CRUDForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD operations on Microsoft Access Database";
            Load += CRUDForm_Load;
            PanelCreate.ResumeLayout(false);
            PanelCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonC;
        private Label label1;
        private Button ButtonR;
        private Button ButtonU;
        private Button ButtonD;
        private Panel PanelCreate;
        private Button ButtonCreate;
        private TextBox TextContact;
        private Label LabelContact;
        private CheckBox Licensed;
        private DateTimePicker DOB;
        private Label LabelLicense;
        private Label LabelDOB;
        private TextBox TextName;
        private Label LabelName;
        private Label LabelCreate;
        private ErrorProvider errorProvider1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label LabelRead;
        private Button ButtonRead;
        private ListView ListDetails;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel2;
        private Label LabelUpdate;
        private Button ButtonUpdate;
        private Panel panel3;
        private Label label4;
        private TextBox TextID;
        private Label LabelID;
        private Button ButtonSearch;
        private TextBox TextCustName;
        private Label LabelCustName;
        private TextBox TextCustID;
        private Label LabelCustID;
        private TextBox TextContact2;
        private Label LabelContact2;
        private CheckBox Licensed2;
        private DateTimePicker DOB2;
        private Label LabelLicense2;
        private Label LabelDOB2;
        private TextBox TextContact3;
        private Label LabelContact3;
        private Label LabelLicensed2;
        private Label LabelDOB3;
        private TextBox TextCustName2;
        private Label LabelCustName2;
        private TextBox TextCustID2;
        private Label LabelCustID2;
        private Button ButtonSearch2;
        private TextBox TextID2;
        private Label LabelID2;
        private Button ButtonDelete;
        private TextBox TextLicensed;
        private TextBox TextDOB;
    }
}
