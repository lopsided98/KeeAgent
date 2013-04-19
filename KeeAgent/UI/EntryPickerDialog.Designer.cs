﻿namespace KeeAgent.UI
{
  partial class EntryPickerDialog
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
      if (disposing && (components != null)) {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryPickerDialog));
      this.mCancelButton = new System.Windows.Forms.Button();
      this.mOkButton = new System.Windows.Forms.Button();
      this.mCustomTreeViewEx = new KeeAgent.UI.TreeViewEx();
      this.mTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.mConfirmConstraintControl = new KeeAgent.UI.ConfirmConstraintControl();
      this.mLifetimeConstraintControl = new KeeAgent.UI.LifetimeConstraintControl();
      this.mTableLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // mCancelButton
      // 
      this.mCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.mCancelButton.Location = new System.Drawing.Point(289, 388);
      this.mCancelButton.Name = "mCancelButton";
      this.mCancelButton.Size = new System.Drawing.Size(75, 23);
      this.mCancelButton.TabIndex = 1;
      this.mCancelButton.Text = "Cancel";
      this.mCancelButton.UseVisualStyleBackColor = true;
      // 
      // mOkButton
      // 
      this.mOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.mOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.mOkButton.Location = new System.Drawing.Point(208, 388);
      this.mOkButton.Name = "mOkButton";
      this.mOkButton.Size = new System.Drawing.Size(75, 23);
      this.mOkButton.TabIndex = 2;
      this.mOkButton.Text = "OK";
      this.mOkButton.UseVisualStyleBackColor = true;
      // 
      // mCustomTreeViewEx
      // 
      this.mCustomTreeViewEx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mCustomTreeViewEx.Location = new System.Drawing.Point(12, 12);
      this.mCustomTreeViewEx.Name = "mCustomTreeViewEx";
      this.mCustomTreeViewEx.ShowNodeToolTips = true;
      this.mCustomTreeViewEx.Size = new System.Drawing.Size(352, 341);
      this.mCustomTreeViewEx.TabIndex = 0;
      this.mCustomTreeViewEx.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.customTreeViewEx_AfterSelect);
      this.mCustomTreeViewEx.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.customTreeViewEx_NodeMouseDoubleClick);
      // 
      // mTableLayoutPanel
      // 
      this.mTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.mTableLayoutPanel.AutoSize = true;
      this.mTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.mTableLayoutPanel.ColumnCount = 2;
      this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.mTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.mTableLayoutPanel.Controls.Add(this.mConfirmConstraintControl, 0, 0);
      this.mTableLayoutPanel.Controls.Add(this.mLifetimeConstraintControl, 1, 0);
      this.mTableLayoutPanel.Location = new System.Drawing.Point(12, 356);
      this.mTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
      this.mTableLayoutPanel.Name = "mTableLayoutPanel";
      this.mTableLayoutPanel.RowCount = 1;
      this.mTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.mTableLayoutPanel.Size = new System.Drawing.Size(352, 26);
      this.mTableLayoutPanel.TabIndex = 3;
      // 
      // mConfirmConstraintControl
      // 
      this.mConfirmConstraintControl.AutoSize = true;
      this.mConfirmConstraintControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.mConfirmConstraintControl.BackColor = System.Drawing.Color.Transparent;
      this.mConfirmConstraintControl.Checked = false;
      this.mConfirmConstraintControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mConfirmConstraintControl.Location = new System.Drawing.Point(10, 0);
      this.mConfirmConstraintControl.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
      this.mConfirmConstraintControl.Name = "mConfirmConstraintControl";
      this.mConfirmConstraintControl.Size = new System.Drawing.Size(166, 26);
      this.mConfirmConstraintControl.TabIndex = 0;
      // 
      // mLifetimeConstraintControl
      // 
      this.mLifetimeConstraintControl.AutoSize = true;
      this.mLifetimeConstraintControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.mLifetimeConstraintControl.Checked = false;
      this.mLifetimeConstraintControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mLifetimeConstraintControl.Lifetime = ((uint)(600u));
      this.mLifetimeConstraintControl.Location = new System.Drawing.Point(176, 0);
      this.mLifetimeConstraintControl.Margin = new System.Windows.Forms.Padding(0);
      this.mLifetimeConstraintControl.Name = "mLifetimeConstraintControl";
      this.mLifetimeConstraintControl.Size = new System.Drawing.Size(176, 26);
      this.mLifetimeConstraintControl.TabIndex = 1;
      // 
      // EntryPickerDialog
      // 
      this.AcceptButton = this.mOkButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.mCancelButton;
      this.ClientSize = new System.Drawing.Size(376, 420);
      this.Controls.Add(this.mTableLayoutPanel);
      this.Controls.Add(this.mOkButton);
      this.Controls.Add(this.mCancelButton);
      this.Controls.Add(this.mCustomTreeViewEx);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EntryPickerDialog";
      this.ShowInTaskbar = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Select Entry";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntryPickerDialog_FormClosing);
      this.mTableLayoutPanel.ResumeLayout(false);
      this.mTableLayoutPanel.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button mCancelButton;
    private System.Windows.Forms.Button mOkButton;
    private KeeAgent.UI.TreeViewEx mCustomTreeViewEx;
    private System.Windows.Forms.TableLayoutPanel mTableLayoutPanel;
    private ConfirmConstraintControl mConfirmConstraintControl;
    private LifetimeConstraintControl mLifetimeConstraintControl;
  }
}