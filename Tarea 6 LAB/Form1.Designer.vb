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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.botonRestarA = New System.Windows.Forms.Button()
        Me.botonSumarA = New System.Windows.Forms.Button()
        Me.botonRestarB = New System.Windows.Forms.Button()
        Me.botonSumarB = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelA = New System.Windows.Forms.Label()
        Me.labelB = New System.Windows.Forms.Label()
        Me.botonSuma = New System.Windows.Forms.Button()
        Me.botonRestar = New System.Windows.Forms.Button()
        Me.botonMultiplicar = New System.Windows.Forms.Button()
        Me.botonDividir = New System.Windows.Forms.Button()
        Me.botonLimpiar = New System.Windows.Forms.Button()
        Me.labelResultado = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'botonRestarA
        '
        Me.botonRestarA.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRestarA.Location = New System.Drawing.Point(105, 162)
        Me.botonRestarA.Name = "botonRestarA"
        Me.botonRestarA.Size = New System.Drawing.Size(49, 41)
        Me.botonRestarA.TabIndex = 0
        Me.botonRestarA.Text = "-"
        Me.botonRestarA.UseVisualStyleBackColor = True
        '
        'botonSumarA
        '
        Me.botonSumarA.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonSumarA.Location = New System.Drawing.Point(293, 160)
        Me.botonSumarA.Name = "botonSumarA"
        Me.botonSumarA.Size = New System.Drawing.Size(49, 41)
        Me.botonSumarA.TabIndex = 1
        Me.botonSumarA.Text = "+"
        Me.botonSumarA.UseVisualStyleBackColor = True
        '
        'botonRestarB
        '
        Me.botonRestarB.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonRestarB.Location = New System.Drawing.Point(105, 231)
        Me.botonRestarB.Name = "botonRestarB"
        Me.botonRestarB.Size = New System.Drawing.Size(49, 41)
        Me.botonRestarB.TabIndex = 2
        Me.botonRestarB.Text = "-"
        Me.botonRestarB.UseVisualStyleBackColor = True
        '
        'botonSumarB
        '
        Me.botonSumarB.Font = New System.Drawing.Font("Consolas", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.botonSumarB.Location = New System.Drawing.Point(293, 231)
        Me.botonSumarB.Name = "botonSumarB"
        Me.botonSumarB.Size = New System.Drawing.Size(49, 41)
        Me.botonSumarB.TabIndex = 3
        Me.botonSumarB.Text = "+"
        Me.botonSumarB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(49, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 43)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(49, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 43)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "B"
        '
        'labelA
        '
        Me.labelA.AutoSize = True
        Me.labelA.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelA.Location = New System.Drawing.Point(210, 162)
        Me.labelA.Name = "labelA"
        Me.labelA.Size = New System.Drawing.Size(39, 43)
        Me.labelA.TabIndex = 6
        Me.labelA.Text = "0"
        '
        'labelB
        '
        Me.labelB.AutoSize = True
        Me.labelB.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.labelB.Location = New System.Drawing.Point(210, 229)
        Me.labelB.Name = "labelB"
        Me.labelB.Size = New System.Drawing.Size(39, 43)
        Me.labelB.TabIndex = 7
        Me.labelB.Text = "0"
        '
        'botonSuma
        '
        Me.botonSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonSuma.Location = New System.Drawing.Point(411, 130)
        Me.botonSuma.Name = "botonSuma"
        Me.botonSuma.Size = New System.Drawing.Size(101, 47)
        Me.botonSuma.TabIndex = 8
        Me.botonSuma.Text = "Sumar"
        Me.botonSuma.UseVisualStyleBackColor = True
        '
        'botonRestar
        '
        Me.botonRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonRestar.Location = New System.Drawing.Point(411, 199)
        Me.botonRestar.Name = "botonRestar"
        Me.botonRestar.Size = New System.Drawing.Size(101, 47)
        Me.botonRestar.TabIndex = 9
        Me.botonRestar.Text = "Restar"
        Me.botonRestar.UseVisualStyleBackColor = True
        '
        'botonMultiplicar
        '
        Me.botonMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonMultiplicar.Location = New System.Drawing.Point(411, 276)
        Me.botonMultiplicar.Name = "botonMultiplicar"
        Me.botonMultiplicar.Size = New System.Drawing.Size(101, 47)
        Me.botonMultiplicar.TabIndex = 10
        Me.botonMultiplicar.Text = "Multiplicar"
        Me.botonMultiplicar.UseVisualStyleBackColor = True
        '
        'botonDividir
        '
        Me.botonDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonDividir.Location = New System.Drawing.Point(411, 348)
        Me.botonDividir.Name = "botonDividir"
        Me.botonDividir.Size = New System.Drawing.Size(101, 47)
        Me.botonDividir.TabIndex = 11
        Me.botonDividir.Text = "Dividir"
        Me.botonDividir.UseVisualStyleBackColor = True
        '
        'botonLimpiar
        '
        Me.botonLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.botonLimpiar.Location = New System.Drawing.Point(105, 416)
        Me.botonLimpiar.Name = "botonLimpiar"
        Me.botonLimpiar.Size = New System.Drawing.Size(180, 34)
        Me.botonLimpiar.TabIndex = 12
        Me.botonLimpiar.Text = "Limpiar"
        Me.botonLimpiar.UseVisualStyleBackColor = True
        '
        'labelResultado
        '
        Me.labelResultado.AutoSize = True
        Me.labelResultado.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.labelResultado.ForeColor = System.Drawing.Color.Red
        Me.labelResultado.Location = New System.Drawing.Point(68, 348)
        Me.labelResultado.Name = "labelResultado"
        Me.labelResultado.Size = New System.Drawing.Size(153, 19)
        Me.labelResultado.TabIndex = 14
        Me.labelResultado.Text = "El resultado es:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Consolas", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(68, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 43)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "OPERACIONES BÁSICAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(345, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Aura Guadalupe Monzón Duarte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(411, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "201503965"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(560, 472)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.labelResultado)
        Me.Controls.Add(Me.botonLimpiar)
        Me.Controls.Add(Me.botonDividir)
        Me.Controls.Add(Me.botonMultiplicar)
        Me.Controls.Add(Me.botonRestar)
        Me.Controls.Add(Me.botonSuma)
        Me.Controls.Add(Me.labelB)
        Me.Controls.Add(Me.labelA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonSumarB)
        Me.Controls.Add(Me.botonRestarB)
        Me.Controls.Add(Me.botonSumarA)
        Me.Controls.Add(Me.botonRestarA)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents botonRestarA As Button
    Friend WithEvents botonSumarA As Button
    Friend WithEvents botonRestarB As Button
    Friend WithEvents botonSumarB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelA As Label
    Friend WithEvents labelB As Label
    Friend WithEvents botonSuma As Button
    Friend WithEvents botonRestar As Button
    Friend WithEvents botonMultiplicar As Button
    Friend WithEvents botonDividir As Button
    Friend WithEvents botonLimpiar As Button
    Friend WithEvents labelResultado As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
