namespace calcular_impuesto_de_renta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_Sueldo = new TextBox();
            txt_AFP = new TextBox();
            txt_SFS = new TextBox();
            txt_ISR = new TextBox();
            txt_Status = new TextBox();
            pictureBox1 = new PictureBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Lavender;
            label1.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 148);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 0;
            label1.Text = "Sueldo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Lavender;
            label2.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(141, 319);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Lavender;
            label3.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(142, 275);
            label3.Name = "label3";
            label3.Size = new Size(33, 21);
            label3.TabIndex = 2;
            label3.Text = "ISR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Lavender;
            label4.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(142, 233);
            label4.Name = "label4";
            label4.Size = new Size(36, 21);
            label4.TabIndex = 3;
            label4.Text = "SFS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Lavender;
            label5.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(141, 189);
            label5.Name = "label5";
            label5.Size = new Size(37, 21);
            label5.TabIndex = 4;
            label5.Text = "AFP";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(122, 42);
            label6.Name = "label6";
            label6.Size = new Size(339, 24);
            label6.TabIndex = 5;
            label6.Text = "Calcular impuesto sobre la renta";
            // 
            // txt_Sueldo
            // 
            txt_Sueldo.Location = new Point(227, 140);
            txt_Sueldo.Name = "txt_Sueldo";
            txt_Sueldo.Size = new Size(100, 23);
            txt_Sueldo.TabIndex = 6;
            // 
            // txt_AFP
            // 
            txt_AFP.Location = new Point(227, 189);
            txt_AFP.Name = "txt_AFP";
            txt_AFP.Size = new Size(100, 23);
            txt_AFP.TabIndex = 7;
            // 
            // txt_SFS
            // 
            txt_SFS.Location = new Point(227, 233);
            txt_SFS.Name = "txt_SFS";
            txt_SFS.Size = new Size(100, 23);
            txt_SFS.TabIndex = 8;
            // 
            // txt_ISR
            // 
            txt_ISR.Location = new Point(227, 272);
            txt_ISR.Name = "txt_ISR";
            txt_ISR.Size = new Size(100, 23);
            txt_ISR.TabIndex = 9;
            // 
            // txt_Status
            // 
            txt_Status.Location = new Point(227, 319);
            txt_Status.Name = "txt_Status";
            txt_Status.Size = new Size(225, 23);
            txt_Status.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(553, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 369);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(104, 400);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(227, 400);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(358, 400);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1190, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(pictureBox1);
            Controls.Add(txt_Status);
            Controls.Add(txt_ISR);
            Controls.Add(txt_SFS);
            Controls.Add(txt_AFP);
            Controls.Add(txt_Sueldo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_Sueldo;
        private TextBox txt_AFP;
        private TextBox txt_SFS;
        private TextBox txt_ISR;
        private TextBox txt_Status;
        private PictureBox pictureBox1;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}
