
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserRowProduitCmd
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRowProduitCmd));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnEdit = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblQteCmd = new System.Windows.Forms.Label();
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTitleProd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.plNote = new System.Windows.Forms.Panel();
            this.plUserNote = new System.Windows.Forms.FlowLayoutPanel();
            this.Notes = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.plNote.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.lblQteCmd);
            this.panel1.Controls.Add(this.imgProd);
            this.panel1.Controls.Add(this.lblTitleProd);
            this.panel1.Controls.Add(this.lblId);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 59);
            this.panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.AllowFocused = false;
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.AutoSizeHeight = true;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.IsCircle = true;
            this.btnDelete.Location = new System.Drawing.Point(223, 10);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 85;
            this.btnDelete.TabStop = false;
            this.btnDelete.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AllowFocused = false;
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.AutoSizeHeight = true;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.IsCircle = true;
            this.btnEdit.Location = new System.Drawing.Point(172, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(35, 35);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEdit.TabIndex = 84;
            this.btnEdit.TabStop = false;
            this.btnEdit.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblQteCmd
            // 
            this.lblQteCmd.BackColor = System.Drawing.Color.Transparent;
            this.lblQteCmd.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQteCmd.Location = new System.Drawing.Point(73, 31);
            this.lblQteCmd.Name = "lblQteCmd";
            this.lblQteCmd.Size = new System.Drawing.Size(72, 21);
            this.lblQteCmd.TabIndex = 82;
            this.lblQteCmd.Text = "250.12 MAD";
            this.lblQteCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgProd
            // 
            this.imgProd.AllowFocused = false;
            this.imgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProd.AutoSizeHeight = true;
            this.imgProd.BorderRadius = 22;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = true;
            this.imgProd.Location = new System.Drawing.Point(6, 5);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(45, 45);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 81;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblTitleProd
            // 
            this.lblTitleProd.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleProd.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleProd.Location = new System.Drawing.Point(64, 11);
            this.lblTitleProd.Name = "lblTitleProd";
            this.lblTitleProd.Size = new System.Drawing.Size(98, 21);
            this.lblTitleProd.TabIndex = 80;
            this.lblTitleProd.Text = "250.12 MAD";
            this.lblTitleProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 21);
            this.lblId.TabIndex = 83;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
            // 
            // plNote
            // 
            this.plNote.Controls.Add(this.plUserNote);
            this.plNote.Controls.Add(this.Notes);
            this.plNote.Location = new System.Drawing.Point(3, 62);
            this.plNote.Name = "plNote";
            this.plNote.Size = new System.Drawing.Size(266, 123);
            this.plNote.TabIndex = 1;
            // 
            // plUserNote
            // 
            this.plUserNote.AutoScroll = true;
            this.plUserNote.Location = new System.Drawing.Point(0, 19);
            this.plUserNote.Margin = new System.Windows.Forms.Padding(0);
            this.plUserNote.Name = "plUserNote";
            this.plUserNote.Size = new System.Drawing.Size(266, 95);
            this.plUserNote.TabIndex = 82;
            // 
            // Notes
            // 
            this.Notes.BackColor = System.Drawing.Color.Transparent;
            this.Notes.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.Notes.Location = new System.Drawing.Point(27, 0);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(55, 21);
            this.Notes.TabIndex = 81;
            this.Notes.Text = "NOTE";
            this.Notes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserRowProduitCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.plNote);
            this.Controls.Add(this.panel1);
            this.Name = "UserRowProduitCmd";
            this.Size = new System.Drawing.Size(272, 65);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.plNote.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.UI.WinForms.BunifuPictureBox btnDelete;
        public Bunifu.UI.WinForms.BunifuPictureBox btnEdit;
        public System.Windows.Forms.Label lblQteCmd;
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        public System.Windows.Forms.Label lblTitleProd;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Panel plNote;
        public System.Windows.Forms.Label Notes;
        public System.Windows.Forms.FlowLayoutPanel plUserNote;
    }
}
