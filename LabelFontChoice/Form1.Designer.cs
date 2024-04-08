
namespace LabelFontChoice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelFontChoice = new System.Windows.Forms.Label();
            this.buttonSizeIncr = new System.Windows.Forms.Button();
            this.buttonSizeDecr = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFontChoice
            // 
            this.labelFontChoice.AutoSize = true;
            this.labelFontChoice.Location = new System.Drawing.Point(59, 71);
            this.labelFontChoice.Name = "labelFontChoice";
            this.labelFontChoice.Size = new System.Drawing.Size(124, 20);
            this.labelFontChoice.TabIndex = 0;
            this.labelFontChoice.Text = "Choice your font";
            // 
            // buttonSizeIncr
            // 
            this.buttonSizeIncr.Location = new System.Drawing.Point(357, 64);
            this.buttonSizeIncr.Name = "buttonSizeIncr";
            this.buttonSizeIncr.Size = new System.Drawing.Size(73, 34);
            this.buttonSizeIncr.TabIndex = 1;
            this.buttonSizeIncr.Text = "A+";
            this.buttonSizeIncr.UseVisualStyleBackColor = true;
            this.buttonSizeIncr.Click += new System.EventHandler(this.buttonSizeIncr_Click);
            // 
            // buttonSizeDecr
            // 
            this.buttonSizeDecr.Location = new System.Drawing.Point(436, 67);
            this.buttonSizeDecr.Name = "buttonSizeDecr";
            this.buttonSizeDecr.Size = new System.Drawing.Size(73, 29);
            this.buttonSizeDecr.TabIndex = 2;
            this.buttonSizeDecr.Text = "a -";
            this.buttonSizeDecr.UseVisualStyleBackColor = true;
            this.buttonSizeDecr.Click += new System.EventHandler(this.buttonSizeDecr_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18"});
            this.comboBoxSize.Location = new System.Drawing.Point(219, 68);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(132, 28);
            this.comboBoxSize.TabIndex = 3;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(528, 66);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(149, 30);
            this.buttonColor.TabIndex = 4;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.buttonSizeDecr);
            this.Controls.Add(this.buttonSizeIncr);
            this.Controls.Add(this.labelFontChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFontChoice;
        private System.Windows.Forms.Button buttonSizeIncr;
        private System.Windows.Forms.Button buttonSizeDecr;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Button buttonColor;
    }
}

