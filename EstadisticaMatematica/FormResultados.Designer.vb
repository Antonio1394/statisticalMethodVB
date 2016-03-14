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
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Me.TelerikMetroTouchTheme1 = New Telerik.WinControls.Themes.TelerikMetroTouchTheme()
        Me.TableResultados = New Telerik.WinControls.UI.RadGridView()
        Me.RadListControl1 = New Telerik.WinControls.UI.RadListControl()
        CType(Me.TableResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableResultados.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableResultados
        '
        Me.TableResultados.BackColor = System.Drawing.Color.White
        Me.TableResultados.Cursor = System.Windows.Forms.Cursors.Default
        Me.TableResultados.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TableResultados.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TableResultados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TableResultados.Location = New System.Drawing.Point(42, 95)
        '
        'TableResultados
        '
        Me.TableResultados.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.HeaderText = "Intervalo I"
        GridViewTextBoxColumn1.Name = "column1"
        GridViewTextBoxColumn1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn1.Width = 85
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.HeaderText = "Intervalo F"
        GridViewTextBoxColumn2.Name = "column2"
        Me.TableResultados.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2})
        SortDescriptor1.PropertyName = "column1"
        Me.TableResultados.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.TableResultados.Name = "TableResultados"
        Me.TableResultados.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TableResultados.ShowGroupPanel = False
        Me.TableResultados.Size = New System.Drawing.Size(662, 263)
        Me.TableResultados.TabIndex = 0
        Me.TableResultados.Text = "RadGridView1"
        Me.TableResultados.ThemeName = "TelerikMetroTouch"
        '
        'RadListControl1
        '
        Me.RadListControl1.Location = New System.Drawing.Point(333, 15)
        Me.RadListControl1.Name = "RadListControl1"
        Me.RadListControl1.Size = New System.Drawing.Size(129, 53)
        Me.RadListControl1.TabIndex = 1
        Me.RadListControl1.Text = "RadListControl1"
        '
        'FormResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 392)
        Me.Controls.Add(Me.RadListControl1)
        Me.Controls.Add(Me.TableResultados)
        Me.Name = "FormResultados"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.Text = "FormResultados"
        Me.ThemeName = "TelerikMetroTouch"
        CType(Me.TableResultados.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableResultados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadListControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelerikMetroTouchTheme1 As Telerik.WinControls.Themes.TelerikMetroTouchTheme
    Friend WithEvents TableResultados As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadListControl1 As Telerik.WinControls.UI.RadListControl
End Class

