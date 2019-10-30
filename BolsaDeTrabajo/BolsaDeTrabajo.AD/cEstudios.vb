Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEstudios

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdPostulante As Integer) As Double
        Return oDatabase.ExecuteScalar("EstudiosAgregar", IdPostulante)
    End Function

    Public Function AgregarDatos(ByVal IdPostulante As Integer, ByVal IdNivelEstudio As Integer, ByVal IdEstadoEstudio As Integer, ByVal Titulo As String, ByVal IdAreaEstudio As String, ByVal Institucion As String, ByVal FechaInicio As Date, ByVal FechaFin As Date) As Double
        Return oDatabase.ExecuteScalar("EstudiosAgregarDatos", IdPostulante, IdNivelEstudio, IdEstadoEstudio, Titulo, IdAreaEstudio, Institucion, FechaInicio, FechaFin)
    End Function

    Public Function BuscarPorPostulante(ByVal IdPostulante As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("EstudiosBuscarPorPostulante", IdPostulante)
    End Function

End Class
