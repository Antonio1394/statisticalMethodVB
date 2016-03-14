<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultados
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TelerikMetroTouchTheme1 = New Telerik.WinControls.Themes.TelerikMetroTouchTheme()
        Me.ListFrecuencias = New Telerik.WinControls.UI.RadListControl()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.ListIntervalos = New Telerik.WinControls.UI.RadListControl()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.ListFrecuencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListIntervalos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListFrecuencias
        '
        Me.ListFrecuencias.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListFrecuencias.ItemHeight = 36
        Me.ListFrecuencias.Location = New System.Drawing.Point(178, 46)
        Me.ListFrecuencias.Name = "ListFrecuencias"
        Me.ListFrecuencias.Size = New System.Drawing.Size(55, 325)
        Me.ListFrecuencias.TabIndex = 3
        Me.ListFrecuencias.Text = "RadListControl1"
        Me.ListFrecuencias.ThemeName = "TelerikMetroTouch"
        '
        'RadLabel1
        '
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel1.Location = New System.Drawing.Point(191, 14)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(18, 30)
        Me.RadLabel1.TabIndex = 4
        Me.RadLabel1.Text = "F"
        '
        'ListIntervalos
        '
        Me.ListIntervalos.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListIntervalos.ItemHeight = 36
        Me.ListIntervalos.Location = New System.Drawing.Point(62, 45)
        Me.ListIntervalos.Name = "ListIntervalos"
        Me.ListIntervalos.Size = New System.Drawing.Size(110, 326)
        Me.ListIntervalos.TabIndex = 5
        Me.ListIntervalos.Text = "RadListControl2"
        Me.ListIntervalos.ThemeName = "TelerikMetroTouch"
        '
        'RadLabel2
        '
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadLabel2.Location = New System.Drawing.Point(62, 14)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(93, 30)
        Me.RadLabel2.TabIndex = 6
        Me.RadLabel2.Text = "Intervalos"
        '
        'FormResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 392)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.ListIntervalos)
        Me.Controls.Add(Me.RadLabel1)
        Me.Controls.Add(Me.ListFrecuencias)
        Me.Name = "FormResultados"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FormResultados"
        Me.ThemeName = "TelerikMetroTouch"
        CType(Me.ListFrecuencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListIntervalos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TelerikMetroTouchTheme1 As Telerik.WinControls.Themes.TelerikMetroTouchTheme
    Friend WithEvents ListFrecuencias As Telerik.WinControls.UI.RadListControl
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents ListIntervalos As Telerik.WinControls.UI.RadListControl
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
End Class

