Public Class Form1
    Private Sub Btn_msg_Click(sender As Object, e As EventArgs) Handles btn_msg.Click

        MessageBox.Show("hello")
        MessageBox.Show("mina:")
        MessageBox.Show("dawoud", "learn vb.net")


        MsgBox("mm")







    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sTrfirstname As String
        Dim sTrlastname As String
        sTrfirstname = "mina"
        sTrlastname = "dawoud"

        MsgBox("hello " + " , MR." + sTrfirstname & " " & sTrlastname + "  .... " + "how are you to day >>>")

    End Sub

    Private Sub Btn_datatype_Click(sender As Object, e As EventArgs) Handles btn_datatype.Click
        Dim Crname As String
        Dim CrModel As String
        Dim CrDoor As Integer
        Dim CrColour As String
        Dim CrTaxed As Boolean
        Dim CrsizCC As Integer
        Dim CrPrice As Decimal
        Dim CrDateRej As Date

        Crname = "Ford"
        CrModel = "Escort"
        CrDoor = 5
        CrColour = "red"
        CrTaxed = True
        CrsizCC = 1200
        CrPrice = 999.99
        CrDateRej = #01/09/2020#


        MsgBox("Crname : " & Crname & vbNewLine & "CrModel:" & CrModel & vbNewLine & "CrDoor: " & CrDoor & vbNewLine & "CrColour: " & CrColour & vbNewLine & "CrTaxed : " & CrTaxed & vbNewLine & "CC:" & CrsizCC & vbNewLine & "Price :" & CrPrice & vbNewLine & "DateRej :" & CrDateRej)



    End Sub

    Private Sub Btn_mssg_Click(sender As Object, e As EventArgs) Handles btn_mssg.Click
        Dim firstNam As String
        Dim LastName As String
        Dim Age As Integer
        Dim listsbox As String

        Age = InputBox("enter age ")
        MsgBox(Age)

        firstNam = TextBox1.Text

        LastName = TextBox2.Text
        Age = TextBox3.Text
        'listsbox = ListBox1.SelectedItem
        listsbox = ListBox1.SelectedIndex

        MsgBox(firstNam & "" & LastName & "" & Age & "" & listsbox)


#Region "mycomment"
        'comment line1
        'comment line2
#End Region

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("hi")
        ListBox1.Items.Add("my first")
        ListBox1.Items.Add("project in vb ")
    End Sub
End Class
