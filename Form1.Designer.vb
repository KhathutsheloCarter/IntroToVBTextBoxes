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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnGreet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(121, 76)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(92, 25)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "FirstName"
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(110, 157)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(90, 25)
        Me.lblLastname.TabIndex = 1
        Me.lblLastname.Text = "LastName"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Location = New System.Drawing.Point(121, 221)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(69, 25)
        Me.lblGender.TabIndex = 2
        Me.lblGender.Text = "Gender"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(246, 70)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(150, 31)
        Me.txtFirstName.TabIndex = 3
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(246, 215)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(150, 31)
        Me.txtGender.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(246, 151)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(150, 31)
        Me.txtLastName.TabIndex = 5
        '
        'btnGreet
        '
        Me.btnGreet.Location = New System.Drawing.Point(190, 337)
        Me.btnGreet.Name = "btnGreet"
        Me.btnGreet.Size = New System.Drawing.Size(169, 92)
        Me.btnGreet.TabIndex = 6
        Me.btnGreet.Text = "Greet Me"
        Me.btnGreet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnGreet)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.lblFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastname As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents btnGreet As Button
End Class
