namespace SystemUm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPainel = new System.Windows.Forms.Button();
            this.BtnTarefas = new System.Windows.Forms.Button();
            this.BtnSobre = new System.Windows.Forms.Button();
            this.BtnLinks = new System.Windows.Forms.Button();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 15);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.BtnLinks);
            this.panel2.Controls.Add(this.BtnSobre);
            this.panel2.Controls.Add(this.BtnTarefas);
            this.panel2.Controls.Add(this.BtnPainel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 666);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(270, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPainel
            // 
            this.BtnPainel.FlatAppearance.BorderSize = 0;
            this.BtnPainel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPainel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPainel.ForeColor = System.Drawing.Color.White;
            this.BtnPainel.Image = ((System.Drawing.Image)(resources.GetObject("BtnPainel.Image")));
            this.BtnPainel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPainel.Location = new System.Drawing.Point(30, 17);
            this.BtnPainel.Name = "BtnPainel";
            this.BtnPainel.Size = new System.Drawing.Size(205, 60);
            this.BtnPainel.TabIndex = 3;
            this.BtnPainel.Text = "Painel";
            this.BtnPainel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPainel.UseVisualStyleBackColor = true;
            this.BtnPainel.Click += new System.EventHandler(this.BtnPainel_Click);
            // 
            // BtnTarefas
            // 
            this.BtnTarefas.FlatAppearance.BorderSize = 0;
            this.BtnTarefas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnTarefas.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTarefas.ForeColor = System.Drawing.Color.White;
            this.BtnTarefas.Image = ((System.Drawing.Image)(resources.GetObject("BtnTarefas.Image")));
            this.BtnTarefas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnTarefas.Location = new System.Drawing.Point(30, 167);
            this.BtnTarefas.Name = "BtnTarefas";
            this.BtnTarefas.Size = new System.Drawing.Size(205, 60);
            this.BtnTarefas.TabIndex = 4;
            this.BtnTarefas.Text = "Tarefas";
            this.BtnTarefas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnTarefas.UseVisualStyleBackColor = true;
            this.BtnTarefas.Click += new System.EventHandler(this.BtnTarefas_Click);
            // 
            // BtnSobre
            // 
            this.BtnSobre.FlatAppearance.BorderSize = 0;
            this.BtnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSobre.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSobre.ForeColor = System.Drawing.Color.White;
            this.BtnSobre.Image = ((System.Drawing.Image)(resources.GetObject("BtnSobre.Image")));
            this.BtnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSobre.Location = new System.Drawing.Point(30, 467);
            this.BtnSobre.Name = "BtnSobre";
            this.BtnSobre.Size = new System.Drawing.Size(205, 60);
            this.BtnSobre.TabIndex = 5;
            this.BtnSobre.Text = "Sobre";
            this.BtnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSobre.UseVisualStyleBackColor = true;
            this.BtnSobre.Click += new System.EventHandler(this.BtnSobre_Click);
            // 
            // BtnLinks
            // 
            this.BtnLinks.FlatAppearance.BorderSize = 0;
            this.BtnLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinks.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLinks.ForeColor = System.Drawing.Color.White;
            this.BtnLinks.Image = ((System.Drawing.Image)(resources.GetObject("BtnLinks.Image")));
            this.BtnLinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLinks.Location = new System.Drawing.Point(30, 317);
            this.BtnLinks.Name = "BtnLinks";
            this.BtnLinks.Size = new System.Drawing.Size(205, 60);
            this.BtnLinks.TabIndex = 6;
            this.BtnLinks.Text = "Links";
            this.BtnLinks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLinks.UseVisualStyleBackColor = true;
            this.BtnLinks.Click += new System.EventHandler(this.BtnLinks_Click);
            // 
            // BtnFechar
            // 
            this.BtnFechar.FlatAppearance.BorderSize = 0;
            this.BtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFechar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFechar.Location = new System.Drawing.Point(1183, 17);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(75, 23);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "Fechar";
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnPainel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLinks;
        private System.Windows.Forms.Button BtnSobre;
        private System.Windows.Forms.Button BtnTarefas;
        private System.Windows.Forms.Button BtnFechar;
    }
}

