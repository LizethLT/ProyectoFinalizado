namespace SistemasVentas.VISTA.VentaVistas
{
    partial class VentaEditarVista
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
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(458, 125);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(110, 22);
            button4.TabIndex = 77;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(458, 84);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 22);
            button3.TabIndex = 76;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(296, 317);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 75;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(145, 317);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 74;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 261);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 73;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 217);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 72;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 264);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 71;
            label4.Text = "ESTADO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 219);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 70;
            label5.Text = "TOTAL";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(138, 173);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 69;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 129);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 68;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 84);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 67;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 176);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 66;
            label3.Text = "FECHA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 131);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 65;
            label2.Text = "VENDEDOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 86);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 64;
            label1.Text = "ID CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(178, 34);
            label6.Name = "label6";
            label6.Size = new Size(184, 35);
            label6.TabIndex = 78;
            label6.Text = "Editar Ventas";
            // 
            // VentaEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(586, 369);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentaEditarVista";
            Text = "VentaEditarVista";
            Load += VentaEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
    }
}