
namespace Parcial_1
{
    partial class Form1
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
            this.Btn_ConvertirConversores = new System.Windows.Forms.Button();
            this.LblCantidadConversores = new System.Windows.Forms.Label();
            this.lblAConvertir = new System.Windows.Forms.Label();
            this.lblConvertir = new System.Windows.Forms.Label();
            this.lblTipoConvertir = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.Cbo_A_Convertir = new System.Windows.Forms.ComboBox();
            this.Cbo_Lo_Que_Quiere_Convertir = new System.Windows.Forms.ComboBox();
            this.Cbo_Tipo_Conversor = new System.Windows.Forms.ComboBox();
            this.Lbl_Respuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ConvertirConversores
            // 
            this.Btn_ConvertirConversores.Location = new System.Drawing.Point(356, 286);
            this.Btn_ConvertirConversores.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ConvertirConversores.Name = "Btn_ConvertirConversores";
            this.Btn_ConvertirConversores.Size = new System.Drawing.Size(99, 37);
            this.Btn_ConvertirConversores.TabIndex = 27;
            this.Btn_ConvertirConversores.Text = "Convertir";
            this.Btn_ConvertirConversores.UseVisualStyleBackColor = true;
            this.Btn_ConvertirConversores.Click += new System.EventHandler(this.Btn_ConvertirConversores_Click);
            // 
            // LblCantidadConversores
            // 
            this.LblCantidadConversores.AutoSize = true;
            this.LblCantidadConversores.Location = new System.Drawing.Point(324, 222);
            this.LblCantidadConversores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadConversores.Name = "LblCantidadConversores";
            this.LblCantidadConversores.Size = new System.Drawing.Size(170, 13);
            this.LblCantidadConversores.TabIndex = 26;
            this.LblCantidadConversores.Text = "CANTIDAD QUE QUIERA MEDIR";
            // 
            // lblAConvertir
            // 
            this.lblAConvertir.AutoSize = true;
            this.lblAConvertir.Location = new System.Drawing.Point(463, 138);
            this.lblAConvertir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAConvertir.Name = "lblAConvertir";
            this.lblAConvertir.Size = new System.Drawing.Size(163, 13);
            this.lblAConvertir.TabIndex = 25;
            this.lblAConvertir.Text = "A LO QUE QUIERE CONERTIR:";
            // 
            // lblConvertir
            // 
            this.lblConvertir.AutoSize = true;
            this.lblConvertir.Location = new System.Drawing.Point(174, 147);
            this.lblConvertir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConvertir.Name = "lblConvertir";
            this.lblConvertir.Size = new System.Drawing.Size(155, 13);
            this.lblConvertir.TabIndex = 24;
            this.lblConvertir.Text = "LO QUE DESEA CONVERTIR:";
            // 
            // lblTipoConvertir
            // 
            this.lblTipoConvertir.AutoSize = true;
            this.lblTipoConvertir.Location = new System.Drawing.Point(292, 84);
            this.lblTipoConvertir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoConvertir.Name = "lblTipoConvertir";
            this.lblTipoConvertir.Size = new System.Drawing.Size(31, 13);
            this.lblTipoConvertir.TabIndex = 23;
            this.lblTipoConvertir.Text = "Tipo:";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(381, 250);
            this.txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(50, 20);
            this.txt_Cantidad.TabIndex = 22;
            // 
            // Cbo_A_Convertir
            // 
            this.Cbo_A_Convertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_A_Convertir.FormattingEnabled = true;
            this.Cbo_A_Convertir.Location = new System.Drawing.Point(466, 162);
            this.Cbo_A_Convertir.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_A_Convertir.Name = "Cbo_A_Convertir";
            this.Cbo_A_Convertir.Size = new System.Drawing.Size(156, 21);
            this.Cbo_A_Convertir.TabIndex = 21;
            // 
            // Cbo_Lo_Que_Quiere_Convertir
            // 
            this.Cbo_Lo_Que_Quiere_Convertir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Lo_Que_Quiere_Convertir.FormattingEnabled = true;
            this.Cbo_Lo_Que_Quiere_Convertir.Location = new System.Drawing.Point(177, 162);
            this.Cbo_Lo_Que_Quiere_Convertir.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Lo_Que_Quiere_Convertir.Name = "Cbo_Lo_Que_Quiere_Convertir";
            this.Cbo_Lo_Que_Quiere_Convertir.Size = new System.Drawing.Size(156, 21);
            this.Cbo_Lo_Que_Quiere_Convertir.TabIndex = 20;
            // 
            // Cbo_Tipo_Conversor
            // 
            this.Cbo_Tipo_Conversor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Tipo_Conversor.FormattingEnabled = true;
            this.Cbo_Tipo_Conversor.Items.AddRange(new object[] {
            "Area"});
            this.Cbo_Tipo_Conversor.Location = new System.Drawing.Point(327, 84);
            this.Cbo_Tipo_Conversor.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_Tipo_Conversor.Name = "Cbo_Tipo_Conversor";
            this.Cbo_Tipo_Conversor.Size = new System.Drawing.Size(156, 21);
            this.Cbo_Tipo_Conversor.TabIndex = 19;
            this.Cbo_Tipo_Conversor.TextChanged += new System.EventHandler(this.CboTipoConversor_TextChanged);
            // 
            // Lbl_Respuesta
            // 
            this.Lbl_Respuesta.AutoSize = true;
            this.Lbl_Respuesta.Location = new System.Drawing.Point(368, 353);
            this.Lbl_Respuesta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Respuesta.Name = "Lbl_Respuesta";
            this.Lbl_Respuesta.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Respuesta.TabIndex = 18;
            this.Lbl_Respuesta.Text = "RESPUESTA: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_ConvertirConversores);
            this.Controls.Add(this.LblCantidadConversores);
            this.Controls.Add(this.lblAConvertir);
            this.Controls.Add(this.lblConvertir);
            this.Controls.Add(this.lblTipoConvertir);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.Cbo_A_Convertir);
            this.Controls.Add(this.Cbo_Lo_Que_Quiere_Convertir);
            this.Controls.Add(this.Cbo_Tipo_Conversor);
            this.Controls.Add(this.Lbl_Respuesta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ConvertirConversores;
        private System.Windows.Forms.Label LblCantidadConversores;
        private System.Windows.Forms.Label lblAConvertir;
        private System.Windows.Forms.Label lblConvertir;
        private System.Windows.Forms.Label lblTipoConvertir;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.ComboBox Cbo_A_Convertir;
        private System.Windows.Forms.ComboBox Cbo_Lo_Que_Quiere_Convertir;
        private System.Windows.Forms.ComboBox Cbo_Tipo_Conversor;
        private System.Windows.Forms.Label Lbl_Respuesta;
    }
}

