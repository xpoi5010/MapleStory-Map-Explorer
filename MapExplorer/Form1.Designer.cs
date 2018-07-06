namespace MapExplorer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.street = new System.Windows.Forms.Label();
            this.id_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.street_combo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Name_combo = new System.Windows.Forms.ComboBox();
            this.ProcessingWorker = new System.ComponentModel.BackgroundWorker();
            this.Loading = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.id_input);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 87);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用地圖代碼搜索";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.Name_combo);
            this.groupBox2.Controls.Add(this.street_combo);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 84);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "選擇器";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(18, 220);
            this.id.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(56, 12);
            this.id.TabIndex = 2;
            this.id.Text = "地圖代號:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(18, 259);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(56, 12);
            this.name.TabIndex = 3;
            this.name.Text = "地圖名稱:";
            // 
            // street
            // 
            this.street.AutoSize = true;
            this.street.Location = new System.Drawing.Point(18, 239);
            this.street.Name = "street";
            this.street.Size = new System.Drawing.Size(56, 12);
            this.street.TabIndex = 4;
            this.street.Text = "地圖街道:";
            // 
            // id_input
            // 
            this.id_input.Location = new System.Drawing.Point(65, 34);
            this.id_input.Name = "id_input";
            this.id_input.Size = new System.Drawing.Size(176, 22);
            this.id_input.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "地圖代碼";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 5;
            this.button1.Text = "複製代號";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "複製街道";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "複製名稱";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 306);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 33);
            this.button4.TabIndex = 8;
            this.button4.Text = "複製全部";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // street_combo
            // 
            this.street_combo.FormattingEnabled = true;
            this.street_combo.Location = new System.Drawing.Point(8, 21);
            this.street_combo.Name = "street_combo";
            this.street_combo.Size = new System.Drawing.Size(233, 20);
            this.street_combo.TabIndex = 0;
            this.street_combo.SelectedIndexChanged += new System.EventHandler(this.street_combo_SelectedIndexChanged);
            this.street_combo.TextChanged += new System.EventHandler(this.street_combo_TextChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(247, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 33);
            this.button5.TabIndex = 2;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(247, 21);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(117, 46);
            this.button6.TabIndex = 3;
            this.button6.Text = "Search";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Name_combo
            // 
            this.Name_combo.FormattingEnabled = true;
            this.Name_combo.Location = new System.Drawing.Point(8, 47);
            this.Name_combo.Name = "Name_combo";
            this.Name_combo.Size = new System.Drawing.Size(233, 20);
            this.Name_combo.TabIndex = 1;
            this.Name_combo.SelectedIndexChanged += new System.EventHandler(this.Name_combo_SelectedIndexChanged);
            // 
            // ProcessingWorker
            // 
            this.ProcessingWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProcessingWorker_DoWork);
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Loading.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Loading.ForeColor = System.Drawing.Color.White;
            this.Loading.Location = new System.Drawing.Point(42, 53);
            this.Loading.Name = "Loading";
            this.Loading.Padding = new System.Windows.Forms.Padding(100);
            this.Loading.Size = new System.Drawing.Size(308, 220);
            this.Loading.TabIndex = 9;
            this.Loading.Text = "Loading Map";
            this.Loading.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 348);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.street);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "楓之谷地圖檢索器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox Name_combo;
        private System.Windows.Forms.ComboBox street_combo;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label street;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker ProcessingWorker;
        private System.Windows.Forms.Label Loading;
    }
}

