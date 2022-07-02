
namespace CafeShopApp_v1.PL.PopUps.PopUpsCaisse
{
    partial class NotePupUp
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotePupUp));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.ElipsePopUp = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseBtnClose = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnAdd = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ddNotes = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAdd = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnAddNoteDb = new Bunifu.Framework.UI.BunifuImageButton();
            this.plTxtAdd = new System.Windows.Forms.Panel();
            this.btnAjouter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteDb)).BeginInit();
            this.plTxtAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // ElipsePopUp
            // 
            this.ElipsePopUp.ElipseRadius = 35;
            this.ElipsePopUp.TargetControl = this;
            // 
            // ElipseBtnClose
            // 
            this.ElipseBtnClose.ElipseRadius = 40;
            this.ElipseBtnClose.TargetControl = this.btnClose;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(341, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(8);
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 21;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 53;
            this.label1.Text = "SELECTIONE UNE NOTE";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.btnAdd;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageActive = null;
            this.btnAdd.Location = new System.Drawing.Point(262, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 39);
            this.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAdd.TabIndex = 55;
            this.btnAdd.TabStop = false;
            this.btnAdd.Zoom = 10;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.plTxtAdd);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 146);
            this.panel1.TabIndex = 55;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ddNotes);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 49);
            this.panel2.TabIndex = 0;
            // 
            // ddNotes
            // 
            this.ddNotes.BackColor = System.Drawing.Color.Transparent;
            this.ddNotes.BackgroundColor = System.Drawing.Color.White;
            this.ddNotes.BorderColor = System.Drawing.Color.Silver;
            this.ddNotes.BorderRadius = 10;
            this.ddNotes.Color = System.Drawing.Color.Silver;
            this.ddNotes.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddNotes.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddNotes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ddNotes.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ddNotes.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ddNotes.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ddNotes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddNotes.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ddNotes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddNotes.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddNotes.FillDropDown = true;
            this.ddNotes.FillIndicator = false;
            this.ddNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddNotes.Font = new System.Drawing.Font("Montserrat", 9F);
            this.ddNotes.ForeColor = System.Drawing.Color.Black;
            this.ddNotes.FormattingEnabled = true;
            this.ddNotes.Icon = null;
            this.ddNotes.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddNotes.IndicatorColor = System.Drawing.Color.Gray;
            this.ddNotes.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddNotes.ItemBackColor = System.Drawing.Color.White;
            this.ddNotes.ItemBorderColor = System.Drawing.Color.White;
            this.ddNotes.ItemForeColor = System.Drawing.Color.Black;
            this.ddNotes.ItemHeight = 33;
            this.ddNotes.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ddNotes.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ddNotes.ItemTopMargin = 3;
            this.ddNotes.Location = new System.Drawing.Point(68, 4);
            this.ddNotes.Name = "ddNotes";
            this.ddNotes.Size = new System.Drawing.Size(188, 39);
            this.ddNotes.TabIndex = 56;
            this.ddNotes.Text = null;
            this.ddNotes.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddNotes.TextLeftMargin = 5;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.btnAddNoteDb;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(385, 45);
            this.panel3.TabIndex = 59;
            // 
            // txtAdd
            // 
            this.txtAdd.AcceptsReturn = false;
            this.txtAdd.AcceptsTab = false;
            this.txtAdd.AnimationSpeed = 200;
            this.txtAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdd.BackColor = System.Drawing.Color.Transparent;
            this.txtAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAdd.BackgroundImage")));
            this.txtAdd.BorderColorActive = System.Drawing.Color.Gainsboro;
            this.txtAdd.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAdd.BorderColorHover = System.Drawing.Color.Transparent;
            this.txtAdd.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAdd.BorderRadius = 15;
            this.txtAdd.BorderThickness = 0;
            this.txtAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdd.DefaultFont = new System.Drawing.Font("Montserrat", 9F);
            this.txtAdd.DefaultText = "";
            this.txtAdd.FillColor = System.Drawing.Color.White;
            this.txtAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAdd.HideSelection = true;
            this.txtAdd.IconLeft = null;
            this.txtAdd.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdd.IconPadding = 10;
            this.txtAdd.IconRight = null;
            this.txtAdd.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdd.Lines = new string[0];
            this.txtAdd.Location = new System.Drawing.Point(68, 4);
            this.txtAdd.MaxLength = 32767;
            this.txtAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAdd.Modified = false;
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            stateProperties1.BorderColor = System.Drawing.Color.Gainsboro;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdd.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAdd.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdd.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdd.OnIdleState = stateProperties4;
            this.txtAdd.Padding = new System.Windows.Forms.Padding(3);
            this.txtAdd.PasswordChar = '\0';
            this.txtAdd.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtAdd.PlaceholderText = "Nouveu Note";
            this.txtAdd.ReadOnly = false;
            this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdd.SelectedText = "";
            this.txtAdd.SelectionLength = 0;
            this.txtAdd.SelectionStart = 0;
            this.txtAdd.ShortcutsEnabled = true;
            this.txtAdd.Size = new System.Drawing.Size(188, 40);
            this.txtAdd.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAdd.TabIndex = 57;
            this.txtAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdd.TextMarginBottom = 0;
            this.txtAdd.TextMarginLeft = 10;
            this.txtAdd.TextMarginTop = 8;
            this.txtAdd.TextPlaceholder = "Nouveu Note";
            this.txtAdd.UseSystemPasswordChar = false;
            this.txtAdd.WordWrap = true;
            // 
            // btnAddNoteDb
            // 
            this.btnAddNoteDb.BackColor = System.Drawing.Color.Black;
            this.btnAddNoteDb.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNoteDb.Image")));
            this.btnAddNoteDb.ImageActive = null;
            this.btnAddNoteDb.Location = new System.Drawing.Point(262, 5);
            this.btnAddNoteDb.Name = "btnAddNoteDb";
            this.btnAddNoteDb.Size = new System.Drawing.Size(39, 39);
            this.btnAddNoteDb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddNoteDb.TabIndex = 57;
            this.btnAddNoteDb.TabStop = false;
            this.btnAddNoteDb.Zoom = 10;
            this.btnAddNoteDb.Click += new System.EventHandler(this.btnAddNoteDb_Click);
            // 
            // plTxtAdd
            // 
            this.plTxtAdd.Controls.Add(this.btnAddNoteDb);
            this.plTxtAdd.Controls.Add(this.txtAdd);
            this.plTxtAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTxtAdd.Location = new System.Drawing.Point(0, 49);
            this.plTxtAdd.Name = "plTxtAdd";
            this.plTxtAdd.Size = new System.Drawing.Size(385, 49);
            this.plTxtAdd.TabIndex = 58;
            this.plTxtAdd.Visible = false;
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
            this.btnAjouter.ButtonText = "Ajouter";
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
            this.btnAjouter.Location = new System.Drawing.Point(137, 7);
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
            this.btnAjouter.Size = new System.Drawing.Size(100, 31);
            this.btnAjouter.TabIndex = 62;
            this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAjouter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAjouter.TextMarginLeft = 0;
            this.btnAjouter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAjouter.UseDefaultRadiusAndThickness = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // NotePupUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotePupUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NotePupUp";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNoteDb)).EndInit();
            this.plTxtAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ElipsePopUp;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuElipse ElipseBtnClose;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDropdown ddNotes;
        private Bunifu.Framework.UI.BunifuImageButton btnAdd;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAjouter;
        private System.Windows.Forms.Panel plTxtAdd;
        private Bunifu.Framework.UI.BunifuImageButton btnAddNoteDb;
        public Bunifu.UI.WinForms.BunifuTextBox txtAdd;
    }
}