Imports System.Data.SqlClient
Imports System.IO

Namespace Classes
    ''' <summary>
    ''' Responsible for reading images from a SQL-Server database table.
    ''' 
    ''' </summary>
    ''' <remarks>
    ''' Each method has code susceptible to runtime exceptions from
    ''' reading data in try/catch blocks and "as is" will not report
    ''' an exception back to the calling code.
    ''' 
    ''' To report exceptions back to the caller use
    ''' 
    ''' If _ops.HasException Then
    '''     MessageBox.Show(_ops.LastExceptionMessage)
    ''' End If
    ''' 
    ''' </remarks>
    Public Class DataOperations
        Inherits BaseSqlServerConnection

        Private _pinvalidImage As Image
        ''' <summary>
        ''' This image is used when there are issues reading a image from a table
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property InvalidImage() As Image
            Get
                Return _pinvalidImage
            End Get
        End Property
        ''' <summary>
        ''' Setup error image
        ''' </summary>
        Public Sub New()

            _pinvalidImage = ConvertTextToImage(
                Environment.NewLine & "    Error",
                "Arial", 20,
                Color.Red, Color.White,
                300, 200)

        End Sub
        ''' <summary>
        ''' Read all records excluding Picture field
        ''' </summary>
        ''' <returns></returns>
        Public Function GetFruits() As List(Of Fruit)

            Dim fruitList As New List(Of Fruit)

            Using cn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand("SELECT id ,[Description] FROM dbo.Fruits", cn)
                    Try
                        cn.Open()
                        Dim reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            fruitList.Add(New Fruit() With
                                             {
                                                 .Id = reader.GetInt32(0),
                                                 .Description = reader.GetString(1)
                                             })

                        End While

                        ' add invalid item, there are only three records in the table
                        fruitList.Add(New Fruit() With {.Id = 100, .Description = "Does not exist"})

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return fruitList

        End Function
        ''' <summary>
        ''' Read all records with all fields
        ''' </summary>
        ''' <returns></returns>
        Public Function GetFruitsWithImagesFromList() As List(Of Fruit)
            Dim fruitImage As Image = Nothing
            Dim fruitList As New List(Of Fruit)

            Using cn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand("SELECT id ,[Description], Picture FROM dbo.Fruits", cn)
                    Try
                        cn.Open()
                        Dim reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim imageData = CType(reader(2), Byte())

                            If imageData IsNot Nothing Then

                                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                                    ms.Write(imageData, 0, imageData.Length)
                                    fruitImage = Image.FromStream(ms, True)
                                End Using

                            Else
                                fruitImage = InvalidImage
                            End If

                            fruitList.Add(New Fruit() With
                                        {
                                            .Id = reader.GetInt32(0),
                                            .Description = reader.GetString(1),
                                            .Picture = fruitImage
                                        })
                        End While

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return fruitList

        End Function
        ''' <summary>
        ''' Read images by a comma delimited list of the primary key id
        ''' </summary>
        ''' <param name="pKeys"></param>
        ''' <returns></returns>
        Public Function GetFruitsWithImagesFromList(pKeys As String) As List(Of Fruit)
            Dim fruitImage As Image = Nothing
            Dim fruitList As New List(Of Fruit)

            Using cn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand($"SELECT id ,[Description], Picture FROM dbo.Fruits WHERE id IN ({pKeys})", cn)
                    Try
                        cn.Open()
                        Dim reader As SqlDataReader = cmd.ExecuteReader()

                        While reader.Read()

                            Dim imageData = CType(reader(2), Byte())

                            If imageData IsNot Nothing Then

                                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                                    ms.Write(imageData, 0, imageData.Length)
                                    fruitImage = Image.FromStream(ms, True)
                                End Using

                            Else
                                fruitImage = InvalidImage
                            End If

                            fruitList.Add(New Fruit() With
                                                {
                                                .Id = reader.GetInt32(0),
                                                .Description = reader.GetString(1),
                                                .Picture = fruitImage
                                                })
                        End While

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return fruitList

        End Function
        Public Function DataTable() As DataTable

            Dim dt As New DataTable

            Dim selectStatement = "SELECT id ,[Description], Picture FROM dbo.Fruits"

            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}
                    Try
                        cn.Open()
                        dt.Load(cmd.ExecuteReader)
                        dt.Columns("Id").ColumnMapping = MappingType.Hidden
                        dt.Columns("Picture").ColumnMapping = MappingType.Hidden
                        dt.Columns("Picture").ReadOnly = True
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using
            End Using

            Return dt

        End Function
        ''' <summary>
        ''' Read Picture from table by primary key
        ''' </summary>
        ''' <param name="pIdentifier"></param>
        ''' <returns></returns>
        Public Function GetImage(pIdentifier As Integer) As Image

            Dim fruitImage As Image = _pinvalidImage

            Using cn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand("SELECT Picture FROM dbo.Fruits WHERE id = @Id", cn)

                    cmd.Parameters.AddWithValue("@id", pIdentifier)

                    Dim reader As SqlDataReader

                    Try
                        cn.Open()

                        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                        If reader.Read Then

                            Dim imageData = CType(reader(0), Byte())

                            reader.Close()

                            If imageData IsNot Nothing Then
                                Using ms As New MemoryStream(imageData, 0, imageData.Length)
                                    ms.Write(imageData, 0, imageData.Length)
                                    fruitImage = Image.FromStream(ms, True)
                                End Using
                            End If

                        End If
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try

                End Using

            End Using

            Return fruitImage

        End Function
        ''' <summary>
        ''' Suitable for displaying an image in a ASP.NET page
        ''' </summary>
        ''' <param name="pIdentifier"></param>
        ''' <returns></returns>
        Public Function GetImageStream(pIdentifier As Integer) As Stream

            Dim stream As Stream = New MemoryStream()

            Using cn As New SqlConnection(ConnectionString)
                Using cmd As New SqlCommand("SELECT Picture FROM dbo.Fruits WHERE id = @Id", cn)

                    cmd.Parameters.AddWithValue("@id", pIdentifier)

                    Dim reader As SqlDataReader

                    Try
                        cn.Open()

                        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

                        If reader.Read Then

                            Dim imageData = CType(reader(0), Byte())

                            reader.Close()

                            If imageData IsNot Nothing Then
                                Return New MemoryStream(imageData, 0, imageData.Length)
                            Else
                                Throw New ImageLoadException($"{pIdentifier} record has an issue with the image")
                            End If

                        End If
                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try

                End Using

            End Using

            Return stream

        End Function
        ''' <summary>
        ''' Responsive for creating a error image
        ''' </summary>
        ''' <param name="pMessageText">Message to display in image</param>
        ''' <param name="pFontName">Font for pMessageText</param>
        ''' <param name="pFontSize">Font size for pMessageText</param>
        ''' <param name="pBackColor">pMessageText back color</param>
        ''' <param name="pForeColor">pMessageText fore color</param>
        ''' <param name="pWidth">Image width</param>
        ''' <param name="pHeight">Image height</param>
        ''' <returns></returns>
        Private Function ConvertTextToImage(pMessageText As String,
                                            pFontName As String, pFontSize As Integer,
                                            pBackColor As Color,
                                            pForeColor As Color,
                                            pWidth As Integer,
                                            pHeight As Integer) As Bitmap

            Dim bmp As New Bitmap(pWidth, pHeight)

            Using graphics As Graphics = Graphics.FromImage(bmp)
                Dim font As New Font(pFontName, pFontSize)
                graphics.FillRectangle(New SolidBrush(pBackColor), 0, 0, bmp.Width, bmp.Height)
                graphics.DrawString(pMessageText, font, New SolidBrush(pForeColor), 0, 0)
                graphics.Flush()
                font.Dispose()
                graphics.Dispose()
            End Using

            Return bmp

        End Function

    End Class

End Namespace
