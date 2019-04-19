namespace TrainTicketsApp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonToOrder = new System.Windows.Forms.Button();
            this.ComboBoxFromTheCity = new System.Windows.Forms.ComboBox();
            this.ComboBoxInTheCity = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DataGridViewTimetable = new System.Windows.Forms.DataGridView();
            this.ButtonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateTimePicker.Location = new System.Drawing.Point(211, 109);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 31);
            this.DateTimePicker.TabIndex = 0;
            this.DateTimePicker.TextChanged += new System.EventHandler(this.DateTimePickerTextChanged);
            // 
            // ButtonToOrder
            // 
            this.ButtonToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonToOrder.Location = new System.Drawing.Point(194, 403);
            this.ButtonToOrder.Name = "ButtonToOrder";
            this.ButtonToOrder.Size = new System.Drawing.Size(217, 35);
            this.ButtonToOrder.TabIndex = 1;
            this.ButtonToOrder.Text = "Забронировать";
            this.ButtonToOrder.UseVisualStyleBackColor = true;
            this.ButtonToOrder.Visible = false;
            this.ButtonToOrder.Click += new System.EventHandler(this.ButtonToOrderClick);
            // 
            // ComboBoxFromTheCity
            // 
            this.ComboBoxFromTheCity.BackColor = System.Drawing.Color.Black;
            this.ComboBoxFromTheCity.DisplayMember = "гшщ";
            this.ComboBoxFromTheCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFromTheCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxFromTheCity.ForeColor = System.Drawing.Color.White;
            this.ComboBoxFromTheCity.FormattingEnabled = true;
            this.ComboBoxFromTheCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxFromTheCity.Location = new System.Drawing.Point(12, 37);
            this.ComboBoxFromTheCity.Name = "ComboBoxFromTheCity";
            this.ComboBoxFromTheCity.Size = new System.Drawing.Size(250, 47);
            this.ComboBoxFromTheCity.TabIndex = 10;
            this.ComboBoxFromTheCity.Tag = "";
            this.ComboBoxFromTheCity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFromTheCitySelectedIndexChanged);
            // 
            // ComboBoxInTheCity
            // 
            this.ComboBoxInTheCity.BackColor = System.Drawing.Color.Black;
            this.ComboBoxInTheCity.DisplayMember = "гшщ";
            this.ComboBoxInTheCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxInTheCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxInTheCity.ForeColor = System.Drawing.Color.White;
            this.ComboBoxInTheCity.FormattingEnabled = true;
            this.ComboBoxInTheCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ComboBoxInTheCity.Location = new System.Drawing.Point(334, 37);
            this.ComboBoxInTheCity.Name = "ComboBoxInTheCity";
            this.ComboBoxInTheCity.Size = new System.Drawing.Size(250, 47);
            this.ComboBoxInTheCity.TabIndex = 11;
            this.ComboBoxInTheCity.Tag = "";
            this.ComboBoxInTheCity.SelectedIndexChanged += new System.EventHandler(this.ComboBoxInTheCitySelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(338, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Куда?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Откуда?";
            // 
            // DataGridViewTimetable
            // 
            this.DataGridViewTimetable.AllowUserToAddRows = false;
            this.DataGridViewTimetable.AllowUserToDeleteRows = false;
            this.DataGridViewTimetable.AllowUserToResizeColumns = false;
            this.DataGridViewTimetable.AllowUserToResizeRows = false;
            this.DataGridViewTimetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTimetable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTimetable.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewTimetable.EnableHeadersVisualStyles = false;
            this.DataGridViewTimetable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewTimetable.Location = new System.Drawing.Point(12, 157);
            this.DataGridViewTimetable.MultiSelect = false;
            this.DataGridViewTimetable.Name = "DataGridViewTimetable";
            this.DataGridViewTimetable.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewTimetable.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewTimetable.RowHeadersVisible = false;
            this.DataGridViewTimetable.RowTemplate.Height = 40;
            this.DataGridViewTimetable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewTimetable.Size = new System.Drawing.Size(572, 228);
            this.DataGridViewTimetable.TabIndex = 15;
            this.DataGridViewTimetable.Visible = false;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.Location = new System.Drawing.Point(515, 109);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(69, 31);
            this.ButtonSearch.TabIndex = 16;
            this.ButtonSearch.Text = "Поиск";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearchClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.DataGridViewTimetable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxInTheCity);
            this.Controls.Add(this.ComboBoxFromTheCity);
            this.Controls.Add(this.ButtonToOrder);
            this.Controls.Add(this.DateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button ButtonToOrder;
        private System.Windows.Forms.ComboBox ComboBoxFromTheCity;
        private System.Windows.Forms.ComboBox ComboBoxInTheCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridViewTimetable;
        private System.Windows.Forms.Button ButtonSearch;
    }
}

