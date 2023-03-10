Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add("Rota: " + ComboBox1.Text + " - " + ComboBox2.Text + " Tarih: " + DateTimePicker1.Text + " Saat: " + MaskedTextBox1.Text + " Yolcu Bilgileri ~ Ad: " + TextBox1.Text + " TC: " + MaskedTextBox2.Text + " Telefon: " + MaskedTextBox3.Text)
        MessageBox.Show("Yolcu kaydı yapıldı")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label9.Text = ComboBox2.Text
        ComboBox2.Text = ComboBox1.Text
        ComboBox1.Text = Label9.Text
    End Sub
End Class
