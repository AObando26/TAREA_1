<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmKL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLibra = New System.Windows.Forms.Label()
        Me.txtKilo = New System.Windows.Forms.TextBox()
        Me.btnRespuesta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kilogramos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Mongolian Baiti", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Libras"
        '
        'lblLibra
        '
        Me.lblLibra.AutoSize = True
        Me.lblLibra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLibra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLibra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLibra.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibra.Location = New System.Drawing.Point(257, 188)
        Me.lblLibra.Name = "lblLibra"
        Me.lblLibra.Size = New System.Drawing.Size(19, 18)
        Me.lblLibra.TabIndex = 2
        Me.lblLibra.Text = "0"
        '
        'txtKilo
        '
        Me.txtKilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKilo.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKilo.Location = New System.Drawing.Point(257, 111)
        Me.txtKilo.Name = "txtKilo"
        Me.txtKilo.Size = New System.Drawing.Size(64, 26)
        Me.txtKilo.TabIndex = 3
        '
        'btnRespuesta
        '
        Me.btnRespuesta.BackColor = System.Drawing.Color.LightGray
        Me.btnRespuesta.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnRespuesta.FlatAppearance.BorderSize = 2
        Me.btnRespuesta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRespuesta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRespuesta.Font = New System.Drawing.Font("Mongolian Baiti", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRespuesta.Location = New System.Drawing.Point(150, 21)
        Me.btnRespuesta.Name = "btnRespuesta"
        Me.btnRespuesta.Size = New System.Drawing.Size(190, 32)
        Me.btnRespuesta.TabIndex = 4
        Me.btnRespuesta.Text = "Convertir a Libras"
        Me.btnRespuesta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnRespuesta)
        Me.Panel1.Location = New System.Drawing.Point(0, 302)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 76)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Kg"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(310, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Lb"
        '
        'FrmKL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(462, 377)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtKilo)
        Me.Controls.Add(Me.lblLibra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmKL"
        Me.Text = "Kilos A Libras"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblLibra As Label
    Friend WithEvents txtKilo As TextBox
    Friend WithEvents btnRespuesta As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
