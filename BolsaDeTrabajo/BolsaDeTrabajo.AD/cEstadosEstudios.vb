Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEstadosEstudios

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("EstadosEstudiosBuscarTodos")
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("EstadoEstudiosAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdEstadoEstudio As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("EstadoEstudiosModificar", IdEstadoEstudio, Nombre, Estado)
    End Function

    Public Function BuscarPorID(ByVal IdEstadoEstudio As Integer) As DataSet
            Return oDatabase.ExecuteDataSet("EstadosEstudioBuscarPorID", IdEstadoEstudio)
    End Function

End Class
