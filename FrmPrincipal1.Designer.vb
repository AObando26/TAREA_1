<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal1
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKL = New System.Windows.Forms.Button()
        Me.btnMC = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.btnKL)
        Me.Panel1.Controls.Add(Me.btnMC)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 405)
        Me.Panel1.TabIndex = 0
        '
        'btnKL
        '
        Me.btnKL.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnKL.FlatAppearance.BorderSize = 2
        Me.btnKL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnKL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnKL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKL.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKL.Location = New System.Drawing.Point(12, 247)
        Me.btnKL.Name = "btnKL"
        Me.btnKL.Size = New System.Drawing.Size(188, 37)
        Me.btnKL.TabIndex = 2
        Me.btnKL.Text = "Kilogramos a Libras"
        Me.btnKL.UseVisualStyleBackColor = True
        '
        'btnMC
        '
        Me.btnMC.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMC.FlatAppearance.BorderSize = 2
        Me.btnMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMC.Font = New System.Drawing.Font("Mongolian Baiti", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMC.Location = New System.Drawing.Point(12, 96)
        Me.btnMC.Name = "btnMC"
        Me.btnMC.Size = New System.Drawing.Size(188, 37)
        Me.btnMC.TabIndex = 2
        Me.btnMC.Text = "Metros a Centímetros"
        Me.btnMC.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Mongolian Baiti", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(219, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONVERSOR"
        '
        'FrmPrincipal1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(577, 404)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPrincipal1"
        Me.Text = "Principal"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKL As Button
    Friend WithEvents btnMC As Button
    Friend WithEvents Label1 As Label
End Class
