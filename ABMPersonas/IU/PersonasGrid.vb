Public Class PersonasGrid

    Private Sub llenarform()
        PersonasForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        PersonasForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        PersonasForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        PersonasForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        PersonasForm.TextBox7.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        PersonasForm.ComboBox1.SelectedItem = DataGridView1.CurrentRow.Cells(4).Value.ToString
        PersonasForm.ComboBox2.SelectedItem = DataGridView1.CurrentRow.Cells(6).Value.ToString
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PersonasForm.operacion = "nuevo"
        PersonasForm.Text = "Alta de Personas"
        PersonasForm.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        PersonasForm.operacion = "elimina"
        PersonasForm.Text = "Eliminar Persona"
        PersonasForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        PersonasForm.Show()
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        PersonasForm.operacion = "modifica"
        PersonasForm.Text = "modificar Personas"
        PersonasForm.indice = DataGridView1.CurrentRow.Index
        llenarform()
        PersonasForm.Show()
    End Sub

    Private Sub ToolStripButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.Close()
    End Sub

    Private Sub PersonasGrid_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        DataGridView1.DataSource = lst
    End Sub

End Class


