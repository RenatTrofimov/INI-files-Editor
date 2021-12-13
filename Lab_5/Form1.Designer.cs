
namespace Lab_5
{
    partial class BlockEditor
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBlockBtn = new System.Windows.Forms.Button();
            this.DeleteBlockBtn = new System.Windows.Forms.Button();
            this.DeleteFieldBtn = new System.Windows.Forms.Button();
            this.AddFieldBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EditFieldBtn = new System.Windows.Forms.Button();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SaveFileBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.textBox1);
            this.MainPanel.Controls.Add(this.EditFieldBtn);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.DeleteFieldBtn);
            this.MainPanel.Controls.Add(this.AddFieldBtn);
            this.MainPanel.Controls.Add(this.DeleteBlockBtn);
            this.MainPanel.Controls.Add(this.AddBlockBtn);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.listBox2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.listBox1);
            this.MainPanel.Enabled = false;
            this.MainPanel.Location = new System.Drawing.Point(12, 34);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(374, 404);
            this.MainPanel.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 355);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Блоки";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(188, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(179, 303);
            this.listBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(188, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поля";
            // 
            // AddBlockBtn
            // 
            this.AddBlockBtn.Location = new System.Drawing.Point(3, 378);
            this.AddBlockBtn.Name = "AddBlockBtn";
            this.AddBlockBtn.Size = new System.Drawing.Size(87, 23);
            this.AddBlockBtn.TabIndex = 4;
            this.AddBlockBtn.Text = "Добавить";
            this.AddBlockBtn.UseVisualStyleBackColor = true;
            this.AddBlockBtn.Click += new System.EventHandler(this.AddBlockBtn_Click);
            // 
            // DeleteBlockBtn
            // 
            this.DeleteBlockBtn.Location = new System.Drawing.Point(95, 378);
            this.DeleteBlockBtn.Name = "DeleteBlockBtn";
            this.DeleteBlockBtn.Size = new System.Drawing.Size(87, 23);
            this.DeleteBlockBtn.TabIndex = 5;
            this.DeleteBlockBtn.Text = "Удалить";
            this.DeleteBlockBtn.UseVisualStyleBackColor = true;
            this.DeleteBlockBtn.Click += new System.EventHandler(this.DeleteBlockBtn_Click);
            // 
            // DeleteFieldBtn
            // 
            this.DeleteFieldBtn.Location = new System.Drawing.Point(280, 378);
            this.DeleteFieldBtn.Name = "DeleteFieldBtn";
            this.DeleteFieldBtn.Size = new System.Drawing.Size(87, 23);
            this.DeleteFieldBtn.TabIndex = 7;
            this.DeleteFieldBtn.Text = "Удалить";
            this.DeleteFieldBtn.UseVisualStyleBackColor = true;
            this.DeleteFieldBtn.Click += new System.EventHandler(this.DeleteFieldBtn_Click);
            // 
            // AddFieldBtn
            // 
            this.AddFieldBtn.Location = new System.Drawing.Point(188, 378);
            this.AddFieldBtn.Name = "AddFieldBtn";
            this.AddFieldBtn.Size = new System.Drawing.Size(87, 23);
            this.AddFieldBtn.TabIndex = 6;
            this.AddFieldBtn.Text = "Добавить";
            this.AddFieldBtn.UseVisualStyleBackColor = true;
            this.AddFieldBtn.Click += new System.EventHandler(this.AddFieldBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(188, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Значениe";
            // 
            // EditFieldBtn
            // 
            this.EditFieldBtn.Location = new System.Drawing.Point(280, 326);
            this.EditFieldBtn.Name = "EditFieldBtn";
            this.EditFieldBtn.Size = new System.Drawing.Size(87, 23);
            this.EditFieldBtn.TabIndex = 9;
            this.EditFieldBtn.Text = "Изменить";
            this.EditFieldBtn.UseVisualStyleBackColor = true;
            this.EditFieldBtn.Click += new System.EventHandler(this.EditFieldBtn_Click);
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(12, 5);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(98, 23);
            this.OpenFileBtn.TabIndex = 10;
            this.OpenFileBtn.Text = "Открыть файл";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // SaveFileBtn
            // 
            this.SaveFileBtn.Enabled = false;
            this.SaveFileBtn.Location = new System.Drawing.Point(282, 5);
            this.SaveFileBtn.Name = "SaveFileBtn";
            this.SaveFileBtn.Size = new System.Drawing.Size(104, 23);
            this.SaveFileBtn.TabIndex = 11;
            this.SaveFileBtn.Text = "Сохранить файл";
            this.SaveFileBtn.UseVisualStyleBackColor = true;
            this.SaveFileBtn.Click += new System.EventHandler(this.SaveFileBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 352);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 20);
            this.textBox1.TabIndex = 10;
            // 
            // BlockEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 450);
            this.Controls.Add(this.SaveFileBtn);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.MainPanel);
            this.Name = "BlockEditor";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EditFieldBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeleteFieldBtn;
        private System.Windows.Forms.Button AddFieldBtn;
        private System.Windows.Forms.Button DeleteBlockBtn;
        private System.Windows.Forms.Button AddBlockBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button OpenFileBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SaveFileBtn;
    }
}

