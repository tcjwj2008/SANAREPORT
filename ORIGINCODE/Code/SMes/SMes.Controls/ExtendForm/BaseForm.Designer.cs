namespace SMes.Controls.ExtendForm
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.mesPaletteEx1 = new SMes.Controls.MesPaletteEx();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.SuspendLayout();
            // 
            // mesPaletteEx1
            // 
            this.mesPaletteEx1.ButtonStyles.ButtonCommon.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial", 9.5F);
            this.mesPaletteEx1.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.ButtonStyles.ButtonCommon.StateNormal.Content.LongText.Font = new System.Drawing.Font("Arial", 9.5F);
            this.mesPaletteEx1.ButtonStyles.ButtonCommon.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateDisabled.Content.LongText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateDisabled.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateOthers.Content.LongText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.Common.StateOthers.Content.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.LabelStyles.LabelCommon.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 9.5F);
            this.mesPaletteEx1.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.MesFont = new System.Drawing.Font("Arial", 10F);
            this.mesPaletteEx1.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.LightSteelBlue;
            this.mesPaletteEx1.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.LightSteelBlue;
            this.mesPaletteEx1.ToolMenuStatus.MenuStrip.MenuStripFont = new System.Drawing.Font("Arial", 10.5F);
            this.mesPaletteEx1.ToolMenuStatus.ToolStrip.ToolStripFont = new System.Drawing.Font("Arial", 10F);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.mesPaletteEx1;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MesPaletteEx mesPaletteEx1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}