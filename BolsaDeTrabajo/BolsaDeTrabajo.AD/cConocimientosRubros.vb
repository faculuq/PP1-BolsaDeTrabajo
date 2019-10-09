Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cConocimientosRubros

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("ConocimientosRubrosAgregar", Nombre, Activo)
    End Function

    Public Function BuscarXId(ByVal IdConocimientoRubro As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("ConocimientosRubrosBuscarXId", IdConocimientoRubro)
    End Function

    Public Function Modificar(ByVal IdConocimientoRubro As Integer, ByVal Nombre As String, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("ConocimientosRubrosModificar", IdConocimientoRubro, Nombre, Activo)
    End Function

    Public Function Eliminar(ByVal IdConocimientoRubro As Integer) As Double
        Return ODatabase.ExecuteScalar("ConocimientosRubrosEliminar", IdConocimientoRubro)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("ConocimientosRubrosBuscarTodos")
    End Function

End Class
