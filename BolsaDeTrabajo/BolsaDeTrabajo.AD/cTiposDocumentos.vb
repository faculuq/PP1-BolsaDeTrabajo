Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cTiposDocumentos

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("DocumentosTiposBuscarTodos")
    End Function

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("DcoumentosTiposAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdTipoDocumento As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("DocumentosTiposModificar", IdTipoDocumento, Nombre, Estado)
    End Function

    Public Function BuscarPorID(ByVal IdTipoDocumento As Integer) As DataSet
            Return oDatabase.ExecuteDataSet("DocumentosTiposBuscarPorID", IdTipoDocumento)
    End Function

End Class
