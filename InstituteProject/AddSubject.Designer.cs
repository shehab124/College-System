
namespace InstituteProject
{
    partial class AddSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSubject));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(390, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 54);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(36, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Credits Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(36, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(37, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subject ID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, 262);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 22);
            this.textBox2.TabIndex = 11;
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(251, 59);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(286, 22);
            this.TextBox1.TabIndex = 10;
            this.TextBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextBox1);
            this.Name = "AddSubject";
            this.Text = "AddSubject";
            this.Load += new System.EventHandler(this.AddSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TextBox1;
    }
}