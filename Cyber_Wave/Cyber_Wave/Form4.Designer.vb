<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Crime_WaveDataSet = New Cyber_Wave.Crime_WaveDataSet()
        Me.First_Incident_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.First_Incident_ReportTableAdapter = New Cyber_Wave.Crime_WaveDataSetTableAdapters.First_Incident_ReportTableAdapter()
        Me.TableAdapterManager = New Cyber_Wave.Crime_WaveDataSetTableAdapters.TableAdapterManager()
        Me.First_Incident_ReportBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.First_Incident_ReportBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.First_Incident_ReportDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Crime_WaveDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.First_Incident_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.First_Incident_ReportBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.First_Incident_ReportBindingNavigator.SuspendLayout()
        CType(Me.First_Incident_ReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Crime_WaveDataSet
        '
        Me.Crime_WaveDataSet.DataSetName = "Crime_WaveDataSet"
        Me.Crime_WaveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'First_Incident_ReportBindingSource
        '
        Me.First_Incident_ReportBindingSource.DataMember = "First_Incident_Report"
        Me.First_Incident_ReportBindingSource.DataSource = Me.Crime_WaveDataSet
        '
        'First_Incident_ReportTableAdapter
        '
        Me.First_Incident_ReportTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccusedTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Case_StatementsTableAdapter = Nothing
        Me.TableAdapterManager.CasesTableAdapter = Nothing
        Me.TableAdapterManager.CrimeTableAdapter = Nothing
        Me.TableAdapterManager.CriminalTableAdapter = Nothing
        Me.TableAdapterManager.First_Incident_ReportTableAdapter = Me.First_Incident_ReportTableAdapter
        Me.TableAdapterManager.Forensic_InvestigatorTableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.PetitionerTableAdapter = Nothing
        Me.TableAdapterManager.StationTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cyber_Wave.Crime_WaveDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VictimTableAdapter = Nothing
        '
        'First_Incident_ReportBindingNavigator
        '
        Me.First_Incident_ReportBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.First_Incident_ReportBindingNavigator.BindingSource = Me.First_Incident_ReportBindingSource
        Me.First_Incident_ReportBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.First_Incident_ReportBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.First_Incident_ReportBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.First_Incident_ReportBindingNavigatorSaveItem})
        Me.First_Incident_ReportBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.First_Incident_ReportBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.First_Incident_ReportBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.First_Incident_ReportBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.First_Incident_ReportBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.First_Incident_ReportBindingNavigator.Name = "First_Incident_ReportBindingNavigator"
        Me.First_Incident_ReportBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.First_Incident_ReportBindingNavigator.Size = New System.Drawing.Size(872, 25)
        Me.First_Incident_ReportBindingNavigator.TabIndex = 0
        Me.First_Incident_ReportBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'First_Incident_ReportBindingNavigatorSaveItem
        '
        Me.First_Incident_ReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.First_Incident_ReportBindingNavigatorSaveItem.Image = CType(resources.GetObject("First_Incident_ReportBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.First_Incident_ReportBindingNavigatorSaveItem.Name = "First_Incident_ReportBindingNavigatorSaveItem"
        Me.First_Incident_ReportBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.First_Incident_ReportBindingNavigatorSaveItem.Text = "Save Data"
        '
        'First_Incident_ReportDataGridView
        '
        Me.First_Incident_ReportDataGridView.AutoGenerateColumns = False
        Me.First_Incident_ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.First_Incident_ReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.First_Incident_ReportDataGridView.DataSource = Me.First_Incident_ReportBindingSource
        Me.First_Incident_ReportDataGridView.Location = New System.Drawing.Point(12, 40)
        Me.First_Incident_ReportDataGridView.Name = "First_Incident_ReportDataGridView"
        Me.First_Incident_ReportDataGridView.Size = New System.Drawing.Size(834, 220)
        Me.First_Incident_ReportDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Fir_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fir_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Investigator_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Investigator_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Inc_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Inc_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Incident_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Incident_Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Incident_Place"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Incident_Place"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Date_Lodged"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Date_Lodged"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 281)
        Me.Controls.Add(Me.First_Incident_ReportDataGridView)
        Me.Controls.Add(Me.First_Incident_ReportBindingNavigator)
        Me.Name = "Form4"
        Me.Text = "Incident Reports View"
        CType(Me.Crime_WaveDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.First_Incident_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.First_Incident_ReportBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.First_Incident_ReportBindingNavigator.ResumeLayout(False)
        Me.First_Incident_ReportBindingNavigator.PerformLayout()
        CType(Me.First_Incident_ReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Crime_WaveDataSet As Crime_WaveDataSet
    Friend WithEvents First_Incident_ReportBindingSource As BindingSource
    Friend WithEvents First_Incident_ReportTableAdapter As Crime_WaveDataSetTableAdapters.First_Incident_ReportTableAdapter
    Friend WithEvents TableAdapterManager As Crime_WaveDataSetTableAdapters.TableAdapterManager
    Friend WithEvents First_Incident_ReportBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents First_Incident_ReportBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents First_Incident_ReportDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
