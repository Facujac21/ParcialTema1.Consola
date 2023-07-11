namespace ParcialTema1.Windows
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InicializarComponente()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            btnCalcular = new Button();
            btn2 = new Button();
            errorProvider1 = new ErrorProvider(components);
            label1 = new Label();
            label2 = new Label();
            ColRadio = new DataGridViewTextBoxColumn();
            ColAltura = new DataGridViewTextBoxColumn();
            ColBase = new DataGridViewTextBoxColumn();
            ColArea = new DataGridViewTextBoxColumn();
            ColVolumen = new DataGridViewTextBoxColumn();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(txtAltura);
            splitContainer1.Panel1.Controls.Add(txtRadio);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(btn2);
            splitContainer1.Panel1.Controls.Add(btnCalcular);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridView1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 173;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColRadio, ColAltura, ColBase, ColArea, ColVolumen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(800, 273);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnOk
            // 
            btnCalcular.Location = new Point(99, 113);
            btnCalcular.Name = "btnOk";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Ok";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(251, 113);
            btn2.Name = "btn2";
            btn2.Size = new Size(75, 23);
            btn2.TabIndex = 1;
            btn2.Text = "Cancelar";
            btn2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 37);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Radio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 77);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 3;
            label2.Text = "Altura:";
            // 
            // ColRadio
            // 
            ColRadio.HeaderText = "Radio";
            ColRadio.Name = "ColRadio";
            ColRadio.ReadOnly = true;
            // 
            // ColAltura
            // 
            ColAltura.HeaderText = "Altura";
            ColAltura.Name = "ColAltura";
            ColAltura.ReadOnly = true;
            // 
            // ColBase
            // 
            ColBase.HeaderText = "Base";
            ColBase.Name = "ColBase";
            ColBase.ReadOnly = true;
            // 
            // ColArea
            // 
            ColArea.HeaderText = "Área";
            ColArea.Name = "ColArea";
            ColArea.ReadOnly = true;
            // 
            // ColVolumen
            // 
            ColVolumen.HeaderText = "Volumen";
            ColVolumen.Name = "ColVolumen";
            ColVolumen.ReadOnly = true;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(141, 34);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 4;
            txtRadio.TextChanged += textBox1_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(141, 77);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 5;
            txtAltura.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "sl";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn2;
        private Button btnCalcular;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private DataGridViewTextBoxColumn ColRadio;
        private DataGridViewTextBoxColumn ColAltura;
        private DataGridViewTextBoxColumn ColBase;
        private DataGridViewTextBoxColumn ColArea;
        private DataGridViewTextBoxColumn ColVolumen;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private Button btnCancelar;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private DataGridViewTextBoxColumn colAltura;
        private DataGridViewTextBoxColumn colRadio;
        private DataGridViewTextBoxColumn colBase;
        private DataGridViewTextBoxColumn colArea;
        private DataGridViewTextBoxColumn colVolumen;
        private SplitContainer splitContainer4;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn colaltura;
    }
}