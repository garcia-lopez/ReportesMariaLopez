Imports Microsoft.Reporting.WinForms
Imports System.Data.SqlClient

Public Class Form1

    Sub verReporte(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPrevia.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPrevia.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPrevia.ReportViewer1.Refresh()
            FrmVistaPrevia.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub

    Sub verReporteDos(ByVal t As DataTable, ByVal ds As String, ByVal nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(ds, t)

            FrmVistaPreviaEmpleados.ReportViewer1.LocalReport.DataSources.Clear()
            FrmVistaPreviaEmpleados.ReportViewer1.LocalReport.DataSources.Add(rpt)
            FrmVistaPreviaEmpleados.ReportViewer1.LocalReport.ReportPath = nombreRpt
            FrmVistaPreviaEmpleados.ReportViewer1.Refresh()
            FrmVistaPreviaEmpleados.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al mostrar reporte")
        End Try
    End Sub

    Private Sub BtnImprimirCargos_Click_1(sender As Object, e As EventArgs) Handles BtnImprimirCargos.Click
        Try
            Dim tsql As String = "SELECT * FROM jobs"
            Dim conex As New SqlConnection(My.Settings.strConn)
            Dim da As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporte(t, "dsRegistros", "diseñosRpt\rptCargo.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

    Private Sub BtnReportesEmpleados_Click(sender As Object, e As EventArgs) Handles BtnReportesEmpleados.Click
        Try
            Dim tsql As String = "SELECT jobs.job_title, employees.first_name, employees.last_name, employees.email, employees.phone_number, employees.hire_date, employees.salary FROM employees INNER JOIN jobs ON employees.job_id = jobs.job_id"
            Dim conex As New SqlConnection(My.Settings.strConn)
            Dim da As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            da.Fill(t)
            verReporteDos(t, "DsReporte", "Reportes\RptEmpleadoTrabajo.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")
        End Try
    End Sub

End Class