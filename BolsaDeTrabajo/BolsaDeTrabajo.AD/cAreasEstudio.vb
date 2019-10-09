Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cAreasEstudio

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("AreasEstudioAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdAreaEstudio As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("AreasEstudioModificar", IdAreaEstudio, Nombre, Estado)
    End Function

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("AreasEstudioBuscarTodos")
    End Function

    Public Function BuscarPorID(ByVal IdAreaEstudio As Integer) As DataSet
            Return oDatabase.ExecuteDataSet("AreasEstudioBuscarPorID", IdAreaEstudio)
    End Function

End Class
