Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cExperienciasLaborales

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdPostulante As Integer) As Double
        Return oDatabase.ExecuteScalar("ExperienciasLAboralesAgregar", IdPostulante)
    End Function

    Public Function AgregarDatos(ByVal IdPostulante As Integer, ByVal IdPuesto As Integer, ByVal IdRubro As Integer, ByVal Nombre As String, ByVal Descripcion As String, ByVal FechaInicio As Date, ByVal FechaFin As Date) As Double
        Return oDatabase.ExecuteScalar("ExperienciasLaboralesAgregarDatos", IdPostulante, IdPuesto, IdRubro, Nombre, Descripcion, FechaInicio, FechaFin)
    End Function

    Public Function BuscarPorPostulante(ByVal IdPostulante As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("ExperienciasBuscarPorPostulante", IdPostulante)
    End Function

End Class
