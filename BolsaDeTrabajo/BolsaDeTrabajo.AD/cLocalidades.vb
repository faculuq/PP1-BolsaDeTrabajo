Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cLocalidades

    Dim ODatabase As Database

    Public Sub New()
        ODatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal CodigoPostal As String, ByVal IdDepartamento As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteScalar("LocalidadesAgregar", Nombre, CodigoPostal, IdDepartamento, IdEstado)
    End Function

    Public Function BuscarXId(ByVal IdLocalidad As Integer) As DataSet
        Return ODatabase.ExecuteDataSet("LocalidadesBuscarXId", IdLocalidad)
    End Function

    Public Function Modificar(ByVal IdLocalidad As Integer, ByVal Nombre As String, ByVal CodigoPostal As String, ByVal IdDepartamento As Integer, ByVal IdEstado As Integer) As Double
        Return ODatabase.ExecuteNonQuery("LocalidadesModificar", IdLocalidad, Nombre, CodigoPostal, IdDepartamento, IdEstado)
    End Function

    Public Function Eliminar(ByVal IdLocalidad As Integer) As Double
        Return ODatabase.ExecuteNonQuery("LocalidadesEliminar", IdLocalidad)
    End Function

    Public Function BuscarTodos() As DataSet
        Return ODatabase.ExecuteDataSet("LocalidadesBuscarTodos")
    End Function

    Public Function BuscarEstados() As DataSet
        Return ODatabase.ExecuteDataSet("LocalidadesBuscarEstados")
    End Function

End Class
