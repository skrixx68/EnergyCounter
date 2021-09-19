
namespace EnergyCounterCSharp
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
            this.lbl_energyCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_roundCount = new System.Windows.Forms.Label();
            this.lbl_energyUsed = new System.Windows.Forms.Label();
            this.btn_energyUsedDecrement = new System.Windows.Forms.Button();
            this.btn_energyUsedIncrement = new System.Windows.Forms.Button();
            this.btn_energyGainIncrement = new System.Windows.Forms.Button();
            this.btn_energyGainDecrement = new System.Windows.Forms.Button();
            this.lbl_energyGained = new System.Windows.Forms.Label();
            this.btn_energyDestroyIncrement = new System.Windows.Forms.Button();
            this.btn_energyDestroyDecrement = new System.Windows.Forms.Button();
            this.lbl_energyDestroyed = new System.Windows.Forms.Label();
            this.btn_endTurn = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_energyCount
            // 
            this.lbl_energyCount.AutoSize = true;
            this.lbl_energyCount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_energyCount.Location = new System.Drawing.Point(128, 38);
            this.lbl_energyCount.Name = "lbl_energyCount";
            this.lbl_energyCount.Size = new System.Drawing.Size(33, 37);
            this.lbl_energyCount.TabIndex = 0;
            this.lbl_energyCount.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(86, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Round";
            // 
            // lbl_roundCount
            // 
            this.lbl_roundCount.AutoSize = true;
            this.lbl_roundCount.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_roundCount.Location = new System.Drawing.Point(160, 8);
            this.lbl_roundCount.Name = "lbl_roundCount";
            this.lbl_roundCount.Size = new System.Drawing.Size(21, 30);
            this.lbl_roundCount.TabIndex = 2;
            this.lbl_roundCount.Text = "1";
            // 
            // lbl_energyUsed
            // 
            this.lbl_energyUsed.AutoSize = true;
            this.lbl_energyUsed.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_energyUsed.Location = new System.Drawing.Point(129, 109);
            this.lbl_energyUsed.Name = "lbl_energyUsed";
            this.lbl_energyUsed.Size = new System.Drawing.Size(32, 37);
            this.lbl_energyUsed.TabIndex = 3;
            this.lbl_energyUsed.Text = "0";
            // 
            // btn_energyUsedDecrement
            // 
            this.btn_energyUsedDecrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyUsedDecrement.Location = new System.Drawing.Point(79, 116);
            this.btn_energyUsedDecrement.Name = "btn_energyUsedDecrement";
            this.btn_energyUsedDecrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyUsedDecrement.TabIndex = 6;
            this.btn_energyUsedDecrement.Text = "-";
            this.btn_energyUsedDecrement.UseVisualStyleBackColor = true;
            this.btn_energyUsedDecrement.Click += new System.EventHandler(this.btn_energyUsedDecrement_Click);
            // 
            // btn_energyUsedIncrement
            // 
            this.btn_energyUsedIncrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyUsedIncrement.Location = new System.Drawing.Point(174, 116);
            this.btn_energyUsedIncrement.Name = "btn_energyUsedIncrement";
            this.btn_energyUsedIncrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyUsedIncrement.TabIndex = 7;
            this.btn_energyUsedIncrement.Text = "+";
            this.btn_energyUsedIncrement.UseVisualStyleBackColor = true;
            this.btn_energyUsedIncrement.Click += new System.EventHandler(this.btn_energyUsedIncrement_Click);
            // 
            // btn_energyGainIncrement
            // 
            this.btn_energyGainIncrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyGainIncrement.Location = new System.Drawing.Point(173, 175);
            this.btn_energyGainIncrement.Name = "btn_energyGainIncrement";
            this.btn_energyGainIncrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyGainIncrement.TabIndex = 10;
            this.btn_energyGainIncrement.Text = "+";
            this.btn_energyGainIncrement.UseVisualStyleBackColor = true;
            this.btn_energyGainIncrement.Click += new System.EventHandler(this.btn_energyGainIncrement_Click);
            // 
            // btn_energyGainDecrement
            // 
            this.btn_energyGainDecrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyGainDecrement.Location = new System.Drawing.Point(77, 175);
            this.btn_energyGainDecrement.Name = "btn_energyGainDecrement";
            this.btn_energyGainDecrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyGainDecrement.TabIndex = 9;
            this.btn_energyGainDecrement.Text = "-";
            this.btn_energyGainDecrement.UseVisualStyleBackColor = true;
            this.btn_energyGainDecrement.Click += new System.EventHandler(this.btn_energyGainDecrement_Click);
            // 
            // lbl_energyGained
            // 
            this.lbl_energyGained.AutoSize = true;
            this.lbl_energyGained.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_energyGained.Location = new System.Drawing.Point(128, 168);
            this.lbl_energyGained.Name = "lbl_energyGained";
            this.lbl_energyGained.Size = new System.Drawing.Size(32, 37);
            this.lbl_energyGained.TabIndex = 8;
            this.lbl_energyGained.Text = "0";
            // 
            // btn_energyDestroyIncrement
            // 
            this.btn_energyDestroyIncrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyDestroyIncrement.Location = new System.Drawing.Point(174, 237);
            this.btn_energyDestroyIncrement.Name = "btn_energyDestroyIncrement";
            this.btn_energyDestroyIncrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyDestroyIncrement.TabIndex = 13;
            this.btn_energyDestroyIncrement.Text = "+";
            this.btn_energyDestroyIncrement.UseVisualStyleBackColor = true;
            this.btn_energyDestroyIncrement.Click += new System.EventHandler(this.btn_energyDestroyIncrement_Click);
            // 
            // btn_energyDestroyDecrement
            // 
            this.btn_energyDestroyDecrement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_energyDestroyDecrement.Location = new System.Drawing.Point(78, 237);
            this.btn_energyDestroyDecrement.Name = "btn_energyDestroyDecrement";
            this.btn_energyDestroyDecrement.Size = new System.Drawing.Size(34, 27);
            this.btn_energyDestroyDecrement.TabIndex = 12;
            this.btn_energyDestroyDecrement.Text = "-";
            this.btn_energyDestroyDecrement.UseVisualStyleBackColor = true;
            this.btn_energyDestroyDecrement.Click += new System.EventHandler(this.btn_energyDestroyDecrement_Click);
            // 
            // lbl_energyDestroyed
            // 
            this.lbl_energyDestroyed.AutoSize = true;
            this.lbl_energyDestroyed.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_energyDestroyed.Location = new System.Drawing.Point(129, 231);
            this.lbl_energyDestroyed.Name = "lbl_energyDestroyed";
            this.lbl_energyDestroyed.Size = new System.Drawing.Size(32, 37);
            this.lbl_energyDestroyed.TabIndex = 11;
            this.lbl_energyDestroyed.Text = "0";
            // 
            // btn_endTurn
            // 
            this.btn_endTurn.Location = new System.Drawing.Point(77, 286);
            this.btn_endTurn.Name = "btn_endTurn";
            this.btn_endTurn.Size = new System.Drawing.Size(130, 37);
            this.btn_endTurn.TabIndex = 14;
            this.btn_endTurn.Text = "End Turn";
            this.btn_endTurn.UseVisualStyleBackColor = true;
            this.btn_endTurn.Click += new System.EventHandler(this.btn_endTurn_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(76, 329);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(77, 37);
            this.btn_clear.TabIndex = 15;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(152, 329);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(55, 37);
            this.btn_reset.TabIndex = 16;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Energy Destroyed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Energy Gained";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Energy Used";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 395);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_endTurn);
            this.Controls.Add(this.btn_energyDestroyIncrement);
            this.Controls.Add(this.btn_energyDestroyDecrement);
            this.Controls.Add(this.lbl_energyDestroyed);
            this.Controls.Add(this.btn_energyGainIncrement);
            this.Controls.Add(this.btn_energyGainDecrement);
            this.Controls.Add(this.lbl_energyGained);
            this.Controls.Add(this.btn_energyUsedIncrement);
            this.Controls.Add(this.btn_energyUsedDecrement);
            this.Controls.Add(this.lbl_energyUsed);
            this.Controls.Add(this.lbl_roundCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_energyCount);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Counter";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_energyCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_roundCount;
        private System.Windows.Forms.Label lbl_energyUsed;
        private System.Windows.Forms.Button btn_energyUsedDecrement;
        private System.Windows.Forms.Button btn_energyUsedIncrement;
        private System.Windows.Forms.Button btn_energyGainIncrement;
        private System.Windows.Forms.Button btn_energyGainDecrement;
        private System.Windows.Forms.Label lbl_energyGained;
        private System.Windows.Forms.Button btn_energyDestroyIncrement;
        private System.Windows.Forms.Button btn_energyDestroyDecrement;
        private System.Windows.Forms.Label lbl_energyDestroyed;
        private System.Windows.Forms.Button btn_endTurn;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

