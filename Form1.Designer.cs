
namespace DataMatrixUpdate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbGood = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDatamatrix = new System.Windows.Forms.TextBox();
            this.gridKiz = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.rtbQuery = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLotBarcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridKiz)).BeginInit();
            this.SuspendLayout();
            // 
            // tbGood
            // 
            this.tbGood.Location = new System.Drawing.Point(318, 23);
            this.tbGood.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbGood.Name = "tbGood";
            this.tbGood.Size = new System.Drawing.Size(872, 31);
            this.tbGood.TabIndex = 0;
            this.tbGood.TextChanged += new System.EventHandler(this.tbGood_TextChanged);
            this.tbGood.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGood_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка для поиска товаров";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1204, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Заменить КИЗ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Отсканируйте новый код";
            // 
            // tbDatamatrix
            // 
            this.tbDatamatrix.Location = new System.Drawing.Point(318, 106);
            this.tbDatamatrix.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbDatamatrix.Name = "tbDatamatrix";
            this.tbDatamatrix.Size = new System.Drawing.Size(872, 31);
            this.tbDatamatrix.TabIndex = 4;
            // 
            // gridKiz
            // 
            this.gridKiz.AllowUserToAddRows = false;
            this.gridKiz.AllowUserToDeleteRows = false;
            this.gridKiz.AllowUserToOrderColumns = true;
            this.gridKiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKiz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridKiz.Location = new System.Drawing.Point(30, 300);
            this.gridKiz.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gridKiz.MultiSelect = false;
            this.gridKiz.Name = "gridKiz";
            this.gridKiz.ReadOnly = true;
            this.gridKiz.RowHeadersWidth = 82;
            this.gridKiz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridKiz.Size = new System.Drawing.Size(1520, 288);
            this.gridKiz.TabIndex = 5;
            this.gridKiz.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridKiz_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1204, 106);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(346, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Заполнить таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rtbQuery
            // 
            this.rtbQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbQuery.Location = new System.Drawing.Point(30, 600);
            this.rtbQuery.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbQuery.Name = "rtbQuery";
            this.rtbQuery.Size = new System.Drawing.Size(1516, 239);
            this.rtbQuery.TabIndex = 7;
            this.rtbQuery.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1113, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "СКАНИРОВАТЬ ТОЛЬКО В АНГЛИЙСКОЙ РАСКЛАДКЕ !!!";
            // 
            // txtLotBarcode
            // 
            this.txtLotBarcode.Location = new System.Drawing.Point(318, 229);
            this.txtLotBarcode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLotBarcode.Name = "txtLotBarcode";
            this.txtLotBarcode.Size = new System.Drawing.Size(400, 31);
            this.txtLotBarcode.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "ШК партии";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1204, 194);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(346, 44);
            this.button3.TabIndex = 11;
            this.button3.Text = "Передать КИЗы в АРМ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLotBarcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbQuery);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gridKiz);
            this.Controls.Add(this.tbDatamatrix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbGood);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Замена КИЗ в базе данных F3Tail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridKiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGood;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDatamatrix;
        private System.Windows.Forms.DataGridView gridKiz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox rtbQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLotBarcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

