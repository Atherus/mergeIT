namespace MergeIT {
    partial class Form1 {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent() {
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRotatePlus = new System.Windows.Forms.Button();
            this.buttonRotateMinus = new System.Windows.Forms.Button();
            this.buttonDeleteFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.AllowDrop = true;
            this.listBoxFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(13, 13);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(354, 199);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxFiles_DragEnter);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.Location = new System.Drawing.Point(373, 12);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 25);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.Text = "Hore";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.Location = new System.Drawing.Point(373, 43);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(75, 25);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.Text = "Dole";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMerge.Location = new System.Drawing.Point(13, 218);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(75, 23);
            this.buttonMerge.TabIndex = 3;
            this.buttonMerge.Text = "Spojiť";
            this.buttonMerge.UseVisualStyleBackColor = true;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.AutoSize = true;
            this.labelVersion.Location = new System.Drawing.Point(388, 228);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(60, 13);
            this.labelVersion.TabIndex = 4;
            this.labelVersion.Text = "Version 0.2";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(373, 189);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Vyčistiť";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRotatePlus
            // 
            this.buttonRotatePlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRotatePlus.Location = new System.Drawing.Point(373, 74);
            this.buttonRotatePlus.Name = "buttonRotatePlus";
            this.buttonRotatePlus.Size = new System.Drawing.Size(75, 25);
            this.buttonRotatePlus.TabIndex = 6;
            this.buttonRotatePlus.Text = "+90°";
            this.buttonRotatePlus.UseVisualStyleBackColor = true;
            this.buttonRotatePlus.Click += new System.EventHandler(this.buttonRotatePlus_Click);
            // 
            // buttonRotateMinus
            // 
            this.buttonRotateMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRotateMinus.Location = new System.Drawing.Point(373, 105);
            this.buttonRotateMinus.Name = "buttonRotateMinus";
            this.buttonRotateMinus.Size = new System.Drawing.Size(75, 25);
            this.buttonRotateMinus.TabIndex = 7;
            this.buttonRotateMinus.Text = "-90°";
            this.buttonRotateMinus.UseVisualStyleBackColor = true;
            this.buttonRotateMinus.Click += new System.EventHandler(this.buttonRotateMinus_Click);
            // 
            // buttonDeleteFile
            // 
            this.buttonDeleteFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFile.Location = new System.Drawing.Point(373, 136);
            this.buttonDeleteFile.Name = "buttonDeleteFile";
            this.buttonDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteFile.TabIndex = 8;
            this.buttonDeleteFile.Text = "Odstrániť";
            this.buttonDeleteFile.UseVisualStyleBackColor = true;
            this.buttonDeleteFile.Click += new System.EventHandler(this.buttonDeleteFile_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 250);
            this.Controls.Add(this.buttonDeleteFile);
            this.Controls.Add(this.buttonRotateMinus);
            this.Controls.Add(this.buttonRotatePlus);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listBoxFiles);
            this.MinimumSize = new System.Drawing.Size(432, 285);
            this.Name = "Form1";
            this.Text = "MergeIT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonRotatePlus;
        private System.Windows.Forms.Button buttonRotateMinus;
        private System.Windows.Forms.Button buttonDeleteFile;
    }
}

