
namespace CafeShopApp_v1.PL.SubUserControle.PlEtatB
{
    partial class UserPlEtatBoutique
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
            this.plTable = new System.Windows.Forms.FlowLayoutPanel();
            this.plEspace = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // plTable
            // 
            this.plTable.AutoScroll = true;
            this.plTable.Location = new System.Drawing.Point(15, 108);
            this.plTable.Margin = new System.Windows.Forms.Padding(0);
            this.plTable.Name = "plTable";
            this.plTable.Padding = new System.Windows.Forms.Padding(5);
            this.plTable.Size = new System.Drawing.Size(939, 485);
            this.plTable.TabIndex = 22;
            // 
            // plEspace
            // 
            this.plEspace.AllowDrop = true;
            this.plEspace.AutoScroll = true;
            this.plEspace.BackColor = System.Drawing.Color.Transparent;
            this.plEspace.Location = new System.Drawing.Point(142, 8);
            this.plEspace.Margin = new System.Windows.Forms.Padding(0);
            this.plEspace.Name = "plEspace";
            this.plEspace.Padding = new System.Windows.Forms.Padding(5);
            this.plEspace.Size = new System.Drawing.Size(662, 94);
            this.plEspace.TabIndex = 21;
            this.plEspace.WrapContents = false;
            // 
            // UserPlEtatBoutique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plTable);
            this.Controls.Add(this.plEspace);
            this.Name = "UserPlEtatBoutique";
            this.Size = new System.Drawing.Size(954, 600);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel plTable;
        private System.Windows.Forms.FlowLayoutPanel plEspace;
    }
}
