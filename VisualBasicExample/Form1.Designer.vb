<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ListBoxForButtonClickExample = New System.Windows.Forms.ListBox()
        Me.cmdGetSingleImage = New System.Windows.Forms.Button()
        Me.PictureBoxForSingleClick = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxForDynamicLoad = New System.Windows.Forms.PictureBox()
        Me.ListBoxForLoadAlImageslExample = New System.Windows.Forms.ListBox()
        Me.dgvFruitPictures = New System.Windows.Forms.DataGridView()
        Me.PictureBoxForDataGridView = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdSaveCurrentImage = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.chkWaterMark = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBoxForSingleClick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxForDynamicLoad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFruitPictures, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxForDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxForButtonClickExample
        '
        Me.ListBoxForButtonClickExample.FormattingEnabled = True
        Me.ListBoxForButtonClickExample.Location = New System.Drawing.Point(6, 20)
        Me.ListBoxForButtonClickExample.Name = "ListBoxForButtonClickExample"
        Me.ListBoxForButtonClickExample.Size = New System.Drawing.Size(154, 121)
        Me.ListBoxForButtonClickExample.TabIndex = 0
        '
        'cmdGetSingleImage
        '
        Me.cmdGetSingleImage.Location = New System.Drawing.Point(6, 147)
        Me.cmdGetSingleImage.Name = "cmdGetSingleImage"
        Me.cmdGetSingleImage.Size = New System.Drawing.Size(75, 23)
        Me.cmdGetSingleImage.TabIndex = 1
        Me.cmdGetSingleImage.Text = "Get image"
        Me.cmdGetSingleImage.UseVisualStyleBackColor = True
        '
        'PictureBoxForSingleClick
        '
        Me.PictureBoxForSingleClick.BackColor = System.Drawing.Color.White
        Me.PictureBoxForSingleClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxForSingleClick.Location = New System.Drawing.Point(174, 20)
        Me.PictureBoxForSingleClick.Name = "PictureBoxForSingleClick"
        Me.PictureBoxForSingleClick.Size = New System.Drawing.Size(131, 121)
        Me.PictureBoxForSingleClick.TabIndex = 2
        Me.PictureBoxForSingleClick.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdSaveCurrentImage)
        Me.GroupBox1.Controls.Add(Me.PictureBoxForSingleClick)
        Me.GroupBox1.Controls.Add(Me.cmdGetSingleImage)
        Me.GroupBox1.Controls.Add(Me.ListBoxForButtonClickExample)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(311, 183)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Example get image from table on button click"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkWaterMark)
        Me.GroupBox2.Controls.Add(Me.PictureBoxForDynamicLoad)
        Me.GroupBox2.Controls.Add(Me.ListBoxForLoadAlImageslExample)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 206)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(305, 183)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Example images loaded at shown event"
        '
        'PictureBoxForDynamicLoad
        '
        Me.PictureBoxForDynamicLoad.BackColor = System.Drawing.Color.White
        Me.PictureBoxForDynamicLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxForDynamicLoad.Location = New System.Drawing.Point(166, 20)
        Me.PictureBoxForDynamicLoad.Name = "PictureBoxForDynamicLoad"
        Me.PictureBoxForDynamicLoad.Size = New System.Drawing.Size(131, 121)
        Me.PictureBoxForDynamicLoad.TabIndex = 2
        Me.PictureBoxForDynamicLoad.TabStop = False
        '
        'ListBoxForLoadAlImageslExample
        '
        Me.ListBoxForLoadAlImageslExample.FormattingEnabled = True
        Me.ListBoxForLoadAlImageslExample.Location = New System.Drawing.Point(6, 20)
        Me.ListBoxForLoadAlImageslExample.Name = "ListBoxForLoadAlImageslExample"
        Me.ListBoxForLoadAlImageslExample.Size = New System.Drawing.Size(154, 121)
        Me.ListBoxForLoadAlImageslExample.TabIndex = 0
        '
        'dgvFruitPictures
        '
        Me.dgvFruitPictures.AllowUserToAddRows = False
        Me.dgvFruitPictures.AllowUserToDeleteRows = False
        Me.dgvFruitPictures.BackgroundColor = System.Drawing.Color.White
        Me.dgvFruitPictures.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvFruitPictures.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvFruitPictures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFruitPictures.ColumnHeadersVisible = False
        Me.dgvFruitPictures.Location = New System.Drawing.Point(3, 19)
        Me.dgvFruitPictures.MultiSelect = False
        Me.dgvFruitPictures.Name = "dgvFruitPictures"
        Me.dgvFruitPictures.ReadOnly = True
        Me.dgvFruitPictures.RowHeadersVisible = False
        Me.dgvFruitPictures.RowTemplate.Height = 16
        Me.dgvFruitPictures.Size = New System.Drawing.Size(160, 126)
        Me.dgvFruitPictures.TabIndex = 0
        '
        'PictureBoxForDataGridView
        '
        Me.PictureBoxForDataGridView.BackColor = System.Drawing.Color.White
        Me.PictureBoxForDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxForDataGridView.Location = New System.Drawing.Point(171, 19)
        Me.PictureBoxForDataGridView.Name = "PictureBoxForDataGridView"
        Me.PictureBoxForDataGridView.Size = New System.Drawing.Size(131, 126)
        Me.PictureBoxForDataGridView.TabIndex = 3
        Me.PictureBoxForDataGridView.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PictureBoxForDataGridView)
        Me.GroupBox3.Controls.Add(Me.dgvFruitPictures)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 395)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(308, 155)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Example displaying from DataTable in DataGridView"
        '
        'cmdSaveCurrentImage
        '
        Me.cmdSaveCurrentImage.Location = New System.Drawing.Point(228, 147)
        Me.cmdSaveCurrentImage.Name = "cmdSaveCurrentImage"
        Me.cmdSaveCurrentImage.Size = New System.Drawing.Size(75, 23)
        Me.cmdSaveCurrentImage.TabIndex = 2
        Me.cmdSaveCurrentImage.Text = "Save"
        Me.cmdSaveCurrentImage.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Image|*.png"
        '
        'chkWaterMark
        '
        Me.chkWaterMark.AutoSize = True
        Me.chkWaterMark.Location = New System.Drawing.Point(6, 160)
        Me.chkWaterMark.Name = "chkWaterMark"
        Me.chkWaterMark.Size = New System.Drawing.Size(81, 17)
        Me.chkWaterMark.TabIndex = 3
        Me.chkWaterMark.Text = "Water mark"
        Me.chkWaterMark.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 559)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reading images"
        CType(Me.PictureBoxForSingleClick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxForDynamicLoad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFruitPictures, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxForDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxForButtonClickExample As ListBox
    Friend WithEvents cmdGetSingleImage As Button
    Friend WithEvents PictureBoxForSingleClick As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBoxForDynamicLoad As PictureBox
    Friend WithEvents ListBoxForLoadAlImageslExample As ListBox
    Friend WithEvents dgvFruitPictures As DataGridView
    Friend WithEvents PictureBoxForDataGridView As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmdSaveCurrentImage As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents chkWaterMark As CheckBox
End Class
