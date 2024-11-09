Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Latihan Operator"
        txtHasil.ReadOnly = True
    End Sub

    ' Deklarasi variabel untuk menyimpan nilai
    Private Function HitungOperasi(ByVal operasi As String) As String
        Try
            ' Validasi input
            If String.IsNullOrEmpty(txtNilaiA.Text) Or String.IsNullOrEmpty(txtNilaiB.Text) Then
                Return "Mohon isi kedua nilai"
            End If

            ' Konversi input ke decimal
            Dim nilaiA As Decimal = Decimal.Parse(txtNilaiA.Text)
            Dim nilaiB As Decimal = Decimal.Parse(txtNilaiB.Text)
            Dim hasil As Decimal

            ' Proses perhitungan sesuai operator
            Select Case operasi
                Case "+"
                    hasil = nilaiA + nilaiB
                Case "-"
                    hasil = nilaiA - nilaiB
                Case "/"
                    If nilaiB = 0 Then
                        Return "Tidak bisa dibagi dengan 0"
                    End If
                    hasil = nilaiA / nilaiB
                Case "*"
                    hasil = nilaiA * nilaiB
                Case "Mod"
                    If nilaiB = 0 Then
                        Return "Tidak bisa modulus dengan 0"
                    End If
                    hasil = nilaiA Mod nilaiB
                Case ">"
                    Return If(nilaiA > nilaiB, "True", "False")
                Case "<"
                    Return If(nilaiA < nilaiB, "True", "False")
                Case Else
                    Return "Operasi tidak valid"
            End Select

            Return hasil.ToString()

        Catch ex As FormatException
            Return "Input harus berupa angka"
        Catch ex As Exception
            Return "Terjadi kesalahan"
        End Try
    End Function

    ' Event handler untuk tombol operasi
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        txtHasil.Text = HitungOperasi("+")
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        txtHasil.Text = HitungOperasi("-")
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        txtHasil.Text = HitungOperasi("/")
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        txtHasil.Text = HitungOperasi("*")
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        txtHasil.Text = HitungOperasi("Mod")
    End Sub

    Private Sub btnLebihBesar_Click(sender As Object, e As EventArgs) Handles btnLebihBesar.Click
        txtHasil.Text = HitungOperasi(">")
    End Sub

    Private Sub btnLebihKecil_Click(sender As Object, e As EventArgs) Handles btnLebihKecil.Click
        txtHasil.Text = HitungOperasi("<")
    End Sub

    ' Event handler untuk tombol batal
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        txtNilaiA.Clear()
        txtNilaiB.Clear()
        txtHasil.Clear()
        txtNilaiA.Focus()
    End Sub

    ' Event handler untuk tombol keluar
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result As DialogResult = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class