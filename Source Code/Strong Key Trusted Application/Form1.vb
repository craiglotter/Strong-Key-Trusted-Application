Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 120)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(512, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "1. Create Strong Key Pair using SDK tool sn.exe (sn.exe -k KeyFileName)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(512, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "2. Add the <Assembly: AssemblyKeyFile(""KeyFileName)"")> to AssemblyInfo.vb (Rememb" & _
        "er relative path to build)"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(512, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "3. Configure .Net Frameword to trust key."
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 11)
        Me.ClientSize = New System.Drawing.Size(528, 266)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = ("Machine Information")
        Label1.Text = Label1.Text & vbCrLf & ("======================")
        Label1.Text = Label1.Text & vbCrLf & ("Machine Name: " + Environment.MachineName)
        Label1.Text = Label1.Text & vbCrLf & ("OS Version: " & Environment.OSVersion.ToString())
        Label1.Text = Label1.Text & vbCrLf & ("System Directory: " + Environment.SystemDirectory)
        Label1.Text = Label1.Text & vbCrLf & ("User Name: " + Environment.UserName)
        Label1.Text = Label1.Text & vbCrLf & ("Version: " + Environment.Version.ToString())
        Label1.Text = Label1.Text & vbCrLf & ("Current Directory: " + Environment.CurrentDirectory)
    End Sub
End Class
