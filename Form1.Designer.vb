<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        btnprint = New Button()
        txtgender = New TextBox()
        btnexit = New Button()
        btndelete = New Button()
        btnupdate = New Button()
        btnadd = New Button()
        Label5 = New Label()
        Label4 = New Label()
        txtID = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        txtFname = New TextBox()
        Label1 = New Label()
        txtage = New TextBox()
        txtphone = New TextBox()
        ID = New Label()
        txtLname = New TextBox()
        DGV = New DataGridView()
        ToolTip1 = New ToolTip(components)
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gray
        Panel1.Controls.Add(btnprint)
        Panel1.Controls.Add(txtgender)
        Panel1.Controls.Add(btnexit)
        Panel1.Controls.Add(btndelete)
        Panel1.Controls.Add(btnupdate)
        Panel1.Controls.Add(btnadd)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtFname)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtage)
        Panel1.Controls.Add(txtphone)
        Panel1.Controls.Add(ID)
        Panel1.Controls.Add(txtLname)
        Panel1.Controls.Add(DGV)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(894, 504)
        Panel1.TabIndex = 0
        ' 
        ' btnprint
        ' 
        btnprint.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnprint.Location = New Point(693, 201)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(161, 50)
        btnprint.TabIndex = 22
        btnprint.Text = "PRINT"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' txtgender
        ' 
        txtgender.Location = New Point(187, 18)
        txtgender.Name = "txtgender"
        txtgender.Size = New Size(117, 23)
        txtgender.TabIndex = 21
        ' 
        ' btnexit
        ' 
        btnexit.AutoSize = True
        btnexit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnexit.Location = New Point(693, 425)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(161, 50)
        btnexit.TabIndex = 18
        btnexit.Text = "EXIT"
        ToolTip1.SetToolTip(btnexit, "Exit")
        btnexit.UseVisualStyleBackColor = True
        ' 
        ' btndelete
        ' 
        btndelete.AutoSize = True
        btndelete.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btndelete.Location = New Point(693, 369)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(161, 50)
        btndelete.TabIndex = 17
        btndelete.Text = "DELETE"
        ToolTip1.SetToolTip(btndelete, "Delete")
        btndelete.UseVisualStyleBackColor = True
        ' 
        ' btnupdate
        ' 
        btnupdate.AutoSize = True
        btnupdate.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnupdate.Location = New Point(693, 313)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(161, 50)
        btnupdate.TabIndex = 16
        btnupdate.Text = "UPDATE"
        ToolTip1.SetToolTip(btnupdate, "Update")
        btnupdate.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.AutoSize = True
        btnadd.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd.Location = New Point(693, 257)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(161, 50)
        btnadd.TabIndex = 15
        btnadd.Text = "ADD"
        ToolTip1.SetToolTip(btnadd, "Add")
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(76, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 30)
        Label5.TabIndex = 14
        Label5.Text = "GENDER :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(640, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 30)
        Label4.TabIndex = 13
        Label4.Text = "ID :"
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(693, 18)
        txtID.Name = "txtID"
        txtID.Size = New Size(186, 23)
        txtID.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(0, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 30)
        Label3.TabIndex = 11
        Label3.Text = "PHONE :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(543, 44)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 30)
        Label2.TabIndex = 10
        Label2.Text = "LAST NAME :"
        ' 
        ' txtFname
        ' 
        txtFname.Location = New Point(457, 18)
        txtFname.Name = "txtFname"
        txtFname.Size = New Size(186, 23)
        txtFname.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(301, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 30)
        Label1.TabIndex = 8
        Label1.Text = "FIRST NAME :" & vbCrLf
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(351, 47)
        txtage.Name = "txtage"
        txtage.Size = New Size(186, 23)
        txtage.TabIndex = 7
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(98, 47)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(186, 23)
        txtphone.TabIndex = 6
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ID.Location = New Point(279, 44)
        ID.Name = "ID"
        ID.Size = New Size(66, 30)
        ID.TabIndex = 5
        ID.Text = "AGE :"
        ' 
        ' txtLname
        ' 
        txtLname.Location = New Point(693, 47)
        txtLname.Name = "txtLname"
        txtLname.Size = New Size(186, 23)
        txtLname.TabIndex = 3
        ' 
        ' DGV
        ' 
        DGV.AllowUserToOrderColumns = True
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Location = New Point(7, 92)
        DGV.Name = "DGV"
        DGV.RowTemplate.Height = 25
        DGV.Size = New Size(636, 404)
        DGV.TabIndex = 2
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(918, 528)
        Controls.Add(Panel1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterParent
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV As DataGridView
    Friend WithEvents btnexit As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnprint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents txtgender As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtage As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents txtLname As TextBox
End Class
