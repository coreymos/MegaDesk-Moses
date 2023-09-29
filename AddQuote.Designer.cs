namespace MegaDesk_Moses
{
    partial class AddQuote
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
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskWidthLabel = new System.Windows.Forms.Label();
            this.DeskDepthLabel = new System.Windows.Forms.Label();
            this.DeskWidthTextBox = new System.Windows.Forms.TextBox();
            this.DeskDepthTextBox = new System.Windows.Forms.TextBox();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.RushOrderLabel = new System.Windows.Forms.Label();
            this.DrawersComboBox = new System.Windows.Forms.ComboBox();
            this.MaterialComboBox = new System.Windows.Forms.ComboBox();
            this.RushOrderComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.QuoteDateLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(311, 67);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(180, 22);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(123, 64);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(160, 25);
            this.CustomerNameLabel.TabIndex = 1;
            this.CustomerNameLabel.Text = "Customer Name:";
            // 
            // DeskWidthLabel
            // 
            this.DeskWidthLabel.AutoSize = true;
            this.DeskWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthLabel.Location = new System.Drawing.Point(130, 120);
            this.DeskWidthLabel.Name = "DeskWidthLabel";
            this.DeskWidthLabel.Size = new System.Drawing.Size(153, 25);
            this.DeskWidthLabel.TabIndex = 2;
            this.DeskWidthLabel.Text = "Desk Width (in):";
            // 
            // DeskDepthLabel
            // 
            this.DeskDepthLabel.AutoSize = true;
            this.DeskDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskDepthLabel.Location = new System.Drawing.Point(129, 172);
            this.DeskDepthLabel.Name = "DeskDepthLabel";
            this.DeskDepthLabel.Size = new System.Drawing.Size(154, 25);
            this.DeskDepthLabel.TabIndex = 3;
            this.DeskDepthLabel.Text = "Desk Depth (in):";
            // 
            // DeskWidthTextBox
            // 
            this.DeskWidthTextBox.Location = new System.Drawing.Point(311, 123);
            this.DeskWidthTextBox.Name = "DeskWidthTextBox";
            this.DeskWidthTextBox.Size = new System.Drawing.Size(94, 22);
            this.DeskWidthTextBox.TabIndex = 4;
            this.DeskWidthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidthTextBox_KeyPress);
            this.DeskWidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthTextBox_Validating);
            // 
            // DeskDepthTextBox
            // 
            this.DeskDepthTextBox.Location = new System.Drawing.Point(311, 175);
            this.DeskDepthTextBox.Name = "DeskDepthTextBox";
            this.DeskDepthTextBox.Size = new System.Drawing.Size(94, 22);
            this.DeskDepthTextBox.TabIndex = 5;
            this.DeskDepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskDepthTextBox_KeyPress);
            this.DeskDepthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DeskDepthTextBox_Validating);
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(98, 226);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Size = new System.Drawing.Size(185, 25);
            this.DrawersLabel.TabIndex = 6;
            this.DrawersLabel.Text = "Number of Drawers:";
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.AutoSize = true;
            this.MaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaterialLabel.Location = new System.Drawing.Point(119, 279);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(164, 25);
            this.MaterialLabel.TabIndex = 7;
            this.MaterialLabel.Text = "Desktop Material:";
            // 
            // RushOrderLabel
            // 
            this.RushOrderLabel.AutoSize = true;
            this.RushOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushOrderLabel.Location = new System.Drawing.Point(98, 337);
            this.RushOrderLabel.Name = "RushOrderLabel";
            this.RushOrderLabel.Size = new System.Drawing.Size(182, 25);
            this.RushOrderLabel.TabIndex = 8;
            this.RushOrderLabel.Text = "Rush Order (Days):";
            // 
            // DrawersComboBox
            // 
            this.DrawersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawersComboBox.FormattingEnabled = true;
            this.DrawersComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersComboBox.Location = new System.Drawing.Point(311, 226);
            this.DrawersComboBox.Name = "DrawersComboBox";
            this.DrawersComboBox.Size = new System.Drawing.Size(121, 24);
            this.DrawersComboBox.TabIndex = 9;
            // 
            // MaterialComboBox
            // 
            this.MaterialComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaterialComboBox.FormattingEnabled = true;
            this.MaterialComboBox.Location = new System.Drawing.Point(311, 279);
            this.MaterialComboBox.Name = "MaterialComboBox";
            this.MaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.MaterialComboBox.TabIndex = 10;
            // 
            // RushOrderComboBox
            // 
            this.RushOrderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RushOrderComboBox.FormattingEnabled = true;
            this.RushOrderComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.RushOrderComboBox.Location = new System.Drawing.Point(311, 337);
            this.RushOrderComboBox.Name = "RushOrderComboBox";
            this.RushOrderComboBox.Size = new System.Drawing.Size(121, 24);
            this.RushOrderComboBox.TabIndex = 11;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.BackColor = System.Drawing.Color.Silver;
            this.MainMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuButton.Location = new System.Drawing.Point(111, 466);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(172, 64);
            this.MainMenuButton.TabIndex = 12;
            this.MainMenuButton.Text = "&Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = false;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.Silver;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(331, 466);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(172, 64);
            this.SubmitButton.TabIndex = 13;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // QuoteDateLabel
            // 
            this.QuoteDateLabel.AutoSize = true;
            this.QuoteDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDateLabel.Location = new System.Drawing.Point(165, 388);
            this.QuoteDateLabel.Name = "QuoteDateLabel";
            this.QuoteDateLabel.Size = new System.Drawing.Size(118, 25);
            this.QuoteDateLabel.TabIndex = 14;
            this.QuoteDateLabel.Text = "Quote Date:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(311, 388);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(119, 25);
            this.dateLabel.TabIndex = 15;
            this.dateLabel.Text = "todays_date";
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.QuoteDateLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.MainMenuButton);
            this.Controls.Add(this.RushOrderComboBox);
            this.Controls.Add(this.MaterialComboBox);
            this.Controls.Add(this.DrawersComboBox);
            this.Controls.Add(this.RushOrderLabel);
            this.Controls.Add(this.MaterialLabel);
            this.Controls.Add(this.DrawersLabel);
            this.Controls.Add(this.DeskDepthTextBox);
            this.Controls.Add(this.DeskWidthTextBox);
            this.Controls.Add(this.DeskDepthLabel);
            this.Controls.Add(this.DeskWidthLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerNameTextBox);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk: Add Quote";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskWidthLabel;
        private System.Windows.Forms.Label DeskDepthLabel;
        private System.Windows.Forms.TextBox DeskWidthTextBox;
        private System.Windows.Forms.TextBox DeskDepthTextBox;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.Label RushOrderLabel;
        private System.Windows.Forms.ComboBox DrawersComboBox;
        private System.Windows.Forms.ComboBox MaterialComboBox;
        private System.Windows.Forms.ComboBox RushOrderComboBox;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label QuoteDateLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
    }
}