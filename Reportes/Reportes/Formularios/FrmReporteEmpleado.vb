Imports Microsoft.Reporting.WinForms
Public Class FrmReporteEmpleado

    Dim tblEmp As New BdHRDataSet.RptJobEmployeesDataTable
    Dim rptEmpleados As New BdHRDataSetTableAdapters.RptJobEmployeesTableAdapter
    Dim tbl As New DataTable

    Sub LlenarGrid()
        rptEmpleados.Fill(tblEmp)
        DgvRegistros.DataSource = tblEmp
        DgvRegistros.Refresh()
        GroupBox2.Text = "Registros guardados: " & DgvRegistros.Rows.Count - 1

    End Sub

    Dim fila As DataRow
    Private Function CrearTabla(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblEmp")

        tbl.Columns.Add("job_title")
        tbl.Columns.Add("first_name")
        tbl.Columns.Add("last_name")
        tbl.Columns.Add("email")
        tbl.Columns.Add("phone_number")
        tbl.Columns.Add("hire_date")
        tbl.Columns.Add("salary")

        For Each emp In query
            fila = tbl.NewRow
            fila("job_title") = emp.job_title
            fila("first_name") = emp.first_name
            fila("last_name") = emp.last_name
            fila("email") = emp.email
            fila("phone_number") = emp.phone_number
            fila("hire_date") = emp.hire_date
            fila("salary") = emp.salary
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub RealizarBusqueda()
        Dim dato As String = TxtDato.Text.Trim
        Dim campo As String = "emp.job_title"
        Dim query = From emp In tblEmp
                    Select emp.job_title, emp.first_name, emp.last_name, emp.email, emp.phone_number,
                        emp.hire_date, emp.salary

        Select Case CmbCampo.SelectedIndex
            Case 0
                query = From emp In tblEmp Where emp.job_title Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email,
                            emp.phone_number, emp.hire_date, emp.salary
            Case 1
                query = From emp In tblEmp Where emp.first_name Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email,
                            emp.phone_number, emp.hire_date, emp.salary
            Case 2
                query = From emp In tblEmp Where emp.last_name Like dato
                        Select emp.job_title, emp.first_name, emp.last_name, emp.email,
                            emp.phone_number, emp.hire_date, emp.salary
        End Select

        tbl = CrearTabla(query)

        DgvRegistros.DataSource = tbl
        DgvRegistros.Refresh()
        GroupBox2.Text = "Registros guardados: " & DgvRegistros.Rows.Count
    End Sub

    Sub verReporte(ByVal t As DataTable, ByVal nombreDS As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDS, t)
            With FrmVistaPreviaEmpleados
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar el reporte")

        End Try
    End Sub

    Private Sub FrmReporteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarGrid()
    End Sub

    Private Sub BtnMostrar_Click(sender As Object, e As EventArgs) Handles BtnMostrar.Click
        RealizarBusqueda()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        verReporte(tbl, "DsReporte", "Reportes\RptEmpleadoTrabajo.rdlc")
    End Sub


End Class