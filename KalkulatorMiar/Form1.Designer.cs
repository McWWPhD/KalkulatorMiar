namespace KalkulatorMiar
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
            this.lbOptions = new System.Windows.Forms.ListBox();
            this.numInput = new System.Windows.Forms.NumericUpDown();
            this.txtValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).BeginInit();
            this.SuspendLayout();
            // 
            // lbOptions
            // 
            this.lbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbOptions.FormattingEnabled = true;
            this.lbOptions.ItemHeight = 25;
            this.lbOptions.Items.AddRange(new object[] {
            "kg -> funty",
            "funty -> kg",
            "C -> F",
            "F -> C",
            "km/h -> kts",
            "kts -> km/h"});
            this.lbOptions.Location = new System.Drawing.Point(155, 146);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(146, 154);
            this.lbOptions.TabIndex = 0;
            this.lbOptions.SelectedIndexChanged += new System.EventHandler(this.lbOptions_SelectedIndexChanged);
            // 
            // numInput
            // 
            this.numInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numInput.Location = new System.Drawing.Point(181, 43);
            this.numInput.Name = "numInput";
            this.numInput.Size = new System.Drawing.Size(120, 38);
            this.numInput.TabIndex = 2;
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtValue.Location = new System.Drawing.Point(102, 362);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(231, 38);
            this.txtValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 441);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.numInput);
            this.Controls.Add(this.lbOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOptions;
        private System.Windows.Forms.NumericUpDown numInput;
        private System.Windows.Forms.TextBox txtValue;
    }
}

