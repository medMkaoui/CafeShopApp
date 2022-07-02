
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserUnite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUnite));
            this.s = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.nameProd = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.ElipseUser = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipsebtn1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.s.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Transparent;
            this.s.BorderColor = System.Drawing.Color.LightGray;
            this.s.BorderRadius = 15;
            this.s.BorderThickness = 1;
            this.s.Controls.Add(this.btnEdit);
            this.s.Controls.Add(this.btnDelete);
            this.s.Controls.Add(this.nameProd);
            this.s.Controls.Add(this.lblId);
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
            this.s.TabIndex = 1;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(214, 15);
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
            this.btnDelete.Location = new System.Drawing.Point(257, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(35, 35);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // nameProd
            // 
            this.nameProd.AutoSize = true;
            this.nameProd.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.nameProd.Location = new System.Drawing.Point(23, 22);
            this.nameProd.Name = "nameProd";
            this.nameProd.Size = new System.Drawing.Size(0, 20);
            this.nameProd.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Montserrat Light", 10F);
            this.lblId.Location = new System.Drawing.Point(23, 22);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(185, 20);
            this.lblId.TabIndex = 4;
            // 
            // ElipseUser
            // 
            this.ElipseUser.ElipseRadius = 15;
            this.ElipseUser.TargetControl = this;
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.ElipseRadius = 10;
            this.ElipseBtn.TargetControl = this.btnEdit;
            // 
            // Elipsebtn1
            // 
            this.Elipsebtn1.ElipseRadius = 10;
            this.Elipsebtn1.TargetControl = this.btnDelete;
            // 
            // UserUnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.s);
            this.Name = "UserUnite";
            this.Size = new System.Drawing.Size(315, 74);
            this.s.ResumeLayout(false);
            this.s.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel s;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.Framework.UI.BunifuImageButton btnDelete;
        public System.Windows.Forms.Label nameProd;
        private Bunifu.Framework.UI.BunifuElipse ElipseUser;
        private Bunifu.Framework.UI.BunifuElipse ElipseBtn;
        private Bunifu.Framework.UI.BunifuElipse Elipsebtn1;
        public System.Windows.Forms.Label lblId;
    }
}
