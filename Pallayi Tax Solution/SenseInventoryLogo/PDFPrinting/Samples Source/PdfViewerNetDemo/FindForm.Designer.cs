namespace PdfViewerNetDemo
{
    partial class FindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchTerm = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.cbCaseSensitive = new System.Windows.Forms.CheckBox();
            this.cbWholeWordOnly = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Term:";
            // 
            // tbSearchTerm
            // 
            this.tbSearchTerm.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSearchTerm.Location = new System.Drawing.Point(16, 35);
            this.tbSearchTerm.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchTerm.Name = "tbSearchTerm";
            this.tbSearchTerm.Size = new System.Drawing.Size(320, 23);
            this.tbSearchTerm.TabIndex = 1;
            this.tbSearchTerm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearchTerm_KeyPress);
            // 
            // btnPrevious
            // 
            this.btnPrevious.AutoSize = true;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrevious.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrevious.Location = new System.Drawing.Point(103, 100);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(108, 35);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.Location = new System.Drawing.Point(246, 100);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(90, 35);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cbCaseSensitive
            // 
            this.cbCaseSensitive.AutoSize = true;
            this.cbCaseSensitive.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCaseSensitive.Location = new System.Drawing.Point(16, 66);
            this.cbCaseSensitive.Margin = new System.Windows.Forms.Padding(4);
            this.cbCaseSensitive.Name = "cbCaseSensitive";
            this.cbCaseSensitive.Size = new System.Drawing.Size(122, 20);
            this.cbCaseSensitive.TabIndex = 4;
            this.cbCaseSensitive.Text = "Case sensitive";
            this.cbCaseSensitive.UseVisualStyleBackColor = true;
            // 
            // cbWholeWordOnly
            // 
            this.cbWholeWordOnly.AutoSize = true;
            this.cbWholeWordOnly.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbWholeWordOnly.Location = new System.Drawing.Point(197, 66);
            this.cbWholeWordOnly.Margin = new System.Windows.Forms.Padding(4);
            this.cbWholeWordOnly.Name = "cbWholeWordOnly";
            this.cbWholeWordOnly.Size = new System.Drawing.Size(136, 20);
            this.cbWholeWordOnly.TabIndex = 5;
            this.cbWholeWordOnly.Text = "Whole word only";
            this.cbWholeWordOnly.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 140);
            this.Controls.Add(this.cbWholeWordOnly);
            this.Controls.Add(this.cbCaseSensitive);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.tbSearchTerm);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchTerm;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox cbCaseSensitive;
        private System.Windows.Forms.CheckBox cbWholeWordOnly;
    }
}