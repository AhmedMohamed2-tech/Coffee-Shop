using System.ComponentModel;

namespace CoffeeShop
{
    partial class CoffeeForm
    {
        private System.ComponentModel.IContainer components = null;

        public CoffeeForm(IContainer components)
        {
            this.components = components;
        }

        private System.Windows.Forms.DataGridView dataGridViewCoffees;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox comboBoxBeanType;
        private System.Windows.Forms.ComboBox comboBoxRoastLevel;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelBeanType;
        private System.Windows.Forms.Label labelRoastLevel;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoffeeForm));
            this.dataGridViewCoffees = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.comboBoxBeanType = new System.Windows.Forms.ComboBox();
            this.comboBoxRoastLevel = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelBeanType = new System.Windows.Forms.Label();
            this.labelRoastLevel = new System.Windows.Forms.Label();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboCupSize = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboSugarQty = new System.Windows.Forms.ComboBox();
            this.comboSugarType = new System.Windows.Forms.ComboBox();
            this.comboCoffeeType = new System.Windows.Forms.ComboBox();
            this.txtOrderQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffees)).BeginInit();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCoffees
            // 
            this.dataGridViewCoffees.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewCoffees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoffees.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewCoffees.Name = "dataGridViewCoffees";
            this.dataGridViewCoffees.Size = new System.Drawing.Size(953, 172);
            this.dataGridViewCoffees.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(67, 193);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(86, 70);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonDelete.Location = new System.Drawing.Point(833, 193);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 70);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Order Served";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.textBoxName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxName.Location = new System.Drawing.Point(149, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(132, 28);
            this.textBoxName.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPrice.Location = new System.Drawing.Point(794, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(132, 28);
            this.txtPrice.TabIndex = 11;
            // 
            // comboBoxBeanType
            // 
            this.comboBoxBeanType.BackColor = System.Drawing.Color.White;
            this.comboBoxBeanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBeanType.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxBeanType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxBeanType.FormattingEnabled = true;
            this.comboBoxBeanType.Location = new System.Drawing.Point(150, 84);
            this.comboBoxBeanType.Name = "comboBoxBeanType";
            this.comboBoxBeanType.Size = new System.Drawing.Size(132, 29);
            this.comboBoxBeanType.TabIndex = 6;
            // 
            // comboBoxRoastLevel
            // 
            this.comboBoxRoastLevel.BackColor = System.Drawing.Color.White;
            this.comboBoxRoastLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoastLevel.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboBoxRoastLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBoxRoastLevel.FormattingEnabled = true;
            this.comboBoxRoastLevel.Location = new System.Drawing.Point(482, 84);
            this.comboBoxRoastLevel.Name = "comboBoxRoastLevel";
            this.comboBoxRoastLevel.Size = new System.Drawing.Size(132, 29);
            this.comboBoxRoastLevel.TabIndex = 8;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(6, 37);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(121, 18);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Customer Name";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.White;
            this.labelPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelPrice.Location = new System.Drawing.Point(668, 137);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(47, 18);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Total";
            // 
            // labelBeanType
            // 
            this.labelBeanType.AutoSize = true;
            this.labelBeanType.BackColor = System.Drawing.Color.White;
            this.labelBeanType.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeanType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelBeanType.Location = new System.Drawing.Point(7, 86);
            this.labelBeanType.Name = "labelBeanType";
            this.labelBeanType.Size = new System.Drawing.Size(86, 18);
            this.labelBeanType.TabIndex = 9;
            this.labelBeanType.Text = "Bean Type";
            // 
            // labelRoastLevel
            // 
            this.labelRoastLevel.AutoSize = true;
            this.labelRoastLevel.BackColor = System.Drawing.Color.White;
            this.labelRoastLevel.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoastLevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRoastLevel.Location = new System.Drawing.Point(344, 86);
            this.labelRoastLevel.Name = "labelRoastLevel";
            this.labelRoastLevel.Size = new System.Drawing.Size(95, 18);
            this.labelRoastLevel.TabIndex = 10;
            this.labelRoastLevel.Text = "Roast Level";
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.Color.Transparent;
            this.grpOrder.Controls.Add(this.label5);
            this.grpOrder.Controls.Add(this.comboCupSize);
            this.grpOrder.Controls.Add(this.btnSubmit);
            this.grpOrder.Controls.Add(this.btnExit);
            this.grpOrder.Controls.Add(this.comboSugarQty);
            this.grpOrder.Controls.Add(this.comboSugarType);
            this.grpOrder.Controls.Add(this.comboCoffeeType);
            this.grpOrder.Controls.Add(this.txtOrderQty);
            this.grpOrder.Controls.Add(this.label4);
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.labelRoastLevel);
            this.grpOrder.Controls.Add(this.labelBeanType);
            this.grpOrder.Controls.Add(this.labelPrice);
            this.grpOrder.Controls.Add(this.labelName);
            this.grpOrder.Controls.Add(this.comboBoxRoastLevel);
            this.grpOrder.Controls.Add(this.comboBoxBeanType);
            this.grpOrder.Controls.Add(this.txtPrice);
            this.grpOrder.Controls.Add(this.textBoxName);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpOrder.Location = new System.Drawing.Point(6, 267);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(963, 224);
            this.grpOrder.TabIndex = 13;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 48;
            this.label5.Text = "Cup Size";
            // 
            // comboCupSize
            // 
            this.comboCupSize.BackColor = System.Drawing.Color.White;
            this.comboCupSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCupSize.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboCupSize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboCupSize.FormattingEnabled = true;
            this.comboCupSize.Location = new System.Drawing.Point(149, 135);
            this.comboCupSize.Name = "comboCupSize";
            this.comboCupSize.Size = new System.Drawing.Size(132, 29);
            this.comboCupSize.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Location = new System.Drawing.Point(441, 189);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(101, 31);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(932, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 22);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // comboSugarQty
            // 
            this.comboSugarQty.BackColor = System.Drawing.Color.White;
            this.comboSugarQty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSugarQty.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboSugarQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboSugarQty.FormattingEnabled = true;
            this.comboSugarQty.Location = new System.Drawing.Point(482, 135);
            this.comboSugarQty.Name = "comboSugarQty";
            this.comboSugarQty.Size = new System.Drawing.Size(132, 29);
            this.comboSugarQty.TabIndex = 10;
            // 
            // comboSugarType
            // 
            this.comboSugarType.BackColor = System.Drawing.Color.White;
            this.comboSugarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSugarType.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboSugarType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboSugarType.FormattingEnabled = true;
            this.comboSugarType.Location = new System.Drawing.Point(794, 84);
            this.comboSugarType.Name = "comboSugarType";
            this.comboSugarType.Size = new System.Drawing.Size(132, 29);
            this.comboSugarType.TabIndex = 9;
            // 
            // comboCoffeeType
            // 
            this.comboCoffeeType.BackColor = System.Drawing.Color.White;
            this.comboCoffeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCoffeeType.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.comboCoffeeType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboCoffeeType.FormattingEnabled = true;
            this.comboCoffeeType.Location = new System.Drawing.Point(794, 35);
            this.comboCoffeeType.Name = "comboCoffeeType";
            this.comboCoffeeType.Size = new System.Drawing.Size(132, 29);
            this.comboCoffeeType.TabIndex = 5;
            // 
            // txtOrderQty
            // 
            this.txtOrderQty.BackColor = System.Drawing.Color.White;
            this.txtOrderQty.Font = new System.Drawing.Font("Pristina", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOrderQty.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtOrderQty.Location = new System.Drawing.Point(482, 38);
            this.txtOrderQty.Name = "txtOrderQty";
            this.txtOrderQty.Size = new System.Drawing.Size(132, 28);
            this.txtOrderQty.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(344, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sugar Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(658, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Sugar Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(344, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Order Qty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(658, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Coffee Type";
            // 
            // CoffeeForm
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 532);
            this.Controls.Add(this.grpOrder);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewCoffees);
            this.Name = "CoffeeForm";
            this.Text = "Coffee Manager";
            this.Load += new System.EventHandler(this.CoffeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoffees)).EndInit();
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboSugarQty;
        private System.Windows.Forms.ComboBox comboSugarType;
        private System.Windows.Forms.ComboBox comboCoffeeType;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboCupSize;
    }
}