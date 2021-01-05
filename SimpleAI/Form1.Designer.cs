namespace SimpleAI
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mapView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.goToSelectedBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mapView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(512, 512);
            this.panel1.TabIndex = 0;
            // 
            // mapView
            // 
            this.mapView.AllowUserToAddRows = false;
            this.mapView.AllowUserToDeleteRows = false;
            this.mapView.AllowUserToResizeColumns = false;
            this.mapView.AllowUserToResizeRows = false;
            this.mapView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mapView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mapView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mapView.ColumnHeadersVisible = false;
            this.mapView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mapView.Location = new System.Drawing.Point(0, 0);
            this.mapView.Margin = new System.Windows.Forms.Padding(0);
            this.mapView.Name = "mapView";
            this.mapView.RowHeadersVisible = false;
            this.mapView.RowHeadersWidth = 18;
            this.mapView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mapView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mapView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.mapView.Size = new System.Drawing.Size(512, 512);
            this.mapView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.goToSelectedBtn);
            this.groupBox1.Location = new System.Drawing.Point(527, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 519);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // goToSelectedBtn
            // 
            this.goToSelectedBtn.Location = new System.Drawing.Point(6, 19);
            this.goToSelectedBtn.Name = "goToSelectedBtn";
            this.goToSelectedBtn.Size = new System.Drawing.Size(239, 23);
            this.goToSelectedBtn.TabIndex = 0;
            this.goToSelectedBtn.Text = "GoToSelected";
            this.goToSelectedBtn.UseVisualStyleBackColor = true;
            this.goToSelectedBtn.Click += new System.EventHandler(this.goToSelectedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 535);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView mapView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button goToSelectedBtn;
    }
}

