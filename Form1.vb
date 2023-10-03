Imports System.Windows.Forms.Design

Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' MsgBox("the sum of =" & Val(TextBox1.Text) + Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("the subtraction of =" & Val(TextBox1.Text) - Val(TextBox2.Text))
        Label4.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("the multiplication of =" & Val(TextBox1.Text) * Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("the division of =" & Val(TextBox1.Text) / Val(TextBox2.Text))
        Label3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Label6.Text = Val(TextBox1.Text) * Val(TextBox2.Text)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Label7.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
