
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserProdCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProdCard));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblTitleProd = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblNbr = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
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
            this.imgProd.BorderRadius = 22;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = true;
            this.imgProd.Location = new System.Drawing.Point(53, 7);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(45, 45);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 67;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.imgProd.Click += new System.EventHandler(this.UserProdCard_Click);
            // 
            // lblTitleProd
            // 
            this.lblTitleProd.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleProd.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitleProd.Location = new System.Drawing.Point(25, 55);
            this.lblTitleProd.Name = "lblTitleProd";
            this.lblTitleProd.Size = new System.Drawing.Size(98, 21);
            this.lblTitleProd.TabIndex = 66;
            this.lblTitleProd.Text = "250.12 MAD";
            this.lblTitleProd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleProd.Click += new System.EventHandler(this.UserProdCard_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(97, 105);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd.TabIndex = 69;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(29, 105);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(20, 20);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.bunifuImageButton1.TabIndex = 70;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lblPrix
            // 
            this.lblPrix.BackColor = System.Drawing.Color.Transparent;
            this.lblPrix.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(25, 75);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(98, 21);
            this.lblPrix.TabIndex = 71;
            this.lblPrix.Text = "250.12 MAD";
            this.lblPrix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrix.Click += new System.EventHandler(this.UserProdCard_Click);
            // 
            // lblId
            // 
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(56, 18);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(34, 21);
            this.lblId.TabIndex = 72;
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblId.Visible = false;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 5;
            this.bunifuElipse2.TargetControl = this.bunifuImageButton1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 5;
            this.bunifuElipse3.TargetControl = this.btnAdd;
            // 
            // lblNbr
            // 
            this.lblNbr.AcceptsReturn = false;
            this.lblNbr.AcceptsTab = false;
            this.lblNbr.AnimationSpeed = 200;
            this.lblNbr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lblNbr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lblNbr.BackColor = System.Drawing.Color.Transparent;
            this.lblNbr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblNbr.BackgroundImage")));
            this.lblNbr.BorderColorActive = System.Drawing.Color.Gainsboro;
            this.lblNbr.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblNbr.BorderColorHover = System.Drawing.Color.Transparent;
            this.lblNbr.BorderColorIdle = System.Drawing.Color.Silver;
            this.lblNbr.BorderRadius = 15;
            this.lblNbr.BorderThickness = 0;
            this.lblNbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lblNbr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNbr.DefaultFont = new System.Drawing.Font("Montserrat", 9F);
            this.lblNbr.DefaultText = "01";
            this.lblNbr.FillColor = System.Drawing.Color.White;
            this.lblNbr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNbr.HideSelection = true;
            this.lblNbr.IconLeft = null;
            this.lblNbr.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNbr.IconPadding = 10;
            this.lblNbr.IconRight = null;
            this.lblNbr.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNbr.Lines = new string[] {
        "01"};
            this.lblNbr.Location = new System.Drawing.Point(52, 104);
            this.lblNbr.MaxLength = 32767;
            this.lblNbr.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblNbr.Modified = false;
            this.lblNbr.Multiline = true;
            this.lblNbr.Name = "lblNbr";
            stateProperties1.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblNbr.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.lblNbr.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblNbr.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblNbr.OnIdleState = stateProperties4;
            this.lblNbr.Padding = new System.Windows.Forms.Padding(3);
            this.lblNbr.PasswordChar = '\0';
            this.lblNbr.PlaceholderForeColor = System.Drawing.Color.Black;
            this.lblNbr.PlaceholderText = "Entrer le nom de Client";
            this.lblNbr.ReadOnly = false;
            this.lblNbr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblNbr.SelectedText = "";
            this.lblNbr.SelectionLength = 0;
            this.lblNbr.SelectionStart = 2;
            this.lblNbr.ShortcutsEnabled = true;
            this.lblNbr.Size = new System.Drawing.Size(40, 21);
            this.lblNbr.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.lblNbr.TabIndex = 73;
            this.lblNbr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblNbr.TextMarginBottom = 0;
            this.lblNbr.TextMarginLeft = 0;
            this.lblNbr.TextMarginTop = 0;
            this.lblNbr.TextPlaceholder = "Entrer le nom de Client";
            this.lblNbr.UseSystemPasswordChar = false;
            this.lblNbr.WordWrap = true;
            // 
            // UserProdCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNbr);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.lblTitleProd);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(5, 15, 5, 15);
            this.Name = "UserProdCard";
            this.Size = new System.Drawing.Size(150, 148);
            this.Click += new System.EventHandler(this.UserProdCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        public System.Windows.Forms.Label lblTitleProd;
        public System.Windows.Forms.Label lblPrix;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        public System.Windows.Forms.Label lblId;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        public Bunifu.UI.WinForms.BunifuTextBox lblNbr;
    }
}
