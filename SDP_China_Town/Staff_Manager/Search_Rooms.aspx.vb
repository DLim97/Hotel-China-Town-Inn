Public Class WebForm11
    Inherits System.Web.UI.Page

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New OleDb.OleDbConnection

        Dim dbProvider As String
        Dim dbSource As String
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        Dim maxRow As Integer
        Dim cor As Integer
        Dim counter As Integer
        Dim pos As Integer

        dbProvider = "PROVIDER=Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data Source=|DataDirectory|Hote.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()



        sql = "SELECT * FROM RoomDetails"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "SearchRoomD")

        maxRow = ds.Tables("SearchRoomD").Rows.Count

        For counter = 0 To maxRow - 1 Step 1
            If TextBox1.Text = ds.Tables("SearchRoomD").Rows(counter).Item("RoomID") Then
                Label1.Text = ds.Tables("SearchRoomD").Rows(counter).Item("RoomType")
                Label2.Text = ds.Tables("SearchRoomD").Rows(counter).Item("Description")

                cor = 1
                Panel1.Visible = True
            End If
        Next
        If cor = 0 Then
            MsgBox("The ID you search doesn't exist.")
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.Visible = False
    End Sub
End Class