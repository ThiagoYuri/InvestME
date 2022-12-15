namespace InvestME.Manager.Forms
{
    partial class FormMain
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
            this.btnImportFile = new System.Windows.Forms.Button();
            this.btnOpenPowerBI = new System.Windows.Forms.Button();
            this.lblCountData = new System.Windows.Forms.Label();
            this.lblCountLotes = new System.Windows.Forms.Label();
            this.lblFirstDateLote = new System.Windows.Forms.Label();
            this.lblLastDateLote = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnImportFile
            // 
            this.btnImportFile.Location = new System.Drawing.Point(23, 144);
            this.btnImportFile.Name = "btnImportFile";
            this.btnImportFile.Size = new System.Drawing.Size(466, 43);
            this.btnImportFile.TabIndex = 0;
            this.btnImportFile.Text = "Importa dados";
            this.btnImportFile.UseVisualStyleBackColor = true;
            this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
            // 
            // btnOpenPowerBI
            // 
            this.btnOpenPowerBI.Location = new System.Drawing.Point(23, 250);
            this.btnOpenPowerBI.Name = "btnOpenPowerBI";
            this.btnOpenPowerBI.Size = new System.Drawing.Size(466, 43);
            this.btnOpenPowerBI.TabIndex = 0;
            this.btnOpenPowerBI.Text = "Abrir PowerBI";
            this.btnOpenPowerBI.UseVisualStyleBackColor = true;
            this.btnOpenPowerBI.Click += new System.EventHandler(this.btnOpenPowerBI_Click);
            // 
            // lblCountData
            // 
            this.lblCountData.Location = new System.Drawing.Point(23, 41);
            this.lblCountData.Name = "lblCountData";
            this.lblCountData.Size = new System.Drawing.Size(225, 25);
            this.lblCountData.TabIndex = 1;
            this.lblCountData.Text = "Qtd de dados:";
            // 
            // lblCountLotes
            // 
            this.lblCountLotes.Location = new System.Drawing.Point(23, 88);
            this.lblCountLotes.Name = "lblCountLotes";
            this.lblCountLotes.Size = new System.Drawing.Size(225, 25);
            this.lblCountLotes.TabIndex = 1;
            this.lblCountLotes.Text = "Qtd lotes:";
            // 
            // lblFirstDateLote
            // 
            this.lblFirstDateLote.Location = new System.Drawing.Point(264, 41);
            this.lblFirstDateLote.Name = "lblFirstDateLote";
            this.lblFirstDateLote.Size = new System.Drawing.Size(225, 25);
            this.lblFirstDateLote.TabIndex = 1;
            this.lblFirstDateLote.Text = "Primeiro lote:";
            // 
            // lblLastDateLote
            // 
            this.lblLastDateLote.Location = new System.Drawing.Point(264, 88);
            this.lblLastDateLote.Name = "lblLastDateLote";
            this.lblLastDateLote.Size = new System.Drawing.Size(225, 25);
            this.lblLastDateLote.TabIndex = 1;
            this.lblLastDateLote.Text = "Ultimo lote:";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Filter files (*.xls)|*.xls|(*.xlsx)|*.xlsx";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar meus investimentos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnAddInvest_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 305);
            this.Controls.Add(this.lblLastDateLote);
            this.Controls.Add(this.lblFirstDateLote);
            this.Controls.Add(this.lblCountLotes);
            this.Controls.Add(this.lblCountData);
            this.Controls.Add(this.btnOpenPowerBI);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnImportFile);
            this.Name = "FormMain";
            this.Text = "InvestME";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnImportFile;
        private Button btnOpenPowerBI;
        private Label lblCountData;
        private Label lblCountLotes;
        private Label lblFirstDateLote;
        private Label lblLastDateLote;
        private OpenFileDialog openFileDialog;
        private Button button1;
    }
}