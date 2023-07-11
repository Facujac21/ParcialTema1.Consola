namespace ParcialTema1.Windows
{
    public partial class Form1 : Form
    {
        private void InitializeComponent()
        {
            splitContainer4 = new SplitContainer();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colaltura = new DataGridViewTextBoxColumn();
            colRadio = new DataGridViewTextBoxColumn();
            colBase = new DataGridViewTextBoxColumn();
            colArea = new DataGridViewTextBoxColumn();
            colVolumen = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(button2);
            splitContainer4.Panel1.Controls.Add(button1);
            splitContainer4.Panel1.Controls.Add(textBox2);
            splitContainer4.Panel1.Controls.Add(textBox1);
            splitContainer4.Panel1.Controls.Add(label2);
            splitContainer4.Panel1.Controls.Add(label1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(dataGridView1);
            splitContainer4.Panel2.Paint += splitContainer4_Panel2_Paint;
            splitContainer4.Size = new Size(700, 460);
            splitContainer4.SplitterDistance = 165;
            splitContainer4.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(195, 124);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(92, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 87);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "altura:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 23);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "radio:";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colaltura, colRadio, colBase, colArea, colVolumen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(700, 291);
            dataGridView1.TabIndex = 0;
            // 
            // colaltura
            // 
            colaltura.HeaderText = "Altura";
            colaltura.Name = "colaltura";
            colaltura.ReadOnly = true;
            // 
            // colRadio
            // 
            colRadio.HeaderText = "Radio";
            colRadio.Name = "colRadio";
            colRadio.ReadOnly = true;
            // 
            // colBase
            // 
            colBase.HeaderText = "Base";
            colBase.Name = "colBase";
            colBase.ReadOnly = true;
            // 
            // colArea
            // 
            colArea.HeaderText = "Area";
            colArea.Name = "colArea";
            colArea.ReadOnly = true;
            // 
            // colVolumen
            // 
            colVolumen.HeaderText = "Volumen";
            colVolumen.Name = "colVolumen";
            colVolumen.ReadOnly = true;
            // 
            // Form1
            // 
            ClientSize = new Size(700, 460);
            Controls.Add(splitContainer4);
            Name = "Form1";
            Load += Form1_Load;
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private void splitContainer4_Panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }