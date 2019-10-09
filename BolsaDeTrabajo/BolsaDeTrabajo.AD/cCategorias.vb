Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cCategorias

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("CategoriasAgregar", Nombre, Activo)
    End Function

    Public Function BuscarXId(ByVal IdCategoria As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("CategoriasBuscarXId", IdCategoria)
    End Function

    Public Function Modificar(ByVal IdCategoria As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("CategoriasModificar", IdCategoria, Nombre, Activo)
    End Function

    Public Function Eliminar(ByVal IdCategoria As Integer) As Double
        Return ODatabase.ExecuteScalar("CategoriasEliminar", IdCategoria)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("CategoriasBuscarTodos")
    End Function

End Class
