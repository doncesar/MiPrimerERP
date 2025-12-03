<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Registro
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
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btn_Cancelar = New Button()
        btn_Registrar = New Button()
        cmb_Rol = New ComboBox()
        txt_Email = New TextBox()
        txt_Nombre = New TextBox()
        txt_Password = New TextBox()
        txt_Usuario = New TextBox()
        DataGridView1 = New DataGridView()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btn_Cancelar)
        GroupBox1.Controls.Add(btn_Registrar)
        GroupBox1.Controls.Add(cmb_Rol)
        GroupBox1.Controls.Add(txt_Email)
        GroupBox1.Controls.Add(txt_Nombre)
        GroupBox1.Controls.Add(txt_Password)
        GroupBox1.Controls.Add(txt_Usuario)
        GroupBox1.Location = New Point(10, 20)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(226, 252)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Registrar Usuarios"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(24, 15)
        Label5.TabIndex = 11
        Label5.Text = "Rol"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 138)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 100)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 9
        Label3.Text = "Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 8
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 7
        Label1.Text = "Usuario"
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.Location = New Point(134, 213)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(75, 23)
        btn_Cancelar.TabIndex = 6
        btn_Cancelar.Text = "CANCELAR"
        btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_Registrar
        ' 
        btn_Registrar.Location = New Point(12, 213)
        btn_Registrar.Name = "btn_Registrar"
        btn_Registrar.Size = New Size(75, 23)
        btn_Registrar.TabIndex = 5
        btn_Registrar.Text = "REGISTRAR"
        btn_Registrar.UseVisualStyleBackColor = True
        ' 
        ' cmb_Rol
        ' 
        cmb_Rol.FormattingEnabled = True
        cmb_Rol.Items.AddRange(New Object() {"Administrador", "Operador", "Supervisor"})
        cmb_Rol.Location = New Point(88, 171)
        cmb_Rol.Name = "cmb_Rol"
        cmb_Rol.Size = New Size(121, 23)
        cmb_Rol.TabIndex = 4
        ' 
        ' txt_Email
        ' 
        txt_Email.Location = New Point(88, 135)
        txt_Email.Name = "txt_Email"
        txt_Email.Size = New Size(121, 23)
        txt_Email.TabIndex = 3
        ' 
        ' txt_Nombre
        ' 
        txt_Nombre.Location = New Point(88, 97)
        txt_Nombre.Name = "txt_Nombre"
        txt_Nombre.Size = New Size(121, 23)
        txt_Nombre.TabIndex = 2
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(88, 57)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(121, 23)
        txt_Password.TabIndex = 1
        txt_Password.UseSystemPasswordChar = True
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(90, 22)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(119, 23)
        txt_Usuario.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(242, 28)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(428, 244)
        DataGridView1.TabIndex = 1
        ' 
        ' Form_Registro
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(682, 288)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Name = "Form_Registro"
        Text = "Registro de Usuarios"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_Registrar As Button
    Friend WithEvents cmb_Rol As ComboBox
    Friend WithEvents txt_Email As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
