Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cProvincias

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal IdPais As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("ProvinciasAgregar", Nombre, IdPais, IdEstado)
    End Function

    Public Function BuscarXId(ByVal IdProvincia As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("ProvinciasBuscarXId", IdProvincia)
    End Function

    Public Function Modificar(ByVal IdProvincia As Integer, ByVal Nombre As String, ByVal IdPais As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("ProvinciasModificar", IdProvincia, Nombre, IdPais, IdEstado)
    End Function

    Public Function Eliminar(ByVal IdProvincia As Integer) As Double
        Return ODatabase.ExecuteScalar("ProvinciasEliminar", IdProvincia)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("ProvinciasBuscarTodos")
    End Function

    Public Function BuscarEstados() As DataSet
        Return ODatabase.ExecuteDataSet("ProvinciasBuscarEstados")
    End Function

    Public Function BuscarXPais(ByVal IdPais As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("ProvinciasBuscarXPais", IdPais)
    End Function

End Class
