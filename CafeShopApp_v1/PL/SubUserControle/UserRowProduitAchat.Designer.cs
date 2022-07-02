
namespace CafeShopApp_v1.PL.SubUserControle
{
    partial class UserRowProduitAchat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRowProduitAchat));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.lblCat = new System.Windows.Forms.Label();
            this.btnEdit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblName = new System.Windows.Forms.Label();
            this.ElipseUser = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseBtn = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipsebtn1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.imgProd = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblUniter = new System.Windows.Forms.Label();
            this.CheckConsom = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblQte = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCat
            // 
            this.lblCat.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblCat.Location = new System.Drawing.Point(206, 14);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(95, 16);
            this.lblCat.TabIndex = 68;
            this.lblCat.Text = "Zite L3od";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageActive = null;
            this.btnEdit.Location = new System.Drawing.Point(677, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(30, 30);
            this.btnEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEdit.TabIndex = 71;
            this.btnEdit.TabStop = false;
            this.btnEdit.Zoom = 10;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Black;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 43);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(756, 1);
            this.bunifuPanel1.TabIndex = 72;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(95)))), ((int)(((byte)(63)))));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageActive = null;
            this.btnDelete.Location = new System.Drawing.Point(715, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(30, 30);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelete.TabIndex = 70;
            this.btnDelete.TabStop = false;
            this.btnDelete.Zoom = 10;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblName.Location = new System.Drawing.Point(71, 12);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 20);
            this.lblName.TabIndex = 67;
            this.lblName.Text = "Name";
            // 
            // ElipseUser
            // 
            this.ElipseUser.ElipseRadius = 15;
            this.ElipseUser.TargetControl = this;
            // 
            // ElipseBtn
            // 
            this.ElipseBtn.ElipseRadius = 7;
            this.ElipseBtn.TargetControl = this.btnEdit;
            // 
            // Elipsebtn1
            // 
            this.Elipsebtn1.ElipseRadius = 7;
            this.Elipsebtn1.TargetControl = this.btnDelete;
            // 
            // imgProd
            // 
            this.imgProd.AllowFocused = false;
            this.imgProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgProd.AutoSizeHeight = true;
            this.imgProd.BorderRadius = 17;
            this.imgProd.Image = ((System.Drawing.Image)(resources.GetObject("imgProd.Image")));
            this.imgProd.IsCircle = false;
            this.imgProd.Location = new System.Drawing.Point(11, 5);
            this.imgProd.Margin = new System.Windows.Forms.Padding(0);
            this.imgProd.Name = "imgProd";
            this.imgProd.Size = new System.Drawing.Size(34, 34);
            this.imgProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProd.TabIndex = 75;
            this.imgProd.TabStop = false;
            this.imgProd.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblId.Location = new System.Drawing.Point(23, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(30, 16);
            this.lblId.TabIndex = 74;
            this.lblId.Visible = false;
            // 
            // lblUniter
            // 
            this.lblUniter.Font = new System.Drawing.Font("Montserrat", 9F);
            this.lblUniter.Location = new System.Drawing.Point(559, 14);
            this.lblUniter.Name = "lblUniter";
            this.lblUniter.Size = new System.Drawing.Size(60, 16);
            this.lblUniter.TabIndex = 77;
            this.lblUniter.Tag = "";
            this.lblUniter.Text = "KG";
            // 
            // CheckConsom
            // 
            this.CheckConsom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.CheckConsom.ChechedOffColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckConsom.Checked = true;
            this.CheckConsom.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.CheckConsom.Enabled = false;
            this.CheckConsom.ForeColor = System.Drawing.Color.White;
            this.CheckConsom.Location = new System.Drawing.Point(320, 12);
            this.CheckConsom.Name = "CheckConsom";
            this.CheckConsom.Size = new System.Drawing.Size(20, 20);
            this.CheckConsom.TabIndex = 78;
            // 
            // lblQte
            // 
            this.lblQte.AcceptsReturn = false;
            this.lblQte.AcceptsTab = false;
            this.lblQte.AnimationSpeed = 200;
            this.lblQte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lblQte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lblQte.BackColor = System.Drawing.Color.Transparent;
            this.lblQte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblQte.BackgroundImage")));
            this.lblQte.BorderColorActive = System.Drawing.Color.LightGray;
            this.lblQte.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblQte.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.lblQte.BorderColorIdle = System.Drawing.Color.Silver;
            this.lblQte.BorderRadius = 10;
            this.lblQte.BorderThickness = 0;
            this.lblQte.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lblQte.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQte.DefaultFont = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQte.DefaultText = "";
            this.lblQte.FillColor = System.Drawing.Color.White;
            this.lblQte.HideSelection = true;
            this.lblQte.IconLeft = null;
            this.lblQte.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQte.IconPadding = 10;
            this.lblQte.IconRight = null;
            this.lblQte.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.lblQte.Lines = new string[0];
            this.lblQte.Location = new System.Drawing.Point(447, 9);
            this.lblQte.Margin = new System.Windows.Forms.Padding(0);
            this.lblQte.MaxLength = 32767;
            this.lblQte.MinimumSize = new System.Drawing.Size(1, 1);
            this.lblQte.Modified = false;
            this.lblQte.Multiline = false;
            this.lblQte.Name = "lblQte";
            stateProperties1.BorderColor = System.Drawing.Color.LightGray;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblQte.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.lblQte.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblQte.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.lblQte.OnIdleState = stateProperties4;
            this.lblQte.Padding = new System.Windows.Forms.Padding(3);
            this.lblQte.PasswordChar = '\0';
            this.lblQte.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.lblQte.PlaceholderText = "";
            this.lblQte.ReadOnly = false;
            this.lblQte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lblQte.SelectedText = "";
            this.lblQte.SelectionLength = 0;
            this.lblQte.SelectionStart = 0;
            this.lblQte.ShortcutsEnabled = true;
            this.lblQte.Size = new System.Drawing.Size(87, 17);
            this.lblQte.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.lblQte.TabIndex = 79;
            this.lblQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblQte.TextMarginBottom = 0;
            this.lblQte.TextMarginLeft = 3;
            this.lblQte.TextMarginTop = 0;
            this.lblQte.TextPlaceholder = "";
            this.lblQte.UseSystemPasswordChar = false;
            this.lblQte.WordWrap = true;
            // 
            // UserRowProduitAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblQte);
            this.Controls.Add(this.CheckConsom);
            this.Controls.Add(this.lblUniter);
            this.Controls.Add(this.lblCat);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgProd);
            this.Controls.Add(this.lblId);
            this.Name = "UserRowProduitAchat";
            this.Size = new System.Drawing.Size(763, 50);
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblCat;
        private Bunifu.Framework.UI.BunifuImageButton btnEdit;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.Framework.UI.BunifuImageButton btnDelete;
        public System.Windows.Forms.Label lblName;
        private Bunifu.Framework.UI.BunifuElipse ElipseUser;
        public Bunifu.UI.WinForms.BunifuPictureBox imgProd;
        public System.Windows.Forms.Label lblId;
        private Bunifu.Framework.UI.BunifuElipse ElipseBtn;
        private Bunifu.Framework.UI.BunifuElipse Elipsebtn1;
        public System.Windows.Forms.Label lblUniter;
        public Bunifu.Framework.UI.BunifuCheckbox CheckConsom;
        public Bunifu.UI.WinForms.BunifuTextBox lblQte;
    }
}
