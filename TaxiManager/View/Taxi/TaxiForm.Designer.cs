namespace TaxiManager.View.Taxi
{
    partial class TaxiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRegNo = new System.Windows.Forms.TextBox();
            this.TxtOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtEngineNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCasisNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtHP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtYearMade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtRate6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtSeatNo = new System.Windows.Forms.TextBox();
            this.TxtRate12 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtComNo = new System.Windows.Forms.TextBox();
            this.DDMake = new System.Windows.Forms.ComboBox();
            this.carmadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxi_managementDataSet = new TaxiManager.taxi_managementDataSet();
            this.DDModel = new System.Windows.Forms.ComboBox();
            this.mademodelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label20 = new System.Windows.Forms.Label();
            this.DDFuel = new System.Windows.Forms.ComboBox();
            this.fueltypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DDColour = new System.Windows.Forms.ComboBox();
            this.coloursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DDClass = new System.Windows.Forms.ComboBox();
            this.classtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DDBodyType = new System.Windows.Forms.ComboBox();
            this.bodytypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTRegDate = new System.Windows.Forms.DateTimePicker();
            this.DDOwnerStatus = new System.Windows.Forms.ComboBox();
            this.ownerstatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.car_madeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.car_madeTableAdapter();
            this.fuel_typeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.fuel_typeTableAdapter();
            this.coloursTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.coloursTableAdapter();
            this.body_typeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.body_typeTableAdapter();
            this.owner_statusTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.owner_statusTableAdapter();
            this.Err = new System.Windows.Forms.ErrorProvider(this.components);
            this.class_typeTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.class_typeTableAdapter();
            this.made_modelTableAdapter = new TaxiManager.taxi_managementDataSetTableAdapters.made_modelTableAdapter();
            this.BtnRoadTax = new System.Windows.Forms.Button();
            this.BtnInsurance = new System.Windows.Forms.Button();
            this.BtnPuspakom = new System.Windows.Forms.Button();
            this.BtnTaxiLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mademodelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fueltypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodytypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerstatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration No.";
            // 
            // TxtRegNo
            // 
            this.TxtRegNo.Location = new System.Drawing.Point(110, 15);
            this.TxtRegNo.Name = "TxtRegNo";
            this.TxtRegNo.Size = new System.Drawing.Size(150, 20);
            this.TxtRegNo.TabIndex = 0;
            // 
            // TxtOwner
            // 
            this.TxtOwner.Location = new System.Drawing.Point(110, 41);
            this.TxtOwner.Name = "TxtOwner";
            this.TxtOwner.Size = new System.Drawing.Size(311, 20);
            this.TxtOwner.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Registered Owner";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(110, 67);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(311, 72);
            this.TxtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // TxtEngineNo
            // 
            this.TxtEngineNo.Location = new System.Drawing.Point(110, 162);
            this.TxtEngineNo.Name = "TxtEngineNo";
            this.TxtEngineNo.Size = new System.Drawing.Size(150, 20);
            this.TxtEngineNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Engine No.";
            // 
            // TxtCasisNo
            // 
            this.TxtCasisNo.Location = new System.Drawing.Point(110, 188);
            this.TxtCasisNo.Name = "TxtCasisNo";
            this.TxtCasisNo.Size = new System.Drawing.Size(150, 20);
            this.TxtCasisNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Casis No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Make";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Model";
            // 
            // TxtHP
            // 
            this.TxtHP.Location = new System.Drawing.Point(110, 268);
            this.TxtHP.Name = "TxtHP";
            this.TxtHP.Size = new System.Drawing.Size(150, 20);
            this.TxtHP.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Horse Power";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fuel Type";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Colour";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(330, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Class";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(330, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Body Type";
            // 
            // TxtYearMade
            // 
            this.TxtYearMade.Location = new System.Drawing.Point(420, 216);
            this.TxtYearMade.Name = "TxtYearMade";
            this.TxtYearMade.Size = new System.Drawing.Size(150, 20);
            this.TxtYearMade.TabIndex = 14;
            this.TxtYearMade.Validating += new System.ComponentModel.CancelEventHandler(this.TxtYearMade_Validating);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(330, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Year Made";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(330, 246);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Registered Date";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(330, 273);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Owner Status";
            // 
            // TxtRate6
            // 
            this.TxtRate6.Location = new System.Drawing.Point(420, 322);
            this.TxtRate6.Name = "TxtRate6";
            this.TxtRate6.Size = new System.Drawing.Size(150, 20);
            this.TxtRate6.TabIndex = 17;
            this.TxtRate6.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRate6_Validating);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(330, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "6 Months (RM)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "Seat No.";
            // 
            // TxtSeatNo
            // 
            this.TxtSeatNo.Location = new System.Drawing.Point(110, 348);
            this.TxtSeatNo.Name = "TxtSeatNo";
            this.TxtSeatNo.Size = new System.Drawing.Size(150, 20);
            this.TxtSeatNo.TabIndex = 11;
            this.TxtSeatNo.Validating += new System.ComponentModel.CancelEventHandler(this.TxtSeatNo_Validating);
            // 
            // TxtRate12
            // 
            this.TxtRate12.Location = new System.Drawing.Point(420, 348);
            this.TxtRate12.Name = "TxtRate12";
            this.TxtRate12.Size = new System.Drawing.Size(150, 20);
            this.TxtRate12.TabIndex = 18;
            this.TxtRate12.Validating += new System.ComponentModel.CancelEventHandler(this.TxtRate12_Validating);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(330, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "License Rate:";
            // 
            // TxtComNo
            // 
            this.TxtComNo.Location = new System.Drawing.Point(500, 41);
            this.TxtComNo.Name = "TxtComNo";
            this.TxtComNo.Size = new System.Drawing.Size(70, 20);
            this.TxtComNo.TabIndex = 2;
            // 
            // DDMake
            // 
            this.DDMake.DataSource = this.carmadeBindingSource;
            this.DDMake.DisplayMember = "cm_name";
            this.DDMake.FormattingEnabled = true;
            this.DDMake.Location = new System.Drawing.Point(110, 214);
            this.DDMake.Name = "DDMake";
            this.DDMake.Size = new System.Drawing.Size(150, 21);
            this.DDMake.TabIndex = 6;
            this.DDMake.ValueMember = "cmid";
            this.DDMake.SelectedIndexChanged += new System.EventHandler(this.DDMake_SelectedIndexChanged);
            // 
            // carmadeBindingSource
            // 
            this.carmadeBindingSource.DataMember = "car_made";
            this.carmadeBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // taxi_managementDataSet
            // 
            this.taxi_managementDataSet.DataSetName = "taxi_managementDataSet";
            this.taxi_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DDModel
            // 
            this.DDModel.DataSource = this.mademodelBindingSource;
            this.DDModel.DisplayMember = "mm_name";
            this.DDModel.FormattingEnabled = true;
            this.DDModel.Location = new System.Drawing.Point(110, 241);
            this.DDModel.Name = "DDModel";
            this.DDModel.Size = new System.Drawing.Size(150, 21);
            this.DDModel.TabIndex = 7;
            this.DDModel.ValueMember = "mmid";
            // 
            // mademodelBindingSource
            // 
            this.mademodelBindingSource.DataMember = "made_model";
            this.mademodelBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(330, 351);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 38;
            this.label20.Text = "12 Months (RM)";
            // 
            // DDFuel
            // 
            this.DDFuel.DataSource = this.fueltypeBindingSource;
            this.DDFuel.DisplayMember = "ft_desc";
            this.DDFuel.FormattingEnabled = true;
            this.DDFuel.Location = new System.Drawing.Point(110, 294);
            this.DDFuel.Name = "DDFuel";
            this.DDFuel.Size = new System.Drawing.Size(150, 21);
            this.DDFuel.TabIndex = 9;
            this.DDFuel.ValueMember = "ftid";
            // 
            // fueltypeBindingSource
            // 
            this.fueltypeBindingSource.DataMember = "fuel_type";
            this.fueltypeBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // DDColour
            // 
            this.DDColour.DataSource = this.coloursBindingSource;
            this.DDColour.DisplayMember = "colour_desc";
            this.DDColour.FormattingEnabled = true;
            this.DDColour.Location = new System.Drawing.Point(110, 321);
            this.DDColour.Name = "DDColour";
            this.DDColour.Size = new System.Drawing.Size(150, 21);
            this.DDColour.TabIndex = 10;
            this.DDColour.ValueMember = "colourid";
            // 
            // coloursBindingSource
            // 
            this.coloursBindingSource.DataMember = "colours";
            this.coloursBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // DDClass
            // 
            this.DDClass.DataSource = this.classtypeBindingSource;
            this.DDClass.DisplayMember = "ct_desc";
            this.DDClass.FormattingEnabled = true;
            this.DDClass.Location = new System.Drawing.Point(420, 162);
            this.DDClass.Name = "DDClass";
            this.DDClass.Size = new System.Drawing.Size(150, 21);
            this.DDClass.TabIndex = 12;
            this.DDClass.ValueMember = "ctid";
            // 
            // classtypeBindingSource
            // 
            this.classtypeBindingSource.DataMember = "class_type";
            this.classtypeBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // DDBodyType
            // 
            this.DDBodyType.DataSource = this.bodytypeBindingSource;
            this.DDBodyType.DisplayMember = "bt_desc";
            this.DDBodyType.FormattingEnabled = true;
            this.DDBodyType.Location = new System.Drawing.Point(420, 189);
            this.DDBodyType.Name = "DDBodyType";
            this.DDBodyType.Size = new System.Drawing.Size(150, 21);
            this.DDBodyType.TabIndex = 13;
            this.DDBodyType.ValueMember = "btid";
            // 
            // bodytypeBindingSource
            // 
            this.bodytypeBindingSource.DataMember = "body_type";
            this.bodytypeBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // DTRegDate
            // 
            this.DTRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTRegDate.Location = new System.Drawing.Point(420, 242);
            this.DTRegDate.Name = "DTRegDate";
            this.DTRegDate.Size = new System.Drawing.Size(150, 20);
            this.DTRegDate.TabIndex = 15;
            // 
            // DDOwnerStatus
            // 
            this.DDOwnerStatus.DataSource = this.ownerstatusBindingSource;
            this.DDOwnerStatus.DisplayMember = "os_desc";
            this.DDOwnerStatus.FormattingEnabled = true;
            this.DDOwnerStatus.Location = new System.Drawing.Point(420, 268);
            this.DDOwnerStatus.Name = "DDOwnerStatus";
            this.DDOwnerStatus.Size = new System.Drawing.Size(150, 21);
            this.DDOwnerStatus.TabIndex = 16;
            this.DDOwnerStatus.ValueMember = "osid";
            // 
            // ownerstatusBindingSource
            // 
            this.ownerstatusBindingSource.DataMember = "owner_status";
            this.ownerstatusBindingSource.DataSource = this.taxi_managementDataSet;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(427, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Company No.";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(333, 389);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 19;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(414, 389);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 20;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(495, 389);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // car_madeTableAdapter
            // 
            this.car_madeTableAdapter.ClearBeforeFill = true;
            // 
            // fuel_typeTableAdapter
            // 
            this.fuel_typeTableAdapter.ClearBeforeFill = true;
            // 
            // coloursTableAdapter
            // 
            this.coloursTableAdapter.ClearBeforeFill = true;
            // 
            // body_typeTableAdapter
            // 
            this.body_typeTableAdapter.ClearBeforeFill = true;
            // 
            // owner_statusTableAdapter
            // 
            this.owner_statusTableAdapter.ClearBeforeFill = true;
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // class_typeTableAdapter
            // 
            this.class_typeTableAdapter.ClearBeforeFill = true;
            // 
            // made_modelTableAdapter
            // 
            this.made_modelTableAdapter.ClearBeforeFill = true;
            // 
            // BtnRoadTax
            // 
            this.BtnRoadTax.Location = new System.Drawing.Point(15, 378);
            this.BtnRoadTax.Name = "BtnRoadTax";
            this.BtnRoadTax.Size = new System.Drawing.Size(69, 42);
            this.BtnRoadTax.TabIndex = 46;
            this.BtnRoadTax.Text = "Road Tax";
            this.BtnRoadTax.UseVisualStyleBackColor = true;
            this.BtnRoadTax.Click += new System.EventHandler(this.BtnRoadTax_Click);
            // 
            // BtnInsurance
            // 
            this.BtnInsurance.Location = new System.Drawing.Point(92, 378);
            this.BtnInsurance.Name = "BtnInsurance";
            this.BtnInsurance.Size = new System.Drawing.Size(69, 42);
            this.BtnInsurance.TabIndex = 46;
            this.BtnInsurance.Text = "Insurance";
            this.BtnInsurance.UseVisualStyleBackColor = true;
            this.BtnInsurance.Click += new System.EventHandler(this.BtnInsurance_Click);
            // 
            // BtnPuspakom
            // 
            this.BtnPuspakom.Location = new System.Drawing.Point(169, 378);
            this.BtnPuspakom.Name = "BtnPuspakom";
            this.BtnPuspakom.Size = new System.Drawing.Size(69, 42);
            this.BtnPuspakom.TabIndex = 46;
            this.BtnPuspakom.Text = "Puspakom";
            this.BtnPuspakom.UseVisualStyleBackColor = true;
            this.BtnPuspakom.Click += new System.EventHandler(this.BtnPuspakom_Click);
            // 
            // BtnTaxiLicense
            // 
            this.BtnTaxiLicense.Location = new System.Drawing.Point(246, 378);
            this.BtnTaxiLicense.Name = "BtnTaxiLicense";
            this.BtnTaxiLicense.Size = new System.Drawing.Size(69, 42);
            this.BtnTaxiLicense.TabIndex = 46;
            this.BtnTaxiLicense.Text = "Taxi License";
            this.BtnTaxiLicense.UseVisualStyleBackColor = true;
            this.BtnTaxiLicense.Click += new System.EventHandler(this.BtnTaxiLicense_Click);
            // 
            // TaxiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 432);
            this.Controls.Add(this.BtnTaxiLicense);
            this.Controls.Add(this.BtnPuspakom);
            this.Controls.Add(this.BtnInsurance);
            this.Controls.Add(this.BtnRoadTax);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.DDOwnerStatus);
            this.Controls.Add(this.DTRegDate);
            this.Controls.Add(this.DDBodyType);
            this.Controls.Add(this.DDClass);
            this.Controls.Add(this.DDColour);
            this.Controls.Add(this.DDFuel);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.DDModel);
            this.Controls.Add(this.DDMake);
            this.Controls.Add(this.TxtComNo);
            this.Controls.Add(this.TxtRate12);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TxtSeatNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TxtRate6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TxtYearMade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TxtHP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtCasisNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtEngineNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtRegNo);
            this.Controls.Add(this.label1);
            this.Name = "TaxiForm";
            this.Text = "Taxi";
            this.Load += new System.EventHandler(this.TaxiForm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.TaxiForm_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.carmadeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxi_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mademodelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fueltypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coloursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bodytypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerstatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRegNo;
        private System.Windows.Forms.TextBox TxtOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtEngineNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCasisNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtHP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtYearMade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtRate6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtSeatNo;
        private System.Windows.Forms.TextBox TxtRate12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtComNo;
        private System.Windows.Forms.ComboBox DDMake;
        private System.Windows.Forms.ComboBox DDModel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox DDFuel;
        private System.Windows.Forms.ComboBox DDColour;
        private System.Windows.Forms.ComboBox DDClass;
        private System.Windows.Forms.ComboBox DDBodyType;
        private System.Windows.Forms.DateTimePicker DTRegDate;
        private System.Windows.Forms.ComboBox DDOwnerStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnCancel;
        private taxi_managementDataSet taxi_managementDataSet;
        private System.Windows.Forms.BindingSource carmadeBindingSource;
        private taxi_managementDataSetTableAdapters.car_madeTableAdapter car_madeTableAdapter;
        private System.Windows.Forms.BindingSource fueltypeBindingSource;
        private taxi_managementDataSetTableAdapters.fuel_typeTableAdapter fuel_typeTableAdapter;
        private System.Windows.Forms.BindingSource coloursBindingSource;
        private taxi_managementDataSetTableAdapters.coloursTableAdapter coloursTableAdapter;
        private System.Windows.Forms.BindingSource classtypeBindingSource;
        private System.Windows.Forms.BindingSource bodytypeBindingSource;
        private taxi_managementDataSetTableAdapters.body_typeTableAdapter body_typeTableAdapter;
        private System.Windows.Forms.BindingSource ownerstatusBindingSource;
        private taxi_managementDataSetTableAdapters.owner_statusTableAdapter owner_statusTableAdapter;
        private System.Windows.Forms.ErrorProvider Err;
        private taxi_managementDataSetTableAdapters.class_typeTableAdapter class_typeTableAdapter;
        private System.Windows.Forms.BindingSource mademodelBindingSource;
        private taxi_managementDataSetTableAdapters.made_modelTableAdapter made_modelTableAdapter;
        private System.Windows.Forms.Button BtnTaxiLicense;
        private System.Windows.Forms.Button BtnPuspakom;
        private System.Windows.Forms.Button BtnInsurance;
        private System.Windows.Forms.Button BtnRoadTax;
    }
}