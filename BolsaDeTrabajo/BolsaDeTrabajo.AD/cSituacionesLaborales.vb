Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cSituacionesLaborales

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("SituacionesLaboralesBuscarTodos")
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("SituacionesLaboralesAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdSituacionLaboral As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("SituacionesLaboralesModificar", IdSituacionLaboral, Nombre, Estado)
    End Function

    Public Function BuscarPorID(ByVal IdSituacionLaboral As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("SituacionesLaboralesBuscarPorID", IdSituacionLaboral)
    End Function

End Class
