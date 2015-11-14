﻿namespace lw_common.ui {
    partial class edit_log_settings_form {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_log_settings_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.typeTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fileTypeTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.syntax = new System.Windows.Forms.Label();
            this.editSyntax = new System.Windows.Forms.Button();
            this.ifLine = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.partSeparator = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.xmlDelimeter = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.csvHasHeader = new System.Windows.Forms.CheckBox();
            this.csvSeparator = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.friendlyName = new System.Windows.Forms.TextBox();
            this.tip = new System.Windows.Forms.ToolTip(this.components);
            this.needsRestart = new System.Windows.Forms.Label();
            this.checkRequiresRestart = new System.Windows.Forms.Timer(this.components);
            this.syntaxLink = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.typeTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.fileTypeTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.typeTab);
            this.panel1.Location = new System.Drawing.Point(-3, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 386);
            this.panel1.TabIndex = 0;
            // 
            // typeTab
            // 
            this.typeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeTab.Controls.Add(this.tabPage1);
            this.typeTab.Controls.Add(this.tabPage2);
            this.typeTab.Controls.Add(this.tabPage7);
            this.typeTab.Controls.Add(this.tabPage8);
            this.typeTab.Controls.Add(this.tabPage9);
            this.typeTab.Location = new System.Drawing.Point(1, 3);
            this.typeTab.Name = "typeTab";
            this.typeTab.SelectedIndex = 0;
            this.typeTab.Size = new System.Drawing.Size(603, 387);
            this.typeTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fileType);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(595, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // fileType
            // 
            this.fileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fileType.FormattingEnabled = true;
            this.fileType.Items.AddRange(new object[] {
            "Best Guess",
            "Line-By-Line",
            "Part-Per-Line",
            "XML",
            "CSV"});
            this.fileType.Location = new System.Drawing.Point(73, 7);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(211, 24);
            this.fileType.TabIndex = 7;
            this.fileType.SelectedIndexChanged += new System.EventHandler(this.fileType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Type";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.fileTypeTab);
            this.panel2.Location = new System.Drawing.Point(2, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(595, 309);
            this.panel2.TabIndex = 0;
            // 
            // fileTypeTab
            // 
            this.fileTypeTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTypeTab.Controls.Add(this.tabPage3);
            this.fileTypeTab.Controls.Add(this.tabPage4);
            this.fileTypeTab.Controls.Add(this.tabPage5);
            this.fileTypeTab.Controls.Add(this.tabPage6);
            this.fileTypeTab.Location = new System.Drawing.Point(-5, 0);
            this.fileTypeTab.Name = "fileTypeTab";
            this.fileTypeTab.SelectedIndex = 0;
            this.fileTypeTab.Size = new System.Drawing.Size(617, 306);
            this.fileTypeTab.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.syntaxLink);
            this.tabPage3.Controls.Add(this.syntax);
            this.tabPage3.Controls.Add(this.editSyntax);
            this.tabPage3.Controls.Add(this.ifLine);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(609, 277);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // syntax
            // 
            this.syntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syntax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.syntax.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntax.Location = new System.Drawing.Point(60, 81);
            this.syntax.Name = "syntax";
            this.syntax.Size = new System.Drawing.Size(454, 60);
            this.syntax.TabIndex = 5;
            // 
            // editSyntax
            // 
            this.editSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editSyntax.Location = new System.Drawing.Point(521, 76);
            this.editSyntax.Name = "editSyntax";
            this.editSyntax.Size = new System.Drawing.Size(63, 27);
            this.editSyntax.TabIndex = 4;
            this.editSyntax.Text = "Edit";
            this.editSyntax.UseVisualStyleBackColor = true;
            this.editSyntax.Click += new System.EventHandler(this.editSyntax_Click);
            // 
            // ifLine
            // 
            this.ifLine.AutoSize = true;
            this.ifLine.Location = new System.Drawing.Point(60, 147);
            this.ifLine.Name = "ifLine";
            this.ifLine.Size = new System.Drawing.Size(400, 21);
            this.ifLine.TabIndex = 1;
            this.ifLine.Text = "If Line doesn\'t match syntax, consider it\'s from previous line";
            this.ifLine.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Line By Line";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.partSeparator);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(609, 277);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // partSeparator
            // 
            this.partSeparator.Location = new System.Drawing.Point(120, 83);
            this.partSeparator.Name = "partSeparator";
            this.partSeparator.Size = new System.Drawing.Size(31, 23);
            this.partSeparator.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Separator Char";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Part-Per-Line";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.xmlDelimeter);
            this.tabPage5.Controls.Add(this.label12);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(609, 277);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(347, 30);
            this.label13.TabIndex = 7;
            this.label13.Text = "This is the node that separates each log entry.\r\nIf not set, LogWizard will consi" +
    "der the first node as the delimeter.";
            // 
            // xmlDelimeter
            // 
            this.xmlDelimeter.Location = new System.Drawing.Point(185, 77);
            this.xmlDelimeter.Name = "xmlDelimeter";
            this.xmlDelimeter.Size = new System.Drawing.Size(224, 23);
            this.xmlDelimeter.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "XML Delimeter Node (opt)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "XML File";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.csvHasHeader);
            this.tabPage6.Controls.Add(this.csvSeparator);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(609, 277);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // csvHasHeader
            // 
            this.csvHasHeader.AutoSize = true;
            this.csvHasHeader.Location = new System.Drawing.Point(10, 115);
            this.csvHasHeader.Name = "csvHasHeader";
            this.csvHasHeader.Size = new System.Drawing.Size(267, 21);
            this.csvHasHeader.TabIndex = 5;
            this.csvHasHeader.Text = "First Line Contains the Column Names";
            this.csvHasHeader.UseVisualStyleBackColor = true;
            // 
            // csvSeparator
            // 
            this.csvSeparator.Location = new System.Drawing.Point(115, 86);
            this.csvSeparator.Name = "csvSeparator";
            this.csvSeparator.Size = new System.Drawing.Size(31, 23);
            this.csvSeparator.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 17);
            this.label11.TabIndex = 3;
            this.label11.Text = "Separator Char";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "CSV File";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(594, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Event Log Settings";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label15);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(594, 361);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "tabPage7";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Debug Print";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label16);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(594, 361);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "tabPage8";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(212, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "Database (Not implemented yet)";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.label17);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(594, 361);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "tabPage9";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(234, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Multiple Logs (Not implemented yet)";
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(7, 427);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(94, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Save Last ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(107, 425);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(213, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "sessions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Log Type";
            // 
            // type
            // 
            this.type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type.Enabled = false;
            this.type.FormattingEnabled = true;
            this.type.Items.AddRange(new object[] {
            "File",
            "Event Log",
            "Debug Print (OutputDebugString)",
            "Database",
            "Multiple"});
            this.type.Location = new System.Drawing.Point(72, 4);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(232, 24);
            this.type.TabIndex = 5;
            this.type.SelectedIndexChanged += new System.EventHandler(this.type_SelectedIndexChanged);
            // 
            // ok
            // 
            this.ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ok.Location = new System.Drawing.Point(534, 423);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(58, 26);
            this.ok.TabIndex = 6;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(291, 426);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(61, 26);
            this.cancel.TabIndex = 7;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Friendly name";
            this.tip.SetToolTip(this.label4, "Friendly Name (optional)\r\nIf you set this, it will show up in History");
            // 
            // friendlyName
            // 
            this.friendlyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.friendlyName.Location = new System.Drawing.Point(412, 5);
            this.friendlyName.Name = "friendlyName";
            this.friendlyName.Size = new System.Drawing.Size(176, 23);
            this.friendlyName.TabIndex = 9;
            // 
            // needsRestart
            // 
            this.needsRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.needsRestart.AutoSize = true;
            this.needsRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.needsRestart.ForeColor = System.Drawing.Color.Red;
            this.needsRestart.Location = new System.Drawing.Point(401, 428);
            this.needsRestart.Name = "needsRestart";
            this.needsRestart.Size = new System.Drawing.Size(131, 17);
            this.needsRestart.TabIndex = 10;
            this.needsRestart.Text = "Requires Restart";
            this.needsRestart.Visible = false;
            // 
            // checkRequiresRestart
            // 
            this.checkRequiresRestart.Enabled = true;
            this.checkRequiresRestart.Interval = 250;
            this.checkRequiresRestart.Tick += new System.EventHandler(this.checkRequiresRestart_Tick);
            // 
            // syntaxLink
            // 
            this.syntaxLink.AutoSize = true;
            this.syntaxLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.syntaxLink.Location = new System.Drawing.Point(0, 81);
            this.syntaxLink.Name = "syntaxLink";
            this.syntaxLink.Size = new System.Drawing.Size(50, 17);
            this.syntaxLink.TabIndex = 6;
            this.syntaxLink.TabStop = true;
            this.syntaxLink.Text = "Syntax";
            this.syntaxLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.syntaxLink_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 45);
            this.label6.TabIndex = 7;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(0, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(469, 45);
            this.label18.TabIndex = 8;
            this.label18.Text = "On these logs, a log entry spans multiple lines. Each line contains a part of the" +
    " log entry.\r\nEach line contains a \"NAME separator VALUE\" part. \r\nAn empty line s" +
    "ignals the end of the log entry.";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(0, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(162, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "This is your usual XML log.\r\nEach XML entry is a log entry.";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(0, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(532, 45);
            this.label20.TabIndex = 10;
            this.label20.Text = "This is a Comma-Separated-Values log.\r\nEach line contains a long entry, each part" +
    " is separated by the separator character (usually a comma).\r\nBy default, the fir" +
    "st line contains the Column Names.";
            // 
            // edit_log_settings_form
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(596, 451);
            this.Controls.Add(this.needsRestart);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.friendlyName);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "edit_log_settings_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Log Settings";
            this.panel1.ResumeLayout(false);
            this.typeTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.fileTypeTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl typeTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl fileTypeTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox friendlyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip tip;
        private System.Windows.Forms.Button editSyntax;
        private System.Windows.Forms.CheckBox ifLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox partSeparator;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox csvSeparator;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox xmlDelimeter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox csvHasHeader;
        private System.Windows.Forms.Label syntax;
        private System.Windows.Forms.Label needsRestart;
        private System.Windows.Forms.Timer checkRequiresRestart;
        private System.Windows.Forms.LinkLabel syntaxLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}