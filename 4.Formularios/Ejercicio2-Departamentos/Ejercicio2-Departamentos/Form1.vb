Public Class Form1
    Public Property empresa = New Empresa(New List(Of Departamento) From {})

    Public Property misEmpleados = New List(Of Empleado) From {}
    Public Sub addEmpleado(empleado As Empleado)
        Me.misEmpleados.add(empleado)
    End Sub

    Public Function checkIfExistEmpleado(emp As Empleado) As Boolean
        Dim encontrado As Boolean = False

        For Each e In Me.misEmpleados
            If e.getNombreCompleto = emp.getNombreCompleto Then
                encontrado = True
            End If

        Next

        Return encontrado

    End Function

    Private Sub checkFormularios(nameForm As String)
        Dim existe As Boolean = False
        For Each f In Me.MdiChildren
            f.WindowState = FormWindowState.Minimized
            If f.Name = nameForm Then
                existe = True
                f.WindowState = FormWindowState.Normal
            End If
        Next
        If Not existe Then
            Select Case nameForm
                Case "InsertarEmpleado"
                    Dim formEmpresa As New InsertarEmpleado
                    formEmpresa.MdiParent = Me
                    formEmpresa.Show()
                    formEmpresa.Dock = DockStyle.Fill
                Case "InsertarDepartamento"
                    Dim formEmpresa As New InsertarDepartamento
                    formEmpresa.MdiParent = Me
                    formEmpresa.Show()
                    formEmpresa.Dock = DockStyle.Fill
                Case "VisualizarEmpresa"
                    Dim formEmpresa As New VisualizarEmpresa
                    formEmpresa.MdiParent = Me
                    formEmpresa.Show()
                    formEmpresa.Dock = DockStyle.Fill
            End Select
        End If
    End Sub

    Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
        checkFormularios("InsertarEmpleado")
    End Sub

    Private Sub DepartamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DepartamentoToolStripMenuItem.Click
        checkFormularios("InsertarDepartamento")
    End Sub

    Private Sub VisualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarToolStripMenuItem.Click
        checkFormularios("VisualizarEmpresa")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
    End Sub
End Class
