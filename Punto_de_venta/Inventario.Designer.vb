<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.POSDataSet = New Punto_de_venta.POSDataSet()
        Me.PastesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PastesTableAdapter = New Punto_de_venta.POSDataSetTableAdapters.pastesTableAdapter()
        Me.TableAdapterManager = New Punto_de_venta.POSDataSetTableAdapters.TableAdapterManager()
        Me.PastesDataGridView = New System.Windows.Forms.DataGridView()
        Me.ComplementosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComplementosTableAdapter = New Punto_de_venta.POSDataSetTableAdapters.complementosTableAdapter()
        Me.ComplementosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New Punto_de_venta.POSDataSetTableAdapters.productosTableAdapter()
        Me.PastesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComplementosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PastesComboBox = New System.Windows.Forms.ComboBox()
        Me.ComplementosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComplementosComboBox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExistenciasDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PastesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PastesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PastesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComplementosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'POSDataSet
        '
        Me.POSDataSet.DataSetName = "POSDataSet"
        Me.POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PastesBindingSource
        '
        Me.PastesBindingSource.DataMember = "pastes"
        Me.PastesBindingSource.DataSource = Me.POSDataSet
        '
        'PastesTableAdapter
        '
        Me.PastesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.cortesTableAdapter = Nothing
        Me.TableAdapterManager.detalle_ventasTableAdapter = Nothing
        Me.TableAdapterManager.productosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Punto_de_venta.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventasTableAdapter = Nothing
        '
        'PastesDataGridView
        '
        Me.PastesDataGridView.AllowUserToAddRows = False
        Me.PastesDataGridView.AllowUserToDeleteRows = False
        Me.PastesDataGridView.AutoGenerateColumns = False
        Me.PastesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PastesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.ExistenciasDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.PastesDataGridView.DataSource = Me.PastesBindingSource1
        Me.PastesDataGridView.Location = New System.Drawing.Point(21, 63)
        Me.PastesDataGridView.Name = "PastesDataGridView"
        Me.PastesDataGridView.ReadOnly = True
        Me.PastesDataGridView.Size = New System.Drawing.Size(334, 168)
        Me.PastesDataGridView.TabIndex = 2
        '
        'ComplementosBindingSource
        '
        Me.ComplementosBindingSource.DataMember = "complementos"
        Me.ComplementosBindingSource.DataSource = Me.POSDataSet
        '
        'ComplementosTableAdapter
        '
        Me.ComplementosTableAdapter.ClearBeforeFill = True
        '
        'ComplementosDataGridView
        '
        Me.ComplementosDataGridView.AllowUserToAddRows = False
        Me.ComplementosDataGridView.AllowUserToDeleteRows = False
        Me.ComplementosDataGridView.AutoGenerateColumns = False
        Me.ComplementosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ComplementosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ComplementosDataGridView.DataSource = Me.ComplementosBindingSource
        Me.ComplementosDataGridView.Location = New System.Drawing.Point(373, 63)
        Me.ComplementosDataGridView.Name = "ComplementosDataGridView"
        Me.ComplementosDataGridView.ReadOnly = True
        Me.ComplementosDataGridView.Size = New System.Drawing.Size(334, 168)
        Me.ComplementosDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn9.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "existencias"
        Me.DataGridViewTextBoxColumn11.HeaderText = "existencias"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn12.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pastes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(369, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Complementos"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(396, 374)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDown1.TabIndex = 6
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "productos"
        Me.ProductosBindingSource.DataSource = Me.POSDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'PastesBindingSource1
        '
        Me.PastesBindingSource1.DataMember = "pastes"
        Me.PastesBindingSource1.DataSource = Me.POSDataSet
        '
        'ComplementosBindingSource1
        '
        Me.ComplementosBindingSource1.DataMember = "complementos"
        Me.ComplementosBindingSource1.DataSource = Me.POSDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(212, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre del producto a modificar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(212, 374)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Existencias a modificar"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(276, 422)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(368, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Quitar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PastesComboBox
        '
        Me.PastesComboBox.DataSource = Me.PastesBindingSource1
        Me.PastesComboBox.DisplayMember = "nombre"
        Me.PastesComboBox.FormattingEnabled = True
        Me.PastesComboBox.Location = New System.Drawing.Point(216, 336)
        Me.PastesComboBox.Name = "PastesComboBox"
        Me.PastesComboBox.Size = New System.Drawing.Size(300, 21)
        Me.PastesComboBox.TabIndex = 6
        Me.PastesComboBox.ValueMember = "id_producto"
        '
        'ComplementosBindingSource2
        '
        Me.ComplementosBindingSource2.DataMember = "complementos"
        Me.ComplementosBindingSource2.DataSource = Me.POSDataSet
        '
        'ComplementosComboBox
        '
        Me.ComplementosComboBox.DataSource = Me.ComplementosBindingSource2
        Me.ComplementosComboBox.DisplayMember = "nombre"
        Me.ComplementosComboBox.FormattingEnabled = True
        Me.ComplementosComboBox.Location = New System.Drawing.Point(216, 336)
        Me.ComplementosComboBox.Name = "ComplementosComboBox"
        Me.ComplementosComboBox.Size = New System.Drawing.Size(300, 21)
        Me.ComplementosComboBox.TabIndex = 12
        Me.ComplementosComboBox.ValueMember = "id_producto"
        Me.ComplementosComboBox.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Tipo de producto a modificar"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Pastes", "Complementos"})
        Me.ComboBox1.Location = New System.Drawing.Point(216, 268)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdproductoDataGridViewTextBoxColumn.Visible = False
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Visible = False
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Visible = False
        '
        'ExistenciasDataGridViewTextBoxColumn
        '
        Me.ExistenciasDataGridViewTextBoxColumn.DataPropertyName = "existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.HeaderText = "existencias"
        Me.ExistenciasDataGridViewTextBoxColumn.Name = "ExistenciasDataGridViewTextBoxColumn"
        Me.ExistenciasDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(728, 466)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComplementosComboBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PastesComboBox)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComplementosDataGridView)
        Me.Controls.Add(Me.PastesDataGridView)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PastesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PastesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PastesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComplementosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents POSDataSet As POSDataSet
    Friend WithEvents PastesBindingSource As BindingSource
    Friend WithEvents PastesTableAdapter As POSDataSetTableAdapters.pastesTableAdapter
    Friend WithEvents TableAdapterManager As POSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PastesDataGridView As DataGridView
    Friend WithEvents ComplementosBindingSource As BindingSource
    Friend WithEvents ComplementosTableAdapter As POSDataSetTableAdapters.complementosTableAdapter
    Friend WithEvents ComplementosDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductosTableAdapter As POSDataSetTableAdapters.productosTableAdapter
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents PastesBindingSource1 As BindingSource
    Friend WithEvents ComplementosBindingSource1 As BindingSource
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PastesComboBox As ComboBox
    Friend WithEvents ComplementosBindingSource2 As BindingSource
    Friend WithEvents ComplementosComboBox As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExistenciasDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
