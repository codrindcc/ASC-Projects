namespace WindowsFormsApp1
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
            this.btn_add_5 = new System.Windows.Forms.Button();
            this.btn_add_10 = new System.Windows.Forms.Button();
            this.btn_add_25 = new System.Windows.Forms.Button();
            this.display = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_take = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_add_100 = new System.Windows.Forms.Button();
            this.btn_Take_capuccino = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add_5
            // 
            this.btn_add_5.Location = new System.Drawing.Point(24, 12);
            this.btn_add_5.Name = "btn_add_5";
            this.btn_add_5.Size = new System.Drawing.Size(95, 23);
            this.btn_add_5.TabIndex = 0;
            this.btn_add_5.Text = "NICKEL";
            this.btn_add_5.UseVisualStyleBackColor = true;
            this.btn_add_5.Click += new System.EventHandler(this.btn_add_5_Click);
            // 
            // btn_add_10
            // 
            this.btn_add_10.Location = new System.Drawing.Point(24, 41);
            this.btn_add_10.Name = "btn_add_10";
            this.btn_add_10.Size = new System.Drawing.Size(95, 23);
            this.btn_add_10.TabIndex = 1;
            this.btn_add_10.Text = "DIME";
            this.btn_add_10.UseVisualStyleBackColor = true;
            this.btn_add_10.Click += new System.EventHandler(this.btn_add_10_Click);
            // 
            // btn_add_25
            // 
            this.btn_add_25.Location = new System.Drawing.Point(24, 70);
            this.btn_add_25.Name = "btn_add_25";
            this.btn_add_25.Size = new System.Drawing.Size(95, 23);
            this.btn_add_25.TabIndex = 2;
            this.btn_add_25.Text = "QUARTER";
            this.btn_add_25.UseVisualStyleBackColor = true;
            this.btn_add_25.Click += new System.EventHandler(this.btn_add_25_Click);
            // 
            // display
            // 
            this.display.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.display.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.display.Location = new System.Drawing.Point(125, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(186, 110);
            this.display.TabIndex = 3;
            this.display.Text = "00";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Take_capuccino);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_take);
            this.panel1.Location = new System.Drawing.Point(24, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 309);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // btn_take
            // 
            this.btn_take.Location = new System.Drawing.Point(80, 23);
            this.btn_take.Name = "btn_take";
            this.btn_take.Size = new System.Drawing.Size(182, 43);
            this.btn_take.TabIndex = 5;
            this.btn_take.Text = "EXPRESSO";
            this.btn_take.UseVisualStyleBackColor = true;
            this.btn_take.Click += new System.EventHandler(this.btn_take_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(152, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(152, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(80, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "DIME : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(80, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 39);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIKEL : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(313, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(254, 436);
            this.listBox1.TabIndex = 5;
            // 
            // btn_add_100
            // 
            this.btn_add_100.Location = new System.Drawing.Point(24, 99);
            this.btn_add_100.Name = "btn_add_100";
            this.btn_add_100.Size = new System.Drawing.Size(95, 23);
            this.btn_add_100.TabIndex = 6;
            this.btn_add_100.Text = "DOLLAR";
            this.btn_add_100.UseVisualStyleBackColor = true;
            this.btn_add_100.Click += new System.EventHandler(this.btn_add_100_Click);
            // 
            // btn_Take_capuccino
            // 
            this.btn_Take_capuccino.Location = new System.Drawing.Point(80, 72);
            this.btn_Take_capuccino.Name = "btn_Take_capuccino";
            this.btn_Take_capuccino.Size = new System.Drawing.Size(182, 43);
            this.btn_Take_capuccino.TabIndex = 7;
            this.btn_Take_capuccino.Text = "CAPUCCINO";
            this.btn_Take_capuccino.UseVisualStyleBackColor = true;
            this.btn_Take_capuccino.Click += new System.EventHandler(this.btn_Take_capuccino_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.btn_add_100);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btn_add_25);
            this.Controls.Add(this.btn_add_10);
            this.Controls.Add(this.btn_add_5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_5;
        private System.Windows.Forms.Button btn_add_10;
        private System.Windows.Forms.Button btn_add_25;
        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_take;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_add_100;
        private System.Windows.Forms.Button btn_Take_capuccino;
    }
}

