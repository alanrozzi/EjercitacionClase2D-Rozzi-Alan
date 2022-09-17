namespace FormsAero
{
    partial class FrmMenu
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.dtgMenuPrincipal = new System.Windows.Forms.DataGridView();
            this.btnVuelosDisponibles = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenuPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 9);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(34, 15);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "texto";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(693, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // dtgMenuPrincipal
            // 
            this.dtgMenuPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMenuPrincipal.Location = new System.Drawing.Point(21, 49);
            this.dtgMenuPrincipal.Name = "dtgMenuPrincipal";
            this.dtgMenuPrincipal.RowTemplate.Height = 25;
            this.dtgMenuPrincipal.Size = new System.Drawing.Size(485, 223);
            this.dtgMenuPrincipal.TabIndex = 2;
            // 
            // btnVuelosDisponibles
            // 
            this.btnVuelosDisponibles.Location = new System.Drawing.Point(597, 49);
            this.btnVuelosDisponibles.Name = "btnVuelosDisponibles";
            this.btnVuelosDisponibles.Size = new System.Drawing.Size(141, 33);
            this.btnVuelosDisponibles.TabIndex = 3;
            this.btnVuelosDisponibles.Text = "Vuelos disponibles";
            this.btnVuelosDisponibles.UseVisualStyleBackColor = true;
            this.btnVuelosDisponibles.Click += new System.EventHandler(this.btnVuelosDisponibles_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(597, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 33);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(597, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 33);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 438);
            this.ControlBox = false;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVuelosDisponibles);
            this.Controls.Add(this.dtgMenuPrincipal);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblNombreUsuario);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            ((System.ComponentModel.ISupportInitialize)(this.dtgMenuPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNombreUsuario;
        private Button btnLogOut;
        private DataGridView dtgMenuPrincipal;
        private Button btnVuelosDisponibles;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}