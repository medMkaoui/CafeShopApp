
namespace CafeShopApp_v1.PL
{
    partial class AllFournisseursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllFournisseursForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.mainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.plDgv = new System.Windows.Forms.FlowLayoutPanel();
            this.plRowHeader = new Bunifu.UI.WinForms.BunifuPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblCountFournissuers = new System.Windows.Forms.Label();
            this.btnSearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtSearch = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.plRowHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundColor = System.Drawing.Color.White;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.BorderThickness = 0;
            this.mainPanel.Controls.Add(this.plDgv);
            this.mainPanel.Controls.Add(this.plRowHeader);
            this.mainPanel.Controls.Add(this.btnNew);
            this.mainPanel.Controls.Add(this.lblCountFournissuers);
            this.mainPanel.Controls.Add(this.btnSearch);
            this.mainPanel.Controls.Add(this.txtSearch);
            this.mainPanel.Controls.Add(this.lblTitle);
            this.mainPanel.Location = new System.Drawing.Point(8, 77);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShowBorders = true;
            this.mainPanel.Size = new System.Drawing.Size(808, 558);
            this.mainPanel.TabIndex = 4;
            // 
            // plDgv
            // 
            this.plDgv.AutoScroll = true;
            this.plDgv.Location = new System.Drawing.Point(24, 153);
            this.plDgv.Name = "plDgv";
            this.plDgv.Size = new System.Drawing.Size(763, 343);
            this.plDgv.TabIndex = 9;
            // 
            // plRowHeader
            // 
            this.plRowHeader.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.plRowHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plRowHeader.BackgroundImage")));
            this.plRowHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plRowHeader.BorderColor = System.Drawing.Color.Transparent;
            this.plRowHeader.BorderRadius = 15;
            this.plRowHeader.BorderThickness = 0;
            this.plRowHeader.Controls.Add(this.label6);
            this.plRowHeader.Controls.Add(this.label5);
            this.plRowHeader.Controls.Add(this.label4);
            this.plRowHeader.Controls.Add(this.label3);
            this.plRowHeader.Controls.Add(this.label1);
            this.plRowHeader.Controls.Add(this.label2);
            this.plRowHeader.Location = new System.Drawing.Point(24, 112);
            this.plRowHeader.Name = "plRowHeader";
            this.plRowHeader.ShowBorders = true;
            this.plRowHeader.Size = new System.Drawing.Size(763, 38);
            this.plRowHeader.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label6.Location = new System.Drawing.Point(426, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max Credit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label5.Location = new System.Drawing.Point(514, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total Credit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label4.Location = new System.Drawing.Point(332, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label3.Location = new System.Drawing.Point(183, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-mail ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label1.Location = new System.Drawing.Point(62, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nom fournisseur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.label2.Location = new System.Drawing.Point(23, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "N°";
            // 
            // btnNew
            // 
            this.btnNew.AllowAnimations = true;
            this.btnNew.AllowMouseEffects = true;
            this.btnNew.AllowToggling = false;
            this.btnNew.AnimationSpeed = 200;
            this.btnNew.AutoGenerateColors = false;
            this.btnNew.AutoRoundBorders = false;
            this.btnNew.AutoSizeLeftIcon = true;
            this.btnNew.AutoSizeRightIcon = true;
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackColor1 = System.Drawing.Color.Black;
            this.btnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNew.BackgroundImage")));
            this.btnNew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.ButtonText = "Nouveau";
            this.btnNew.ButtonTextMarginLeft = 0;
            this.btnNew.ColorContrastOnClick = 45;
            this.btnNew.ColorContrastOnHover = 45;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnNew.CustomizableEdges = borderEdges1;
            this.btnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNew.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNew.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnNew.Font = new System.Drawing.Font("Montserrat Light", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNew.IconMarginLeft = 11;
            this.btnNew.IconPadding = 10;
            this.btnNew.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNew.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNew.IconSize = 25;
            this.btnNew.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnNew.IdleBorderRadius = 15;
            this.btnNew.IdleBorderThickness = 1;
            this.btnNew.IdleFillColor = System.Drawing.Color.Black;
            this.btnNew.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnNew.IdleIconLeftImage")));
            this.btnNew.IdleIconRightImage = null;
            this.btnNew.IndicateFocus = false;
            this.btnNew.Location = new System.Drawing.Point(644, 31);
            this.btnNew.Name = "btnNew";
            this.btnNew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNew.OnDisabledState.BorderRadius = 15;
            this.btnNew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnDisabledState.BorderThickness = 1;
            this.btnNew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNew.OnDisabledState.IconLeftImage = null;
            this.btnNew.OnDisabledState.IconRightImage = null;
            this.btnNew.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNew.onHoverState.BorderRadius = 15;
            this.btnNew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.onHoverState.BorderThickness = 1;
            this.btnNew.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnNew.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnNew.onHoverState.IconLeftImage = null;
            this.btnNew.onHoverState.IconRightImage = null;
            this.btnNew.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNew.OnIdleState.BorderRadius = 15;
            this.btnNew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnIdleState.BorderThickness = 1;
            this.btnNew.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnNew.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnNew.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnNew.OnIdleState.IconLeftImage")));
            this.btnNew.OnIdleState.IconRightImage = null;
            this.btnNew.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNew.OnPressedState.BorderRadius = 15;
            this.btnNew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNew.OnPressedState.BorderThickness = 1;
            this.btnNew.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnNew.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnNew.OnPressedState.IconLeftImage = null;
            this.btnNew.OnPressedState.IconRightImage = null;
            this.btnNew.Size = new System.Drawing.Size(143, 40);
            this.btnNew.TabIndex = 7;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNew.TextMarginLeft = 0;
            this.btnNew.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNew.UseDefaultRadiusAndThickness = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblCountFournissuers
            // 
            this.lblCountFournissuers.AutoSize = true;
            this.lblCountFournissuers.BackColor = System.Drawing.Color.Transparent;
            this.lblCountFournissuers.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCountFournissuers.Location = new System.Drawing.Point(39, 69);
            this.lblCountFournissuers.Name = "lblCountFournissuers";
            this.lblCountFournissuers.Size = new System.Drawing.Size(62, 13);
            this.lblCountFournissuers.TabIndex = 4;
            this.lblCountFournissuers.Text = "50 Client (s)";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageActive = null;
            this.btnSearch.Location = new System.Drawing.Point(429, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(20, 20);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSearch.TabIndex = 3;
            this.btnSearch.TabStop = false;
            this.btnSearch.Zoom = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.AcceptsReturn = false;
            this.txtSearch.AcceptsTab = false;
            this.txtSearch.AnimationSpeed = 200;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.BackgroundImage")));
            this.txtSearch.BorderColorActive = System.Drawing.Color.Gainsboro;
            this.txtSearch.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.BorderColorHover = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 15;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultFont = new System.Drawing.Font("Montserrat", 9F);
            this.txtSearch.DefaultText = "";
            this.txtSearch.FillColor = System.Drawing.Color.White;
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.HideSelection = true;
            this.txtSearch.IconLeft = null;
            this.txtSearch.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.IconPadding = 10;
            this.txtSearch.IconRight = null;
            this.txtSearch.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(421, 31);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtSearch.Modified = false;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            stateProperties1.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtSearch.OnIdleState = stateProperties4;
            this.txtSearch.Padding = new System.Windows.Forms.Padding(3);
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtSearch.PlaceholderText = "Recherchez";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(202, 40);
            this.txtSearch.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TextMarginBottom = 0;
            this.txtSearch.TextMarginLeft = 25;
            this.txtSearch.TextMarginTop = 10;
            this.txtSearch.TextPlaceholder = "Recherchez";
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WordWrap = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "FOURNISSEURS";
            // 
            // AllFournisseursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainPanel);
            this.Name = "AllFournisseursForm";
            this.Size = new System.Drawing.Size(824, 713);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.plRowHeader.ResumeLayout(false);
            this.plRowHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel plDgv;
        private Bunifu.UI.WinForms.BunifuPanel plRowHeader;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNew;
        private System.Windows.Forms.Label lblCountFournissuers;
        private Bunifu.Framework.UI.BunifuImageButton btnSearch;
        public Bunifu.UI.WinForms.BunifuTextBox txtSearch;
        private System.Windows.Forms.Label lblTitle;
    }
}
