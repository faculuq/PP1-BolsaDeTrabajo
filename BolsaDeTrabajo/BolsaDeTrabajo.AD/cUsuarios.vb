Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cUsuarios

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function BuscarPorLoginPass(ByVal Email As String, ByVal Password As String) As DataSet

        Try

            Return oDatabase.ExecuteDataSet("UsuariosBuscarPorLoginPass", Email, Password)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

    Public Function Agregar(ByVal Email As String, ByVal Password As String) As Double

        Try

            Return oDatabase.ExecuteScalar("UsuariosAgregar", Email, Password)

        Catch ex As System.Exception
            Throw ex
        End Try

    End Function

End Class
