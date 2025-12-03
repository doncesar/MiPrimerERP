<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Ingreso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        btn_Cancelar = New Button()
        btn_Aceptar = New Button()
        Label2 = New Label()
        Label1 = New Label()
        txt_Password = New TextBox()
        txt_Usuario = New TextBox()
        Timer1 = New Timer(components)
        StatusStrip1 = New StatusStrip()
        Label_Fecha = New ToolStripStatusLabel()
        Label_Hora = New ToolStripStatusLabel()
        GroupBox1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_Cancelar)
        GroupBox1.Controls.Add(btn_Aceptar)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txt_Password)
        GroupBox1.Controls.Add(txt_Usuario)
        GroupBox1.Location = New Point(23, 16)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(206, 125)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "INGRESO"
        ' 
        ' btn_Cancelar
        ' 
        btn_Cancelar.Location = New Point(121, 92)
        btn_Cancelar.Name = "btn_Cancelar"
        btn_Cancelar.Size = New Size(75, 23)
        btn_Cancelar.TabIndex = 3
        btn_Cancelar.Text = "CANCELAR"
        btn_Cancelar.UseVisualStyleBackColor = True
        ' 
        ' btn_Aceptar
        ' 
        btn_Aceptar.Location = New Point(6, 92)
        btn_Aceptar.Name = "btn_Aceptar"
        btn_Aceptar.Size = New Size(75, 23)
        btn_Aceptar.TabIndex = 2
        btn_Aceptar.Text = "ACEPTAR"
        btn_Aceptar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 15)
        Label2.TabIndex = 3
        Label2.Text = "CONTRASEÑA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 15)
        Label1.TabIndex = 2
        Label1.Text = "USUARIO"
        ' 
        ' txt_Password
        ' 
        txt_Password.Location = New Point(96, 53)
        txt_Password.Name = "txt_Password"
        txt_Password.Size = New Size(100, 23)
        txt_Password.TabIndex = 1
        txt_Password.UseSystemPasswordChar = True
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.Location = New Point(96, 24)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(100, 23)
        txt_Usuario.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New ToolStripItem() {Label_Fecha, Label_Hora})
        StatusStrip1.Location = New Point(0, 185)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(267, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' Label_Fecha
        ' 
        Label_Fecha.Name = "Label_Fecha"
        Label_Fecha.Size = New Size(38, 17)
        Label_Fecha.Text = "Fecha"
        ' 
        ' Label_Hora
        ' 
        Label_Hora.Name = "Label_Hora"
        Label_Hora.Size = New Size(33, 17)
        Label_Hora.Text = "Hora"
        ' 
        ' Form_Ingreso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(267, 207)
        Controls.Add(StatusStrip1)
        Controls.Add(GroupBox1)
        Name = "Form_Ingreso"
        Text = "Mi Primer ERP"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents txt_Password As TextBox
    Friend WithEvents btn_Cancelar As Button
    Friend WithEvents btn_Aceptar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Label_Hora As ToolStripStatusLabel
    Friend WithEvents Label_Fecha As ToolStripStatusLabel

End Class
