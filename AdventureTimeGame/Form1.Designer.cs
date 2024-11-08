namespace AdventureTimeGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageBox = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.Label();
            this.option1Button = new System.Windows.Forms.Button();
            this.option2Button = new System.Windows.Forms.Button();
            this.option3Button = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.BackColor = System.Drawing.Color.Black;
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageBox.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageBox.ForeColor = System.Drawing.Color.Lime;
            this.imageBox.Image = global::AdventureTimeGame.Properties.Resources.adventurelogo;
            this.imageBox.Location = new System.Drawing.Point(237, 9);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(392, 201);
            this.imageBox.TabIndex = 0;
            this.imageBox.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Black;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textBox.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.Lime;
            this.textBox.Location = new System.Drawing.Point(237, 210);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(392, 80);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Press Button to Start";
            this.textBox.Click += new System.EventHandler(this.textBox_Click);
            // 
            // option1Button
            // 
            this.option1Button.BackColor = System.Drawing.Color.Red;
            this.option1Button.Enabled = false;
            this.option1Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option1Button.FlatAppearance.BorderSize = 5;
            this.option1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option1Button.Location = new System.Drawing.Point(447, 482);
            this.option1Button.Name = "option1Button";
            this.option1Button.Size = new System.Drawing.Size(87, 82);
            this.option1Button.TabIndex = 2;
            this.option1Button.UseVisualStyleBackColor = false;
            this.option1Button.Click += new System.EventHandler(this.option1Button_Click);
            // 
            // option2Button
            // 
            this.option2Button.BackColor = System.Drawing.Color.Lime;
            this.option2Button.Enabled = false;
            this.option2Button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.option2Button.FlatAppearance.BorderSize = 5;
            this.option2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option2Button.Location = new System.Drawing.Point(540, 442);
            this.option2Button.Name = "option2Button";
            this.option2Button.Size = new System.Drawing.Size(75, 57);
            this.option2Button.TabIndex = 3;
            this.option2Button.UseVisualStyleBackColor = false;
            this.option2Button.Click += new System.EventHandler(this.option2Button_Click);
            // 
            // option3Button
            // 
            this.option3Button.BackColor = System.Drawing.Color.Cyan;
            this.option3Button.Enabled = false;
            this.option3Button.FlatAppearance.BorderSize = 5;
            this.option3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.option3Button.Location = new System.Drawing.Point(455, 405);
            this.option3Button.Name = "option3Button";
            this.option3Button.Size = new System.Drawing.Size(75, 57);
            this.option3Button.TabIndex = 4;
            this.option3Button.UseVisualStyleBackColor = false;
            this.option3Button.Click += new System.EventHandler(this.option3Button_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Blue;
            this.startButton.FlatAppearance.BorderSize = 5;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Location = new System.Drawing.Point(554, 321);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(42, 35);
            this.startButton.TabIndex = 5;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // option1Label
            // 
            this.option1Label.AutoSize = true;
            this.option1Label.BackColor = System.Drawing.Color.Black;
            this.option1Label.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.Lime;
            this.option1Label.Location = new System.Drawing.Point(245, 247);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(0, 11);
            this.option1Label.TabIndex = 6;
            // 
            // option2Label
            // 
            this.option2Label.AutoSize = true;
            this.option2Label.BackColor = System.Drawing.Color.Black;
            this.option2Label.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.Lime;
            this.option2Label.Location = new System.Drawing.Point(245, 258);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(0, 11);
            this.option2Label.TabIndex = 7;
            // 
            // option3Label
            // 
            this.option3Label.AutoSize = true;
            this.option3Label.BackColor = System.Drawing.Color.Black;
            this.option3Label.Font = new System.Drawing.Font("MS PGothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.Lime;
            this.option3Label.Location = new System.Drawing.Point(245, 269);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(0, 11);
            this.option3Label.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AdventureTimeGame.Properties.Resources.Bmobackground3;
            this.ClientSize = new System.Drawing.Size(641, 576);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.option3Button);
            this.Controls.Add(this.option2Button);
            this.Controls.Add(this.option1Button);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Adventure Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imageBox;
        private System.Windows.Forms.Label textBox;
        private System.Windows.Forms.Button option1Button;
        private System.Windows.Forms.Button option2Button;
        private System.Windows.Forms.Button option3Button;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
    }
}

