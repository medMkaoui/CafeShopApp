
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserSteLiv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSteLiv));
            this.s = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblNameSte = new System.Windows.Forms.Label();
            this.btnDeleteElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnEditElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LogoSte = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSte)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.BorderColor = System.Drawing.Color.LightGray;
            this.s.BorderRadius = 15;
            this.s.BorderThickness = 1;
            this.s.Controls.Add(this.LogoSte);
            this.s.Controls.Add(this.btnEdit);
            this.s.Controls.Add(this.btnDelete);
            this.s.Controls.Add(this.lblNameSte);
            this.s.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.s.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.s.Location = new System.Drawing.Point(1, 2);
            this.s.Margin = new System.Windows.Forms.Padding(0);
            this.s.Name = "s";
            this.s.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.s.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.s.ShadowColor = System.Drawing.Color.Transparent;
            this.s.ShadowDept = 2;
            this.s.ShadowDepth = 5;
            this.s.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.ForwardDiagonal;
            this.s.ShadowTopLeftVisible = false;
            this.s.Size = new System.Drawing.Size(312, 70);
            this.s.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.s.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(217, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(35, 35);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 3;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(95)))), ((int)(((byte)(63)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(260, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblNameSte
            // 
            this.lblNameSte.AutoSize = true;
            this.lblNameSte.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSte.Location = new System.Drawing.Point(61, 25);
            this.lblNameSte.Name = "lblNameSte";
            this.lblNameSte.Size = new System.Drawing.Size(105, 18);
            this.lblNameSte.TabIndex = 1;
            this.lblNameSte.Text = "Nom d\'espace";
            // 
            // btnDeleteElipse
            // 
            this.btnDeleteElipse.ElipseRadius = 10;
            this.btnDeleteElipse.TargetControl = this.btnDelete;
            // 
            // btnEditElipse
            // 
            this.btnEditElipse.ElipseRadius = 10;
            this.btnEditElipse.TargetControl = this.btnEdit;
            // 
            // LogoSte
            // 
            this.LogoSte.AllowFocused = false;
            this.LogoSte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoSte.AutoSizeHeight = true;
            this.LogoSte.BorderRadius = 20;
            this.LogoSte.Image = ((System.Drawing.Image)(resources.GetObject("LogoSte.Image")));
            this.LogoSte.IsCircle = true;
            this.LogoSte.Location = new System.Drawing.Point(12, 14);
            this.LogoSte.Name = "LogoSte";
            this.LogoSte.Size = new System.Drawing.Size(40, 40);
            this.LogoSte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoSte.TabIndex = 4;
            this.LogoSte.TabStop = false;
            this.LogoSte.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // UserSteLiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.s);
            this.Name = "UserSteLiv";
            this.Size = new System.Drawing.Size(315, 74);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoSte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel s;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        public System.Windows.Forms.Label lblNameSte;
        private Bunifu.Framework.UI.BunifuElipse btnDeleteElipse;
        private Bunifu.Framework.UI.BunifuElipse btnEditElipse;
        public Bunifu.UI.WinForms.BunifuPictureBox LogoSte;
    }
}
