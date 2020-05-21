namespace Lab_2
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.d_InputTable = new System.Windows.Forms.DataGridView();
            this.c_InputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.с_InputValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_InputData = new System.Windows.Forms.Label();
            this.d_OutputTable = new System.Windows.Forms.DataGridView();
            this.с_OutputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_OutputValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_OutputData = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.d_InputTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_OutputTable)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.White;
            this.menuStripMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStripMain.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.runNetToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(784, 40);
            this.menuStripMain.TabIndex = 2;
            this.menuStripMain.Text = "menuStripMain";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.connectToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("connectToolStripMenuItem.Image")));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(88, 36);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // runNetToolStripMenuItem
            // 
            this.runNetToolStripMenuItem.Name = "runNetToolStripMenuItem";
            this.runNetToolStripMenuItem.Size = new System.Drawing.Size(67, 36);
            this.runNetToolStripMenuItem.Text = "Run net";
            this.runNetToolStripMenuItem.Click += new System.EventHandler(this.runNetToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(60, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.d_InputTable);
            this.splitContainer1.Panel1.Controls.Add(this.l_InputData);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.d_OutputTable);
            this.splitContainer1.Panel2.Controls.Add(this.l_OutputData);
            this.splitContainer1.Size = new System.Drawing.Size(784, 564);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 3;
            // 
            // d_InputTable
            // 
            this.d_InputTable.AllowUserToAddRows = false;
            this.d_InputTable.AllowUserToDeleteRows = false;
            this.d_InputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d_InputTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.d_InputTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.d_InputTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_InputTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_InputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.d_InputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_InputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_InputName,
            this.с_InputValue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_InputTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_InputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_InputTable.EnableHeadersVisualStyles = false;
            this.d_InputTable.Location = new System.Drawing.Point(0, 25);
            this.d_InputTable.Name = "d_InputTable";
            this.d_InputTable.RowHeadersVisible = false;
            this.d_InputTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_InputTable.Size = new System.Drawing.Size(365, 535);
            this.d_InputTable.TabIndex = 3;
            this.d_InputTable.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_InputTable_CellEndEdit);
            this.d_InputTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.d_InputTable_CellValueChanged);
            // 
            // c_InputName
            // 
            this.c_InputName.HeaderText = "Имя входного параметра";
            this.c_InputName.Name = "c_InputName";
            this.c_InputName.ReadOnly = true;
            // 
            // с_InputValue
            // 
            this.с_InputValue.HeaderText = "Значение входного параметра";
            this.с_InputValue.Name = "с_InputValue";
            // 
            // l_InputData
            // 
            this.l_InputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_InputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_InputData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_InputData.ForeColor = System.Drawing.Color.White;
            this.l_InputData.Location = new System.Drawing.Point(0, 0);
            this.l_InputData.Name = "l_InputData";
            this.l_InputData.Size = new System.Drawing.Size(365, 25);
            this.l_InputData.TabIndex = 0;
            this.l_InputData.Text = "Input data";
            this.l_InputData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // d_OutputTable
            // 
            this.d_OutputTable.AllowUserToAddRows = false;
            this.d_OutputTable.AllowUserToDeleteRows = false;
            this.d_OutputTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.d_OutputTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.d_OutputTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.d_OutputTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.d_OutputTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_OutputTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.d_OutputTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.d_OutputTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.с_OutputName,
            this.c_OutputValue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.d_OutputTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.d_OutputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.d_OutputTable.EnableHeadersVisualStyles = false;
            this.d_OutputTable.Location = new System.Drawing.Point(0, 25);
            this.d_OutputTable.Name = "d_OutputTable";
            this.d_OutputTable.RowHeadersVisible = false;
            this.d_OutputTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.d_OutputTable.Size = new System.Drawing.Size(407, 535);
            this.d_OutputTable.TabIndex = 2;
            // 
            // с_OutputName
            // 
            this.с_OutputName.HeaderText = "Имя выходного параметра";
            this.с_OutputName.Name = "с_OutputName";
            this.с_OutputName.ReadOnly = true;
            // 
            // c_OutputValue
            // 
            this.c_OutputValue.HeaderText = "Значение выходного параметра";
            this.c_OutputValue.Name = "c_OutputValue";
            this.c_OutputValue.ReadOnly = true;
            // 
            // l_OutputData
            // 
            this.l_OutputData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(137)))), ((int)(((byte)(209)))));
            this.l_OutputData.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_OutputData.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_OutputData.ForeColor = System.Drawing.Color.White;
            this.l_OutputData.Location = new System.Drawing.Point(0, 0);
            this.l_OutputData.Name = "l_OutputData";
            this.l_OutputData.Size = new System.Drawing.Size(407, 25);
            this.l_OutputData.TabIndex = 1;
            this.l_OutputData.Text = "Output data";
            this.l_OutputData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 604);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStripMain);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(800, 643);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KBANN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.d_InputTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d_OutputTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNetToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView d_InputTable;
        private System.Windows.Forms.Label l_InputData;
        private System.Windows.Forms.DataGridView d_OutputTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOutput;
        private System.Windows.Forms.Label l_OutputData;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_InputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn с_InputValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn с_OutputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_OutputValue;
    }
}

