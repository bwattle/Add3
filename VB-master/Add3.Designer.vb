<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add3))
        Me.txtNumber_1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNumber_2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumber_3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalSum = New System.Windows.Forms.TextBox()
        Me.BtnCalcSum = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNumber_1
        '
        Me.txtNumber_1.Location = New System.Drawing.Point(98, 41)
        Me.txtNumber_1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumber_1.Name = "txtNumber_1"
        Me.txtNumber_1.Size = New System.Drawing.Size(104, 20)
        Me.txtNumber_1.TabIndex = 0
        Me.txtNumber_1.Text = "Enter #1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "1st Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 70)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "2nd Number"
        '
        'txtNumber_2
        '
        Me.txtNumber_2.Location = New System.Drawing.Point(98, 68)
        Me.txtNumber_2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumber_2.Name = "txtNumber_2"
        Me.txtNumber_2.Size = New System.Drawing.Size(104, 20)
        Me.txtNumber_2.TabIndex = 1
        Me.txtNumber_2.Text = "Enter #2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "3rd Number"
        '
        'txtNumber_3
        '
        Me.txtNumber_3.Location = New System.Drawing.Point(98, 97)
        Me.txtNumber_3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNumber_3.Name = "txtNumber_3"
        Me.txtNumber_3.Size = New System.Drawing.Size(104, 20)
        Me.txtNumber_3.TabIndex = 2
        Me.txtNumber_3.Text = "Enter #3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sum "
        '
        'txtTotalSum
        '
        Me.txtTotalSum.Location = New System.Drawing.Point(98, 172)
        Me.txtTotalSum.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalSum.Name = "txtTotalSum"
        Me.txtTotalSum.Size = New System.Drawing.Size(104, 20)
        Me.txtTotalSum.TabIndex = 6
        Me.txtTotalSum.Text = "Answer"
        '
        'BtnCalcSum
        '
        Me.BtnCalcSum.Location = New System.Drawing.Point(34, 131)
        Me.BtnCalcSum.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCalcSum.Name = "BtnCalcSum"
        Me.BtnCalcSum.Size = New System.Drawing.Size(168, 22)
        Me.BtnCalcSum.TabIndex = 3
        Me.BtnCalcSum.Text = "Calculate Sum"
        Me.BtnCalcSum.UseVisualStyleBackColor = True
        '
        'Add3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 248)
        Me.Controls.Add(Me.BtnCalcSum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTotalSum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNumber_3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumber_2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNumber_1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Add3"
        Me.Text = "v101 Add3 Concatenates."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNumber_1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNumber_2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNumber_3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalSum As TextBox
    Friend WithEvents BtnCalcSum As Button
End Class
