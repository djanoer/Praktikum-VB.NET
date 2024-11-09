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
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.txtNilaiA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNilaiB = New System.Windows.Forms.TextBox()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnKurang = New System.Windows.Forms.Button()
        Me.btnBagi = New System.Windows.Forms.Button()
        Me.btnKali = New System.Windows.Forms.Button()
        Me.btnMod = New System.Windows.Forms.Button()
        Me.btnLebihBesar = New System.Windows.Forms.Button()
        Me.btnLebihKecil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(332, 74)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(110, 37)
        Me.btnBatal.TabIndex = 0
        Me.btnBatal.Text = "BATAL"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'txtNilaiA
        '
        Me.txtNilaiA.Location = New System.Drawing.Point(170, 74)
        Me.txtNilaiA.Name = "txtNilaiA"
        Me.txtNilaiA.Size = New System.Drawing.Size(121, 20)
        Me.txtNilaiA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input Nilai Bilangan A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Input Nilai Bilangan B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Hasil Operasi"
        '
        'txtNilaiB
        '
        Me.txtNilaiB.Location = New System.Drawing.Point(170, 119)
        Me.txtNilaiB.Name = "txtNilaiB"
        Me.txtNilaiB.Size = New System.Drawing.Size(121, 20)
        Me.txtNilaiB.TabIndex = 5
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(170, 160)
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(121, 20)
        Me.txtHasil.TabIndex = 6
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(332, 143)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(110, 37)
        Me.btnKeluar.TabIndex = 7
        Me.btnKeluar.Text = "KELUAR"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambah.Location = New System.Drawing.Point(38, 204)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(47, 31)
        Me.btnTambah.TabIndex = 8
        Me.btnTambah.Text = "+"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnKurang
        '
        Me.btnKurang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKurang.Location = New System.Drawing.Point(96, 204)
        Me.btnKurang.Name = "btnKurang"
        Me.btnKurang.Size = New System.Drawing.Size(47, 31)
        Me.btnKurang.TabIndex = 9
        Me.btnKurang.Text = "-"
        Me.btnKurang.UseVisualStyleBackColor = True
        '
        'btnBagi
        '
        Me.btnBagi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBagi.Location = New System.Drawing.Point(157, 204)
        Me.btnBagi.Name = "btnBagi"
        Me.btnBagi.Size = New System.Drawing.Size(47, 31)
        Me.btnBagi.TabIndex = 10
        Me.btnBagi.Text = "/"
        Me.btnBagi.UseVisualStyleBackColor = True
        '
        'btnKali
        '
        Me.btnKali.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKali.Location = New System.Drawing.Point(220, 204)
        Me.btnKali.Name = "btnKali"
        Me.btnKali.Size = New System.Drawing.Size(47, 31)
        Me.btnKali.TabIndex = 11
        Me.btnKali.Text = "*"
        Me.btnKali.UseVisualStyleBackColor = True
        '
        'btnMod
        '
        Me.btnMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMod.Location = New System.Drawing.Point(284, 204)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(47, 31)
        Me.btnMod.TabIndex = 12
        Me.btnMod.Text = "Mod"
        Me.btnMod.UseVisualStyleBackColor = True
        '
        'btnLebihBesar
        '
        Me.btnLebihBesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLebihBesar.Location = New System.Drawing.Point(38, 254)
        Me.btnLebihBesar.Name = "btnLebihBesar"
        Me.btnLebihBesar.Size = New System.Drawing.Size(47, 31)
        Me.btnLebihBesar.TabIndex = 13
        Me.btnLebihBesar.Text = ">"
        Me.btnLebihBesar.UseVisualStyleBackColor = True
        '
        'btnLebihKecil
        '
        Me.btnLebihKecil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLebihKecil.Location = New System.Drawing.Point(96, 254)
        Me.btnLebihKecil.Name = "btnLebihKecil"
        Me.btnLebihKecil.Size = New System.Drawing.Size(47, 31)
        Me.btnLebihKecil.TabIndex = 14
        Me.btnLebihKecil.Text = "<"
        Me.btnLebihKecil.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 311)
        Me.Controls.Add(Me.btnLebihKecil)
        Me.Controls.Add(Me.btnLebihBesar)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnKali)
        Me.Controls.Add(Me.btnBagi)
        Me.Controls.Add(Me.btnKurang)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.txtNilaiB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNilaiA)
        Me.Controls.Add(Me.btnBatal)
        Me.Name = "Form1"
        Me.Text = "Latihan Operator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBatal As Button
    Friend WithEvents txtNilaiA As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNilaiB As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents btnLebihBesar As Button
    Friend WithEvents btnLebihKecil As Button
End Class
