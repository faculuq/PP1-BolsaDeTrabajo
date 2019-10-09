Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cPaises

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("PaisesAgregar", Nombre, IdEstado)
    End Function

    Public Function BuscarXId(ByVal IdPais As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("PaisesBuscarXId", IdPais)
    End Function

    Public Function Modificar(ByVal IdPais As Integer, ByVal Nombre As String, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("PaisesModificar", IdPais, Nombre, IdEstado)
    End Function

    Public Function Eliminar(ByVal IdPais As Integer) As Double
        Return ODatabase.ExecuteScalar("PaisesEliminar", IdPais)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("PaisesBuscarTodos")
    End Function

    Public Function BuscarEstados() As DataSet
        Return ODatabase.ExecuteDataSet("PaisesBuscarEstados")
    End Function

End Class
