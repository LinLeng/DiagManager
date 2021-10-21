/**************************************************
beginning of licensing agreement
Microsoft Public License (Ms-PL)

This license governs use of the accompanying software. If you use the software, you accept this license. If you do not accept the license, do not use the software.

1. Definitions

The terms "reproduce," "reproduction," "derivative works," and "distribution" have the same meaning here as under U.S. copyright law.

A "contribution" is the original software, or any additions or changes to the software.

A "contributor" is any person that distributes its contribution under this license.

"Licensed patents" are a contributor's patent claims that read directly on its contribution.

2. Grant of Rights

(A) Copyright Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free copyright license to reproduce its contribution, prepare derivative works of its contribution, and distribute its contribution or any derivative works that you create.

(B) Patent Grant- Subject to the terms of this license, including the license conditions and limitations in section 3, each contributor grants you a non-exclusive, worldwide, royalty-free license under its licensed patents to make, have made, use, sell, offer for sale, import, and/or otherwise dispose of its contribution in the software or derivative works of the contribution in the software.

3. Conditions and Limitations

(A) No Trademark License- This license does not grant you rights to use any contributors' name, logo, or trademarks.

(B) If you bring a patent claim against any contributor over patents that you claim are infringed by the software, your patent license from such contributor to the software ends automatically.

(C) If you distribute any portion of the software, you must retain all copyright, patent, trademark, and attribution notices that are present in the software.

(D) If you distribute any portion of the software in source code form, you may do so only under this license by including a complete copy of this license with your distribution. If you distribute any portion of the software in compiled or object code form, you may only do so under a license that complies with this license.

(E) The software is licensed "as-is." You bear the risk of using it. The contributors give no express warranties, guarantees or conditions. You may have additional consumer rights under your local laws which this license cannot change. To the extent permitted under your local laws, the contributors exclude the implied warranties of merchantability, fitness for a particular purpose and non-infringement. 
end of licensing agreement
**************************************************/
namespace PssdiagConfig
{
    partial class fmSettings
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
            this.tlp_Settings_Overall = new System.Windows.Forms.TableLayoutPanel();
            this.txtDefaultPssdPath = new System.Windows.Forms.TextBox();
            this.tlp_setting_colorpicker = new System.Windows.Forms.TableLayoutPanel();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.lblShowColor = new System.Windows.Forms.Label();
            this.lblCurrentColorText = new System.Windows.Forms.Label();
            this.lblDefaultPath = new System.Windows.Forms.Label();
            this.lblBkColor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxCreateEmail = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.tlp_Settings_Overall.SuspendLayout();
            this.tlp_setting_colorpicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Settings_Overall
            // 
            this.tlp_Settings_Overall.ColumnCount = 2;
            this.tlp_Settings_Overall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Settings_Overall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_Settings_Overall.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Settings_Overall.Controls.Add(this.txtDefaultPssdPath, 1, 1);
            this.tlp_Settings_Overall.Controls.Add(this.tlp_setting_colorpicker, 1, 2);
            this.tlp_Settings_Overall.Controls.Add(this.lblDefaultPath, 0, 1);
            this.tlp_Settings_Overall.Controls.Add(this.lblBkColor, 0, 2);
            this.tlp_Settings_Overall.Controls.Add(this.label1, 0, 4);
            this.tlp_Settings_Overall.Controls.Add(this.chkBoxCreateEmail, 1, 4);
            this.tlp_Settings_Overall.Controls.Add(this.label2, 0, 7);
            this.tlp_Settings_Overall.Controls.Add(this.btnReset, 0, 6);
            this.tlp_Settings_Overall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Settings_Overall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlp_Settings_Overall.Location = new System.Drawing.Point(0, 0);
            this.tlp_Settings_Overall.Name = "tlp_Settings_Overall";
            this.tlp_Settings_Overall.RowCount = 8;
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tlp_Settings_Overall.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_Settings_Overall.Size = new System.Drawing.Size(639, 512);
            this.tlp_Settings_Overall.TabIndex = 0;
            // 
            // txtDefaultPssdPath
            // 
            this.txtDefaultPssdPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDefaultPssdPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDefaultPssdPath.Location = new System.Drawing.Point(162, 33);
            this.txtDefaultPssdPath.Name = "txtDefaultPssdPath";
            this.txtDefaultPssdPath.Size = new System.Drawing.Size(465, 24);
            this.txtDefaultPssdPath.TabIndex = 0;
            // 
            // tlp_setting_colorpicker
            // 
            this.tlp_setting_colorpicker.ColumnCount = 4;
            this.tlp_setting_colorpicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_setting_colorpicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_setting_colorpicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_setting_colorpicker.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tlp_setting_colorpicker.Controls.Add(this.btnPickColor, 0, 0);
            this.tlp_setting_colorpicker.Controls.Add(this.lblCurrentColorText, 1, 0);
            this.tlp_setting_colorpicker.Controls.Add(this.lblShowColor, 2, 0);
            this.tlp_setting_colorpicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.tlp_setting_colorpicker.Location = new System.Drawing.Point(162, 71);
            this.tlp_setting_colorpicker.Name = "tlp_setting_colorpicker";
            this.tlp_setting_colorpicker.RowCount = 1;
            this.tlp_setting_colorpicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_setting_colorpicker.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tlp_setting_colorpicker.Size = new System.Drawing.Size(474, 28);
            this.tlp_setting_colorpicker.TabIndex = 1;
            // 
            // btnPickColor
            // 
            this.btnPickColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPickColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPickColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPickColor.Location = new System.Drawing.Point(3, 3);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(75, 22);
            this.btnPickColor.TabIndex = 0;
            this.btnPickColor.Text = "Pick Color";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // lblShowColor
            // 
            this.lblShowColor.AutoSize = true;
            this.lblShowColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShowColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblShowColor.Location = new System.Drawing.Point(213, 0);
            this.lblShowColor.Name = "lblShowColor";
            this.lblShowColor.Size = new System.Drawing.Size(54, 28);
            this.lblShowColor.TabIndex = 2;
            this.lblShowColor.Text = "       ";
            this.lblShowColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCurrentColorText
            // 
            this.lblCurrentColorText.AutoSize = true;
            this.lblCurrentColorText.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCurrentColorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentColorText.Location = new System.Drawing.Point(128, 0);
            this.lblCurrentColorText.Name = "lblCurrentColorText";
            this.lblCurrentColorText.Size = new System.Drawing.Size(79, 28);
            this.lblCurrentColorText.TabIndex = 1;
            this.lblCurrentColorText.Text = "Current Color";
            this.lblCurrentColorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDefaultPath
            // 
            this.lblDefaultPath.AutoSize = true;
            this.lblDefaultPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDefaultPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultPath.Location = new System.Drawing.Point(3, 30);
            this.lblDefaultPath.Name = "lblDefaultPath";
            this.lblDefaultPath.Size = new System.Drawing.Size(142, 38);
            this.lblDefaultPath.TabIndex = 2;
            this.lblDefaultPath.Text = "Default PSSDIAG Path";
            this.lblDefaultPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBkColor
            // 
            this.lblBkColor.AutoSize = true;
            this.lblBkColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblBkColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBkColor.Location = new System.Drawing.Point(3, 68);
            this.lblBkColor.Name = "lblBkColor";
            this.lblBkColor.Size = new System.Drawing.Size(116, 34);
            this.lblBkColor.TabIndex = 3;
            this.lblBkColor.Text = "Background Color";
            this.lblBkColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create Email on Save";
            // 
            // chkBoxCreateEmail
            // 
            this.chkBoxCreateEmail.AutoSize = true;
            this.chkBoxCreateEmail.Checked = true;
            this.chkBoxCreateEmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxCreateEmail.Location = new System.Drawing.Point(162, 119);
            this.chkBoxCreateEmail.Name = "chkBoxCreateEmail";
            this.chkBoxCreateEmail.Size = new System.Drawing.Size(15, 14);
            this.chkBoxCreateEmail.TabIndex = 6;
            this.chkBoxCreateEmail.UseVisualStyleBackColor = true;
            this.chkBoxCreateEmail.CheckedChanged += new System.EventHandler(this.chkBoxCreateEmail_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tlp_Settings_Overall.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "* Settings are saved when Settings window is closed";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(3, 453);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset to Defaults";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // fmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 512);
            this.Controls.Add(this.tlp_Settings_Overall);
            this.Name = "fmSettings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmSettings_FormClosing);
            this.Load += new System.EventHandler(this.fmSettings_Load);
            this.tlp_Settings_Overall.ResumeLayout(false);
            this.tlp_Settings_Overall.PerformLayout();
            this.tlp_setting_colorpicker.ResumeLayout(false);
            this.tlp_setting_colorpicker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Settings_Overall;
        private System.Windows.Forms.TextBox txtDefaultPssdPath;
        private System.Windows.Forms.TableLayoutPanel tlp_setting_colorpicker;
        private System.Windows.Forms.Button btnPickColor;
        private System.Windows.Forms.Label lblCurrentColorText;
        private System.Windows.Forms.Label lblShowColor;
        private System.Windows.Forms.Label lblDefaultPath;
        private System.Windows.Forms.Label lblBkColor;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxCreateEmail;
        private System.Windows.Forms.Label label2;
    }
}