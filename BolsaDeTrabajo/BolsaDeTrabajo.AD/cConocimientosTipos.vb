Imports Microsoft.VisualBasic
Imports System.DataSqlClientl
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cConocimientosTipos

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal IdConocimientoRubro As Integer, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("ConocimientosTiposAgregar", Nombre, IdConocimientoRubro, Activo)
    End Function

    Public Function BuscarXId(ByVal IdConocimientoTipo As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("ConocimientosTiposBuscarXId", IdConocimientoTipo)
    End Function

    Public Function Modificar(ByVal IdConocimientoTipo As Integer, ByVal Nombre As String, ByVal IdConocimientoRubro As Integer, ByVal Activo As Boolean) As Double
        Return ODatabase.ExecuteScalar("ConocimientosTiposModificar", IdConocimientoTipo, Nombre, IdConocimientoRubro, Activo)
    End Function

    Public Function Eliminar(ByVal IdConocimientoTipo As Integer) As Double
        Return ODatabase.ExecuteScalar("ConocimientosTiposEliminar", IdConocimientoTipo)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("ConocimientosTiposBuscarTodos")
    End Function

    Public Function BuscarRubros() As DataSet
        Return ODatabase.ExecuteDataSet("ConocimientosTiposBuscarRubros")
    End Function

End Class
