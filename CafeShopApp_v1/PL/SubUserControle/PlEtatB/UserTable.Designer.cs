
namespace CafeShopApp_v1.PL.SubUserControle.PlEtatB
{
    partial class UserTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserTable));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTitleTable = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.checkMerge = new Bunifu.Framework.UI.BunifuCheckbox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // imgProd
            // 
            this.imgProd.AllowFocused = false;
            this.imgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProd.AutoSizeHeight = true;
            this.imgProd.BorderRadius = 35;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = true;
            this.imgProd.Location = new System.Drawing.Point(35, 18);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(71, 71);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 75;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.imgProd.DoubleClick += new System.EventHandler(this.UserTable_DoubleClick);
            // 
            // lblTitleTable
            // 
            this.lblTitleTable.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleTable.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleTable.Location = new System.Drawing.Point(26, 92);
            this.lblTitleTable.Name = "lblTitleTable";
            this.lblTitleTable.Size = new System.Drawing.Size(98, 21);
            this.lblTitleTable.TabIndex = 74;
            this.lblTitleTable.Text = "250.12 MAD";
            this.lblTitleTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleTable.DoubleClick += new System.EventHandler(this.UserTable_DoubleClick);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(57, 26);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 21);
            this.lblId.TabIndex = 79;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this;
            // 
            // checkMerge
            // 
            this.checkMerge.BackColor = System.Drawing.Color.Silver;
            this.checkMerge.ChechedOffColor = System.Drawing.Color.Silver;
            this.checkMerge.Checked = false;
            this.checkMerge.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkMerge.Enabled = false;
            this.checkMerge.ForeColor = System.Drawing.Color.White;
            this.checkMerge.Location = new System.Drawing.Point(122, 3);
            this.checkMerge.MaximumSize = new System.Drawing.Size(30, 30);
            this.checkMerge.MinimumSize = new System.Drawing.Size(10, 10);
            this.checkMerge.Name = "checkMerge";
            this.checkMerge.Size = new System.Drawing.Size(20, 20);
            this.checkMerge.TabIndex = 80;
            this.checkMerge.Visible = false;
            // 
            // UserTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkMerge);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.lblTitleTable);
            this.Controls.Add(this.lblId);
            this.Name = "UserTable";
            this.Size = new System.Drawing.Size(145, 148);
            this.DoubleClick += new System.EventHandler(this.UserTable_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        public System.Windows.Forms.Label lblTitleTable;
        public System.Windows.Forms.Label lblId;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        public Bunifu.Framework.UI.BunifuCheckbox checkMerge;
    }
}
