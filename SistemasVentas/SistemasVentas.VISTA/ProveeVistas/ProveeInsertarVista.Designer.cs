namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVista
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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 131);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 87);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 178);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "FECHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 134);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 10;
            label3.Text = "PROVEEDOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 89);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 9;
            label2.Text = "PRODUCTO";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(146, 176);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 220);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 222);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 15;
            label5.Text = "PRECIO";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(296, 282);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 43;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(146, 282);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 42;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(456, 86);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 22);
            button3.TabIndex = 44;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(456, 127);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(110, 22);
            button4.TabIndex = 45;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(169, 30);
            label1.Name = "label1";
            label1.Size = new Size(212, 35);
            label1.TabIndex = 46;
            label1.Text = "Agregar Provee";
            // 
            // ProveeInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(587, 376);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProveeInsertarVista";
            Text = "ProveeIngresarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private Label label5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}