Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEstados

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal IdCategoria As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("EstadosAgregar", Nombre, IdCategoria, Descripcion, Activo)
    End Function

    Public Function BuscarXId(ByVal IdEstado As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("EstadosBuscarXId", IdEstado)
    End Function

    Public Function Modificar(ByVal IdEstado As Integer, ByVal Nombre As String, ByVal IdCategoria As Integer, ByVal Descripcion As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("EstadosModificar", IdEstado, Nombre, IdCategoria, Descripcion, Activo)
    End Function

    Public Function Eliminar(ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("EstadosEliminar", IdEstado)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("EstadosBuscarTodos")
    End Function

    Public Function BuscarCategorias() As DataSet
        Return ODatabase.ExecuteDataSet("EstadosBuscarCategorias")
    End Function

End Class
