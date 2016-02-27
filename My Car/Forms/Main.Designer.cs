namespace MyCar.Forms
{
    partial class Main
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("My Vehichles");
            this.treeViewVehichles = new System.Windows.Forms.TreeView();
            this.myCarDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myCarDBDataSet = new MyCar.MyCarDBDataSet();
            this.dataGridViewFixesList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixesList)).BeginInit();
            this.SuspendLayout();
            // 
            // treeViewVehichles
            // 
            this.treeViewVehichles.Location = new System.Drawing.Point(0, 27);
            this.treeViewVehichles.Name = "treeViewVehichles";
            treeNode1.Checked = true;
            treeNode1.Name = "Vehichles";
            treeNode1.Text = "My Vehichles";
            this.treeViewVehichles.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewVehichles.Size = new System.Drawing.Size(213, 325);
            this.treeViewVehichles.TabIndex = 0;
            // 
            // myCarDBDataSetBindingSource
            // 
            this.myCarDBDataSetBindingSource.DataSource = this.myCarDBDataSet;
            this.myCarDBDataSetBindingSource.Position = 0;
            // 
            // myCarDBDataSet
            // 
            this.myCarDBDataSet.DataSetName = "MyCarDBDataSet";
            this.myCarDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewFixesList
            // 
            this.dataGridViewFixesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFixesList.Location = new System.Drawing.Point(220, 28);
            this.dataGridViewFixesList.Name = "dataGridViewFixesList";
            this.dataGridViewFixesList.Size = new System.Drawing.Size(713, 230);
            this.dataGridViewFixesList.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 352);
            this.Controls.Add(this.dataGridViewFixesList);
            this.Controls.Add(this.treeViewVehichles);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Controls.SetChildIndex(this.treeViewVehichles, 0);
            this.Controls.SetChildIndex(this.dataGridViewFixesList, 0);
            ((System.ComponentModel.ISupportInitialize)(this.myCarDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCarDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFixesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewVehichles;
        private System.Windows.Forms.BindingSource myCarDBDataSetBindingSource;
        private MyCar.MyCarDBDataSet myCarDBDataSet;
        private System.Windows.Forms.DataGridView dataGridViewFixesList;
    }
}