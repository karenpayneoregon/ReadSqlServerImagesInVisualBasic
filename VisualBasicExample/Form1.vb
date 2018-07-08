Imports System.IO
Imports VisualBasicExamples.Classes

Public Class Form1

    Private ReadOnly _ops As DataOperations = New DataOperations
    Private ReadOnly _bs As BindingSource = New BindingSource

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        SaveFileDialog1.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory

        '
        ' Load ListBox with id and description, no picture
        '
        ListBoxForButtonClickExample.DataSource = _ops.GetFruits()

        cmdGetSingleImage.PerformClick()

        '
        ' Load ListBox with id, description and picture
        '
        ListBoxForLoadAlImageslExample.DataSource = _ops.GetFruitsWithImagesFromList()

        '
        ' Load DataGridView via BindingSource set to a DataTable with id, description and picture
        '
        _bs.DataSource = _ops.DataTable()
        dgvFruitPictures.DataSource = _bs
        dgvFruitPictures.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

        '
        ' Setup PictureBox for displaying current image of 
        ' our BindingSource assigned to the DataGridView
        '
        Dim imageBinding As New Binding("Image", _bs, "Picture")
        AddHandler imageBinding.Format, AddressOf BindImage
        PictureBoxForDataGridView.DataBindings.Add(imageBinding)

    End Sub
    ''' <summary>
    ''' Get current image by primary key
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdGetSingleImage_Click(sender As Object, e As EventArgs) Handles cmdGetSingleImage.Click
        Dim primaryKey = CType(ListBoxForButtonClickExample.SelectedItem, Fruit).Id
        PictureBoxForSingleClick.Image = _ops.GetImage(primaryKey)
    End Sub
    ''' <summary>
    ''' Save current image return via primary key
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub cmdSaveCurrentImage_Click(sender As Object, e As EventArgs) Handles cmdSaveCurrentImage.Click
        SaveFileDialog1.FileName = ListBoxForButtonClickExample.Text.Replace(" ", "")
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim primaryKey = CType(ListBoxForButtonClickExample.SelectedItem, Fruit).Id
            _ops.GetImage(primaryKey).Save(SaveFileDialog1.FileName)
        End If
    End Sub
    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ListBoxForLoadAlImageslExample.SelectedIndexChanged

        If chkWaterMark.Checked Then
            Dim color = Drawing.Color.Black

            If ListBoxForLoadAlImageslExample.Text.StartsWith("Red") Then
                color = Drawing.Color.Azure
            End If


            Dim bmp = New Bitmap(CType(ListBoxForLoadAlImageslExample.SelectedItem, Fruit).Picture)
            Dim canvas As Graphics = Graphics.FromImage(bmp)

            canvas.DrawString("code sample",
                              New Font("Arial", 9, FontStyle.Regular),
                              New SolidBrush(color), 10, 50)

            PictureBoxForDynamicLoad.Image = bmp

        Else
            PictureBoxForDynamicLoad.Image = CType(ListBoxForLoadAlImageslExample.SelectedItem, Fruit).Picture
        End If

    End Sub
    Private Sub BindImage(sender As Object, e As ConvertEventArgs)

        If e.DesiredType Is GetType(Image) Then
            Using ms As New MemoryStream(CType(e.Value, Byte()))
                Dim logo = Image.FromStream(ms)
                e.Value = logo
            End Using
        End If

    End Sub
    ''' <summary>
    ''' Force loading image with or without water mark
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub chkWaterMark_CheckedChanged(sender As Object, e As EventArgs) Handles chkWaterMark.CheckedChanged
        ListBox2_SelectedIndexChanged(Nothing, EventArgs.Empty)
    End Sub
End Class

