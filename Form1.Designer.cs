using System.Windows.Forms;

namespace WinForms
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";

            AddButton();        

        }

        private Button btn1;

        private void AddButton(){
            this.btn1 =new Button();
            this.btn1.Name = "btnClickThis";
            this.btn1.Text = "Click This";
            this.btn1.Location = new System.Drawing.Point((this.ClientSize.Width - btn1.Size.Width)/2,this.ClientSize.Height/2);
            this.btn1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn1.AutoSize = true;// Default value is false
            
            this.Controls.Add(btn1);
        }

        #endregion
    }
}

