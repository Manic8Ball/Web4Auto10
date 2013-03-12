<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.InventoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModelNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VBAutoDataSet = New VBAutoCenter10.VBAutoDataSet()
        Me.VehicleTableAdapter = New VBAutoCenter10.VBAutoDataSetTableAdapters.VehicleTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VBAutoDataSet1 = New VBAutoCenter10.VBAutoDataSet1()
        Me.VehicleBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicleTableAdapter1 = New VBAutoCenter10.VBAutoDataSet1TableAdapters.VehicleTableAdapter()
        Me.FillBy1ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillBy1ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBAutoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicleBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy1ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InventoryIDDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.ModelNameDataGridViewTextBoxColumn, Me.YearDataGridViewTextBoxColumn, Me.VehicleIDDataGridViewTextBoxColumn, Me.CostValueDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VehicleBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(26, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 116)
        Me.DataGridView1.TabIndex = 0
        '
        'InventoryIDDataGridViewTextBoxColumn
        '
        Me.InventoryIDDataGridViewTextBoxColumn.DataPropertyName = "InventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.HeaderText = "InventoryID"
        Me.InventoryIDDataGridViewTextBoxColumn.Name = "InventoryIDDataGridViewTextBoxColumn"
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        '
        'ModelNameDataGridViewTextBoxColumn
        '
        Me.ModelNameDataGridViewTextBoxColumn.DataPropertyName = "ModelName"
        Me.ModelNameDataGridViewTextBoxColumn.HeaderText = "ModelName"
        Me.ModelNameDataGridViewTextBoxColumn.Name = "ModelNameDataGridViewTextBoxColumn"
        '
        'YearDataGridViewTextBoxColumn
        '
        Me.YearDataGridViewTextBoxColumn.DataPropertyName = "Year"
        Me.YearDataGridViewTextBoxColumn.HeaderText = "Year"
        Me.YearDataGridViewTextBoxColumn.Name = "YearDataGridViewTextBoxColumn"
        '
        'VehicleIDDataGridViewTextBoxColumn
        '
        Me.VehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID"
        Me.VehicleIDDataGridViewTextBoxColumn.Name = "VehicleIDDataGridViewTextBoxColumn"
        '
        'CostValueDataGridViewTextBoxColumn
        '
        Me.CostValueDataGridViewTextBoxColumn.DataPropertyName = "CostValue"
        Me.CostValueDataGridViewTextBoxColumn.HeaderText = "CostValue"
        Me.CostValueDataGridViewTextBoxColumn.Name = "CostValueDataGridViewTextBoxColumn"
        '
        'VehicleBindingSource
        '
        Me.VehicleBindingSource.DataMember = "Vehicle"
        Me.VehicleBindingSource.DataSource = Me.VBAutoDataSet
        '
        'VBAutoDataSet
        '
        Me.VBAutoDataSet.DataSetName = "VBAutoDataSet"
        Me.VBAutoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleTableAdapter
        '
        Me.VehicleTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.VehicleBindingSource
        Me.ComboBox1.DisplayMember = "InventoryID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(188, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "InventoryID"
        '
        'VBAutoDataSet1
        '
        Me.VBAutoDataSet1.DataSetName = "VBAutoDataSet1"
        Me.VBAutoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehicleBindingSource1
        '
        Me.VehicleBindingSource1.DataMember = "Vehicle"
        Me.VehicleBindingSource1.DataSource = Me.VBAutoDataSet1
        '
        'VehicleTableAdapter1
        '
        Me.VehicleTableAdapter1.ClearBeforeFill = True
        '
        'FillBy1ToolStrip
        '
        Me.FillBy1ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillBy1ToolStripButton})
        Me.FillBy1ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy1ToolStrip.Name = "FillBy1ToolStrip"
        Me.FillBy1ToolStrip.Size = New System.Drawing.Size(717, 25)
        Me.FillBy1ToolStrip.TabIndex = 2
        Me.FillBy1ToolStrip.Text = "FillBy1ToolStrip"
        '
        'FillBy1ToolStripButton
        '
        Me.FillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy1ToolStripButton.Name = "FillBy1ToolStripButton"
        Me.FillBy1ToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.FillBy1ToolStripButton.Text = "    "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Inventory ID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 199)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FillBy1ToolStrip)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "VB Auto"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBAutoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBAutoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicleBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy1ToolStrip.ResumeLayout(False)
        Me.FillBy1ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VBAutoDataSet As VBAutoCenter10.VBAutoDataSet
    Friend WithEvents VehicleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter As VBAutoCenter10.VBAutoDataSetTableAdapters.VehicleTableAdapter
    Friend WithEvents InventoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModelNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents YearDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents VBAutoDataSet1 As VBAutoCenter10.VBAutoDataSet1
    Friend WithEvents VehicleBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents VehicleTableAdapter1 As VBAutoCenter10.VBAutoDataSet1TableAdapters.VehicleTableAdapter
    Friend WithEvents FillBy1ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillBy1ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
