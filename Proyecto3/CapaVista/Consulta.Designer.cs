
namespace CapaVista
{
    partial class Consulta
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
            this.Dgv_registos = new System.Windows.Forms.DataGridView();
            this.bnt_Consulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registos)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_registos
            // 
            this.Dgv_registos.AllowUserToAddRows = false;
            this.Dgv_registos.AllowUserToDeleteRows = false;
            this.Dgv_registos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_registos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_registos.Location = new System.Drawing.Point(12, 142);
            this.Dgv_registos.Name = "Dgv_registos";
            this.Dgv_registos.ReadOnly = true;
            this.Dgv_registos.RowHeadersWidth = 51;
            this.Dgv_registos.RowTemplate.Height = 24;
            this.Dgv_registos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_registos.Size = new System.Drawing.Size(776, 288);
            this.Dgv_registos.TabIndex = 0;
            // 
            // bnt_Consulta
            // 
            this.bnt_Consulta.BackColor = System.Drawing.Color.Orange;
            this.bnt_Consulta.Location = new System.Drawing.Point(630, 26);
            this.bnt_Consulta.Name = "bnt_Consulta";
            this.bnt_Consulta.Size = new System.Drawing.Size(158, 63);
            this.bnt_Consulta.TabIndex = 1;
            this.bnt_Consulta.Text = "Consulta";
            this.bnt_Consulta.UseVisualStyleBackColor = false;
            this.bnt_Consulta.Click += new System.EventHandler(this.bnt_Consulta_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnt_Consulta);
            this.Controls.Add(this.Dgv_registos);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_registos;
        private System.Windows.Forms.Button bnt_Consulta;
    }
}