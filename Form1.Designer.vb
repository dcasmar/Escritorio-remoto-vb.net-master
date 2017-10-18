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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtPuerto = New System.Windows.Forms.TextBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.txtIP = New System.Windows.Forms.TextBox()
        Me.btnEnviarMensaje = New System.Windows.Forms.Button()
        Me.txtDummyContent = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 423)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(683, 423)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtPuerto
        '
        Me.txtPuerto.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtPuerto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPuerto.Location = New System.Drawing.Point(228, 10)
        Me.txtPuerto.Name = "txtPuerto"
        Me.txtPuerto.Size = New System.Drawing.Size(100, 20)
        Me.txtPuerto.TabIndex = 5
        Me.txtPuerto.Text = "9999"
        Me.txtPuerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConectar.Location = New System.Drawing.Point(340, 8)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(98, 23)
        Me.btnConectar.TabIndex = 4
        Me.btnConectar.Text = "conectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'txtIP
        '
        Me.txtIP.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtIP.Location = New System.Drawing.Point(46, 11)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(100, 20)
        Me.txtIP.TabIndex = 6
        Me.txtIP.Text = "192.168.0.11"
        Me.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnEnviarMensaje
        '
        Me.btnEnviarMensaje.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEnviarMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnviarMensaje.Location = New System.Drawing.Point(454, 7)
        Me.btnEnviarMensaje.Name = "btnEnviarMensaje"
        Me.btnEnviarMensaje.Size = New System.Drawing.Size(115, 24)
        Me.btnEnviarMensaje.TabIndex = 7
        Me.btnEnviarMensaje.Text = "Controlar PC remoto"
        Me.btnEnviarMensaje.UseVisualStyleBackColor = False
        '
        'txtDummyContent
        '
        Me.txtDummyContent.Location = New System.Drawing.Point(575, 9)
        Me.txtDummyContent.Name = "txtDummyContent"
        Me.txtDummyContent.Size = New System.Drawing.Size(108, 20)
        Me.txtDummyContent.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "IP:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "PUERTO:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(707, 495)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDummyContent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEnviarMensaje)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.txtPuerto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnConectar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "CLIENTE"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtPuerto As System.Windows.Forms.TextBox
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents btnEnviarMensaje As System.Windows.Forms.Button
    Friend WithEvents txtDummyContent As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
