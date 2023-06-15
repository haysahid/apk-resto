Public Class FormKategori
    Private Sub RefreshGrid()
        DTGrid = KontrolKategori.tampilData.ToTable
        DGKategori.DataSource = DTGrid
    End Sub

    Private Sub FormKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class