﻿namespace Rust
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PizdaPognali = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PizdaPognali
            // 
            this.PizdaPognali.Location = new System.Drawing.Point(267, 194);
            this.PizdaPognali.Name = "PizdaPognali";
            this.PizdaPognali.Size = new System.Drawing.Size(289, 23);
            this.PizdaPognali.TabIndex = 0;
            this.PizdaPognali.Text = "PizdaPognali";
            this.PizdaPognali.UseVisualStyleBackColor = true;
            this.PizdaPognali.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.PizdaPognali);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PizdaPognali;
    }
}

