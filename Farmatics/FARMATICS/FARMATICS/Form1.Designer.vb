<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbPerfil = New System.Windows.Forms.GroupBox()
        Me.txt_DNI = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_charge = New System.Windows.Forms.Label()
        Me.txt_ID = New System.Windows.Forms.Label()
        Me.txt_lastname = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pb_profile = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_client = New System.Windows.Forms.Button()
        Me.btn_productos = New System.Windows.Forms.Button()
        Me.btn_facturar = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbPerfil.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbPerfil
        '
        Me.gbPerfil.BackColor = System.Drawing.Color.Transparent
        Me.gbPerfil.Controls.Add(Me.btn_salir)
        Me.gbPerfil.Controls.Add(Me.PictureBox3)
        Me.gbPerfil.Controls.Add(Me.PictureBox1)
        Me.gbPerfil.Controls.Add(Me.txt_DNI)
        Me.gbPerfil.Controls.Add(Me.Label5)
        Me.gbPerfil.Controls.Add(Me.txt_charge)
        Me.gbPerfil.Controls.Add(Me.txt_ID)
        Me.gbPerfil.Controls.Add(Me.txt_lastname)
        Me.gbPerfil.Controls.Add(Me.txt_name)
        Me.gbPerfil.Controls.Add(Me.Label4)
        Me.gbPerfil.Controls.Add(Me.Label3)
        Me.gbPerfil.Controls.Add(Me.Label2)
        Me.gbPerfil.Controls.Add(Me.Label1)
        Me.gbPerfil.Controls.Add(Me.PictureBox2)
        Me.gbPerfil.Controls.Add(Me.GroupBox1)
        Me.gbPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbPerfil.Location = New System.Drawing.Point(23, 18)
        Me.gbPerfil.Margin = New System.Windows.Forms.Padding(0)
        Me.gbPerfil.Name = "gbPerfil"
        Me.gbPerfil.Size = New System.Drawing.Size(234, 545)
        Me.gbPerfil.TabIndex = 0
        Me.gbPerfil.TabStop = False
        '
        'txt_DNI
        '
        Me.txt_DNI.AutoSize = True
        Me.txt_DNI.BackColor = System.Drawing.Color.Silver
        Me.txt_DNI.Location = New System.Drawing.Point(100, 397)
        Me.txt_DNI.Name = "txt_DNI"
        Me.txt_DNI.Size = New System.Drawing.Size(43, 13)
        Me.txt_DNI.TabIndex = 13
        Me.txt_DNI.Text = "txt_DNI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(62, 397)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DNI :"
        '
        'txt_charge
        '
        Me.txt_charge.AutoSize = True
        Me.txt_charge.BackColor = System.Drawing.Color.Silver
        Me.txt_charge.Location = New System.Drawing.Point(100, 369)
        Me.txt_charge.Name = "txt_charge"
        Me.txt_charge.Size = New System.Drawing.Size(57, 13)
        Me.txt_charge.TabIndex = 11
        Me.txt_charge.Text = "txt_charge"
        '
        'txt_ID
        '
        Me.txt_ID.AutoSize = True
        Me.txt_ID.BackColor = System.Drawing.Color.Silver
        Me.txt_ID.Location = New System.Drawing.Point(100, 345)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(35, 13)
        Me.txt_ID.TabIndex = 10
        Me.txt_ID.Text = "txt_ID"
        '
        'txt_lastname
        '
        Me.txt_lastname.AutoSize = True
        Me.txt_lastname.BackColor = System.Drawing.Color.Silver
        Me.txt_lastname.Location = New System.Drawing.Point(100, 321)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.Size = New System.Drawing.Size(66, 13)
        Me.txt_lastname.TabIndex = 9
        Me.txt_lastname.Text = "txt_lastname"
        '
        'txt_name
        '
        Me.txt_name.AutoSize = True
        Me.txt_name.BackColor = System.Drawing.Color.Silver
        Me.txt_name.Location = New System.Drawing.Point(100, 296)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(50, 13)
        Me.txt_name.TabIndex = 8
        Me.txt_name.Text = "txt_name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(53, 369)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cargo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(18, 345)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Identificación :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(39, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Apellidos :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(39, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombres :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pb_profile)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 154)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(48, 466)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(134, 37)
        Me.btn_salir.TabIndex = 2
        Me.btn_salir.Text = "SALIR"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.gbPerfil)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.btn_Buscar)
        Me.Panel1.Location = New System.Drawing.Point(12, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1003, 585)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.logo_farmatic_vec_png
        Me.PictureBox1.Location = New System.Drawing.Point(16, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Silver
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(16, 283)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(201, 154)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'pb_profile
        '
        Me.pb_profile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pb_profile.BackColor = System.Drawing.Color.Silver
        Me.pb_profile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pb_profile.Image = Global.WindowsApplication1.My.Resources.Resources.profile_2092113_960_720
        Me.pb_profile.Location = New System.Drawing.Point(6, 14)
        Me.pb_profile.Name = "pb_profile"
        Me.pb_profile.Size = New System.Drawing.Size(134, 129)
        Me.pb_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_profile.TabIndex = 3
        Me.pb_profile.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Silver
        Me.PictureBox3.Location = New System.Drawing.Point(65, 76)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 14)
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(673, 366)
        Me.DataGridView1.TabIndex = 1
        '
        'btn_client
        '
        Me.btn_client.Location = New System.Drawing.Point(254, 3)
        Me.btn_client.Name = "btn_client"
        Me.btn_client.Size = New System.Drawing.Size(117, 56)
        Me.btn_client.TabIndex = 2
        Me.btn_client.Text = "btn_client"
        Me.btn_client.UseVisualStyleBackColor = True
        '
        'btn_productos
        '
        Me.btn_productos.Location = New System.Drawing.Point(131, 3)
        Me.btn_productos.Name = "btn_productos"
        Me.btn_productos.Size = New System.Drawing.Size(117, 56)
        Me.btn_productos.TabIndex = 3
        Me.btn_productos.Text = "btn_productos"
        Me.btn_productos.UseVisualStyleBackColor = True
        '
        'btn_facturar
        '
        Me.btn_facturar.Location = New System.Drawing.Point(8, 3)
        Me.btn_facturar.Name = "btn_facturar"
        Me.btn_facturar.Size = New System.Drawing.Size(117, 56)
        Me.btn_facturar.TabIndex = 4
        Me.btn_facturar.Text = "btn_facturar"
        Me.btn_facturar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(691, 105)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(117, 37)
        Me.btn_Buscar.TabIndex = 5
        Me.btn_Buscar.Text = "btn_Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_client)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_productos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_facturar)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(273, 91)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(376, 71)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 168)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(709, 395)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(814, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 20)
        Me.TextBox1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(527, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 57)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CAJA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 646)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.gbPerfil.ResumeLayout(False)
        Me.gbPerfil.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_profile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbPerfil As System.Windows.Forms.GroupBox
    Friend WithEvents pb_profile As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents txt_lastname As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txt_charge As System.Windows.Forms.Label
    Friend WithEvents txt_ID As System.Windows.Forms.Label
    Friend WithEvents txt_DNI As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_facturar As System.Windows.Forms.Button
    Friend WithEvents btn_productos As System.Windows.Forms.Button
    Friend WithEvents btn_client As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
