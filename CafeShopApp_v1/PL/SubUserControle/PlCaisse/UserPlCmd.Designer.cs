
namespace CafeShopApp_v1.PL.SubUserControle.PlCaisse
{
    partial class UserPlCmd
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPlCmd));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.plCmdRows = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEnvoyerCuisine = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEnAttend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnPayer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bb = new System.Windows.Forms.Label();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // plCmdRows
            // 
            this.plCmdRows.AutoScroll = true;
            this.plCmdRows.Location = new System.Drawing.Point(3, 23);
            this.plCmdRows.Name = "plCmdRows";
            this.plCmdRows.Size = new System.Drawing.Size(310, 343);
            this.plCmdRows.TabIndex = 0;
            this.plCmdRows.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.plCmdRows_ControlAdded);
            this.plCmdRows.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.plCmdRows_ControlRemoved);
            // 
            // btnEnvoyerCuisine
            // 
            this.btnEnvoyerCuisine.AllowAnimations = true;
            this.btnEnvoyerCuisine.AllowMouseEffects = true;
            this.btnEnvoyerCuisine.AllowToggling = false;
            this.btnEnvoyerCuisine.AnimationSpeed = 200;
            this.btnEnvoyerCuisine.AutoGenerateColors = false;
            this.btnEnvoyerCuisine.AutoRoundBorders = false;
            this.btnEnvoyerCuisine.AutoSizeLeftIcon = true;
            this.btnEnvoyerCuisine.AutoSizeRightIcon = true;
            this.btnEnvoyerCuisine.BackColor = System.Drawing.Color.Transparent;
            this.btnEnvoyerCuisine.BackColor1 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnvoyerCuisine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnvoyerCuisine.BackgroundImage")));
            this.btnEnvoyerCuisine.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnvoyerCuisine.ButtonText = "ENVOYER VERS LA CUISINE";
            this.btnEnvoyerCuisine.ButtonTextMarginLeft = 0;
            this.btnEnvoyerCuisine.ColorContrastOnClick = 45;
            this.btnEnvoyerCuisine.ColorContrastOnHover = 45;
            this.btnEnvoyerCuisine.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnEnvoyerCuisine.CustomizableEdges = borderEdges2;
            this.btnEnvoyerCuisine.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnvoyerCuisine.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnvoyerCuisine.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnvoyerCuisine.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnvoyerCuisine.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEnvoyerCuisine.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnvoyerCuisine.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyerCuisine.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnvoyerCuisine.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnvoyerCuisine.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEnvoyerCuisine.IconMarginLeft = 11;
            this.btnEnvoyerCuisine.IconPadding = 10;
            this.btnEnvoyerCuisine.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnvoyerCuisine.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnvoyerCuisine.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEnvoyerCuisine.IconSize = 25;
            this.btnEnvoyerCuisine.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEnvoyerCuisine.IdleBorderRadius = 15;
            this.btnEnvoyerCuisine.IdleBorderThickness = 1;
            this.btnEnvoyerCuisine.IdleFillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnvoyerCuisine.IdleIconLeftImage = null;
            this.btnEnvoyerCuisine.IdleIconRightImage = null;
            this.btnEnvoyerCuisine.IndicateFocus = false;
            this.btnEnvoyerCuisine.Location = new System.Drawing.Point(5, 442);
            this.btnEnvoyerCuisine.Name = "btnEnvoyerCuisine";
            this.btnEnvoyerCuisine.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnvoyerCuisine.OnDisabledState.BorderRadius = 15;
            this.btnEnvoyerCuisine.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnvoyerCuisine.OnDisabledState.BorderThickness = 1;
            this.btnEnvoyerCuisine.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnvoyerCuisine.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnvoyerCuisine.OnDisabledState.IconLeftImage = null;
            this.btnEnvoyerCuisine.OnDisabledState.IconRightImage = null;
            this.btnEnvoyerCuisine.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEnvoyerCuisine.onHoverState.BorderRadius = 15;
            this.btnEnvoyerCuisine.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnvoyerCuisine.onHoverState.BorderThickness = 1;
            this.btnEnvoyerCuisine.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEnvoyerCuisine.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyerCuisine.onHoverState.IconLeftImage = null;
            this.btnEnvoyerCuisine.onHoverState.IconRightImage = null;
            this.btnEnvoyerCuisine.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEnvoyerCuisine.OnIdleState.BorderRadius = 15;
            this.btnEnvoyerCuisine.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnvoyerCuisine.OnIdleState.BorderThickness = 1;
            this.btnEnvoyerCuisine.OnIdleState.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEnvoyerCuisine.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyerCuisine.OnIdleState.IconLeftImage = null;
            this.btnEnvoyerCuisine.OnIdleState.IconRightImage = null;
            this.btnEnvoyerCuisine.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnvoyerCuisine.OnPressedState.BorderRadius = 15;
            this.btnEnvoyerCuisine.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnvoyerCuisine.OnPressedState.BorderThickness = 1;
            this.btnEnvoyerCuisine.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnvoyerCuisine.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEnvoyerCuisine.OnPressedState.IconLeftImage = null;
            this.btnEnvoyerCuisine.OnPressedState.IconRightImage = null;
            this.btnEnvoyerCuisine.Size = new System.Drawing.Size(310, 40);
            this.btnEnvoyerCuisine.TabIndex = 14;
            this.btnEnvoyerCuisine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnvoyerCuisine.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnvoyerCuisine.TextMarginLeft = 0;
            this.btnEnvoyerCuisine.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEnvoyerCuisine.UseDefaultRadiusAndThickness = true;
            this.btnEnvoyerCuisine.Click += new System.EventHandler(this.btnEnvoyerCuisine_Click);
            // 
            // btnEnAttend
            // 
            this.btnEnAttend.AllowAnimations = true;
            this.btnEnAttend.AllowMouseEffects = true;
            this.btnEnAttend.AllowToggling = false;
            this.btnEnAttend.AnimationSpeed = 200;
            this.btnEnAttend.AutoGenerateColors = false;
            this.btnEnAttend.AutoRoundBorders = false;
            this.btnEnAttend.AutoSizeLeftIcon = true;
            this.btnEnAttend.AutoSizeRightIcon = true;
            this.btnEnAttend.BackColor = System.Drawing.Color.Transparent;
            this.btnEnAttend.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEnAttend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnAttend.BackgroundImage")));
            this.btnEnAttend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnAttend.ButtonText = "EN ATTEND";
            this.btnEnAttend.ButtonTextMarginLeft = 0;
            this.btnEnAttend.ColorContrastOnClick = 45;
            this.btnEnAttend.ColorContrastOnHover = 45;
            this.btnEnAttend.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnEnAttend.CustomizableEdges = borderEdges3;
            this.btnEnAttend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEnAttend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnAttend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnAttend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnAttend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnEnAttend.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnAttend.ForeColor = System.Drawing.Color.White;
            this.btnEnAttend.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnAttend.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnAttend.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnEnAttend.IconMarginLeft = 11;
            this.btnEnAttend.IconPadding = 10;
            this.btnEnAttend.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEnAttend.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEnAttend.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnEnAttend.IconSize = 25;
            this.btnEnAttend.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnEnAttend.IdleBorderRadius = 15;
            this.btnEnAttend.IdleBorderThickness = 1;
            this.btnEnAttend.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEnAttend.IdleIconLeftImage = null;
            this.btnEnAttend.IdleIconRightImage = null;
            this.btnEnAttend.IndicateFocus = false;
            this.btnEnAttend.Location = new System.Drawing.Point(5, 497);
            this.btnEnAttend.Name = "btnEnAttend";
            this.btnEnAttend.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnEnAttend.OnDisabledState.BorderRadius = 15;
            this.btnEnAttend.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnAttend.OnDisabledState.BorderThickness = 1;
            this.btnEnAttend.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnAttend.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnEnAttend.OnDisabledState.IconLeftImage = null;
            this.btnEnAttend.OnDisabledState.IconRightImage = null;
            this.btnEnAttend.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEnAttend.onHoverState.BorderRadius = 15;
            this.btnEnAttend.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnAttend.onHoverState.BorderThickness = 1;
            this.btnEnAttend.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnEnAttend.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnEnAttend.onHoverState.IconLeftImage = null;
            this.btnEnAttend.onHoverState.IconRightImage = null;
            this.btnEnAttend.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnEnAttend.OnIdleState.BorderRadius = 15;
            this.btnEnAttend.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnAttend.OnIdleState.BorderThickness = 1;
            this.btnEnAttend.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnEnAttend.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnEnAttend.OnIdleState.IconLeftImage = null;
            this.btnEnAttend.OnIdleState.IconRightImage = null;
            this.btnEnAttend.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnAttend.OnPressedState.BorderRadius = 15;
            this.btnEnAttend.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnEnAttend.OnPressedState.BorderThickness = 1;
            this.btnEnAttend.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnEnAttend.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnEnAttend.OnPressedState.IconLeftImage = null;
            this.btnEnAttend.OnPressedState.IconRightImage = null;
            this.btnEnAttend.Size = new System.Drawing.Size(310, 40);
            this.btnEnAttend.TabIndex = 13;
            this.btnEnAttend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnAttend.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEnAttend.TextMarginLeft = 0;
            this.btnEnAttend.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnEnAttend.UseDefaultRadiusAndThickness = true;
            this.btnEnAttend.Click += new System.EventHandler(this.btnEnAttend_Click);
            // 
            // btnPayer
            // 
            this.btnPayer.AllowAnimations = true;
            this.btnPayer.AllowMouseEffects = true;
            this.btnPayer.AllowToggling = false;
            this.btnPayer.AnimationSpeed = 200;
            this.btnPayer.AutoGenerateColors = false;
            this.btnPayer.AutoRoundBorders = false;
            this.btnPayer.AutoSizeLeftIcon = true;
            this.btnPayer.AutoSizeRightIcon = true;
            this.btnPayer.BackColor = System.Drawing.Color.Transparent;
            this.btnPayer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnPayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPayer.BackgroundImage")));
            this.btnPayer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayer.ButtonText = "PAYER";
            this.btnPayer.ButtonTextMarginLeft = 0;
            this.btnPayer.ColorContrastOnClick = 45;
            this.btnPayer.ColorContrastOnHover = 45;
            this.btnPayer.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnPayer.CustomizableEdges = borderEdges1;
            this.btnPayer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPayer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPayer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPayer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPayer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnPayer.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayer.ForeColor = System.Drawing.Color.White;
            this.btnPayer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPayer.IconMarginLeft = 11;
            this.btnPayer.IconPadding = 10;
            this.btnPayer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPayer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPayer.IconSize = 25;
            this.btnPayer.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPayer.IdleBorderRadius = 15;
            this.btnPayer.IdleBorderThickness = 1;
            this.btnPayer.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnPayer.IdleIconLeftImage = null;
            this.btnPayer.IdleIconRightImage = null;
            this.btnPayer.IndicateFocus = false;
            this.btnPayer.Location = new System.Drawing.Point(5, 552);
            this.btnPayer.Name = "btnPayer";
            this.btnPayer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnPayer.OnDisabledState.BorderRadius = 15;
            this.btnPayer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayer.OnDisabledState.BorderThickness = 1;
            this.btnPayer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnPayer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPayer.OnDisabledState.IconLeftImage = null;
            this.btnPayer.OnDisabledState.IconRightImage = null;
            this.btnPayer.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPayer.onHoverState.BorderRadius = 15;
            this.btnPayer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayer.onHoverState.BorderThickness = 1;
            this.btnPayer.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnPayer.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPayer.onHoverState.IconLeftImage = null;
            this.btnPayer.onHoverState.IconRightImage = null;
            this.btnPayer.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPayer.OnIdleState.BorderRadius = 15;
            this.btnPayer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayer.OnIdleState.BorderThickness = 1;
            this.btnPayer.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(195)))), ((int)(((byte)(137)))));
            this.btnPayer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPayer.OnIdleState.IconLeftImage = null;
            this.btnPayer.OnIdleState.IconRightImage = null;
            this.btnPayer.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPayer.OnPressedState.BorderRadius = 15;
            this.btnPayer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnPayer.OnPressedState.BorderThickness = 1;
            this.btnPayer.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnPayer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnPayer.OnPressedState.IconLeftImage = null;
            this.btnPayer.OnPressedState.IconRightImage = null;
            this.btnPayer.Size = new System.Drawing.Size(310, 40);
            this.btnPayer.TabIndex = 15;
            this.btnPayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPayer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPayer.TextMarginLeft = 0;
            this.btnPayer.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPayer.UseDefaultRadiusAndThickness = true;
            this.btnPayer.Click += new System.EventHandler(this.btnPayer_Click);
            // 
            // bb
            // 
            this.bb.AutoSize = true;
            this.bb.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bb.Location = new System.Drawing.Point(19, 394);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(81, 15);
            this.bb.TabIndex = 16;
            this.bb.Text = "TOTAL (MAD)";
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.AutoSize = true;
            this.lblMontantTotal.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantTotal.Location = new System.Drawing.Point(253, 394);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(37, 15);
            this.lblMontantTotal.TabIndex = 17;
            this.lblMontantTotal.Text = "00.00";
            // 
            // UserPlCmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plCmdRows);
            this.Controls.Add(this.lblMontantTotal);
            this.Controls.Add(this.bb);
            this.Controls.Add(this.btnPayer);
            this.Controls.Add(this.btnEnvoyerCuisine);
            this.Controls.Add(this.btnEnAttend);
            this.Name = "UserPlCmd";
            this.Size = new System.Drawing.Size(320, 633);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label bb;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnPayer;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnvoyerCuisine;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEnAttend;
        public System.Windows.Forms.FlowLayoutPanel plCmdRows;
        public System.Windows.Forms.Label lblMontantTotal;
    }
}
