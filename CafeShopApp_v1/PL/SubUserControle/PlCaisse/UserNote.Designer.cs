
namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    partial class UserNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNote));
            this.btnDelete = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblNameNote = new System.Windows.Forms.Label();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.AllowFocused = false;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeHeight = true;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.IsCircle = true;
            this.btnDelete.Location = new System.Drawing.Point(38, 1);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(15, 15);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 86;
            this.btnDelete.TabStop = false;
            this.btnDelete.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // lblNameNote
            // 
            this.lblNameNote.Font = new System.Drawing.Font("Montserrat", 8F);
            this.lblNameNote.Location = new System.Drawing.Point(60, 3);
            this.lblNameNote.Name = "lblNameNote";
            this.lblNameNote.Size = new System.Drawing.Size(143, 15);
            this.lblNameNote.TabIndex = 87;
            this.lblNameNote.Text = "San";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(197, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(8);
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 88;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UserNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNameNote);
            this.Controls.Add(this.btnDelete);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserNote";
            this.Size = new System.Drawing.Size(232, 20);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPictureBox btnDelete;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        public System.Windows.Forms.Label lblNameNote;
    }
}
