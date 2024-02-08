namespace testtttt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.statesDataGrid = new System.Windows.Forms.DataGridView();
            this.sortAsc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.avgMedian = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flagDescriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateBirdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateColorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.threeLargestCitiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateCapitalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianIncomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationComputerJobQuotientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesDataSet = new testtttt.StatesDataSet();
            this.statesTableAdapter = new testtttt.StatesDataSetTableAdapters.StatesTableAdapter();
            this.stateLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // statesDataGrid
            // 
            this.statesDataGrid.AutoGenerateColumns = false;
            this.statesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statesDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.statesDataGridViewTextBoxColumn,
            this.flagDescriptionsDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.stateFlowerDataGridViewTextBoxColumn,
            this.stateBirdDataGridViewTextBoxColumn,
            this.stateColorsDataGridViewTextBoxColumn,
            this.threeLargestCitiesDataGridViewTextBoxColumn,
            this.stateCapitalDataGridViewTextBoxColumn,
            this.medianIncomeDataGridViewTextBoxColumn,
            this.locationComputerJobQuotientDataGridViewTextBoxColumn});
            this.statesDataGrid.DataSource = this.statesBindingSource;
            this.statesDataGrid.Location = new System.Drawing.Point(3, 161);
            this.statesDataGrid.Name = "statesDataGrid";
            this.statesDataGrid.RowHeadersWidth = 62;
            this.statesDataGrid.RowTemplate.Height = 28;
            this.statesDataGrid.Size = new System.Drawing.Size(1800, 616);
            this.statesDataGrid.TabIndex = 2;
            // 
            // sortAsc
            // 
            this.sortAsc.BackColor = System.Drawing.SystemColors.Info;
            this.sortAsc.Location = new System.Drawing.Point(133, 810);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(210, 44);
            this.sortAsc.TabIndex = 3;
            this.sortAsc.Text = "Sort States Ascending";
            this.sortAsc.UseVisualStyleBackColor = false;
            this.sortAsc.Click += new System.EventHandler(this.sortAsc_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(448, 810);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sort States Descending";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(771, 810);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 44);
            this.button2.TabIndex = 5;
            this.button2.Text = "Median Income<=$65,000";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // avgMedian
            // 
            this.avgMedian.BackColor = System.Drawing.SystemColors.Info;
            this.avgMedian.Location = new System.Drawing.Point(1050, 810);
            this.avgMedian.Name = "avgMedian";
            this.avgMedian.Size = new System.Drawing.Size(240, 44);
            this.avgMedian.TabIndex = 6;
            this.avgMedian.Text = "Average Median for all States";
            this.avgMedian.UseVisualStyleBackColor = false;
            this.avgMedian.Click += new System.EventHandler(this.avgMedian_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // statesDataGridViewTextBoxColumn
            // 
            this.statesDataGridViewTextBoxColumn.DataPropertyName = "States";
            this.statesDataGridViewTextBoxColumn.HeaderText = "States";
            this.statesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.statesDataGridViewTextBoxColumn.Name = "statesDataGridViewTextBoxColumn";
            this.statesDataGridViewTextBoxColumn.Width = 150;
            // 
            // flagDescriptionsDataGridViewTextBoxColumn
            // 
            this.flagDescriptionsDataGridViewTextBoxColumn.DataPropertyName = "Flag Descriptions";
            this.flagDescriptionsDataGridViewTextBoxColumn.HeaderText = "Flag Descriptions";
            this.flagDescriptionsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.flagDescriptionsDataGridViewTextBoxColumn.Name = "flagDescriptionsDataGridViewTextBoxColumn";
            this.flagDescriptionsDataGridViewTextBoxColumn.Width = 150;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateFlowerDataGridViewTextBoxColumn
            // 
            this.stateFlowerDataGridViewTextBoxColumn.DataPropertyName = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.HeaderText = "State Flower";
            this.stateFlowerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateFlowerDataGridViewTextBoxColumn.Name = "stateFlowerDataGridViewTextBoxColumn";
            this.stateFlowerDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateBirdDataGridViewTextBoxColumn
            // 
            this.stateBirdDataGridViewTextBoxColumn.DataPropertyName = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.HeaderText = "State Bird";
            this.stateBirdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateBirdDataGridViewTextBoxColumn.Name = "stateBirdDataGridViewTextBoxColumn";
            this.stateBirdDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateColorsDataGridViewTextBoxColumn
            // 
            this.stateColorsDataGridViewTextBoxColumn.DataPropertyName = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.HeaderText = "State Colors";
            this.stateColorsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateColorsDataGridViewTextBoxColumn.Name = "stateColorsDataGridViewTextBoxColumn";
            this.stateColorsDataGridViewTextBoxColumn.Width = 150;
            // 
            // threeLargestCitiesDataGridViewTextBoxColumn
            // 
            this.threeLargestCitiesDataGridViewTextBoxColumn.DataPropertyName = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.HeaderText = "Three Largest Cities";
            this.threeLargestCitiesDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.threeLargestCitiesDataGridViewTextBoxColumn.Name = "threeLargestCitiesDataGridViewTextBoxColumn";
            this.threeLargestCitiesDataGridViewTextBoxColumn.Width = 150;
            // 
            // stateCapitalDataGridViewTextBoxColumn
            // 
            this.stateCapitalDataGridViewTextBoxColumn.DataPropertyName = "State Capital";
            this.stateCapitalDataGridViewTextBoxColumn.HeaderText = "State Capital";
            this.stateCapitalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.stateCapitalDataGridViewTextBoxColumn.Name = "stateCapitalDataGridViewTextBoxColumn";
            this.stateCapitalDataGridViewTextBoxColumn.Width = 150;
            // 
            // medianIncomeDataGridViewTextBoxColumn
            // 
            this.medianIncomeDataGridViewTextBoxColumn.DataPropertyName = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.HeaderText = "Median Income";
            this.medianIncomeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.medianIncomeDataGridViewTextBoxColumn.Name = "medianIncomeDataGridViewTextBoxColumn";
            this.medianIncomeDataGridViewTextBoxColumn.Width = 150;
            // 
            // locationComputerJobQuotientDataGridViewTextBoxColumn
            // 
            this.locationComputerJobQuotientDataGridViewTextBoxColumn.DataPropertyName = "Location computer job quotient";
            this.locationComputerJobQuotientDataGridViewTextBoxColumn.HeaderText = "Location computer job quotient";
            this.locationComputerJobQuotientDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.locationComputerJobQuotientDataGridViewTextBoxColumn.Name = "locationComputerJobQuotientDataGridViewTextBoxColumn";
            this.locationComputerJobQuotientDataGridViewTextBoxColumn.Width = 150;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.statesDataSet;
            // 
            // statesDataSet
            // 
            this.statesDataSet.DataSetName = "StatesDataSet";
            this.statesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(574, 70);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(314, 30);
            this.stateLabel.TabIndex = 7;
            this.stateLabel.Text = "States in the United States";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 921);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 48);
            this.button3.TabIndex = 8;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.avgMedian);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.statesDataGrid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView statesDataGrid;
        private StatesDataSet statesDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StatesDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDescriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateBirdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateColorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn threeLargestCitiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateCapitalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianIncomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationComputerJobQuotientDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button sortAsc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button avgMedian;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button button3;
    }
}

