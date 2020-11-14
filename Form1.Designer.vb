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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.CrystalReport11 = New WindowsApplication1.CrystalReport1()
        Me.CrystalReport12 = New WindowsApplication1.CrystalReport1()
        Me.FormSkin1 = New WindowsApplication1.FormSkin()
        Me.FlatClose1 = New WindowsApplication1.FlatClose()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FlatGroupBox1 = New WindowsApplication1.FlatGroupBox()
        Me.lblSlot = New WindowsApplication1.FlatLabel()
        Me.lblTotal = New WindowsApplication1.FlatLabel()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.txtHR = New WindowsApplication1.FlatTextBox()
        Me.txtTime = New WindowsApplication1.FlatTextBox()
        Me.txtDate = New WindowsApplication1.FlatTextBox()
        Me.txtID = New WindowsApplication1.FlatTextBox()
        Me.FlatMax1 = New WindowsApplication1.FlatMax()
        Me.FlatButton1 = New WindowsApplication1.FlatButton()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.bttnStartCapture = New WindowsApplication1.FlatButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BoxVehicles = New System.Windows.Forms.TextBox()
        Me.cmbMaxVehicles = New System.Windows.Forms.TextBox()
        Me.cmbMaxResults = New System.Windows.Forms.TextBox()
        Me.lblCaution = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cmbMaxResults1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstBoxVehicles = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbMaxVehicles1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ibOriginal = New Emgu.CV.UI.ImageBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCameraList = New System.Windows.Forms.ComboBox()
        Me.bttnStartCapture1 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.FormSkin1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlatGroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 1000
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM8"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.PictureBox2)
        Me.FormSkin1.Controls.Add(Me.FlatGroupBox1)
        Me.FormSkin1.Controls.Add(Me.CrystalReportViewer1)
        Me.FormSkin1.Controls.Add(Me.txtHR)
        Me.FormSkin1.Controls.Add(Me.txtTime)
        Me.FormSkin1.Controls.Add(Me.txtDate)
        Me.FormSkin1.Controls.Add(Me.txtID)
        Me.FormSkin1.Controls.Add(Me.FlatMax1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.PictureBox4)
        Me.FormSkin1.Controls.Add(Me.bttnStartCapture)
        Me.FormSkin1.Controls.Add(Me.GroupBox2)
        Me.FormSkin1.Controls.Add(Me.GroupBox1)
        Me.FormSkin1.Controls.Add(Me.PictureBox3)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(1125, 683)
        Me.FormSkin1.TabIndex = 0
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(1099, 11)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 41
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.parking
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 40
        Me.PictureBox2.TabStop = False
        '
        'FlatGroupBox1
        '
        Me.FlatGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FlatGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.FlatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.FlatGroupBox1.Controls.Add(Me.lblSlot)
        Me.FlatGroupBox1.Controls.Add(Me.lblTotal)
        Me.FlatGroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!)
        Me.FlatGroupBox1.Location = New System.Drawing.Point(259, 47)
        Me.FlatGroupBox1.Name = "FlatGroupBox1"
        Me.FlatGroupBox1.ShowText = True
        Me.FlatGroupBox1.Size = New System.Drawing.Size(595, 159)
        Me.FlatGroupBox1.TabIndex = 39
        Me.FlatGroupBox1.Text = "Parking Status"
        '
        'lblSlot
        '
        Me.lblSlot.AutoSize = True
        Me.lblSlot.BackColor = System.Drawing.Color.Transparent
        Me.lblSlot.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblSlot.ForeColor = System.Drawing.Color.White
        Me.lblSlot.Location = New System.Drawing.Point(173, 99)
        Me.lblSlot.Name = "lblSlot"
        Me.lblSlot.Size = New System.Drawing.Size(270, 25)
        Me.lblSlot.TabIndex = 1
        Me.lblSlot.Text = "Total number of Vehicle inside:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(173, 55)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(270, 25)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "Total number of Vehicle inside:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Enabled = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(419, 364)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(706, 319)
        Me.CrystalReportViewer1.TabIndex = 38
        Me.CrystalReportViewer1.Visible = False
        '
        'txtHR
        '
        Me.txtHR.BackColor = System.Drawing.Color.Transparent
        Me.txtHR.Location = New System.Drawing.Point(336, 12)
        Me.txtHR.MaxLength = 32767
        Me.txtHR.Multiline = False
        Me.txtHR.Name = "txtHR"
        Me.txtHR.ReadOnly = False
        Me.txtHR.Size = New System.Drawing.Size(75, 29)
        Me.txtHR.TabIndex = 37
        Me.txtHR.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtHR.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHR.UseSystemPasswordChar = False
        Me.txtHR.Visible = False
        '
        'txtTime
        '
        Me.txtTime.BackColor = System.Drawing.Color.Transparent
        Me.txtTime.Location = New System.Drawing.Point(543, 12)
        Me.txtTime.MaxLength = 32767
        Me.txtTime.Multiline = False
        Me.txtTime.Name = "txtTime"
        Me.txtTime.ReadOnly = False
        Me.txtTime.Size = New System.Drawing.Size(75, 29)
        Me.txtTime.TabIndex = 36
        Me.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtTime.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTime.UseSystemPasswordChar = False
        Me.txtTime.Visible = False
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Transparent
        Me.txtDate.Location = New System.Drawing.Point(420, 12)
        Me.txtDate.MaxLength = 32767
        Me.txtDate.Multiline = False
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = False
        Me.txtDate.Size = New System.Drawing.Size(75, 29)
        Me.txtDate.TabIndex = 35
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDate.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDate.UseSystemPasswordChar = False
        Me.txtDate.Visible = False
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.Transparent
        Me.txtID.Location = New System.Drawing.Point(244, 11)
        Me.txtID.MaxLength = 32767
        Me.txtID.Multiline = False
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = False
        Me.txtID.Size = New System.Drawing.Size(75, 29)
        Me.txtID.TabIndex = 34
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtID.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtID.UseSystemPasswordChar = False
        Me.txtID.Visible = False
        '
        'FlatMax1
        '
        Me.FlatMax1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMax1.BackColor = System.Drawing.Color.White
        Me.FlatMax1.BaseColor = System.Drawing.Color.White
        Me.FlatMax1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMax1.ForeColor = System.Drawing.Color.White
        Me.FlatMax1.Location = New System.Drawing.Point(1075, 11)
        Me.FlatMax1.Name = "FlatMax1"
        Me.FlatMax1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMax1.TabIndex = 33
        Me.FlatMax1.Text = "FlatMax1"
        Me.FlatMax1.TextColor = System.Drawing.Color.Black
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(935, 146)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton1.TabIndex = 32
        Me.FlatButton1.Text = "Park IN"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.FlatButton1.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(889, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(152, 44)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 31
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'bttnStartCapture
        '
        Me.bttnStartCapture.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.bttnStartCapture.BackColor = System.Drawing.Color.Transparent
        Me.bttnStartCapture.BaseColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.bttnStartCapture.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnStartCapture.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.bttnStartCapture.Location = New System.Drawing.Point(259, 352)
        Me.bttnStartCapture.Name = "bttnStartCapture"
        Me.bttnStartCapture.Rounded = False
        Me.bttnStartCapture.Size = New System.Drawing.Size(595, 120)
        Me.bttnStartCapture.TabIndex = 30
        Me.bttnStartCapture.Text = "PARKING IN"
        Me.bttnStartCapture.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BoxVehicles)
        Me.GroupBox2.Controls.Add(Me.cmbMaxVehicles)
        Me.GroupBox2.Controls.Add(Me.cmbMaxResults)
        Me.GroupBox2.Controls.Add(Me.lblCaution)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.cmbMaxResults1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lstBoxVehicles)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbMaxVehicles1)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 58)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(46, 35)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ANPR"
        Me.GroupBox2.Visible = False
        '
        'BoxVehicles
        '
        Me.BoxVehicles.Location = New System.Drawing.Point(163, 362)
        Me.BoxVehicles.Name = "BoxVehicles"
        Me.BoxVehicles.Size = New System.Drawing.Size(100, 32)
        Me.BoxVehicles.TabIndex = 24
        '
        'cmbMaxVehicles
        '
        Me.cmbMaxVehicles.Location = New System.Drawing.Point(163, 339)
        Me.cmbMaxVehicles.Name = "cmbMaxVehicles"
        Me.cmbMaxVehicles.Size = New System.Drawing.Size(100, 32)
        Me.cmbMaxVehicles.TabIndex = 23
        Me.cmbMaxVehicles.Text = "1"
        '
        'cmbMaxResults
        '
        Me.cmbMaxResults.Location = New System.Drawing.Point(57, 346)
        Me.cmbMaxResults.Name = "cmbMaxResults"
        Me.cmbMaxResults.Size = New System.Drawing.Size(100, 32)
        Me.cmbMaxResults.TabIndex = 22
        Me.cmbMaxResults.Text = "1"
        '
        'lblCaution
        '
        Me.lblCaution.AutoSize = True
        Me.lblCaution.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCaution.ForeColor = System.Drawing.Color.Red
        Me.lblCaution.Location = New System.Drawing.Point(32, 306)
        Me.lblCaution.Name = "lblCaution"
        Me.lblCaution.Size = New System.Drawing.Size(238, 26)
        Me.lblCaution.TabIndex = 13
        Me.lblCaution.Text = "Found Banned Vehicle!"
        Me.lblCaution.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(26, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Max vehicles per image"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(325, 344)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 38)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Save Image"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cmbMaxResults1
        '
        Me.cmbMaxResults1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaxResults1.FormattingEnabled = True
        Me.cmbMaxResults1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbMaxResults1.Location = New System.Drawing.Point(161, 41)
        Me.cmbMaxResults1.Name = "cmbMaxResults1"
        Me.cmbMaxResults1.Size = New System.Drawing.Size(115, 33)
        Me.cmbMaxResults1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(161, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(209, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Max results per vehicle"
        '
        'lstBoxVehicles
        '
        Me.lstBoxVehicles.FormattingEnabled = True
        Me.lstBoxVehicles.ItemHeight = 25
        Me.lstBoxVehicles.Location = New System.Drawing.Point(295, 88)
        Me.lstBoxVehicles.Name = "lstBoxVehicles"
        Me.lstBoxVehicles.Size = New System.Drawing.Size(135, 179)
        Me.lstBoxVehicles.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Results"
        '
        'cmbMaxVehicles1
        '
        Me.cmbMaxVehicles1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaxVehicles1.FormattingEnabled = True
        Me.cmbMaxVehicles1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cmbMaxVehicles1.Location = New System.Drawing.Point(26, 41)
        Me.cmbMaxVehicles1.Name = "cmbMaxVehicles1"
        Me.cmbMaxVehicles1.Size = New System.Drawing.Size(118, 33)
        Me.cmbMaxVehicles1.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(295, 39)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(135, 35)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Contacts DB"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ibOriginal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxCameraList)
        Me.GroupBox1.Controls.Add(Me.bttnStartCapture1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(65, 38)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Live Video"
        Me.GroupBox1.Visible = False
        '
        'ibOriginal
        '
        Me.ibOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ibOriginal.Location = New System.Drawing.Point(24, 88)
        Me.ibOriginal.Name = "ibOriginal"
        Me.ibOriginal.Size = New System.Drawing.Size(250, 250)
        Me.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ibOriginal.TabIndex = 2
        Me.ibOriginal.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Camera"
        '
        'ComboBoxCameraList
        '
        Me.ComboBoxCameraList.FormattingEnabled = True
        Me.ComboBoxCameraList.Location = New System.Drawing.Point(24, 41)
        Me.ComboBoxCameraList.Name = "ComboBoxCameraList"
        Me.ComboBoxCameraList.Size = New System.Drawing.Size(157, 33)
        Me.ComboBoxCameraList.TabIndex = 22
        '
        'bttnStartCapture1
        '
        Me.bttnStartCapture1.Location = New System.Drawing.Point(187, 40)
        Me.bttnStartCapture1.Name = "bttnStartCapture1"
        Me.bttnStartCapture1.Size = New System.Drawing.Size(87, 34)
        Me.bttnStartCapture1.TabIndex = 23
        Me.bttnStartCapture1.Text = "Start Capture"
        Me.bttnStartCapture1.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(259, 211)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(595, 117)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 683)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpenAlpr Test _ Shane (x86)"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlatGroupBox1.ResumeLayout(False)
        Me.FlatGroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ibOriginal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FormSkin1 As FormSkin
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BoxVehicles As TextBox
    Friend WithEvents cmbMaxVehicles As TextBox
    Friend WithEvents cmbMaxResults As TextBox
    Friend WithEvents lblCaution As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents cmbMaxResults1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstBoxVehicles As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbMaxVehicles1 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ibOriginal As Emgu.CV.UI.ImageBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCameraList As ComboBox
    Friend WithEvents bttnStartCapture1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents bttnStartCapture As FlatButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents txtID As FlatTextBox
    Friend WithEvents FlatMax1 As FlatMax
    Friend WithEvents txtTime As FlatTextBox
    Friend WithEvents txtDate As FlatTextBox
    Friend WithEvents txtHR As FlatTextBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As CrystalReport1
    Friend WithEvents CrystalReport12 As CrystalReport1
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents FlatGroupBox1 As FlatGroupBox
    Friend WithEvents lblSlot As FlatLabel
    Friend WithEvents lblTotal As FlatLabel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents FlatClose1 As FlatClose
End Class
