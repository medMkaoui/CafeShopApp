
namespace CafeShopApp_v1.PL
{
    partial class UserCategorie_Prod
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plProd = new System.Windows.Forms.FlowLayoutPanel();
            this.plCate = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // plProd
            // 
            this.plProd.AutoScroll = true;
            this.plProd.Location = new System.Drawing.Point(14, 100);
            this.plProd.Margin = new System.Windows.Forms.Padding(0);
            this.plProd.Name = "plProd";
            this.plProd.Padding = new System.Windows.Forms.Padding(5);
            this.plProd.Size = new System.Drawing.Size(690, 485);
            this.plProd.TabIndex = 20;
            // 
            // plCate
            // 
            this.plCate.AllowDrop = true;
            this.plCate.AutoScroll = true;
            this.plCate.BackColor = System.Drawing.Color.Transparent;
            this.plCate.Location = new System.Drawing.Point(14, 0);
            this.plCate.Margin = new System.Windows.Forms.Padding(0);
            this.plCate.Name = "plCate";
            this.plCate.Padding = new System.Windows.Forms.Padding(5);
            this.plCate.Size = new System.Drawing.Size(675, 94);
            this.plCate.TabIndex = 19;
            this.plCate.WrapContents = false;
            // 
            // UserCategorie_Prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plProd);
            this.Controls.Add(this.plCate);
            this.Name = "UserCategorie_Prod";
            this.Size = new System.Drawing.Size(704, 600);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel plCate;
        public System.Windows.Forms.FlowLayoutPanel plProd;
    }
}
