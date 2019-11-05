﻿Imports Microsoft.VisualBasic
Imports System.DataSqlClient
Imports System.Data
Imports System.IO
Imports Microsoft.Practices.EnterpriseLibrary.Data
Imports System.Configuration

Public Class cEmpresas

    Dim oDatabase As Database

    Public Sub New()
        oDatabase = DatabaseFactory.CreateDatabase("Conn")
    End Sub

    Public Function Agregar(ByVal IdUsuario As Integer) As Double
        Return oDatabase.ExecuteScalar("EmpresasAgregar", IdUsuario)
    End Function

    Public Function GuardarInformacion(ByVal IdUsuario As Integer, ByVal Nombre As String, ByVal RazonSocial As String, ByVal IdTipoDoc As Integer, ByVal NumeroDocumento As Integer, ByVal IdRubro As Integer, ByVal FechaFundacion As Date) As Double
        Return oDatabase.ExecuteScalar("EmpresasGuardarInformacion", IdUsuario, Nombre, RazonSocial, IdTipoDoc, NumeroDocumento, FechaFundacion, IdRubro)
    End Function

    Public Function GuardarDatosContacto(ByVal IdUsuario As Integer, ByVal Telefono As Integer, ByVal IdLocalidad As Integer, ByVal Calle As Integer, ByVal Numero As Integer) As Double
        Return oDatabase.ExecuteScalar("EmpresasGuardarDatosContacto", IdUsuario, Telefono, IdLocalidad, Calle, Numero)
    End Function

    Public Function EmpresaBuscarPorUsuario(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteScalar("EmpresaBuscarPorUsuario", IdUsuario)
    End Function
    Public Function EmpresaBuscarPorIdEmpresa(ByVal IdUsuario As Integer) As DataSet
        Return oDatabase.ExecuteScalar("EmpresaBuscarPorIdEmpresa", IdUsuario)
    End Function

End Class
