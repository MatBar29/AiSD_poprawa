namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.liczbaTB = new System.Windows.Forms.TextBox();
            this.liczbaNUD = new System.Windows.Forms.NumericUpDown();
            this.czaslb = new System.Windows.Forms.Label();
            this.czasWyniklb = new System.Windows.Forms.Label();
            this.sortBbt = new System.Windows.Forms.Button();
            this.sortSbt = new System.Windows.Forms.Button();
            this.sortIbt = new System.Windows.Forms.Button();
            this.sortMbt = new System.Windows.Forms.Button();
            this.sortQbt = new System.Windows.Forms.Button();
            this.genbt = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.liczbaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // liczbaTB
            // 
            this.liczbaTB.Location = new System.Drawing.Point(115, 75);
            this.liczbaTB.Name = "liczbaTB";
            this.liczbaTB.Size = new System.Drawing.Size(186, 23);
            this.liczbaTB.TabIndex = 0;
            // 
            // liczbaNUD
            // 
            this.liczbaNUD.Location = new System.Drawing.Point(456, 75);
            this.liczbaNUD.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.liczbaNUD.Name = "liczbaNUD";
            this.liczbaNUD.Size = new System.Drawing.Size(147, 23);
            this.liczbaNUD.TabIndex = 1;
            // 
            // czaslb
            // 
            this.czaslb.AutoSize = true;
            this.czaslb.Location = new System.Drawing.Point(456, 174);
            this.czaslb.Name = "czaslb";
            this.czaslb.Size = new System.Drawing.Size(34, 15);
            this.czaslb.TabIndex = 2;
            this.czaslb.Text = "Czas:";
            // 
            // czasWyniklb
            // 
            this.czasWyniklb.AutoSize = true;
            this.czasWyniklb.Location = new System.Drawing.Point(496, 174);
            this.czasWyniklb.Name = "czasWyniklb";
            this.czasWyniklb.Size = new System.Drawing.Size(38, 15);
            this.czasWyniklb.TabIndex = 3;
            this.czasWyniklb.Text = "label2";
            // 
            // sortBbt
            // 
            this.sortBbt.Location = new System.Drawing.Point(115, 322);
            this.sortBbt.Name = "sortBbt";
            this.sortBbt.Size = new System.Drawing.Size(75, 23);
            this.sortBbt.TabIndex = 4;
            this.sortBbt.Text = "SB";
            this.sortBbt.UseVisualStyleBackColor = true;
            // 
            // sortSbt
            // 
            this.sortSbt.Location = new System.Drawing.Point(223, 322);
            this.sortSbt.Name = "sortSbt";
            this.sortSbt.Size = new System.Drawing.Size(75, 23);
            this.sortSbt.TabIndex = 5;
            this.sortSbt.Text = "SS";
            this.sortSbt.UseVisualStyleBackColor = true;
            // 
            // sortIbt
            // 
            this.sortIbt.Location = new System.Drawing.Point(336, 322);
            this.sortIbt.Name = "sortIbt";
            this.sortIbt.Size = new System.Drawing.Size(75, 23);
            this.sortIbt.TabIndex = 6;
            this.sortIbt.Text = "SI";
            this.sortIbt.UseVisualStyleBackColor = true;
            // 
            // sortMbt
            // 
            this.sortMbt.Location = new System.Drawing.Point(456, 322);
            this.sortMbt.Name = "sortMbt";
            this.sortMbt.Size = new System.Drawing.Size(75, 23);
            this.sortMbt.TabIndex = 7;
            this.sortMbt.Text = "SM";
            this.sortMbt.UseVisualStyleBackColor = true;
            // 
            // sortQbt
            // 
            this.sortQbt.Location = new System.Drawing.Point(565, 322);
            this.sortQbt.Name = "sortQbt";
            this.sortQbt.Size = new System.Drawing.Size(75, 23);
            this.sortQbt.TabIndex = 8;
            this.sortQbt.Text = "SQ";
            this.sortQbt.UseVisualStyleBackColor = true;
            // 
            // genbt
            // 
            this.genbt.Location = new System.Drawing.Point(456, 104);
            this.genbt.Name = "genbt";
            this.genbt.Size = new System.Drawing.Size(147, 24);
            this.genbt.TabIndex = 9;
            this.genbt.Text = "Generuj";
            this.genbt.UseVisualStyleBackColor = true;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(367, 78);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 10;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.genbt);
            this.Controls.Add(this.sortQbt);
            this.Controls.Add(this.sortMbt);
            this.Controls.Add(this.sortIbt);
            this.Controls.Add(this.sortSbt);
            this.Controls.Add(this.sortBbt);
            this.Controls.Add(this.czasWyniklb);
            this.Controls.Add(this.czaslb);
            this.Controls.Add(this.liczbaNUD);
            this.Controls.Add(this.liczbaTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.liczbaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox liczbaTB;
        private NumericUpDown liczbaNUD;
        private Label czaslb;
        private Label czasWyniklb;
        private Button sortBbt;
        private Button sortSbt;
        private Button sortIbt;
        private Button sortMbt;
        private Button sortQbt;
        private Button genbt;
        private CheckBox checkBox;
    }
}