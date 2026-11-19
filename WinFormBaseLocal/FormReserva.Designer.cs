namespace WinFormBaseLocal
{
    partial class FormReserva
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBoxCliente = new ComboBox();
            comboBoxCancha = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(77, 201);
            button1.Name = "button1";
            button1.Size = new Size(189, 73);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 60);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 1;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(77, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 32);
            label2.TabIndex = 1;
            label2.Text = "Cancha";
            // 
            // comboBoxCliente
            // 
            comboBoxCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCliente.FormattingEnabled = true;
            comboBoxCliente.Location = new Point(192, 57);
            comboBoxCliente.Name = "comboBoxCliente";
            comboBoxCliente.Size = new Size(314, 40);
            comboBoxCliente.TabIndex = 2;
            // 
            // comboBoxCancha
            // 
            comboBoxCancha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCancha.FormattingEnabled = true;
            comboBoxCancha.Location = new Point(192, 111);
            comboBoxCancha.Name = "comboBoxCancha";
            comboBoxCancha.Size = new Size(314, 40);
            comboBoxCancha.TabIndex = 2;
            // 
            // FormReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxCancha);
            Controls.Add(comboBoxCliente);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "FormReserva";
            Text = "FormReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxCliente;
        private ComboBox comboBoxCancha;
    }
}