<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.bsDaySummary = New System.Windows.Forms.BindingSource(Me.components)
        Me.DaySummaryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenningDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClosingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LowestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighestDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VolumeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvgpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btGetDaySummary = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDaySummary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DaySummaryDateDataGridViewTextBoxColumn, Me.OpenningDataGridViewTextBoxColumn, Me.ClosingDataGridViewTextBoxColumn, Me.LowestDataGridViewTextBoxColumn, Me.HighestDataGridViewTextBoxColumn, Me.VolumeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.AvgpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsDaySummary
        Me.DataGridView1.Location = New System.Drawing.Point(46, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(922, 66)
        Me.DataGridView1.TabIndex = 0
        '
        'bsDaySummary
        '
        Me.bsDaySummary.DataSource = GetType(BitcoinStatus.Domain.DaySummary)
        '
        'DaySummaryDateDataGridViewTextBoxColumn
        '
        Me.DaySummaryDateDataGridViewTextBoxColumn.DataPropertyName = "DaySummaryDate"
        Me.DaySummaryDateDataGridViewTextBoxColumn.HeaderText = "DaySummaryDate"
        Me.DaySummaryDateDataGridViewTextBoxColumn.Name = "DaySummaryDateDataGridViewTextBoxColumn"
        '
        'OpenningDataGridViewTextBoxColumn
        '
        Me.OpenningDataGridViewTextBoxColumn.DataPropertyName = "openning"
        Me.OpenningDataGridViewTextBoxColumn.HeaderText = "openning"
        Me.OpenningDataGridViewTextBoxColumn.Name = "OpenningDataGridViewTextBoxColumn"
        '
        'ClosingDataGridViewTextBoxColumn
        '
        Me.ClosingDataGridViewTextBoxColumn.DataPropertyName = "closing"
        Me.ClosingDataGridViewTextBoxColumn.HeaderText = "closing"
        Me.ClosingDataGridViewTextBoxColumn.Name = "ClosingDataGridViewTextBoxColumn"
        '
        'LowestDataGridViewTextBoxColumn
        '
        Me.LowestDataGridViewTextBoxColumn.DataPropertyName = "lowest"
        Me.LowestDataGridViewTextBoxColumn.HeaderText = "lowest"
        Me.LowestDataGridViewTextBoxColumn.Name = "LowestDataGridViewTextBoxColumn"
        '
        'HighestDataGridViewTextBoxColumn
        '
        Me.HighestDataGridViewTextBoxColumn.DataPropertyName = "highest"
        Me.HighestDataGridViewTextBoxColumn.HeaderText = "highest"
        Me.HighestDataGridViewTextBoxColumn.Name = "HighestDataGridViewTextBoxColumn"
        '
        'VolumeDataGridViewTextBoxColumn
        '
        Me.VolumeDataGridViewTextBoxColumn.DataPropertyName = "volume"
        Me.VolumeDataGridViewTextBoxColumn.HeaderText = "volume"
        Me.VolumeDataGridViewTextBoxColumn.Name = "VolumeDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'AvgpriceDataGridViewTextBoxColumn
        '
        Me.AvgpriceDataGridViewTextBoxColumn.DataPropertyName = "avg_price"
        Me.AvgpriceDataGridViewTextBoxColumn.HeaderText = "avg_price"
        Me.AvgpriceDataGridViewTextBoxColumn.Name = "AvgpriceDataGridViewTextBoxColumn"
        '
        'btGetDaySummary
        '
        Me.btGetDaySummary.Location = New System.Drawing.Point(467, 150)
        Me.btGetDaySummary.Name = "btGetDaySummary"
        Me.btGetDaySummary.Size = New System.Drawing.Size(109, 42)
        Me.btGetDaySummary.TabIndex = 1
        Me.btGetDaySummary.Text = "Get Day Summary"
        Me.btGetDaySummary.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 261)
        Me.Controls.Add(Me.btGetDaySummary)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmMain"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDaySummary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsDaySummary As BindingSource
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DaySummaryDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpenningDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClosingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LowestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HighestDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VolumeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AvgpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btGetDaySummary As Button
End Class
