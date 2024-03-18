
namespace ControlCondominio
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
            this.BtnLimpiarPropietario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDpi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNoCasa = new System.Windows.Forms.TextBox();
            this.textBoxCuota = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxDpiDueño = new System.Windows.Forms.ComboBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Registrar_Propietarios = new System.Windows.Forms.Button();
            this.Reistro_Propiedades = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiarPropietario
            // 
            this.BtnLimpiarPropietario.Location = new System.Drawing.Point(154, 310);
            this.BtnLimpiarPropietario.Name = "BtnLimpiarPropietario";
            this.BtnLimpiarPropietario.Size = new System.Drawing.Size(94, 23);
            this.BtnLimpiarPropietario.TabIndex = 0;
            this.BtnLimpiarPropietario.Text = "Limpiar";
            this.BtnLimpiarPropietario.UseVisualStyleBackColor = true;
            this.BtnLimpiarPropietario.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(85, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROPIETARIOS";
            // 
            // TxtDpi
            // 
            this.TxtDpi.Location = new System.Drawing.Point(97, 57);
            this.TxtDpi.Name = "TxtDpi";
            this.TxtDpi.Size = new System.Drawing.Size(132, 20);
            this.TxtDpi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DPI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(97, 106);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(132, 20);
            this.TxtApellido.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(23, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. De Casa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkRed;
            this.label6.Location = new System.Drawing.Point(85, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "PROPIEDADES";
            // 
            // textBoxNoCasa
            // 
            this.textBoxNoCasa.Location = new System.Drawing.Point(116, 216);
            this.textBoxNoCasa.Name = "textBoxNoCasa";
            this.textBoxNoCasa.Size = new System.Drawing.Size(132, 20);
            this.textBoxNoCasa.TabIndex = 10;
            // 
            // textBoxCuota
            // 
            this.textBoxCuota.Location = new System.Drawing.Point(116, 269);
            this.textBoxCuota.Name = "textBoxCuota";
            this.textBoxCuota.Size = new System.Drawing.Size(132, 20);
            this.textBoxCuota.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(23, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Mantenimiento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(23, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "DPI del Pripietario:";
            // 
            // comboBoxDpiDueño
            // 
            this.comboBoxDpiDueño.FormattingEnabled = true;
            this.comboBoxDpiDueño.Location = new System.Drawing.Point(116, 242);
            this.comboBoxDpiDueño.Name = "comboBoxDpiDueño";
            this.comboBoxDpiDueño.Size = new System.Drawing.Size(132, 21);
            this.comboBoxDpiDueño.TabIndex = 15;
            this.comboBoxDpiDueño.SelectedIndexChanged += new System.EventHandler(this.comboBoxDpiDueño_SelectedIndexChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(97, 83);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(132, 20);
            this.TxtNombre.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registrar_Propietarios
            // 
            this.Registrar_Propietarios.Location = new System.Drawing.Point(97, 150);
            this.Registrar_Propietarios.Name = "Registrar_Propietarios";
            this.Registrar_Propietarios.Size = new System.Drawing.Size(106, 23);
            this.Registrar_Propietarios.TabIndex = 19;
            this.Registrar_Propietarios.Text = "Registrar Dueño";
            this.Registrar_Propietarios.UseVisualStyleBackColor = true;
            this.Registrar_Propietarios.Click += new System.EventHandler(this.button4_Click);
            // 
            // Reistro_Propiedades
            // 
            this.Reistro_Propiedades.Location = new System.Drawing.Point(2, 310);
            this.Reistro_Propiedades.Name = "Reistro_Propiedades";
            this.Reistro_Propiedades.Size = new System.Drawing.Size(146, 23);
            this.Reistro_Propiedades.TabIndex = 20;
            this.Reistro_Propiedades.Text = "Registrar Propietario";
            this.Reistro_Propiedades.UseVisualStyleBackColor = true;
            this.Reistro_Propiedades.Click += new System.EventHandler(this.Reistro_Propietrarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(261, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(261, 191);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(430, 150);
            this.dataGridView2.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(716, 390);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Reistro_Propiedades);
            this.Controls.Add(this.Registrar_Propietarios);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.comboBoxDpiDueño);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCuota);
            this.Controls.Add(this.textBoxNoCasa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDpi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiarPropietario);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiarPropietario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDpi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxNoCasa;
        private System.Windows.Forms.TextBox textBoxCuota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxDpiDueño;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Registrar_Propietarios;
        private System.Windows.Forms.Button Reistro_Propiedades;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

