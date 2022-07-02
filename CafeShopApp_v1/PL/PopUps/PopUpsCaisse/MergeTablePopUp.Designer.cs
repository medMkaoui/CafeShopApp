
namespace CafeShopApp_v1.PL.PopUps.PopUpsCaisse
{
    partial class MergeTablePopUp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MergeTablePopUp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.ddEspace = new Bunifu.UI.WinForms.BunifuDropdown();
            this.fg = new System.Windows.Forms.Label();
            this.plLiv = new System.Windows.Forms.Panel();
            this.ddTable = new Bunifu.UI.WinForms.BunifuDropdown();
            this.plTable = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.plContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAjouter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.plBtns = new System.Windows.Forms.Panel();
            this.plMain = new System.Windows.Forms.Panel();
            this.ElipseBtnClose = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseChargePopUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.plTable.SuspendLayout();
            this.plContent.SuspendLayout();
            this.plBtns.SuspendLayout();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ddEspace
            // 
            this.ddEspace.BackColor = System.Drawing.Color.Transparent;
            this.ddEspace.BackgroundColor = System.Drawing.Color.White;
            this.ddEspace.BorderColor = System.Drawing.Color.Silver;
            this.ddEspace.BorderRadius = 10;
            this.ddEspace.Color = System.Drawing.Color.Silver;
            this.ddEspace.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddEspace.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddEspace.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddEspace.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddEspace.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddEspace.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddEspace.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddEspace.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddEspace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddEspace.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddEspace.FillDropDown = true;
            this.ddEspace.FillIndicator = false;
            this.ddEspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddEspace.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ddEspace.ForeColor = System.Drawing.Color.Black;
            this.ddEspace.FormattingEnabled = true;
            this.ddEspace.Icon = null;
            this.ddEspace.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEspace.IndicatorColor = System.Drawing.Color.Gray;
            this.ddEspace.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEspace.ItemBackColor = System.Drawing.Color.White;
            this.ddEspace.ItemBorderColor = System.Drawing.Color.White;
            this.ddEspace.ItemForeColor = System.Drawing.Color.Black;
            this.ddEspace.ItemHeight = 33;
            this.ddEspace.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddEspace.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddEspace.Items.AddRange(new object[] {
            "Préparé par le cuisinier",
            "Préparé par le bar man"});
            this.ddEspace.ItemTopMargin = 3;
            this.ddEspace.Location = new System.Drawing.Point(26, 37);
            this.ddEspace.Name = "ddEspace";
            this.ddEspace.Size = new System.Drawing.Size(160, 39);
            this.ddEspace.TabIndex = 76;
            this.ddEspace.Text = null;
            this.ddEspace.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddEspace.TextLeftMargin = 5;
            this.ddEspace.SelectedIndexChanged += new System.EventHandler(this.ddEspace_SelectedIndexChanged);
            // 
            // fg
            // 
            this.fg.AutoSize = true;
            this.fg.BackColor = System.Drawing.Color.Transparent;
            this.fg.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.Location = new System.Drawing.Point(202, 9);
            this.fg.Name = "fg";
            this.fg.Size = new System.Drawing.Size(51, 21);
            this.fg.TabIndex = 75;
            this.fg.Text = "Table";
            // 
            // plLiv
            // 
            this.plLiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.plLiv.Location = new System.Drawing.Point(3, 100);
            this.plLiv.Name = "plLiv";
            this.plLiv.Size = new System.Drawing.Size(389, 42);
            this.plLiv.TabIndex = 1;
            // 
            // ddTable
            // 
            this.ddTable.BackColor = System.Drawing.Color.Transparent;
            this.ddTable.BackgroundColor = System.Drawing.Color.White;
            this.ddTable.BorderColor = System.Drawing.Color.Silver;
            this.ddTable.BorderRadius = 10;
            this.ddTable.Color = System.Drawing.Color.Silver;
            this.ddTable.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddTable.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddTable.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddTable.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddTable.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddTable.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddTable.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddTable.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddTable.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddTable.FillDropDown = true;
            this.ddTable.FillIndicator = false;
            this.ddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddTable.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ddTable.ForeColor = System.Drawing.Color.Black;
            this.ddTable.FormattingEnabled = true;
            this.ddTable.Icon = null;
            this.ddTable.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddTable.IndicatorColor = System.Drawing.Color.Gray;
            this.ddTable.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddTable.ItemBackColor = System.Drawing.Color.White;
            this.ddTable.ItemBorderColor = System.Drawing.Color.White;
            this.ddTable.ItemForeColor = System.Drawing.Color.Black;
            this.ddTable.ItemHeight = 33;
            this.ddTable.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddTable.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddTable.Items.AddRange(new object[] {
            "Préparé par le cuisinier",
            "Préparé par le bar man"});
            this.ddTable.ItemTopMargin = 3;
            this.ddTable.Location = new System.Drawing.Point(203, 37);
            this.ddTable.Name = "ddTable";
            this.ddTable.Size = new System.Drawing.Size(164, 39);
            this.ddTable.TabIndex = 74;
            this.ddTable.Text = null;
            this.ddTable.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddTable.TextLeftMargin = 5;
            // 
            // plTable
            // 
            this.plTable.Controls.Add(this.ddEspace);
            this.plTable.Controls.Add(this.fg);
            this.plTable.Controls.Add(this.ddTable);
            this.plTable.Controls.Add(this.label5);
            this.plTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTable.Location = new System.Drawing.Point(3, 3);
            this.plTable.Name = "plTable";
            this.plTable.Size = new System.Drawing.Size(389, 91);
            this.plTable.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 73;
            this.label5.Text = "Espace";
            // 
            // plContent
            // 
            this.plContent.Controls.Add(this.plTable);
            this.plContent.Controls.Add(this.plLiv);
            this.plContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.plContent.Location = new System.Drawing.Point(0, 0);
            this.plContent.Margin = new System.Windows.Forms.Padding(0);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(392, 90);
            this.plContent.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.AllowAnimations = true;
            this.btnAjouter.AllowMouseEffects = true;
            this.btnAjouter.AllowToggling = false;
            this.btnAjouter.AnimationSpeed = 200;
            this.btnAjouter.AutoGenerateColors = false;
            this.btnAjouter.AutoRoundBorders = false;
            this.btnAjouter.AutoSizeLeftIcon = true;
            this.btnAjouter.AutoSizeRightIcon = true;
            this.btnAjouter.BackColor = System.Drawing.Color.Transparent;
            this.btnAjouter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnAjouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.BackgroundImage")));
            this.btnAjouter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAjouter.ButtonText = "Ok";
            this.btnAjouter.ButtonTextMarginLeft = 0;
            this.btnAjouter.ColorContrastOnClick = 45;
            this.btnAjouter.ColorContrastOnHover = 45;
            this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAjouter.CustomizableEdges = borderEdges1;
            this.btnAjouter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAjouter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAjouter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAjouter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAjouter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAjouter.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjouter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAjouter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAjouter.IconMarginLeft = 11;
            this.btnAjouter.IconPadding = 10;
            this.btnAjouter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAjouter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAjouter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAjouter.IconSize = 25;
            this.btnAjouter.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAjouter.IdleBorderRadius = 15;
            this.btnAjouter.IdleBorderThickness = 1;
            this.btnAjouter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnAjouter.IdleIconLeftImage = null;
            this.btnAjouter.IdleIconRightImage = null;
            this.btnAjouter.IndicateFocus = false;
            this.btnAjouter.Location = new System.Drawing.Point(148, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAjouter.OnDisabledState.BorderRadius = 15;
            this.btnAjouter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAjouter.OnDisabledState.BorderThickness = 1;
            this.btnAjouter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAjouter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAjouter.OnDisabledState.IconLeftImage = null;
            this.btnAjouter.OnDisabledState.IconRightImage = null;
            this.btnAjouter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAjouter.onHoverState.BorderRadius = 15;
            this.btnAjouter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAjouter.onHoverState.BorderThickness = 1;
            this.btnAjouter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAjouter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.onHoverState.IconLeftImage = null;
            this.btnAjouter.onHoverState.IconRightImage = null;
            this.btnAjouter.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAjouter.OnIdleState.BorderRadius = 15;
            this.btnAjouter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAjouter.OnIdleState.BorderThickness = 1;
            this.btnAjouter.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnAjouter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnIdleState.IconLeftImage = null;
            this.btnAjouter.OnIdleState.IconRightImage = null;
            this.btnAjouter.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAjouter.OnPressedState.BorderRadius = 15;
            this.btnAjouter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAjouter.OnPressedState.BorderThickness = 1;
            this.btnAjouter.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAjouter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.OnPressedState.IconLeftImage = null;
            this.btnAjouter.OnPressedState.IconRightImage = null;
            this.btnAjouter.Size = new System.Drawing.Size(82, 30);
            this.btnAjouter.TabIndex = 61;
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextMarginLeft = 0;
            this.btnAjouter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAjouter.UseDefaultRadiusAndThickness = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // plBtns
            // 
            this.plBtns.Controls.Add(this.btnAjouter);
            this.plBtns.Dock = System.Windows.Forms.DockStyle.Top;
            this.plBtns.Location = new System.Drawing.Point(0, 90);
            this.plBtns.Margin = new System.Windows.Forms.Padding(0);
            this.plBtns.Name = "plBtns";
            this.plBtns.Size = new System.Drawing.Size(392, 55);
            this.plBtns.TabIndex = 2;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.plBtns);
            this.plMain.Controls.Add(this.plContent);
            this.plMain.Location = new System.Drawing.Point(2, 49);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(392, 149);
            this.plMain.TabIndex = 14;
            // 
            // ElipseBtnClose
            // 
            this.ElipseBtnClose.ElipseRadius = 40;
            this.ElipseBtnClose.TargetControl = this;
            // 
            // ElipseChargePopUp
            // 
            this.ElipseChargePopUp.ElipseRadius = 35;
            this.ElipseChargePopUp.TargetControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(385, 21);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Choisissez la salle et la longueur à combiner avec";
            // 
            // MergeTablePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 201);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MergeTablePopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MergeTablePopUp";
            this.plTable.ResumeLayout(false);
            this.plTable.PerformLayout();
            this.plContent.ResumeLayout(false);
            this.plBtns.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuDropdown ddEspace;
        private System.Windows.Forms.Label fg;
        private System.Windows.Forms.Panel plLiv;
        private Bunifu.UI.WinForms.BunifuDropdown ddTable;
        private System.Windows.Forms.Panel plTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel plContent;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAjouter;
        private System.Windows.Forms.Panel plBtns;
        private System.Windows.Forms.Panel plMain;
        private Bunifu.Framework.UI.BunifuElipse ElipseBtnClose;
        public System.Windows.Forms.Label lblTitle;
        private Bunifu.Framework.UI.BunifuElipse ElipseChargePopUp;
    }
}