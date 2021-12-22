
namespace WinConvertDataSetToXml.UI
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlstrSalir = new System.Windows.Forms.ToolStripButton();
            this.tlstrTest = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlstrSalir,
            this.tlstrTest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(712, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlstrSalir
            // 
            this.tlstrSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrSalir.Image = ((System.Drawing.Image)(resources.GetObject("tlstrSalir.Image")));
            this.tlstrSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrSalir.Name = "tlstrSalir";
            this.tlstrSalir.Size = new System.Drawing.Size(23, 22);
            this.tlstrSalir.Text = "toolStripButton1";
            this.tlstrSalir.ToolTipText = "Salir";
            // 
            // tlstrTest
            // 
            this.tlstrTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlstrTest.Image = ((System.Drawing.Image)(resources.GetObject("tlstrTest.Image")));
            this.tlstrTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlstrTest.Name = "tlstrTest";
            this.tlstrTest.Size = new System.Drawing.Size(23, 22);
            this.tlstrTest.Text = "toolStripButton2";
            this.tlstrTest.ToolTipText = "Test";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(712, 406);
            this.textBox1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 436);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tlstrSalir;
        private System.Windows.Forms.ToolStripButton tlstrTest;
        private System.Windows.Forms.TextBox textBox1;
    }
}

