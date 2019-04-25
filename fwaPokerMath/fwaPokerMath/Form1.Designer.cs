namespace fwaPokerMath
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
            this.btnCreateDice = new System.Windows.Forms.Button();
            this.nudDiceNumber = new System.Windows.Forms.NumericUpDown();
            this.lblDiceNumber = new System.Windows.Forms.Label();
            this.lblFaceNumber = new System.Windows.Forms.Label();
            this.nudFaceNumber = new System.Windows.Forms.NumericUpDown();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.chkPrintException = new System.Windows.Forms.CheckBox();
            this.txtClearConsole = new System.Windows.Forms.Button();
            this.lblCreateDice = new System.Windows.Forms.Label();
            this.lblGetStatistic = new System.Windows.Forms.Label();
            this.lblIterCount = new System.Windows.Forms.Label();
            this.nudIterCount = new System.Windows.Forms.NumericUpDown();
            this.btnGetStatistic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaceNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDice
            // 
            this.btnCreateDice.Location = new System.Drawing.Point(15, 87);
            this.btnCreateDice.Name = "btnCreateDice";
            this.btnCreateDice.Size = new System.Drawing.Size(75, 23);
            this.btnCreateDice.TabIndex = 0;
            this.btnCreateDice.Text = "Создать";
            this.btnCreateDice.UseVisualStyleBackColor = true;
            this.btnCreateDice.Click += new System.EventHandler(this.btnCreateDice_Click);
            // 
            // nudDiceNumber
            // 
            this.nudDiceNumber.Location = new System.Drawing.Point(125, 29);
            this.nudDiceNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudDiceNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDiceNumber.Name = "nudDiceNumber";
            this.nudDiceNumber.Size = new System.Drawing.Size(42, 20);
            this.nudDiceNumber.TabIndex = 1;
            this.nudDiceNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblDiceNumber
            // 
            this.lblDiceNumber.AutoSize = true;
            this.lblDiceNumber.Location = new System.Drawing.Point(12, 31);
            this.lblDiceNumber.Name = "lblDiceNumber";
            this.lblDiceNumber.Size = new System.Drawing.Size(107, 13);
            this.lblDiceNumber.TabIndex = 2;
            this.lblDiceNumber.Text = "Количество костей:";
            // 
            // lblFaceNumber
            // 
            this.lblFaceNumber.AutoSize = true;
            this.lblFaceNumber.Location = new System.Drawing.Point(12, 57);
            this.lblFaceNumber.Name = "lblFaceNumber";
            this.lblFaceNumber.Size = new System.Drawing.Size(107, 13);
            this.lblFaceNumber.TabIndex = 3;
            this.lblFaceNumber.Text = "Количество граней:";
            // 
            // nudFaceNumber
            // 
            this.nudFaceNumber.Location = new System.Drawing.Point(125, 55);
            this.nudFaceNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudFaceNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudFaceNumber.Name = "nudFaceNumber";
            this.nudFaceNumber.Size = new System.Drawing.Size(42, 20);
            this.nudFaceNumber.TabIndex = 4;
            this.nudFaceNumber.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(173, 7);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(391, 322);
            this.txtConsole.TabIndex = 5;
            // 
            // chkPrintException
            // 
            this.chkPrintException.AutoSize = true;
            this.chkPrintException.Location = new System.Drawing.Point(424, 335);
            this.chkPrintException.Name = "chkPrintException";
            this.chkPrintException.Size = new System.Drawing.Size(140, 17);
            this.chkPrintException.TabIndex = 6;
            this.chkPrintException.Text = "Выводить исключения";
            this.chkPrintException.UseVisualStyleBackColor = true;
            // 
            // txtClearConsole
            // 
            this.txtClearConsole.Location = new System.Drawing.Point(173, 331);
            this.txtClearConsole.Name = "txtClearConsole";
            this.txtClearConsole.Size = new System.Drawing.Size(75, 23);
            this.txtClearConsole.TabIndex = 7;
            this.txtClearConsole.Text = "Очистить";
            this.txtClearConsole.UseVisualStyleBackColor = true;
            this.txtClearConsole.Click += new System.EventHandler(this.txtClearConsole_Click);
            // 
            // lblCreateDice
            // 
            this.lblCreateDice.AutoSize = true;
            this.lblCreateDice.Location = new System.Drawing.Point(12, 10);
            this.lblCreateDice.Name = "lblCreateDice";
            this.lblCreateDice.Size = new System.Drawing.Size(123, 13);
            this.lblCreateDice.TabIndex = 8;
            this.lblCreateDice.Text = "Создать набор костей:";
            // 
            // lblGetStatistic
            // 
            this.lblGetStatistic.AutoSize = true;
            this.lblGetStatistic.Location = new System.Drawing.Point(12, 152);
            this.lblGetStatistic.Name = "lblGetStatistic";
            this.lblGetStatistic.Size = new System.Drawing.Size(111, 13);
            this.lblGetStatistic.TabIndex = 9;
            this.lblGetStatistic.Text = "Собрать статистику:";
            // 
            // lblIterCount
            // 
            this.lblIterCount.AutoSize = true;
            this.lblIterCount.Location = new System.Drawing.Point(12, 177);
            this.lblIterCount.Name = "lblIterCount";
            this.lblIterCount.Size = new System.Drawing.Size(59, 13);
            this.lblIterCount.TabIndex = 10;
            this.lblIterCount.Text = "Итераций:";
            // 
            // nudIterCount
            // 
            this.nudIterCount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIterCount.Location = new System.Drawing.Point(77, 175);
            this.nudIterCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudIterCount.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudIterCount.Name = "nudIterCount";
            this.nudIterCount.Size = new System.Drawing.Size(90, 20);
            this.nudIterCount.TabIndex = 11;
            this.nudIterCount.ThousandsSeparator = true;
            this.nudIterCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnGetStatistic
            // 
            this.btnGetStatistic.Location = new System.Drawing.Point(12, 201);
            this.btnGetStatistic.Name = "btnGetStatistic";
            this.btnGetStatistic.Size = new System.Drawing.Size(75, 23);
            this.btnGetStatistic.TabIndex = 12;
            this.btnGetStatistic.Text = "Расчет";
            this.btnGetStatistic.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 364);
            this.Controls.Add(this.btnGetStatistic);
            this.Controls.Add(this.nudIterCount);
            this.Controls.Add(this.lblIterCount);
            this.Controls.Add(this.lblGetStatistic);
            this.Controls.Add(this.lblCreateDice);
            this.Controls.Add(this.txtClearConsole);
            this.Controls.Add(this.chkPrintException);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.nudFaceNumber);
            this.Controls.Add(this.lblFaceNumber);
            this.Controls.Add(this.lblDiceNumber);
            this.Controls.Add(this.nudDiceNumber);
            this.Controls.Add(this.btnCreateDice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDiceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFaceNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIterCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDice;
        private System.Windows.Forms.NumericUpDown nudDiceNumber;
        private System.Windows.Forms.Label lblDiceNumber;
        private System.Windows.Forms.Label lblFaceNumber;
        private System.Windows.Forms.NumericUpDown nudFaceNumber;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.CheckBox chkPrintException;
        private System.Windows.Forms.Button txtClearConsole;
        private System.Windows.Forms.Label lblCreateDice;
        private System.Windows.Forms.Label lblGetStatistic;
        private System.Windows.Forms.Label lblIterCount;
        private System.Windows.Forms.NumericUpDown nudIterCount;
        private System.Windows.Forms.Button btnGetStatistic;
    }
}

