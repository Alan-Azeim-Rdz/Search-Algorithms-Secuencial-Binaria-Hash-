namespace Search_Algorithms__Secuencial__Binaria___Hash_
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
        private void InitializeComponent()
        {
            txtKey = new TextBox();
            txtValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnInsert = new Button();
            btnSearch = new Button();
            lstAlumnos = new ListBox();
            TxtSearchId = new TextBox();
            label3 = new Label();
            BtnSequentialAndBinary = new Button();
            SuspendLayout();
            // 
            // txtKey
            // 
            txtKey.Location = new Point(83, 27);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(147, 23);
            txtKey.TabIndex = 0;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(83, 67);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(147, 23);
            txtValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "E-Maill";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(83, 107);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Agregar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(83, 234);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstAlumnos
            // 
            lstAlumnos.FormattingEnabled = true;
            lstAlumnos.ItemHeight = 15;
            lstAlumnos.Location = new Point(390, 12);
            lstAlumnos.Name = "lstAlumnos";
            lstAlumnos.Size = new Size(470, 514);
            lstAlumnos.TabIndex = 6;
            // 
            // TxtSearchId
            // 
            TxtSearchId.Location = new Point(52, 190);
            TxtSearchId.Name = "TxtSearchId";
            TxtSearchId.Size = new Size(147, 23);
            TxtSearchId.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 172);
            label3.Name = "label3";
            label3.Size = new Size(116, 15);
            label3.TabIndex = 8;
            label3.Text = "Id asociado al correo";
            // 
            // BtnSequentialAndBinary
            // 
            BtnSequentialAndBinary.Location = new Point(12, 485);
            BtnSequentialAndBinary.Name = "BtnSequentialAndBinary";
            BtnSequentialAndBinary.Size = new Size(146, 23);
            BtnSequentialAndBinary.TabIndex = 9;
            BtnSequentialAndBinary.Text = "sequential and binary search";
            BtnSequentialAndBinary.UseVisualStyleBackColor = true;
            BtnSequentialAndBinary.Click += BtnSequentialAndBinary_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 531);
            Controls.Add(BtnSequentialAndBinary);
            Controls.Add(label3);
            Controls.Add(TxtSearchId);
            Controls.Add(lstAlumnos);
            Controls.Add(btnSearch);
            Controls.Add(btnInsert);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtValue);
            Controls.Add(txtKey);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKey;
        private TextBox txtValue;
        private Label label1;
        private Label label2;
        private Button btnInsert;
        private Button btnSearch;
        private ListBox lstAlumnos;
        private TextBox TxtSearchId;
        private Label label3;
        private Button BtnSequentialAndBinary;
    }
}
