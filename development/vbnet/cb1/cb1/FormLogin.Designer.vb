<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonMasuk = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnLogout = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Constantia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 103)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kenyamanan Inap di "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Constantia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SpringGreen
        Me.Label2.Location = New System.Drawing.Point(154, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hot"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Constantia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(224, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 45)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "tel"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Constantia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(372, 77)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hotel kami menyediakan pengalaman menginap yang istimewa dengan pelayanan ramah d" &
    "an fasilitas yang modern, menciptakan suasana yang nyaman dan tak terlupakan bag" &
    "i para tamu"
        '
        'ButtonMasuk
        '
        Me.ButtonMasuk.BackColor = System.Drawing.Color.SpringGreen
        Me.ButtonMasuk.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMasuk.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMasuk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonMasuk.Location = New System.Drawing.Point(32, 290)
        Me.ButtonMasuk.Name = "ButtonMasuk"
        Me.ButtonMasuk.Size = New System.Drawing.Size(117, 35)
        Me.ButtonMasuk.TabIndex = 4
        Me.ButtonMasuk.Text = "Checking Now"
        Me.ButtonMasuk.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.cb1.My.Resources.Resources.p1
        Me.PictureBox1.Location = New System.Drawing.Point(415, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 348)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnLogout.Location = New System.Drawing.Point(635, 12)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(74, 24)
        Me.BtnLogout.TabIndex = 7
        Me.BtnLogout.Text = "Keluar"
        Me.BtnLogout.UseVisualStyleBackColor = False
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(732, 450)
        Me.Controls.Add(Me.BtnLogout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonMasuk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonMasuk As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLogout As Button
End Class
