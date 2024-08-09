namespace CrudRegionCodigo
{
    partial class frmManRegion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtRegion = new TextBox();
            btnSave = new Button();
            dxDataGrid = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            txtIdRegion = new TextBox();
            chkEstado = new CheckBox();
            btnActualizar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dxDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 55);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Nmae:";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(227, 61);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(125, 27);
            txtRegion.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(551, 21);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Registrar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dxDataGrid
            // 
            dxDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dxDataGrid.Location = new Point(39, 260);
            dxDataGrid.Name = "dxDataGrid";
            dxDataGrid.RowHeadersWidth = 51;
            dxDataGrid.RowTemplate.Height = 29;
            dxDataGrid.Size = new Size(619, 258);
            dxDataGrid.TabIndex = 3;
            dxDataGrid.CellContentClick += dxDataGrid_CellContentClick;
            dxDataGrid.SelectionChanged += dxDataGrid_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 12);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 139);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 5;
            label3.Text = "Estado";
            // 
            // txtIdRegion
            // 
            txtIdRegion.Location = new Point(227, 12);
            txtIdRegion.Name = "txtIdRegion";
            txtIdRegion.Size = new Size(125, 27);
            txtIdRegion.TabIndex = 6;
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(227, 135);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(102, 24);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Habilitado";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(551, 83);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(551, 139);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmManRegion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 541);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(chkEstado);
            Controls.Add(txtIdRegion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dxDataGrid);
            Controls.Add(btnSave);
            Controls.Add(txtRegion);
            Controls.Add(label1);
            Name = "frmManRegion";
            Text = "frmManRegion";
            ((System.ComponentModel.ISupportInitialize)dxDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRegion;
        private Button btnSave;
        private DataGridView dxDataGrid;
        private Label label2;
        private Label label3;
        private TextBox txtIdRegion;
        private CheckBox chkEstado;
        private Button btnActualizar;
        private Button btnEliminar;
    }
}