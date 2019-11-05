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

End Class
