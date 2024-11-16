namespace Search_Algorithms__Secuencial__Binaria___Hash_
{
    partial class Secuencial_Binary
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
            cmbSearchMethod = new ComboBox();
            txtKey = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            lstNumbers = new ListView();
            btnAddNumber = new Button();
            label2 = new Label();
            txtNewNumber = new TextBox();
            SuspendLayout();
            // 
            // cmbSearchMethod
            // 
            cmbSearchMethod.FormattingEnabled = true;
            cmbSearchMethod.Items.AddRange(new object[] { "Secuencial", "Binaria" });
            cmbSearchMethod.Location = new Point(263, 225);
            cmbSearchMethod.Name = "cmbSearchMethod";
            cmbSearchMethod.Size = new Size(121, 23);
            cmbSearchMethod.TabIndex = 0;
            // 
            // txtKey
            // 
            txtKey.Location = new Point(21, 225);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(193, 23);
            txtKey.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 207);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 2;
            label1.Text = "escribe un numero a buscar";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(41, 288);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lstNumbers
            // 
            lstNumbers.Location = new Point(453, 30);
            lstNumbers.Name = "lstNumbers";
            lstNumbers.Size = new Size(335, 408);
            lstNumbers.TabIndex = 4;
            lstNumbers.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddNumber
            // 
            btnAddNumber.Location = new Point(41, 103);
            btnAddNumber.Name = "btnAddNumber";
            btnAddNumber.Size = new Size(75, 23);
            btnAddNumber.TabIndex = 7;
            btnAddNumber.Text = "Add";
            btnAddNumber.UseVisualStyleBackColor = true;
            btnAddNumber.Click += btnAddNumber_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(155, 15);
            label2.TabIndex = 6;
            label2.Text = "escribe un arreglo ordenado";
            // 
            // txtNewNumber
            // 
            txtNewNumber.Location = new Point(21, 40);
            txtNewNumber.Name = "txtNewNumber";
            txtNewNumber.Size = new Size(193, 23);
            txtNewNumber.TabIndex = 5;
            // 
            // Secuencial_Binary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNumber);
            Controls.Add(label2);
            Controls.Add(txtNewNumber);
            Controls.Add(lstNumbers);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(txtKey);
            Controls.Add(cmbSearchMethod);
            Name = "Secuencial_Binary";
            Text = "Secuencial_Binary";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSearchMethod;
        private TextBox txtKey;
        private Label label1;
        private Button btnSearch;
        private ListView lstNumbers;
        private Button btnAddNumber;
        private Label label2;
        private TextBox txtNewNumber;
    }
}