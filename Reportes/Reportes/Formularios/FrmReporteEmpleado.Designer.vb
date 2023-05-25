<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmReporteEmpleado
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CmbCampo = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.DtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.TxtRango1 = New System.Windows.Forms.TextBox()
        Me.TxtRango2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.CmbCampo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione por que campo desea buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.DtpFecha1)
        Me.GroupBox2.Controls.Add(Me.TxtRango2)
        Me.GroupBox2.Controls.Add(Me.DtpFecha2)
        Me.GroupBox2.Controls.Add(Me.TxtRango1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 342)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros Encontrados"
        '
        'BtnMostrar
        '
        Me.BtnMostrar.Location = New System.Drawing.Point(695, 35)
        Me.BtnMostrar.Name = "BtnMostrar"
        Me.BtnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnMostrar.TabIndex = 2
        Me.BtnMostrar.Text = "Mostrar"
        Me.BtnMostrar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(264, 35)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(425, 22)
        Me.TextBox1.TabIndex = 3
        '
        'CmbCampo
        '
        Me.CmbCampo.FormattingEnabled = True
        Me.CmbCampo.Items.AddRange(New Object() {"Profesión", "Nombres", "Apellidos"})
        Me.CmbCampo.Location = New System.Drawing.Point(32, 33)
        Me.CmbCampo.Name = "CmbCampo"
        Me.CmbCampo.Size = New System.Drawing.Size(226, 24)
        Me.CmbCampo.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(753, 315)
        Me.DataGridView1.TabIndex = 0
        '
        'DtpFecha1
        '
        Me.DtpFecha1.Location = New System.Drawing.Point(76, 83)
        Me.DtpFecha1.Name = "DtpFecha1"
        Me.DtpFecha1.Size = New System.Drawing.Size(200, 22)
        Me.DtpFecha1.TabIndex = 1
        '
        'DtpFecha2
        '
        Me.DtpFecha2.Location = New System.Drawing.Point(527, 68)
        Me.DtpFecha2.Name = "DtpFecha2"
        Me.DtpFecha2.Size = New System.Drawing.Size(200, 22)
        Me.DtpFecha2.TabIndex = 2
        '
        'TxtRango1
        '
        Me.TxtRango1.Location = New System.Drawing.Point(310, 105)
        Me.TxtRango1.Name = "TxtRango1"
        Me.TxtRango1.Size = New System.Drawing.Size(100, 22)
        Me.TxtRango1.TabIndex = 3
        '
        'TxtRango2
        '
        Me.TxtRango2.Location = New System.Drawing.Point(382, 45)
        Me.TxtRango2.Name = "TxtRango2"
        Me.TxtRango2.Size = New System.Drawing.Size(100, 22)
        Me.TxtRango2.TabIndex = 4
        '
        'FrmReporteEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReporteEmpleado"
        Me.Text = "Reporte de Empleado por Profesión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbCampo As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DtpFecha1 As DateTimePicker
    Friend WithEvents TxtRango2 As TextBox
    Friend WithEvents DtpFecha2 As DateTimePicker
    Friend WithEvents TxtRango1 As TextBox
End Class
