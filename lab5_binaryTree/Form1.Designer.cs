
namespace lab5_binaryTree
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
            this.show_tree = new System.Windows.Forms.Button();
            this.add_elem = new System.Windows.Forms.Button();
            this.inorder = new System.Windows.Forms.Button();
            this.preorder = new System.Windows.Forms.Button();
            this.postorder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newElem_textbox = new System.Windows.Forms.TextBox();
            this.travelsalPath_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.searchPath_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // show_tree
            // 
            this.show_tree.Location = new System.Drawing.Point(84, 23);
            this.show_tree.Name = "show_tree";
            this.show_tree.Size = new System.Drawing.Size(75, 23);
            this.show_tree.TabIndex = 0;
            this.show_tree.Text = "Show Tree";
            this.show_tree.UseVisualStyleBackColor = true;
            this.show_tree.Click += new System.EventHandler(this.show_tree_Click);
            // 
            // add_elem
            // 
            this.add_elem.Location = new System.Drawing.Point(48, 85);
            this.add_elem.Name = "add_elem";
            this.add_elem.Size = new System.Drawing.Size(75, 23);
            this.add_elem.TabIndex = 1;
            this.add_elem.Text = "Add Element";
            this.add_elem.UseVisualStyleBackColor = true;
            this.add_elem.Click += new System.EventHandler(this.add_elem_Click);
            // 
            // inorder
            // 
            this.inorder.Location = new System.Drawing.Point(15, 175);
            this.inorder.Name = "inorder";
            this.inorder.Size = new System.Drawing.Size(56, 23);
            this.inorder.TabIndex = 2;
            this.inorder.Text = "Inorder";
            this.inorder.UseVisualStyleBackColor = true;
            this.inorder.Click += new System.EventHandler(this.inorder_Click);
            // 
            // preorder
            // 
            this.preorder.Location = new System.Drawing.Point(89, 175);
            this.preorder.Name = "preorder";
            this.preorder.Size = new System.Drawing.Size(59, 23);
            this.preorder.TabIndex = 3;
            this.preorder.Text = "Preorder";
            this.preorder.UseVisualStyleBackColor = true;
            this.preorder.Click += new System.EventHandler(this.preorder_Click);
            // 
            // postorder
            // 
            this.postorder.Location = new System.Drawing.Point(170, 175);
            this.postorder.Name = "postorder";
            this.postorder.Size = new System.Drawing.Size(64, 23);
            this.postorder.TabIndex = 4;
            this.postorder.Text = "Postorder";
            this.postorder.UseVisualStyleBackColor = true;
            this.postorder.Click += new System.EventHandler(this.postorder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(252, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 453);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Path:";
            // 
            // newElem_textbox
            // 
            this.newElem_textbox.Location = new System.Drawing.Point(129, 87);
            this.newElem_textbox.Name = "newElem_textbox";
            this.newElem_textbox.Size = new System.Drawing.Size(64, 20);
            this.newElem_textbox.TabIndex = 7;
            // 
            // travelsalPath_textbox
            // 
            this.travelsalPath_textbox.Location = new System.Drawing.Point(40, 216);
            this.travelsalPath_textbox.Name = "travelsalPath_textbox";
            this.travelsalPath_textbox.Size = new System.Drawing.Size(206, 20);
            this.travelsalPath_textbox.TabIndex = 8;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(48, 310);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 9;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Path:";
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(129, 312);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(64, 20);
            this.search_textbox.TabIndex = 11;
            // 
            // searchPath_textbox
            // 
            this.searchPath_textbox.Location = new System.Drawing.Point(40, 350);
            this.searchPath_textbox.Name = "searchPath_textbox";
            this.searchPath_textbox.Size = new System.Drawing.Size(206, 20);
            this.searchPath_textbox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchPath_textbox);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.travelsalPath_textbox);
            this.Controls.Add(this.newElem_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.postorder);
            this.Controls.Add(this.preorder);
            this.Controls.Add(this.inorder);
            this.Controls.Add(this.add_elem);
            this.Controls.Add(this.show_tree);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button show_tree;
        private System.Windows.Forms.Button add_elem;
        private System.Windows.Forms.Button inorder;
        private System.Windows.Forms.Button preorder;
        private System.Windows.Forms.Button postorder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newElem_textbox;
        private System.Windows.Forms.TextBox travelsalPath_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.TextBox searchPath_textbox;
    }
}

