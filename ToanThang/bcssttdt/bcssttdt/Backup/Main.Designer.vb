﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.statusbar = New System.Windows.Forms.StatusStrip
        Me.lblunit = New System.Windows.Forms.ToolStripStatusLabel
        Me.lbluser = New System.Windows.Forms.ToolStripStatusLabel
        Me.printer = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.mnu = New System.Windows.Forms.MenuStrip
        Me.ChucNangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ThoatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btnIN = New System.Windows.Forms.ToolStripButton
        Me.btnpreview = New System.Windows.Forms.ToolStripButton
        Me.btnrefresh2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btndkloc = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btnmform = New System.Windows.Forms.ToolStripButton
        Me.grd = New System.Windows.Forms.DataGridView
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.grddetail = New System.Windows.Forms.DataGridView
        Me.statusbar.SuspendLayout()
        Me.mnu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grddetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'statusbar
        '
        Me.statusbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblunit, Me.lbluser, Me.printer, Me.ToolStripStatusLabel1})
        Me.statusbar.Location = New System.Drawing.Point(0, 373)
        Me.statusbar.Name = "statusbar"
        Me.statusbar.Size = New System.Drawing.Size(727, 22)
        Me.statusbar.TabIndex = 0
        Me.statusbar.Text = "StatusStrip1"
        '
        'lblunit
        '
        Me.lblunit.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.lblunit.Name = "lblunit"
        Me.lblunit.Size = New System.Drawing.Size(30, 17)
        Me.lblunit.Text = "Unit"
        '
        'lbluser
        '
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(29, 17)
        Me.lbluser.Text = "User"
        '
        'printer
        '
        Me.printer.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left
        Me.printer.Name = "printer"
        Me.printer.Size = New System.Drawing.Size(43, 17)
        Me.printer.Text = "Printer"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(610, 17)
        Me.ToolStripStatusLabel1.Spring = True
        '
        'mnu
        '
        Me.mnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChucNangToolStripMenuItem})
        Me.mnu.Location = New System.Drawing.Point(0, 0)
        Me.mnu.Name = "mnu"
        Me.mnu.Size = New System.Drawing.Size(727, 24)
        Me.mnu.TabIndex = 1
        Me.mnu.Text = "MenuStrip1"
        '
        'ChucNangToolStripMenuItem
        '
        Me.ChucNangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThoatToolStripMenuItem})
        Me.ChucNangToolStripMenuItem.Name = "ChucNangToolStripMenuItem"
        Me.ChucNangToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ChucNangToolStripMenuItem.Tag = "200"
        Me.ChucNangToolStripMenuItem.Text = "Chuc nang"
        '
        'ThoatToolStripMenuItem
        '
        Me.ThoatToolStripMenuItem.Name = "ThoatToolStripMenuItem"
        Me.ThoatToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.ThoatToolStripMenuItem.Tag = "999"
        Me.ThoatToolStripMenuItem.Text = "Thoat"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIN, Me.btnpreview, Me.btnrefresh2, Me.ToolStripSeparator2, Me.btndkloc, Me.ToolStripSeparator1, Me.btnmform})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(727, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIN
        '
        Me.btnIN.Image = CType(resources.GetObject("btnIN.Image"), System.Drawing.Image)
        Me.btnIN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(37, 22)
        Me.btnIN.Tag = "201"
        Me.btnIN.Text = "In"
        '
        'btnpreview
        '
        Me.btnpreview.Image = CType(resources.GetObject("btnpreview.Image"), System.Drawing.Image)
        Me.btnpreview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnpreview.Name = "btnpreview"
        Me.btnpreview.Size = New System.Drawing.Size(47, 22)
        Me.btnpreview.Tag = "202"
        Me.btnpreview.Text = "Xem"
        '
        'btnrefresh2
        '
        Me.btnrefresh2.Image = CType(resources.GetObject("btnrefresh2.Image"), System.Drawing.Image)
        Me.btnrefresh2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnrefresh2.Name = "btnrefresh2"
        Me.btnrefresh2.Size = New System.Drawing.Size(64, 22)
        Me.btnrefresh2.Tag = "203"
        Me.btnrefresh2.Text = "lam tuoi"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btndkloc
        '
        Me.btndkloc.Image = CType(resources.GetObject("btndkloc.Image"), System.Drawing.Image)
        Me.btndkloc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btndkloc.Name = "btndkloc"
        Me.btndkloc.Size = New System.Drawing.Size(54, 22)
        Me.btndkloc.Tag = "001"
        Me.btndkloc.Text = "dk loc"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btnmform
        '
        Me.btnmform.Image = CType(resources.GetObject("btnmform.Image"), System.Drawing.Image)
        Me.btnmform.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnmform.Name = "btnmform"
        Me.btnmform.Size = New System.Drawing.Size(91, 22)
        Me.btnmform.Tag = "020"
        Me.btnmform.Text = "Khai bao mau"
        '
        'grd
        '
        Me.grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grd.Location = New System.Drawing.Point(0, 0)
        Me.grd.Name = "grd"
        Me.grd.Size = New System.Drawing.Size(727, 254)
        Me.grd.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 49)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grd)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grddetail)
        Me.SplitContainer1.Size = New System.Drawing.Size(727, 324)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.TabIndex = 4
        '
        'grddetail
        '
        Me.grddetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grddetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grddetail.Location = New System.Drawing.Point(0, 0)
        Me.grddetail.Name = "grddetail"
        Me.grddetail.Size = New System.Drawing.Size(727, 66)
        Me.grddetail.TabIndex = 4
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(727, 395)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.statusbar)
        Me.Controls.Add(Me.mnu)
        Me.MainMenuStrip = Me.mnu
        Me.Name = "MainForm"
        Me.Tag = "000"
        Me.Text = "Form1"
        Me.statusbar.ResumeLayout(False)
        Me.statusbar.PerformLayout()
        Me.mnu.ResumeLayout(False)
        Me.mnu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grddetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusbar As System.Windows.Forms.StatusStrip
    Friend WithEvents mnu As System.Windows.Forms.MenuStrip
    Friend WithEvents ChucNangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbluser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ThoatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnIN As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnpreview As System.Windows.Forms.ToolStripButton
    Friend WithEvents grd As System.Windows.Forms.DataGridView
    Friend WithEvents btndkloc As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnrefresh2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents printer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblunit As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnmform As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents grddetail As System.Windows.Forms.DataGridView

End Class