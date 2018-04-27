namespace SRT
{
    partial class Stactistique
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stactistique));
            this.Cliente = new Bunifu.Framework.UI.BunifuTileButton();
            this.impaid = new Bunifu.Framework.UI.BunifuTileButton();
            this.paid = new Bunifu.Framework.UI.BunifuTileButton();
            this.gaint = new Bunifu.Framework.UI.BunifuTileButton();
            this.SuspendLayout();
            // 
            // Cliente
            // 
            this.Cliente.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Cliente.color = System.Drawing.SystemColors.ActiveBorder;
            this.Cliente.colorActive = System.Drawing.SystemColors.ActiveBorder;
            this.Cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cliente.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Cliente.ForeColor = System.Drawing.Color.Black;
            this.Cliente.Image = ((System.Drawing.Image)(resources.GetObject("Cliente.Image")));
            this.Cliente.ImagePosition = 20;
            this.Cliente.ImageZoom = 30;
            this.Cliente.LabelPosition = 41;
            this.Cliente.LabelText = "Tile 1";
            this.Cliente.Location = new System.Drawing.Point(471, 41);
            this.Cliente.Margin = new System.Windows.Forms.Padding(6);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(287, 160);
            this.Cliente.TabIndex = 8;
            this.Cliente.Click += new System.EventHandler(this.Cliente_Click);
            // 
            // impaid
            // 
            this.impaid.BackColor = System.Drawing.Color.DarkRed;
            this.impaid.color = System.Drawing.Color.DarkRed;
            this.impaid.colorActive = System.Drawing.Color.DarkRed;
            this.impaid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.impaid.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.impaid.ForeColor = System.Drawing.Color.White;
            this.impaid.Image = ((System.Drawing.Image)(resources.GetObject("impaid.Image")));
            this.impaid.ImagePosition = 20;
            this.impaid.ImageZoom = 30;
            this.impaid.LabelPosition = 41;
            this.impaid.LabelText = "Tile 1";
            this.impaid.Location = new System.Drawing.Point(471, 282);
            this.impaid.Margin = new System.Windows.Forms.Padding(6);
            this.impaid.Name = "impaid";
            this.impaid.Size = new System.Drawing.Size(287, 161);
            this.impaid.TabIndex = 7;
            this.impaid.Click += new System.EventHandler(this.impaid_Click);
            // 
            // paid
            // 
            this.paid.BackColor = System.Drawing.Color.SeaGreen;
            this.paid.color = System.Drawing.Color.SeaGreen;
            this.paid.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.paid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paid.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.paid.ForeColor = System.Drawing.Color.White;
            this.paid.Image = ((System.Drawing.Image)(resources.GetObject("paid.Image")));
            this.paid.ImagePosition = 20;
            this.paid.ImageZoom = 40;
            this.paid.LabelPosition = 41;
            this.paid.LabelText = "Tile 1";
            this.paid.Location = new System.Drawing.Point(80, 282);
            this.paid.Margin = new System.Windows.Forms.Padding(6);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(287, 161);
            this.paid.TabIndex = 6;
            this.paid.Click += new System.EventHandler(this.paid_Click);
            // 
            // gaint
            // 
            this.gaint.BackColor = System.Drawing.Color.SeaGreen;
            this.gaint.color = System.Drawing.Color.SeaGreen;
            this.gaint.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.gaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gaint.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.gaint.ForeColor = System.Drawing.Color.White;
            this.gaint.Image = ((System.Drawing.Image)(resources.GetObject("gaint.Image")));
            this.gaint.ImagePosition = 20;
            this.gaint.ImageZoom = 30;
            this.gaint.LabelPosition = 41;
            this.gaint.LabelText = "Tile 1";
            this.gaint.Location = new System.Drawing.Point(80, 41);
            this.gaint.Margin = new System.Windows.Forms.Padding(6);
            this.gaint.Name = "gaint";
            this.gaint.Size = new System.Drawing.Size(287, 161);
            this.gaint.TabIndex = 5;
            // 
            // Stactistique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 492);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.impaid);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.gaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stactistique";
            this.Text = "Stactistique";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton Cliente;
        private Bunifu.Framework.UI.BunifuTileButton impaid;
        private Bunifu.Framework.UI.BunifuTileButton paid;
        private Bunifu.Framework.UI.BunifuTileButton gaint;
    }
}