Imports Microsoft.Reporting.WinForms
Public Class FrmReporteEmpleado

    Dim tblEmp As New BdHRDataSet.RptJobEmployeesDataTable
    Dim rptEmpleados As New BdHRDataSetTableAdapters.RptJobEmployeesTableAdapter
    Dim tbl As New DataTable

    Sub LlenarGrid()
        rptEmpleados.Fill(tblEmp)
        DgvRe
    End Sub

End Class