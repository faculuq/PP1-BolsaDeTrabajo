Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cAvisos

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarAvisos() As DataSet
        Return oDatabase.ExecuteDataSet("AvisosBuscar")
    End Function

    Public Function Postularse(ByVal IdPostulante As Integer, ByVal IdAviso As Integer) As Double
        Return oDatabase.ExecuteScalar("AvisosPostularse", IdPostulante, IdAviso)
    End Function

    Public Function BuscarPorEmpresa(ByVal IdEmpresa As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("AvisosBuscarPorEmpresa", IdEmpresa)
    End Function

    Public Function BuscarPorPalabraClave(ByVal PalabraClave As String) As DataSet
        Return oDatabase.ExecuteDataSet("AvisosBuscarPorPalabraClave", PalabraClave)
    End Function

    Public Function Agregar(ByVal IdEmpresa As Integer, ByVal Puesto As String, ByVal Requisitos As String, ByVal Palabra1 As String, ByVal Palabra2 As String) As Double
        Return oDatabase.ExecuteScalar("AvisosAgregar", IdEmpresa, Puesto, Requisitos, Palabra1, Palabra2)
    End Function

End Class
