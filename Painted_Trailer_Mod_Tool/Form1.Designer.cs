namespace Painted_Trailer_Mod_Tool
{
    partial class Form_Main
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
            this.checkBoxOldTrailers = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonPickColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxModName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxOldTrailers
            // 
            this.checkBoxOldTrailers.AutoSize = true;
            this.checkBoxOldTrailers.Location = new System.Drawing.Point(12, 43);
            this.checkBoxOldTrailers.Name = "checkBoxOldTrailers";
            this.checkBoxOldTrailers.Size = new System.Drawing.Size(150, 24);
            this.checkBoxOldTrailers.TabIndex = 0;
            this.checkBoxOldTrailers.Text = "Use old Trailers";
            this.checkBoxOldTrailers.UseVisualStyleBackColor = true;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(155, 90);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(75, 30);
            this.buttonCreate.TabIndex = 1;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonPickColor
            // 
            this.buttonPickColor.Location = new System.Drawing.Point(12, 90);
            this.buttonPickColor.Name = "buttonPickColor";
            this.buttonPickColor.Size = new System.Drawing.Size(100, 30);
            this.buttonPickColor.TabIndex = 2;
            this.buttonPickColor.Text = "Pick Color";
            this.buttonPickColor.UseVisualStyleBackColor = true;
            this.buttonPickColor.Click += new System.EventHandler(this.buttonPickColor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name of mod:";
            // 
            // textBoxModName
            // 
            this.textBoxModName.Location = new System.Drawing.Point(130, 10);
            this.textBoxModName.Name = "textBoxModName";
            this.textBoxModName.Size = new System.Drawing.Size(100, 27);
            this.textBoxModName.TabIndex = 4;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 168);
            this.Controls.Add(this.textBoxModName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPickColor);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.checkBoxOldTrailers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painted Trailer Mod Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxOldTrailers;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonPickColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxModName;
    }
}

