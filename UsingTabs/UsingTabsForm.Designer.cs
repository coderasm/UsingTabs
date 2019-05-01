namespace UsingTabs
{
   partial class UsingTabsForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
      this.displayLabel = new System.Windows.Forms.Label();
      this.textOptionsTabControl = new System.Windows.Forms.TabControl();
      this.colorTabPage = new System.Windows.Forms.TabPage();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.greenRadioButton = new System.Windows.Forms.RadioButton();
      this.redRadioButton = new System.Windows.Forms.RadioButton();
      this.blackRadioButton = new System.Windows.Forms.RadioButton();
      this.sizeTabPage = new System.Windows.Forms.TabPage();
      this.radioButton6 = new System.Windows.Forms.RadioButton();
      this.radioButton5 = new System.Windows.Forms.RadioButton();
      this.radioButton4 = new System.Windows.Forms.RadioButton();
      this.size20RadioButton = new System.Windows.Forms.RadioButton();
      this.size16RadioButton = new System.Windows.Forms.RadioButton();
      this.size12RadioButton = new System.Windows.Forms.RadioButton();
      this.messageTabPage = new System.Windows.Forms.TabPage();
      this.radioButton10 = new System.Windows.Forms.RadioButton();
      this.radioButton9 = new System.Windows.Forms.RadioButton();
      this.radioButton8 = new System.Windows.Forms.RadioButton();
      this.radioButton7 = new System.Windows.Forms.RadioButton();
      this.goodbyeRadioButton = new System.Windows.Forms.RadioButton();
      this.helloRadioButton = new System.Windows.Forms.RadioButton();
      this.aboutTabPage = new System.Windows.Forms.TabPage();
      this.messageLabel = new System.Windows.Forms.Label();
      this.fontTabPage = new System.Windows.Forms.TabPage();
      this.label3 = new System.Windows.Forms.Label();
      this.familyBox = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.styleBox = new System.Windows.Forms.ComboBox();
      this.processTabPage = new System.Windows.Forms.TabPage();
      this.reverseCheck = new System.Windows.Forms.CheckBox();
      this.lowerCaseRadio = new System.Windows.Forms.RadioButton();
      this.upperCaseRadio = new System.Windows.Forms.RadioButton();
      this.lengthLabel = new System.Windows.Forms.Label();
      this.lengthValueLabel = new System.Windows.Forms.Label();
      this.capitalizeRadio = new System.Windows.Forms.RadioButton();
      this.textOptionsTabControl.SuspendLayout();
      this.colorTabPage.SuspendLayout();
      this.sizeTabPage.SuspendLayout();
      this.messageTabPage.SuspendLayout();
      this.aboutTabPage.SuspendLayout();
      this.fontTabPage.SuspendLayout();
      this.processTabPage.SuspendLayout();
      this.SuspendLayout();
      // 
      // displayLabel
      // 
      this.displayLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.displayLabel.Location = new System.Drawing.Point(42, 127);
      this.displayLabel.Name = "displayLabel";
      this.displayLabel.Size = new System.Drawing.Size(240, 42);
      this.displayLabel.TabIndex = 7;
      this.displayLabel.Text = "Hello!";
      this.displayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textOptionsTabControl
      // 
      this.textOptionsTabControl.Controls.Add(this.colorTabPage);
      this.textOptionsTabControl.Controls.Add(this.sizeTabPage);
      this.textOptionsTabControl.Controls.Add(this.messageTabPage);
      this.textOptionsTabControl.Controls.Add(this.fontTabPage);
      this.textOptionsTabControl.Controls.Add(this.processTabPage);
      this.textOptionsTabControl.Controls.Add(this.aboutTabPage);
      this.textOptionsTabControl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textOptionsTabControl.Location = new System.Drawing.Point(12, 12);
      this.textOptionsTabControl.Name = "textOptionsTabControl";
      this.textOptionsTabControl.SelectedIndex = 0;
      this.textOptionsTabControl.Size = new System.Drawing.Size(309, 114);
      this.textOptionsTabControl.TabIndex = 6;
      // 
      // colorTabPage
      // 
      this.colorTabPage.Controls.Add(this.radioButton3);
      this.colorTabPage.Controls.Add(this.radioButton2);
      this.colorTabPage.Controls.Add(this.radioButton1);
      this.colorTabPage.Controls.Add(this.greenRadioButton);
      this.colorTabPage.Controls.Add(this.redRadioButton);
      this.colorTabPage.Controls.Add(this.blackRadioButton);
      this.colorTabPage.Location = new System.Drawing.Point(4, 24);
      this.colorTabPage.Name = "colorTabPage";
      this.colorTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.colorTabPage.Size = new System.Drawing.Size(301, 86);
      this.colorTabPage.TabIndex = 0;
      this.colorTabPage.Text = "Color";
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton3.Location = new System.Drawing.Point(75, 56);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(64, 19);
      this.radioButton3.TabIndex = 5;
      this.radioButton3.Text = "Orange";
      this.radioButton3.CheckedChanged += new System.EventHandler(this.orangeRadioButton_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton2.Location = new System.Drawing.Point(75, 31);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(59, 19);
      this.radioButton2.TabIndex = 4;
      this.radioButton2.Text = "Yellow";
      this.radioButton2.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton1.Location = new System.Drawing.Point(75, 6);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(48, 19);
      this.radioButton1.TabIndex = 3;
      this.radioButton1.Text = "Blue";
      this.radioButton1.CheckedChanged += new System.EventHandler(this.blueRadioButton_CheckedChanged);
      // 
      // greenRadioButton
      // 
      this.greenRadioButton.AutoSize = true;
      this.greenRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.greenRadioButton.Location = new System.Drawing.Point(6, 56);
      this.greenRadioButton.Name = "greenRadioButton";
      this.greenRadioButton.Size = new System.Drawing.Size(56, 19);
      this.greenRadioButton.TabIndex = 2;
      this.greenRadioButton.Text = "Green";
      this.greenRadioButton.CheckedChanged += new System.EventHandler(this.greenRadioButton_CheckedChanged);
      // 
      // redRadioButton
      // 
      this.redRadioButton.AutoSize = true;
      this.redRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.redRadioButton.Location = new System.Drawing.Point(6, 31);
      this.redRadioButton.Name = "redRadioButton";
      this.redRadioButton.Size = new System.Drawing.Size(45, 19);
      this.redRadioButton.TabIndex = 1;
      this.redRadioButton.Text = "Red";
      this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
      // 
      // blackRadioButton
      // 
      this.blackRadioButton.AutoSize = true;
      this.blackRadioButton.Checked = true;
      this.blackRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.blackRadioButton.Location = new System.Drawing.Point(6, 6);
      this.blackRadioButton.Name = "blackRadioButton";
      this.blackRadioButton.Size = new System.Drawing.Size(53, 19);
      this.blackRadioButton.TabIndex = 0;
      this.blackRadioButton.TabStop = true;
      this.blackRadioButton.Text = "Black";
      this.blackRadioButton.CheckedChanged += new System.EventHandler(this.blackRadioButton_CheckedChanged);
      // 
      // sizeTabPage
      // 
      this.sizeTabPage.Controls.Add(this.radioButton6);
      this.sizeTabPage.Controls.Add(this.radioButton5);
      this.sizeTabPage.Controls.Add(this.radioButton4);
      this.sizeTabPage.Controls.Add(this.size20RadioButton);
      this.sizeTabPage.Controls.Add(this.size16RadioButton);
      this.sizeTabPage.Controls.Add(this.size12RadioButton);
      this.sizeTabPage.Location = new System.Drawing.Point(4, 24);
      this.sizeTabPage.Name = "sizeTabPage";
      this.sizeTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.sizeTabPage.Size = new System.Drawing.Size(301, 86);
      this.sizeTabPage.TabIndex = 1;
      this.sizeTabPage.Text = "Size";
      // 
      // radioButton6
      // 
      this.radioButton6.AutoSize = true;
      this.radioButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton6.Location = new System.Drawing.Point(80, 56);
      this.radioButton6.Name = "radioButton6";
      this.radioButton6.Size = new System.Drawing.Size(68, 19);
      this.radioButton6.TabIndex = 5;
      this.radioButton6.Text = "28 point";
      this.radioButton6.CheckedChanged += new System.EventHandler(this.size28RadioButton_CheckedChanged);
      // 
      // radioButton5
      // 
      this.radioButton5.AutoSize = true;
      this.radioButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton5.Location = new System.Drawing.Point(6, 6);
      this.radioButton5.Name = "radioButton5";
      this.radioButton5.Size = new System.Drawing.Size(62, 19);
      this.radioButton5.TabIndex = 4;
      this.radioButton5.Text = "8 point";
      this.radioButton5.CheckedChanged += new System.EventHandler(this.size8RadioButton_CheckedChanged);
      // 
      // radioButton4
      // 
      this.radioButton4.AutoSize = true;
      this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton4.Location = new System.Drawing.Point(80, 31);
      this.radioButton4.Name = "radioButton4";
      this.radioButton4.Size = new System.Drawing.Size(68, 19);
      this.radioButton4.TabIndex = 3;
      this.radioButton4.Text = "24 point";
      this.radioButton4.CheckedChanged += new System.EventHandler(this.size24RadioButton_CheckedChanged);
      // 
      // size20RadioButton
      // 
      this.size20RadioButton.AutoSize = true;
      this.size20RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.size20RadioButton.Location = new System.Drawing.Point(80, 6);
      this.size20RadioButton.Name = "size20RadioButton";
      this.size20RadioButton.Size = new System.Drawing.Size(68, 19);
      this.size20RadioButton.TabIndex = 2;
      this.size20RadioButton.Text = "20 point";
      this.size20RadioButton.CheckedChanged += new System.EventHandler(this.size20RadioButton_CheckedChanged);
      // 
      // size16RadioButton
      // 
      this.size16RadioButton.AutoSize = true;
      this.size16RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.size16RadioButton.Location = new System.Drawing.Point(6, 56);
      this.size16RadioButton.Name = "size16RadioButton";
      this.size16RadioButton.Size = new System.Drawing.Size(68, 19);
      this.size16RadioButton.TabIndex = 1;
      this.size16RadioButton.Text = "16 point";
      this.size16RadioButton.CheckedChanged += new System.EventHandler(this.size16RadioButton_CheckedChanged);
      // 
      // size12RadioButton
      // 
      this.size12RadioButton.AutoSize = true;
      this.size12RadioButton.Checked = true;
      this.size12RadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.size12RadioButton.Location = new System.Drawing.Point(6, 31);
      this.size12RadioButton.Name = "size12RadioButton";
      this.size12RadioButton.Size = new System.Drawing.Size(68, 19);
      this.size12RadioButton.TabIndex = 0;
      this.size12RadioButton.TabStop = true;
      this.size12RadioButton.Text = "12 point";
      this.size12RadioButton.CheckedChanged += new System.EventHandler(this.size12RadioButton_CheckedChanged);
      // 
      // messageTabPage
      // 
      this.messageTabPage.Controls.Add(this.radioButton10);
      this.messageTabPage.Controls.Add(this.radioButton9);
      this.messageTabPage.Controls.Add(this.radioButton8);
      this.messageTabPage.Controls.Add(this.radioButton7);
      this.messageTabPage.Controls.Add(this.goodbyeRadioButton);
      this.messageTabPage.Controls.Add(this.helloRadioButton);
      this.messageTabPage.Location = new System.Drawing.Point(4, 24);
      this.messageTabPage.Name = "messageTabPage";
      this.messageTabPage.Size = new System.Drawing.Size(301, 86);
      this.messageTabPage.TabIndex = 2;
      this.messageTabPage.Text = "Message";
      // 
      // radioButton10
      // 
      this.radioButton10.AutoSize = true;
      this.radioButton10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton10.Location = new System.Drawing.Point(87, 56);
      this.radioButton10.Name = "radioButton10";
      this.radioButton10.Size = new System.Drawing.Size(85, 19);
      this.radioButton10.TabIndex = 7;
      this.radioButton10.Text = "Watch Out!";
      this.radioButton10.CheckedChanged += new System.EventHandler(this.watchOutRadioButton_CheckedChanged);
      // 
      // radioButton9
      // 
      this.radioButton9.AutoSize = true;
      this.radioButton9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton9.Location = new System.Drawing.Point(87, 31);
      this.radioButton9.Name = "radioButton9";
      this.radioButton9.Size = new System.Drawing.Size(70, 19);
      this.radioButton9.TabIndex = 6;
      this.radioButton9.Text = "Surprise!";
      this.radioButton9.CheckedChanged += new System.EventHandler(this.surpriseRadioButton_CheckedChanged);
      // 
      // radioButton8
      // 
      this.radioButton8.AutoSize = true;
      this.radioButton8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton8.Location = new System.Drawing.Point(87, 6);
      this.radioButton8.Name = "radioButton8";
      this.radioButton8.Size = new System.Drawing.Size(52, 19);
      this.radioButton8.TabIndex = 5;
      this.radioButton8.Text = "Wait!";
      this.radioButton8.CheckedChanged += new System.EventHandler(this.waitRadioButton_CheckedChanged);
      // 
      // radioButton7
      // 
      this.radioButton7.AutoSize = true;
      this.radioButton7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.radioButton7.Location = new System.Drawing.Point(6, 56);
      this.radioButton7.Name = "radioButton7";
      this.radioButton7.Size = new System.Drawing.Size(52, 19);
      this.radioButton7.TabIndex = 4;
      this.radioButton7.Text = "Stop!";
      this.radioButton7.CheckedChanged += new System.EventHandler(this.stopRadioButton_CheckedChanged);
      // 
      // goodbyeRadioButton
      // 
      this.goodbyeRadioButton.AutoSize = true;
      this.goodbyeRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.goodbyeRadioButton.Location = new System.Drawing.Point(6, 31);
      this.goodbyeRadioButton.Name = "goodbyeRadioButton";
      this.goodbyeRadioButton.Size = new System.Drawing.Size(76, 19);
      this.goodbyeRadioButton.TabIndex = 3;
      this.goodbyeRadioButton.Text = "Goodbye!";
      this.goodbyeRadioButton.CheckedChanged += new System.EventHandler(this.goodbyeRadioButton_CheckedChanged);
      // 
      // helloRadioButton
      // 
      this.helloRadioButton.AutoSize = true;
      this.helloRadioButton.Checked = true;
      this.helloRadioButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.helloRadioButton.Location = new System.Drawing.Point(6, 6);
      this.helloRadioButton.Name = "helloRadioButton";
      this.helloRadioButton.Size = new System.Drawing.Size(56, 19);
      this.helloRadioButton.TabIndex = 2;
      this.helloRadioButton.TabStop = true;
      this.helloRadioButton.Text = "Hello!";
      this.helloRadioButton.CheckedChanged += new System.EventHandler(this.helloRadioButton_CheckedChanged);
      // 
      // aboutTabPage
      // 
      this.aboutTabPage.Controls.Add(this.messageLabel);
      this.aboutTabPage.Location = new System.Drawing.Point(4, 24);
      this.aboutTabPage.Name = "aboutTabPage";
      this.aboutTabPage.Size = new System.Drawing.Size(301, 86);
      this.aboutTabPage.TabIndex = 3;
      this.aboutTabPage.Text = "About";
      // 
      // messageLabel
      // 
      this.messageLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.messageLabel.Location = new System.Drawing.Point(6, 6);
      this.messageLabel.Name = "messageLabel";
      this.messageLabel.Size = new System.Drawing.Size(227, 46);
      this.messageLabel.TabIndex = 0;
      this.messageLabel.Text = "Tabs are used to organize controls and conserve screen space.";
      // 
      // fontTabPage
      // 
      this.fontTabPage.Controls.Add(this.label3);
      this.fontTabPage.Controls.Add(this.familyBox);
      this.fontTabPage.Controls.Add(this.label1);
      this.fontTabPage.Controls.Add(this.styleBox);
      this.fontTabPage.Location = new System.Drawing.Point(4, 24);
      this.fontTabPage.Name = "fontTabPage";
      this.fontTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.fontTabPage.Size = new System.Drawing.Size(301, 86);
      this.fontTabPage.TabIndex = 4;
      this.fontTabPage.Text = "Font";
      this.fontTabPage.UseVisualStyleBackColor = true;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(168, 17);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(42, 15);
      this.label3.TabIndex = 5;
      this.label3.Text = "Family";
      // 
      // familyBox
      // 
      this.familyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.familyBox.FormattingEnabled = true;
      this.familyBox.Location = new System.Drawing.Point(147, 32);
      this.familyBox.Name = "familyBox";
      this.familyBox.Size = new System.Drawing.Size(99, 23);
      this.familyBox.TabIndex = 4;
      this.familyBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(48, 17);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Style";
      // 
      // styleBox
      // 
      this.styleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.styleBox.FormattingEnabled = true;
      this.styleBox.Location = new System.Drawing.Point(16, 32);
      this.styleBox.Name = "styleBox";
      this.styleBox.Size = new System.Drawing.Size(99, 23);
      this.styleBox.TabIndex = 0;
      this.styleBox.SelectedIndexChanged += new System.EventHandler(this.fontStyleChanged);
      // 
      // processTabPage
      // 
      this.processTabPage.Controls.Add(this.capitalizeRadio);
      this.processTabPage.Controls.Add(this.lengthValueLabel);
      this.processTabPage.Controls.Add(this.lengthLabel);
      this.processTabPage.Controls.Add(this.lowerCaseRadio);
      this.processTabPage.Controls.Add(this.upperCaseRadio);
      this.processTabPage.Controls.Add(this.reverseCheck);
      this.processTabPage.Location = new System.Drawing.Point(4, 24);
      this.processTabPage.Name = "processTabPage";
      this.processTabPage.Padding = new System.Windows.Forms.Padding(3);
      this.processTabPage.Size = new System.Drawing.Size(301, 86);
      this.processTabPage.TabIndex = 5;
      this.processTabPage.Text = "Process";
      this.processTabPage.UseVisualStyleBackColor = true;
      // 
      // reverseCheck
      // 
      this.reverseCheck.AutoSize = true;
      this.reverseCheck.Location = new System.Drawing.Point(6, 6);
      this.reverseCheck.Name = "reverseCheck";
      this.reverseCheck.Size = new System.Drawing.Size(66, 19);
      this.reverseCheck.TabIndex = 0;
      this.reverseCheck.Text = "Reverse";
      this.reverseCheck.UseVisualStyleBackColor = true;
      this.reverseCheck.CheckedChanged += new System.EventHandler(this.reverseChanged);
      // 
      // lowerCaseRadio
      // 
      this.lowerCaseRadio.AutoSize = true;
      this.lowerCaseRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lowerCaseRadio.Location = new System.Drawing.Point(92, 56);
      this.lowerCaseRadio.Name = "lowerCaseRadio";
      this.lowerCaseRadio.Size = new System.Drawing.Size(80, 19);
      this.lowerCaseRadio.TabIndex = 3;
      this.lowerCaseRadio.Text = "Lowercase";
      this.lowerCaseRadio.CheckedChanged += new System.EventHandler(this.lowerCaseChanged);
      // 
      // upperCaseRadio
      // 
      this.upperCaseRadio.AutoSize = true;
      this.upperCaseRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.upperCaseRadio.Location = new System.Drawing.Point(6, 56);
      this.upperCaseRadio.Name = "upperCaseRadio";
      this.upperCaseRadio.Size = new System.Drawing.Size(80, 19);
      this.upperCaseRadio.TabIndex = 2;
      this.upperCaseRadio.Text = "Uppercase";
      this.upperCaseRadio.CheckedChanged += new System.EventHandler(this.upperCaseChanged);
      // 
      // lengthLabel
      // 
      this.lengthLabel.AutoSize = true;
      this.lengthLabel.Location = new System.Drawing.Point(144, 7);
      this.lengthLabel.Name = "lengthLabel";
      this.lengthLabel.Size = new System.Drawing.Size(47, 15);
      this.lengthLabel.TabIndex = 4;
      this.lengthLabel.Text = "Length:";
      // 
      // lengthValueLabel
      // 
      this.lengthValueLabel.AutoSize = true;
      this.lengthValueLabel.Location = new System.Drawing.Point(191, 7);
      this.lengthValueLabel.Name = "lengthValueLabel";
      this.lengthValueLabel.Size = new System.Drawing.Size(13, 15);
      this.lengthValueLabel.TabIndex = 5;
      this.lengthValueLabel.Text = "6";
      // 
      // capitalizeRadio
      // 
      this.capitalizeRadio.AutoSize = true;
      this.capitalizeRadio.Checked = true;
      this.capitalizeRadio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.capitalizeRadio.Location = new System.Drawing.Point(6, 31);
      this.capitalizeRadio.Name = "capitalizeRadio";
      this.capitalizeRadio.Size = new System.Drawing.Size(76, 19);
      this.capitalizeRadio.TabIndex = 1;
      this.capitalizeRadio.Text = "Capitalize";
      this.capitalizeRadio.CheckedChanged += new System.EventHandler(this.capitalizedChanged);
      // 
      // UsingTabsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(333, 188);
      this.Controls.Add(this.displayLabel);
      this.Controls.Add(this.textOptionsTabControl);
      this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "UsingTabsForm";
      this.Text = "Using Tabs";
      this.textOptionsTabControl.ResumeLayout(false);
      this.colorTabPage.ResumeLayout(false);
      this.colorTabPage.PerformLayout();
      this.sizeTabPage.ResumeLayout(false);
      this.sizeTabPage.PerformLayout();
      this.messageTabPage.ResumeLayout(false);
      this.messageTabPage.PerformLayout();
      this.aboutTabPage.ResumeLayout(false);
      this.fontTabPage.ResumeLayout(false);
      this.fontTabPage.PerformLayout();
      this.processTabPage.ResumeLayout(false);
      this.processTabPage.PerformLayout();
      this.ResumeLayout(false);

      }

      #endregion

      internal System.Windows.Forms.Label displayLabel;
      internal System.Windows.Forms.TabControl textOptionsTabControl;
      internal System.Windows.Forms.TabPage colorTabPage;
      internal System.Windows.Forms.RadioButton greenRadioButton;
      internal System.Windows.Forms.RadioButton redRadioButton;
      internal System.Windows.Forms.RadioButton blackRadioButton;
      internal System.Windows.Forms.TabPage sizeTabPage;
      internal System.Windows.Forms.RadioButton size20RadioButton;
      internal System.Windows.Forms.RadioButton size16RadioButton;
      internal System.Windows.Forms.RadioButton size12RadioButton;
      internal System.Windows.Forms.TabPage messageTabPage;
      internal System.Windows.Forms.TabPage aboutTabPage;
      internal System.Windows.Forms.Label messageLabel;
      internal System.Windows.Forms.RadioButton goodbyeRadioButton;
      internal System.Windows.Forms.RadioButton helloRadioButton;
    internal System.Windows.Forms.RadioButton radioButton3;
    internal System.Windows.Forms.RadioButton radioButton2;
    internal System.Windows.Forms.RadioButton radioButton1;
    internal System.Windows.Forms.RadioButton radioButton6;
    internal System.Windows.Forms.RadioButton radioButton5;
    internal System.Windows.Forms.RadioButton radioButton4;
    internal System.Windows.Forms.RadioButton radioButton9;
    internal System.Windows.Forms.RadioButton radioButton8;
    internal System.Windows.Forms.RadioButton radioButton7;
    internal System.Windows.Forms.RadioButton radioButton10;
    private System.Windows.Forms.TabPage fontTabPage;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox styleBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox familyBox;
    private System.Windows.Forms.TabPage processTabPage;
    private System.Windows.Forms.CheckBox reverseCheck;
    internal System.Windows.Forms.RadioButton lowerCaseRadio;
    internal System.Windows.Forms.RadioButton upperCaseRadio;
    private System.Windows.Forms.Label lengthLabel;
    private System.Windows.Forms.Label lengthValueLabel;
    internal System.Windows.Forms.RadioButton capitalizeRadio;
  }
}

/**************************************************************************
 * (C) Copyright 1992-2011 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
