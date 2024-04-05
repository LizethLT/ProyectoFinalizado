namespace SistemasVentas.VISTA.UsuarioVistas
{
    partial class UsuarioInsertarVista
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 164);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 117);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 71);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 211);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 12;
            label4.Text = "FECHA REGISTRO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 166);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 11;
            label3.Text = "CONTRASEÑA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 121);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 10;
            label2.Text = "NOMBRE USER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 76);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 9;
            label1.Text = "PERSONA";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 210);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(282, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(302, 274);
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
            button1.Location = new Point(152, 274);
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
            button3.Location = new Point(485, 69);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(110, 22);
            button3.TabIndex = 44;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(183, 21);
            label5.Name = "label5";
            label5.Size = new Size(218, 35);
            label5.TabIndex = 45;
            label5.Text = "Agregar Usuario";
            // 
            // UsuarioInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(608, 338);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuarioInsertarVista";
            Text = "UsuarioInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label5;
    }
}