<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormularioEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(469, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteCargosToolStripMenuItem, Me.ReporteEmpleadosToolStripMenuItem, Me.FormularioEmpleadosToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(60, 24)
        Me.ToolStripMenuItem1.Text = "Menú"
        '
        'ReporteCargosToolStripMenuItem
        '
        Me.ReporteCargosToolStripMenuItem.Name = "ReporteCargosToolStripMenuItem"
        Me.ReporteCargosToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.ReporteCargosToolStripMenuItem.Text = "Reporte Cargos"
        '
        'ReporteEmpleadosToolStripMenuItem
        '
        Me.ReporteEmpleadosToolStripMenuItem.Name = "ReporteEmpleadosToolStripMenuItem"
        Me.ReporteEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.ReporteEmpleadosToolStripMenuItem.Text = "Reporte Empleados"
        '
        'FormularioEmpleadosToolStripMenuItem
        '
        Me.FormularioEmpleadosToolStripMenuItem.Name = "FormularioEmpleadosToolStripMenuItem"
        Me.FormularioEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(242, 26)
        Me.FormularioEmpleadosToolStripMenuItem.Text = "Formulario Empleados"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 554)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Menú Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteCargosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormularioEmpleadosToolStripMenuItem As ToolStripMenuItem
End Class
