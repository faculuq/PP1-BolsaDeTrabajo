Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cDepartamentos

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal IdProvincia As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("DepartamentosAgregar", Nombre, IdProvincia, IdEstado)
    End Function

    Public Function BuscarXId(ByVal IdDepartamento As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("DepartamentosBuscarXId", IdDepartamento)
    End Function

    Public Function Modificar(ByVal IdDepartamento As Integer, ByVal Nombre As String, ByVal IdProvincia As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("DepartamentosModificar", IdDepartamento, Nombre, IdProvincia, IdEstado)
    End Function

    Public Function Eliminar(ByVal IdDepartamento As Integer) As Double
        Return ODatabase.ExecuteScalar("DepartamentosEliminar", IdDepartamento)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("DepartamentosBuscarTodos")
    End Function

    Public Function BuscarEstados() As DataSet
        Return ODatabase.ExecuteDataSet("DepartamentosBuscarEstados")
    End Function

    Public Function BuscarXProvincia(ByVal IdProvincia As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("DepartamentosBuscarXProvincia", IdProvincia)
    End Function

End Class
