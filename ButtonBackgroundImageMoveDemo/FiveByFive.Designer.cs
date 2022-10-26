
namespace ChessMazeUI
{
    partial class FiveByFive
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
            this.Make5x5Level = new System.Windows.Forms.Button();
            this.AddParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Make5x5Level
            // 
            this.Make5x5Level.Location = new System.Drawing.Point(650, 23);
            this.Make5x5Level.Name = "Make5x5Level";
            this.Make5x5Level.Size = new System.Drawing.Size(116, 23);
            this.Make5x5Level.TabIndex = 0;
            this.Make5x5Level.Text = "Make5x5Level";
            this.Make5x5Level.UseVisualStyleBackColor = true;
            this.Make5x5Level.Click += new System.EventHandler(this.Make5x5Level_Click);
            // 
            // AddParts
            // 
            this.AddParts.Location = new System.Drawing.Point(650, 53);
            this.AddParts.Name = "AddParts";
            this.AddParts.Size = new System.Drawing.Size(116, 23);
            this.AddParts.TabIndex = 1;
            this.AddParts.Text = "Add Parts";
            this.AddParts.UseVisualStyleBackColor = true;
            this.AddParts.Click += new System.EventHandler(this.AddParts_Click);
            // 
            // FiveByFive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddParts);
            this.Controls.Add(this.Make5x5Level);
            this.Name = "FiveByFive";
            this.Text = "FiveByFive";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Make5x5Level;
        private System.Windows.Forms.Button AddParts;
    }
}