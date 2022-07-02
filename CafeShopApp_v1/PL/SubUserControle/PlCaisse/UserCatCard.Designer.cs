
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserCatCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCatCard));
            this.lblName = new System.Windows.Forms.Label();
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.ElipseCard = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblId = new System.Windows.Forms.Label();
            this.lblContProd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(62, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(98, 21);
            this.lblName.TabIndex = 64;
            this.lblName.Text = "-----";
            this.lblName.Click += new System.EventHandler(this.UserCatCard_Click);
            // 
            // imgProd
            // 
            this.imgProd.AllowFocused = false;
            this.imgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProd.AutoSizeHeight = true;
            this.imgProd.BorderRadius = 20;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = true;
            this.imgProd.Location = new System.Drawing.Point(16, 8);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(40, 40);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 65;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.imgProd.Click += new System.EventHandler(this.UserCatCard_Click);
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
            this.lblId.Location = new System.Drawing.Point(39, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(15, 18);
            this.lblId.TabIndex = 66;
            this.lblId.Visible = false;
            // 
            // lblContProd
            // 
            this.lblContProd.BackColor = System.Drawing.Color.Transparent;
            this.lblContProd.Font = new System.Drawing.Font("Montserrat Light", 6F);
            this.lblContProd.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblContProd.Location = new System.Drawing.Point(63, 36);
            this.lblContProd.Name = "lblContProd";
            this.lblContProd.Size = new System.Drawing.Size(98, 10);
            this.lblContProd.TabIndex = 67;
            this.lblContProd.Text = "-----";
            this.lblContProd.Click += new System.EventHandler(this.UserCatCard_Click);
            // 
            // UserCatCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblContProd);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.Name = "UserCatCard";
            this.Size = new System.Drawing.Size(177, 60);
            this.Click += new System.EventHandler(this.UserCatCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lblName;
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        private Bunifu.Framework.UI.BunifuElipse ElipseCard;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Label lblContProd;
    }
}
