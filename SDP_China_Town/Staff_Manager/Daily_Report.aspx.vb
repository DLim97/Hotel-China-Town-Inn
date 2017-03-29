Imports System.Data.OleDb
Public Class WebForm6
    Inherits System.Web.UI.Page
    Dim con As New OleDb.OleDbConnection

    Dim dbProvider As String
    Dim dbSource As String
    Dim da As New OleDb.OleDbDataAdapter
    Dim ds As New DataSet
    Dim d As Date
    Dim Sql As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbProvider = "PROVIDER=Microsoft.JET.OLEDB.4.0;"
        dbSource = "Data Source=|DataDirectory|Hote.mdb"
        con.ConnectionString = dbProvider & dbSource
        con.Open()



        Sql = ("SELECT CheckInOutID, CheckIn, CheckOut, RoomID, RoomType, CustomerName FROM CheckInOut")


        da = New OleDb.OleDbDataAdapter(Sql, con)
        da.Fill(ds, "Daily")

        Dim dt As New DataTable
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
    End Sub
End Class