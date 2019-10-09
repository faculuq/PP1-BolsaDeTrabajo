Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cAreasLaborales

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("AreasLaboralesAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdAreLaboral As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("AreasLaboralesModificar", IdAreLaboral, Nombre, Estado)
    End Function

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("AreasLaboralesBuscarTodos")
    End Function

    Public Function BuscarPorID(ByVal IdAreaLaboral As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("AreasLaboralesBuscarPorID", IdAreaLaboral)
    End Function

End Class
