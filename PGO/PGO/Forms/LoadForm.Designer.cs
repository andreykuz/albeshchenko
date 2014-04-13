namespace PGO.Forms
{
    partial class LoadForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dTable = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolPEREHOD = new System.Windows.Forms.ToolStripSplitButton();
            this.peopleToolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.landToolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.pgoToolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.houseToolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolREPORT = new System.Windows.Forms.ToolStripSplitButton();
            this.поквартирнаКарточкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тимчасоваНезайнятістьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.складСімїToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЖітелівСелаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton3 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.landBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filter_parent = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dTable
            // 
            this.dTable.AllowUserToAddRows = false;
            this.dTable.AllowUserToDeleteRows = false;
            this.dTable.AllowUserToResizeRows = false;
            this.dTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dTable.ColumnHeadersHeight = 50;
            this.dTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dTable.Location = new System.Drawing.Point(0, 61);
            this.dTable.Name = "dTable";
            this.dTable.ReadOnly = true;
            this.dTable.RowHeadersVisible = false;
            this.dTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dTable.Size = new System.Drawing.Size(674, 321);
            this.dTable.TabIndex = 0;
            this.dTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dTable_CellDoubleClick);
            this.dTable.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dTable_ColumnWidthChanged);
            this.dTable.Resize += new System.EventHandler(this.dTable_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolPEREHOD,
            this.toolREPORT,
            this.toolStripSplitButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::PGO.Properties.Resources.plus_2;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 24);
            this.toolStripButton1.Text = "Додати";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::PGO.Properties.Resources.minus_2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(97, 24);
            this.toolStripButton2.Text = "Видалити";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::PGO.Properties.Resources.pencil_edit;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(108, 24);
            this.toolStripButton3.Text = "Редагувати";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::PGO.Properties.Resources.refresh;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(96, 24);
            this.toolStripButton4.Text = "Обновити";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolPEREHOD
            // 
            this.toolPEREHOD.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peopleToolBtn,
            this.landToolBtn,
            this.pgoToolBtn,
            this.houseToolBtn});
            this.toolPEREHOD.Image = global::PGO.Properties.Resources.tag_blue;
            this.toolPEREHOD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPEREHOD.Name = "toolPEREHOD";
            this.toolPEREHOD.Size = new System.Drawing.Size(109, 24);
            this.toolPEREHOD.Text = "Переходи";
            // 
            // peopleToolBtn
            // 
            this.peopleToolBtn.Name = "peopleToolBtn";
            this.peopleToolBtn.Size = new System.Drawing.Size(174, 24);
            this.peopleToolBtn.Text = "Фізичні особи";
            this.peopleToolBtn.Click += new System.EventHandler(this.peopleToolBtn_Click);
            // 
            // landToolBtn
            // 
            this.landToolBtn.Name = "landToolBtn";
            this.landToolBtn.Size = new System.Drawing.Size(174, 24);
            this.landToolBtn.Text = "Земля";
            this.landToolBtn.Click += new System.EventHandler(this.landToolBtn_Click);
            // 
            // pgoToolBtn
            // 
            this.pgoToolBtn.Name = "pgoToolBtn";
            this.pgoToolBtn.Size = new System.Drawing.Size(174, 24);
            this.pgoToolBtn.Text = "Господарства";
            this.pgoToolBtn.Click += new System.EventHandler(this.pgoToolBtn_Click);
            // 
            // houseToolBtn
            // 
            this.houseToolBtn.Name = "houseToolBtn";
            this.houseToolBtn.Size = new System.Drawing.Size(174, 24);
            this.houseToolBtn.Text = "Будинки";
            this.houseToolBtn.Click += new System.EventHandler(this.houseToolBtn_Click);
            // 
            // toolREPORT
            // 
            this.toolREPORT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поквартирнаКарточкаToolStripMenuItem,
            this.довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem,
            this.тимчасоваНезайнятістьToolStripMenuItem,
            this.складСімїToolStripMenuItem,
            this.списокЖітелівСелаToolStripMenuItem});
            this.toolREPORT.Image = global::PGO.Properties.Resources.document_file;
            this.toolREPORT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolREPORT.Name = "toolREPORT";
            this.toolREPORT.Size = new System.Drawing.Size(77, 24);
            this.toolREPORT.Text = "Звіти";
            // 
            // поквартирнаКарточкаToolStripMenuItem
            // 
            this.поквартирнаКарточкаToolStripMenuItem.Name = "поквартирнаКарточкаToolStripMenuItem";
            this.поквартирнаКарточкаToolStripMenuItem.Size = new System.Drawing.Size(454, 24);
            this.поквартирнаКарточкаToolStripMenuItem.Text = "Поквартирна карточка";
            // 
            // довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem
            // 
            this.довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem.Name = "довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem";
            this.довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem.Size = new System.Drawing.Size(454, 24);
            this.довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem.Text = "Довідка про наявність(відсутність) земельної ділянки";
            // 
            // тимчасоваНезайнятістьToolStripMenuItem
            // 
            this.тимчасоваНезайнятістьToolStripMenuItem.Name = "тимчасоваНезайнятістьToolStripMenuItem";
            this.тимчасоваНезайнятістьToolStripMenuItem.Size = new System.Drawing.Size(454, 24);
            this.тимчасоваНезайнятістьToolStripMenuItem.Text = "Тимчасова незайнятість";
            // 
            // складСімїToolStripMenuItem
            // 
            this.складСімїToolStripMenuItem.Name = "складСімїToolStripMenuItem";
            this.складСімїToolStripMenuItem.Size = new System.Drawing.Size(454, 24);
            this.складСімїToolStripMenuItem.Text = "Склад сімї та заєрестрованих";
            // 
            // списокЖітелівСелаToolStripMenuItem
            // 
            this.списокЖітелівСелаToolStripMenuItem.Name = "списокЖітелівСелаToolStripMenuItem";
            this.списокЖітелівСелаToolStripMenuItem.Size = new System.Drawing.Size(454, 24);
            this.списокЖітелівСелаToolStripMenuItem.Text = "Список жітелів села";
            // 
            // toolStripSplitButton3
            // 
            this.toolStripSplitButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2});
            this.toolStripSplitButton3.Image = global::PGO.Properties.Resources.trash_box_2;
            this.toolStripSplitButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton3.Name = "toolStripSplitButton3";
            this.toolStripSplitButton3.Size = new System.Drawing.Size(87, 24);
            this.toolStripSplitButton3.Text = "Фільтр";
            this.toolStripSplitButton3.Visible = false;
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(100, 23);
            // 
            // filter_parent
            // 
            this.filter_parent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filter_parent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filter_parent.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter_parent.Location = new System.Drawing.Point(0, 27);
            this.filter_parent.Margin = new System.Windows.Forms.Padding(10);
            this.filter_parent.Name = "filter_parent";
            this.filter_parent.Size = new System.Drawing.Size(674, 34);
            this.filter_parent.TabIndex = 4;
            this.filter_parent.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.filter_parent_ControlAdded);
            // 
            // LoadForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(674, 382);
            this.Controls.Add(this.dTable);
            this.Controls.Add(this.filter_parent);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(690, 420);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSplitButton toolPEREHOD;
        private System.Windows.Forms.ToolStripMenuItem peopleToolBtn;
        private System.Windows.Forms.ToolStripMenuItem landToolBtn;
        private System.Windows.Forms.ToolStripMenuItem pgoToolBtn;
        private System.Windows.Forms.ToolStripMenuItem houseToolBtn;
        private System.Windows.Forms.ToolStripSplitButton toolREPORT;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton3;
        private System.Windows.Forms.BindingSource landBindingSource;
        public System.Windows.Forms.DataGridView dTable;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripMenuItem поквартирнаКарточкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem довідкаПроНаявністьвідсутністьЗемельноїДілянкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тимчасоваНезайнятістьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem складСімїToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЖітелівСелаToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel filter_parent;
    }
}