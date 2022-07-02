
namespace CafeShopApp_v1.PL.SubUserControle.PlEtatB
{
    partial class UserEspaceCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEspaceCard));
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ElipseCard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // imgProd
            // 
            this.imgProd.AllowFocused = false;
            this.imgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProd.AutoSizeHeight = true;
            this.imgProd.BorderRadius = 20;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = true;
            this.imgProd.Location = new System.Drawing.Point(16, 10);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(40, 40);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 69;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.imgProd.Click += new System.EventHandler(this.UserEspaceCard_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 21);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Boutique";
            this.lblName.Click += new System.EventHandler(this.UserEspaceCard_Click);
            // 
            // ElipseCard
            // 
            this.ElipseCard.ElipseRadius = 15;
            this.ElipseCard.TargetControl = this;
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(39, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 18);
            this.lblId.TabIndex = 70;
            this.lblId.Visible = false;
            // 
            // UserEspaceCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Name = "UserEspaceCard";
            this.Size = new System.Drawing.Size(177, 60);
            this.Click += new System.EventHandler(this.UserEspaceCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        public System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuElipse ElipseCard;
        public System.Windows.Forms.Label lblId;
    }
}
