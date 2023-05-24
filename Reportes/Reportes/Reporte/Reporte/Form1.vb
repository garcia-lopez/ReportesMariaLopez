﻿

Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

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

    Private Sub BtnImprimirCargo_Click(sender As Object, e As EventArgs) Handles BtnImprimirCargo.Click
        Try
            Dim tsql As String = "Select * from jobs"
            Dim conex As New SqlConnection(My.Settings.cStrDBRH)
            Dim ds As New SqlDataAdapter(tsql, conex)
            Dim t As New DataTable
            ds.Fill(t)
            verReporte(t, "dsRegistros", "diseñosRpt\rptCargo.rdlc")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al cargar reporte")

        End Try
    End Sub
End Class
