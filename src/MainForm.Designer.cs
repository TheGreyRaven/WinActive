namespace WinActive
{
    partial class MainForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.boxCard = new Bunifu.Framework.UI.BunifuCards();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.activateButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exitButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.mdlButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.githubButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.boxCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.ElipseRadius = 5;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // boxCard
            // 
            this.boxCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.boxCard.BorderRadius = 5;
            this.boxCard.BottomSahddow = true;
            this.boxCard.color = System.Drawing.Color.Tomato;
            this.boxCard.Controls.Add(this.outputBox);
            this.boxCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.boxCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.boxCard.LeftSahddow = false;
            this.boxCard.Location = new System.Drawing.Point(0, 0);
            this.boxCard.Name = "boxCard";
            this.boxCard.RightSahddow = true;
            this.boxCard.ShadowDepth = 20;
            this.boxCard.Size = new System.Drawing.Size(800, 325);
            this.boxCard.TabIndex = 0;
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.outputBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputBox.ForeColor = System.Drawing.SystemColors.Window;
            this.outputBox.Location = new System.Drawing.Point(8, 11);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.outputBox.Size = new System.Drawing.Size(785, 304);
            this.outputBox.TabIndex = 1;
            this.outputBox.Text = "";
            // 
            // activateButton
            // 
            this.activateButton.BackColor = System.Drawing.Color.Transparent;
            this.activateButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("activateButton.BackgroundImage")));
            this.activateButton.ButtonText = "Activate Microsoft Products";
            this.activateButton.ButtonTextMarginLeft = 0;
            this.activateButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.activateButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.activateButton.DisabledForecolor = System.Drawing.Color.White;
            this.activateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateButton.ForeColor = System.Drawing.Color.White;
            this.activateButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.activateButton.IconPadding = 10;
            this.activateButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.activateButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.activateButton.IdleBorderRadius = 1;
            this.activateButton.IdleBorderThickness = 0;
            this.activateButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.activateButton.IdleIconLeftImage = null;
            this.activateButton.IdleIconRightImage = null;
            this.activateButton.Location = new System.Drawing.Point(8, 331);
            this.activateButton.Name = "activateButton";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.activateButton.onHoverState = stateProperties4;
            this.activateButton.Size = new System.Drawing.Size(210, 45);
            this.activateButton.TabIndex = 1;
            this.activateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.ButtonText = "Exit";
            this.exitButton.ButtonTextMarginLeft = 0;
            this.exitButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.exitButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.exitButton.DisabledForecolor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IconPadding = 10;
            this.exitButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.exitButton.IdleBorderRadius = 1;
            this.exitButton.IdleBorderThickness = 0;
            this.exitButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.exitButton.IdleIconLeftImage = null;
            this.exitButton.IdleIconRightImage = null;
            this.exitButton.Location = new System.Drawing.Point(8, 393);
            this.exitButton.Name = "exitButton";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.exitButton.onHoverState = stateProperties3;
            this.exitButton.Size = new System.Drawing.Size(210, 45);
            this.exitButton.TabIndex = 2;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // DragControl2
            // 
            this.DragControl2.Fixed = true;
            this.DragControl2.Horizontal = true;
            this.DragControl2.TargetControl = this.boxCard;
            this.DragControl2.Vertical = true;
            // 
            // mdlButton
            // 
            this.mdlButton.BackColor = System.Drawing.Color.Transparent;
            this.mdlButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mdlButton.BackgroundImage")));
            this.mdlButton.ButtonText = "MyDigitalLife";
            this.mdlButton.ButtonTextMarginLeft = 0;
            this.mdlButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.mdlButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.mdlButton.DisabledForecolor = System.Drawing.Color.White;
            this.mdlButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdlButton.ForeColor = System.Drawing.Color.White;
            this.mdlButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.mdlButton.IconPadding = 10;
            this.mdlButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.mdlButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.mdlButton.IdleBorderRadius = 1;
            this.mdlButton.IdleBorderThickness = 0;
            this.mdlButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.mdlButton.IdleIconLeftImage = null;
            this.mdlButton.IdleIconRightImage = null;
            this.mdlButton.Location = new System.Drawing.Point(583, 393);
            this.mdlButton.Name = "mdlButton";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.mdlButton.onHoverState = stateProperties2;
            this.mdlButton.Size = new System.Drawing.Size(210, 45);
            this.mdlButton.TabIndex = 3;
            this.mdlButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mdlButton.Click += new System.EventHandler(this.mdlButton_Click);
            // 
            // githubButton
            // 
            this.githubButton.BackColor = System.Drawing.Color.Transparent;
            this.githubButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("githubButton.BackgroundImage")));
            this.githubButton.ButtonText = "GitHub";
            this.githubButton.ButtonTextMarginLeft = 0;
            this.githubButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.githubButton.DisabledFillColor = System.Drawing.Color.Gray;
            this.githubButton.DisabledForecolor = System.Drawing.Color.White;
            this.githubButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.githubButton.ForeColor = System.Drawing.Color.White;
            this.githubButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.githubButton.IconPadding = 10;
            this.githubButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.githubButton.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.githubButton.IdleBorderRadius = 1;
            this.githubButton.IdleBorderThickness = 0;
            this.githubButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.githubButton.IdleIconLeftImage = null;
            this.githubButton.IdleIconRightImage = null;
            this.githubButton.Location = new System.Drawing.Point(583, 331);
            this.githubButton.Name = "githubButton";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.githubButton.onHoverState = stateProperties1;
            this.githubButton.Size = new System.Drawing.Size(210, 45);
            this.githubButton.TabIndex = 4;
            this.githubButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.githubButton.Click += new System.EventHandler(this.githubButton_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(333, 425);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(127, 13);
            this.bunifuCustomLabel1.TabIndex = 5;
            this.bunifuCustomLabel1.Text = "Made by: TheGreyRaven";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.githubButton);
            this.Controls.Add(this.mdlButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.boxCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "WinActive";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.boxCard.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuCards boxCard;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exitButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton activateButton;
        private Bunifu.Framework.UI.BunifuDragControl DragControl2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton mdlButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton githubButton;
        public System.Windows.Forms.RichTextBox outputBox;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

