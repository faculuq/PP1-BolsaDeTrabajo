Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cPuestosLaborales

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal Nombre As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("PuestosLaboralesAgregar", Nombre, Estado)
    End Function

    Public Function Modificar(ByVal Nombre As Integer, ByVal IdPuestoLaboral As String, ByVal Estado As Boolean) As Double
        Return oDatabase.ExecuteScalar("PuestosLaboralesModificar", IdPuestoLaboral, Nombre, Estado)
    End Function
    Public Function BuscarTodos() As DataSet
        Return oDatabase.ExecuteDataSet("PuestosLaboralesBuscarTodos")
    End Function
    Public Function BuscarPorID(ByVal IdPuestoLaboral As Integer) As DataSet
        Return oDatabase.ExecuteDataSet("PuestosLaboralesBuscarPorId", IdPuestoLaboral)
    End Function

End Class
