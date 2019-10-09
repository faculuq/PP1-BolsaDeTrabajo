Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cNivelesEstudios

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("NivelesEstudioAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdNivelEstudio As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("NivelesEstudioModificar", IdNivelEstudio, Nombre, Estado)
    End Function

    Public Function BuscarTodos() As DataSet

        Return oDatabase.ExecuteDataSet("NivelesEstudioBuscarTodos")
    End Function

    Public Function BuscarPorID(ByVal IdNivelEstudio As Integer) As DataSet
            Return oDatabase.ExecuteDataSet("NivelesEstudioBuscarPorID", IdNivelEstudio)
    End Function

End Class
