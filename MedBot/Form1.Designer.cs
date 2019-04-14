namespace MedBot
{
    partial class Form1
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
            this.userInputBox = new System.Windows.Forms.TextBox();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.getResults = new System.Windows.Forms.Button();
            this.MedicineItemsView = new System.Windows.Forms.ListView();
            this.itemId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemUrl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // userInputBox
            // 
            this.userInputBox.Location = new System.Drawing.Point(12, 59);
            this.userInputBox.Multiline = true;
            this.userInputBox.Name = "userInputBox";
            this.userInputBox.Size = new System.Drawing.Size(776, 128);
            this.userInputBox.TabIndex = 0;
            // 
            // userInputLabel
            // 
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInputLabel.Location = new System.Drawing.Point(12, 27);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(396, 29);
            this.userInputLabel.TabIndex = 1;
            this.userInputLabel.Text = "Enter Medical Report Text Here";
            // 
            // getResults
            // 
            this.getResults.Location = new System.Drawing.Point(713, 193);
            this.getResults.Name = "getResults";
            this.getResults.Size = new System.Drawing.Size(75, 23);
            this.getResults.TabIndex = 2;
            this.getResults.Text = "Get Results";
            this.getResults.UseVisualStyleBackColor = true;
            this.getResults.Click += new System.EventHandler(this.GetResults_Click);
            // 
            // MedicineItemsView
            // 
            this.MedicineItemsView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemId,
            this.name,
            this.itemType,
            this.price,
            this.itemUrl});
            this.MedicineItemsView.FullRowSelect = true;
            this.MedicineItemsView.GridLines = true;
            this.MedicineItemsView.Location = new System.Drawing.Point(12, 221);
            this.MedicineItemsView.Name = "MedicineItemsView";
            this.MedicineItemsView.Size = new System.Drawing.Size(776, 252);
            this.MedicineItemsView.TabIndex = 3;
            this.MedicineItemsView.UseCompatibleStateImageBehavior = false;
            this.MedicineItemsView.View = System.Windows.Forms.View.Details;
            // 
            // itemId
            // 
            this.itemId.Text = "Id";
            this.itemId.Width = 200;
            // 
            // name
            // 
            this.name.Text = "Item Name";
            this.name.Width = 300;
            // 
            // itemType
            // 
            this.itemType.DisplayIndex = 3;
            this.itemType.Text = "Type";
            this.itemType.Width = 300;
            // 
            // price
            // 
            this.price.DisplayIndex = 2;
            this.price.Text = "Price";
            this.price.Width = 150;
            // 
            // itemUrl
            // 
            this.itemUrl.Text = "Url";
            this.itemUrl.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.MedicineItemsView);
            this.Controls.Add(this.getResults);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.userInputBox);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userInputBox;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Button getResults;
        private System.Windows.Forms.ListView MedicineItemsView;
        private System.Windows.Forms.ColumnHeader itemId;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader itemType;
        private System.Windows.Forms.ColumnHeader itemUrl;
    }
}

