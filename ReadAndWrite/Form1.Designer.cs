namespace ReadAndWrite
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
            this.textEditor = new System.Windows.Forms.RichTextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textEditor
            // 
            this.textEditor.Location = new System.Drawing.Point(12, 99);
            this.textEditor.Name = "textEditor";
            this.textEditor.Size = new System.Drawing.Size(968, 383);
            this.textEditor.TabIndex = 0;
            this.textEditor.Text = "";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Location = new System.Drawing.Point(364, 26);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(254, 50);
            this.buttonChoose.TabIndex = 1;
            this.buttonChoose.Text = "انتخاب فایل";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(364, 512);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(254, 50);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "ویرایش";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(830, 512);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(150, 50);
            this.Save.TabIndex = 3;
            this.Save.Text = "ذخیره";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "ذخیره به عنوان";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonChoose);
            this.Controls.Add(this.textEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox textEditor;
        private Button buttonChoose;
        private Button buttonEdit;
        private Button Save;
        private Button button1;
    }
}