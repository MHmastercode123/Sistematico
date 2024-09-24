namespace Prueba2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtnombre = new TextBox();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtcantidad = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmboxCategoria = new ComboBox();
            BtnAgregar = new Button();
            listdeProductos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 0;
            label1.Text = "Productos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 63);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(103, 65);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(197, 23);
            txtnombre.TabIndex = 2;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(103, 111);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(197, 23);
            txtPrecio.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(9, 111);
            label3.Name = "label3";
            label3.Size = new Size(62, 21);
            label3.TabIndex = 3;
            label3.Text = "Precio:";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(103, 164);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(197, 23);
            txtcantidad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(9, 164);
            label4.Name = "label4";
            label4.Size = new Size(87, 21);
            label4.TabIndex = 5;
            label4.Text = "Cantidad: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 218);
            label5.Name = "label5";
            label5.Size = new Size(88, 21);
            label5.TabIndex = 5;
            label5.Text = "Categoria:";
            // 
            // cmboxCategoria
            // 
            cmboxCategoria.FormattingEnabled = true;
            cmboxCategoria.Location = new Point(103, 218);
            cmboxCategoria.Name = "cmboxCategoria";
            cmboxCategoria.Size = new Size(197, 23);
            cmboxCategoria.TabIndex = 7;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Location = new Point(123, 275);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(90, 30);
            BtnAgregar.TabIndex = 8;
            BtnAgregar.Text = "Agregar";
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // listdeProductos
            // 
            listdeProductos.FormattingEnabled = true;
            listdeProductos.ItemHeight = 15;
            listdeProductos.Location = new Point(6, 328);
            listdeProductos.Name = "listdeProductos";
            listdeProductos.Size = new Size(326, 139);
            listdeProductos.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 508);
            Controls.Add(listdeProductos);
            Controls.Add(BtnAgregar);
            Controls.Add(cmboxCategoria);
            Controls.Add(txtcantidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtnombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtnombre;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtcantidad;
        private Label label4;
        private Label label5;
        private ComboBox cmboxCategoria;
        private Button BtnAgregar;
        private ListBox listdeProductos;
    }
}
