namespace ShoesProject
{
    partial class ChooseForm
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
            lb1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Location = new Point(47, 28);
            lb1.Name = "lb1";
            lb1.Size = new Size(185, 20);
            lb1.TabIndex = 0;
            lb1.Text = "Выберите что вам нужно";
            // 
            // button1
            // 
            button1.Location = new Point(34, 87);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Заказы";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(150, 87);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Продукты";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 167);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lb1);
            Name = "ChooseForm";
            Text = "ChooseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Button button1;
        private Button button2;
    }
}