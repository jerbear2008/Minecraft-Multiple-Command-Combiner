namespace Minecraft_Multiple_Command_Combiner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.richTextBoxCommandInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCommandOutput = new System.Windows.Forms.RichTextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.checkBoxDestroyAEx = new System.Windows.Forms.CheckBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSaveOutput = new System.Windows.Forms.Button();
            this.buttonSaveInput = new System.Windows.Forms.Button();
            this.buttonLoadInput = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.linkLabelGithub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Location = new System.Drawing.Point(66, 6);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(122, 21);
            this.comboBoxVersion.TabIndex = 1;
            // 
            // richTextBoxCommandInput
            // 
            this.richTextBoxCommandInput.Location = new System.Drawing.Point(12, 33);
            this.richTextBoxCommandInput.Name = "richTextBoxCommandInput";
            this.richTextBoxCommandInput.Size = new System.Drawing.Size(776, 300);
            this.richTextBoxCommandInput.TabIndex = 2;
            this.richTextBoxCommandInput.Text = "";
            // 
            // richTextBoxCommandOutput
            // 
            this.richTextBoxCommandOutput.Location = new System.Drawing.Point(12, 339);
            this.richTextBoxCommandOutput.Name = "richTextBoxCommandOutput";
            this.richTextBoxCommandOutput.ReadOnly = true;
            this.richTextBoxCommandOutput.Size = new System.Drawing.Size(776, 79);
            this.richTextBoxCommandOutput.TabIndex = 3;
            this.richTextBoxCommandOutput.Text = "";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(12, 424);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(541, 23);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // checkBoxDestroyAEx
            // 
            this.checkBoxDestroyAEx.AutoSize = true;
            this.checkBoxDestroyAEx.Checked = true;
            this.checkBoxDestroyAEx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDestroyAEx.Location = new System.Drawing.Point(194, 10);
            this.checkBoxDestroyAEx.Name = "checkBoxDestroyAEx";
            this.checkBoxDestroyAEx.Size = new System.Drawing.Size(135, 17);
            this.checkBoxDestroyAEx.TabIndex = 5;
            this.checkBoxDestroyAEx.Text = "Destroy after execution";
            this.checkBoxDestroyAEx.UseVisualStyleBackColor = true;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(559, 424);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(155, 23);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Version :";
            // 
            // buttonSaveOutput
            // 
            this.buttonSaveOutput.Location = new System.Drawing.Point(720, 424);
            this.buttonSaveOutput.Name = "buttonSaveOutput";
            this.buttonSaveOutput.Size = new System.Drawing.Size(68, 23);
            this.buttonSaveOutput.TabIndex = 8;
            this.buttonSaveOutput.Text = "Save";
            this.buttonSaveOutput.UseVisualStyleBackColor = true;
            this.buttonSaveOutput.Click += new System.EventHandler(this.buttonSaveOutput_Click);
            // 
            // buttonSaveInput
            // 
            this.buttonSaveInput.Location = new System.Drawing.Point(720, 4);
            this.buttonSaveInput.Name = "buttonSaveInput";
            this.buttonSaveInput.Size = new System.Drawing.Size(68, 23);
            this.buttonSaveInput.TabIndex = 9;
            this.buttonSaveInput.Text = "Save";
            this.buttonSaveInput.UseVisualStyleBackColor = true;
            this.buttonSaveInput.Click += new System.EventHandler(this.buttonSaveInput_Click);
            // 
            // buttonLoadInput
            // 
            this.buttonLoadInput.Location = new System.Drawing.Point(646, 4);
            this.buttonLoadInput.Name = "buttonLoadInput";
            this.buttonLoadInput.Size = new System.Drawing.Size(68, 23);
            this.buttonLoadInput.TabIndex = 10;
            this.buttonLoadInput.Text = "Load";
            this.buttonLoadInput.UseVisualStyleBackColor = true;
            this.buttonLoadInput.Click += new System.EventHandler(this.buttonLoadInput_Click);
            // 
            // linkLabelGithub
            // 
            this.linkLabelGithub.AutoSize = true;
            this.linkLabelGithub.Location = new System.Drawing.Point(602, 11);
            this.linkLabelGithub.Name = "linkLabelGithub";
            this.linkLabelGithub.Size = new System.Drawing.Size(38, 13);
            this.linkLabelGithub.TabIndex = 11;
            this.linkLabelGithub.TabStop = true;
            this.linkLabelGithub.Text = "Github";
            this.linkLabelGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGithub_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelGithub);
            this.Controls.Add(this.buttonLoadInput);
            this.Controls.Add(this.buttonSaveInput);
            this.Controls.Add(this.buttonSaveOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.checkBoxDestroyAEx);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.richTextBoxCommandOutput);
            this.Controls.Add(this.richTextBoxCommandInput);
            this.Controls.Add(this.comboBoxVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minecraft Multiple Command Combiner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.RichTextBox richTextBoxCommandInput;
        private System.Windows.Forms.RichTextBox richTextBoxCommandOutput;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.CheckBox checkBoxDestroyAEx;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSaveOutput;
        private System.Windows.Forms.Button buttonSaveInput;
        private System.Windows.Forms.Button buttonLoadInput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel linkLabelGithub;
    }
}

