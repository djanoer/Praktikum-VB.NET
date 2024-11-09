<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcoba
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
        Me.Btntampilkan = New System.Windows.Forms.Button()
        Me.cbojeniskelamin = New System.Windows.Forms.ComboBox()
        Me.cbofakultas = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btntampilkan
        '
        Me.Btntampilkan.Location = New System.Drawing.Point(55, 171)
        Me.Btntampilkan.Name = "Btntampilkan"
        Me.Btntampilkan.Size = New System.Drawing.Size(194, 46)
        Me.Btntampilkan.TabIndex = 0
        Me.Btntampilkan.Text = "Tampilkan Pesan"
        Me.Btntampilkan.UseVisualStyleBackColor = True
        '
        'cbojeniskelamin
        '
        Me.cbojeniskelamin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbojeniskelamin.FormattingEnabled = True
        Me.cbojeniskelamin.Items.AddRange(New Object() {"Laki - Laki", "Perempuan"})
        Me.cbojeniskelamin.Location = New System.Drawing.Point(129, 87)
        Me.cbojeniskelamin.Name = "cbojeniskelamin"
        Me.cbojeniskelamin.Size = New System.Drawing.Size(121, 21)
        Me.cbojeniskelamin.TabIndex = 1
        '
        'cbofakultas
        '
        Me.cbofakultas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofakultas.FormattingEnabled = True
        Me.cbofakultas.Items.AddRange(New Object() {"FAI", "FBS", "FIA", "FIK", "FT"})
        Me.cbofakultas.Location = New System.Drawing.Point(129, 124)
        Me.cbofakultas.Name = "cbofakultas"
        Me.cbofakultas.Size = New System.Drawing.Size(120, 21)
        Me.cbofakultas.TabIndex = 2
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(129, 47)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(120, 20)
        Me.txtnama.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fakultas"
        '
        'Frmcoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.cbofakultas)
        Me.Controls.Add(Me.cbojeniskelamin)
        Me.Controls.Add(Me.Btntampilkan)
        Me.Name = "Frmcoba"
        Me.Text = "Percobaan Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btntampilkan As Button
    Friend WithEvents cbojeniskelamin As ComboBox
    Friend WithEvents cbofakultas As ComboBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
