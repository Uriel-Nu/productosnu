
namespace winformproductos1
{
    partial class Formproductos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgprod = new System.Windows.Forms.DataGridView();
            this.btncargar = new System.Windows.Forms.Button();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtdescrip = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblstock = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblstockmov = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.rbegreso = new System.Windows.Forms.RadioButton();
            this.rbingreso = new System.Windows.Forms.RadioButton();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lbldescripmov = new System.Windows.Forms.Label();
            this.lblcodmov = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprod)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgprod);
            this.tabPage1.Controls.Add(this.btncargar);
            this.tabPage1.Controls.Add(this.txtstock);
            this.tabPage1.Controls.Add(this.txtdescrip);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.lblstock);
            this.tabPage1.Controls.Add(this.lbldesc);
            this.tabPage1.Controls.Add(this.lblcodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgprod
            // 
            this.dgprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprod.Location = new System.Drawing.Point(117, 207);
            this.dgprod.Name = "dgprod";
            this.dgprod.Size = new System.Drawing.Size(240, 150);
            this.dgprod.TabIndex = 7;
            // 
            // btncargar
            // 
            this.btncargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncargar.Location = new System.Drawing.Point(300, 88);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(80, 35);
            this.btncargar.TabIndex = 6;
            this.btncargar.Text = "cargar";
            this.btncargar.UseVisualStyleBackColor = true;
            this.btncargar.Click += new System.EventHandler(this.btncargar_Click);
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(147, 139);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(100, 20);
            this.txtstock.TabIndex = 5;
            // 
            // txtdescrip
            // 
            this.txtdescrip.Location = new System.Drawing.Point(147, 91);
            this.txtdescrip.Name = "txtdescrip";
            this.txtdescrip.Size = new System.Drawing.Size(100, 20);
            this.txtdescrip.TabIndex = 4;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(147, 53);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.txtcodigo.TabIndex = 3;
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(22, 134);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(58, 24);
            this.lblstock.TabIndex = 2;
            this.lblstock.Text = "stock";
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(22, 87);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(119, 24);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "descripcion";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(22, 48);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(74, 24);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.lblstockmov);
            this.tabPage2.Controls.Add(this.btnaceptar);
            this.tabPage2.Controls.Add(this.rbegreso);
            this.tabPage2.Controls.Add(this.rbingreso);
            this.tabPage2.Controls.Add(this.txtcant);
            this.tabPage2.Controls.Add(this.lblcantidad);
            this.tabPage2.Controls.Add(this.lbldescripmov);
            this.tabPage2.Controls.Add(this.lblcodmov);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(139, 232);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 107);
            this.dataGridView2.TabIndex = 8;
            // 
            // lblstockmov
            // 
            this.lblstockmov.AutoSize = true;
            this.lblstockmov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstockmov.Location = new System.Drawing.Point(41, 125);
            this.lblstockmov.Name = "lblstockmov";
            this.lblstockmov.Size = new System.Drawing.Size(66, 24);
            this.lblstockmov.TabIndex = 7;
            this.lblstockmov.Text = "label2";
            // 
            // btnaceptar
            // 
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(458, 77);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(90, 38);
            this.btnaceptar.TabIndex = 6;
            this.btnaceptar.Text = "aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btncarg2_Click);
            // 
            // rbegreso
            // 
            this.rbegreso.AutoSize = true;
            this.rbegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbegreso.Location = new System.Drawing.Point(285, 91);
            this.rbegreso.Name = "rbegreso";
            this.rbegreso.Size = new System.Drawing.Size(82, 24);
            this.rbegreso.TabIndex = 5;
            this.rbegreso.TabStop = true;
            this.rbegreso.Text = "egreso";
            this.rbegreso.UseVisualStyleBackColor = true;
            // 
            // rbingreso
            // 
            this.rbingreso.AutoSize = true;
            this.rbingreso.Checked = true;
            this.rbingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbingreso.Location = new System.Drawing.Point(285, 50);
            this.rbingreso.Name = "rbingreso";
            this.rbingreso.Size = new System.Drawing.Size(86, 24);
            this.rbingreso.TabIndex = 4;
            this.rbingreso.TabStop = true;
            this.rbingreso.Text = "ingreso";
            this.rbingreso.UseVisualStyleBackColor = true;
            this.rbingreso.CheckedChanged += new System.EventHandler(this.rbingreso_CheckedChanged);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(154, 169);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(100, 20);
            this.txtcant.TabIndex = 3;
            this.txtcant.TextChanged += new System.EventHandler(this.txtcant_TextChanged);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(40, 164);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(89, 24);
            this.lblcantidad.TabIndex = 2;
            this.lblcantidad.Text = "cantidad";
            // 
            // lbldescripmov
            // 
            this.lbldescripmov.AutoSize = true;
            this.lbldescripmov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescripmov.Location = new System.Drawing.Point(41, 73);
            this.lbldescripmov.Name = "lbldescripmov";
            this.lbldescripmov.Size = new System.Drawing.Size(66, 24);
            this.lbldescripmov.TabIndex = 1;
            this.lbldescripmov.Text = "label2";
            // 
            // lblcodmov
            // 
            this.lblcodmov.AutoSize = true;
            this.lblcodmov.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodmov.Location = new System.Drawing.Point(40, 30);
            this.lblcodmov.Name = "lblcodmov";
            this.lblcodmov.Size = new System.Drawing.Size(66, 24);
            this.lblcodmov.TabIndex = 0;
            this.lblcodmov.Text = "label1";
            // 
            // Formproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Formproductos";
            this.Text = "Formproductos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprod)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txtdescrip;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lbldescripmov;
        private System.Windows.Forms.Label lblcodmov;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.RadioButton rbegreso;
        private System.Windows.Forms.RadioButton rbingreso;
        private System.Windows.Forms.Label lblstockmov;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgprod;
    }
}