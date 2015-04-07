/*
 * Created by SharpDevelop.
 * User: nwc
 * Date: 04/07/2014
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace NFOCreator
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.ComboBox();
            this.caminho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Correr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path to share:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1Click);
            // 
            // tipo
            // 
            this.tipo.FormattingEnabled = true;
            this.tipo.Items.AddRange(new object[] {
            "Videos",
            "MusicVideos"});
            this.tipo.Location = new System.Drawing.Point(166, 54);
            this.tipo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(307, 28);
            this.tipo.TabIndex = 1;
            this.tipo.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // caminho
            // 
            this.caminho.Location = new System.Drawing.Point(166, 18);
            this.caminho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.caminho.Name = "caminho";
            this.caminho.Size = new System.Drawing.Size(511, 26);
            this.caminho.TabIndex = 0;
            this.caminho.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Media Type:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Correr
            // 
            this.Correr.Location = new System.Drawing.Point(479, 54);
            this.Correr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Correr.Name = "Correr";
            this.Correr.Size = new System.Drawing.Size(198, 35);
            this.Correr.TabIndex = 3;
            this.Correr.Text = "Create NFOs";
            this.Correr.UseVisualStyleBackColor = true;
            this.Correr.Click += new System.EventHandler(this.CorrerClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 106);
            this.Controls.Add(this.Correr);
            this.Controls.Add(this.caminho);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "NFOCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button Correr;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox caminho;
		private System.Windows.Forms.ComboBox tipo;
		private System.Windows.Forms.Label label1;
		
		void Label1Click(object sender, System.EventArgs e)
		{
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, System.EventArgs e)
		{
			
		}
		
		void TextBox1TextChanged(object sender, System.EventArgs e)
		{
			
		}
	}
}
