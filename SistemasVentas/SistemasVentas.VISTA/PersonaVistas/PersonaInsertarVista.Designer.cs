﻿namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaInsertarVista
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button1 = new Button();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 72);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "NOMBRE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 117);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "APELLIDOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 162);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "TELEFONO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 207);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 3;
            label4.Text = "CI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 252);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "CORREO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 70);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(138, 115);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 160);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(138, 205);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(138, 250);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 23);
            textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(138, 295);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(282, 23);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 297);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 10;
            label6.Text = "ESTADO";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(292, 342);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(114, 34);
            button2.TabIndex = 41;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(141, 342);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 40;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(114, 9);
            label7.Name = "label7";
            label7.Size = new Size(223, 35);
            label7.TabIndex = 42;
            label7.Text = "Agregar Persona";
            // 
            // PersonaInsertarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(456, 408);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonaInsertarVista";
            Text = "PersonaInsertarVista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label6;
        private Button button2;
        private Button button1;
        private Label label7;
    }
}