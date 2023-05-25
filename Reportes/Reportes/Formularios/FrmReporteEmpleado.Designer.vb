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
        Me.BtnMostrar = New System.Windows.Forms.Button()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.CmbCampo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DgvRegistros = New System.Windows.Forms.DataGridView()
        Me.DtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.TxtRango2 = New System.Windows.Forms.TextBox()
        Me.DtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.TxtRango1 = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.BtnMostrar)
        Me.GroupBox1.Controls.Add(Me.TxtDato)
        Me.GroupBox1.Controls.Add(Me.CmbCampo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 78)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione por que campo desea buscar"
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
        'TxtDato
        '
        Me.TxtDato.Location = New System.Drawing.Point(264, 35)
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(425, 22)
        Me.TxtDato.TabIndex = 3
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
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.DgvRegistros)
        Me.GroupBox2.Controls.Add(Me.DtpFecha1)
        Me.GroupBox2.Controls.Add(Me.TxtRango2)
        Me.GroupBox2.Controls.Add(Me.DtpFecha2)
        Me.GroupBox2.Controls.Add(Me.TxtRango1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 342)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registros Encontrados"
        '
        'DgvRegistros
        '
        Me.DgvRegistros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvRegistros.Location = New System.Drawing.Point(17, 21)
        Me.DgvRegistros.Name = "DgvRegistros"
        Me.DgvRegistros.RowHeadersWidth = 51
        Me.DgvRegistros.RowTemplate.Height = 24
        Me.DgvRegistros.Size = New System.Drawing.Size(753, 315)
        Me.DgvRegistros.TabIndex = 0
        '
        'DtpFecha1
        '
        Me.DtpFecha1.Location = New System.Drawing.Point(76, 83)
        Me.DtpFecha1.Name = "DtpFecha1"
        Me.DtpFecha1.Size = New System.Drawing.Size(200, 22)
        Me.DtpFecha1.TabIndex = 1
        '
        'TxtRango2
        '
        Me.TxtRango2.Location = New System.Drawing.Point(382, 45)
        Me.TxtRango2.Name = "TxtRango2"
        Me.TxtRango2.Size = New System.Drawing.Size(100, 22)
        Me.TxtRango2.TabIndex = 4
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
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 27)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Reportes.My.Resources.Resources.impresora
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'FrmReporteEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 479)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmReporteEmpleado"
        Me.Text = "Reporte de Empleado por Profesión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DgvRegistros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CmbCampo As ComboBox
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents BtnMostrar As Button
    Friend WithEvents DgvRegistros As DataGridView
    Friend WithEvents DtpFecha1 As DateTimePicker
    Friend WithEvents TxtRango2 As TextBox
    Friend WithEvents DtpFecha2 As DateTimePicker
    Friend WithEvents TxtRango1 As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class
