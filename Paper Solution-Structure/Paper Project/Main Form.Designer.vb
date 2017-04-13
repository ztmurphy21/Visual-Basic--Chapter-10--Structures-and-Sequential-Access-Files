<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.chkDisc = New System.Windows.Forms.CheckBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Paper_Project.My.Resources.Resources.Wallpaper
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 140)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(146, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(142, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Price:"
        '
        'lblPrice
        '
        Me.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPrice.Location = New System.Drawing.Point(146, 110)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(90, 27)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtId.Location = New System.Drawing.Point(146, 58)
        Me.txtId.MaxLength = 4
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(59, 27)
        Me.txtId.TabIndex = 1
        '
        'chkDisc
        '
        Me.chkDisc.AutoSize = true
        Me.chkDisc.Location = New System.Drawing.Point(224, 33)
        Me.chkDisc.Name = "chkDisc"
        Me.chkDisc.Size = New System.Drawing.Size(154, 24)
        Me.chkDisc.TabIndex = 2
        Me.chkDisc.Text = "&Employee discount"
        Me.chkDisc.UseVisualStyleBackColor = true
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(282, 79)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(96, 31)
        Me.btnGet.TabIndex = 3
        Me.btnGet.Text = "&Get Price"
        Me.btnGet.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(282, 116)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 31)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 180)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGet)
        Me.Controls.Add(Me.chkDisc)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paper Warehouse"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fill array with IDs and prices
        priceList(0).strId = "A45G"
        priceList(0).dblPrice = 8.99
        priceList(1).strId = "J63Y"
        priceList(1).dblPrice = 12.99
        priceList(2).strId = "M93K"
        priceList(2).dblPrice = 5.99
        priceList(3).strId = "C20P"
        priceList(3).dblPrice = 13.5
        priceList(4).strId = "F77T"
        priceList(4).dblPrice = 7.25
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents chkDisc As CheckBox
    Friend WithEvents btnGet As Button
    Friend WithEvents btnExit As Button
End Class
