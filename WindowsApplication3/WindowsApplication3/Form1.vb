Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NIK"
        arr(0, 1) = "Nama"
        arr(1, 0) = "Jenis Kelamin"
        arr(1, 1) = "Status"
        arr(2, 0) = "Laki-laki"
        arr(2, 1) = "Perempuan"
        arr(3, 0) = "Menikah"
        arr(3, 1) = "Belum Menikah"

        ListView1.GridLines = True
        ListView1.View = View.Details

        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next
        Next

        For baris = 2 To 2
            For kolom = 0 To 1
                ComboBox1.Items.Add(arr(baris, kolom))
            Next
        Next

        For baris = 3 To 3
            For kolom = 0 To 1
                ComboBox2.Items.Add(arr(baris, kolom))
            Next
        Next
        TextBox2.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(4) As String
        arr(0) = TextBox1.Text
        arr(1) = TextBox2.Text
        arr(2) = ComboBox1.Text
        arr(3) = ComboBox2.Text

        Dim list As New ListViewItem
        list = ListView1.Items.Add(arr(0))
        list.SubItems.Add(arr(1))
        list.SubItems.Add(arr(2))
        list.SubItems.Add(arr(3))

        TextBox1.Text = ""
        TextBox2.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox2.Focus()
    End Sub
    Private Sub Listview1_ColumnClick(sender As System.Object, e As System.Windows.Forms.ColumnClickEventArgs) Handles ListView1.ColumnClick
        If ListView1.Sorting = SortOrder.Descending Then
            ListView1.Sorting = SortOrder.Ascending
        Else
            ListView1.Sorting = SortOrder.Descending
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim Bold3 As Font = New Font(Me.Font.FontFamily, Me.FontHeight + 1, FontStyle.Bold)
        TextBox3.Font = Bold3
        TextBox3.ReadOnly = True
    End Sub
End Class
