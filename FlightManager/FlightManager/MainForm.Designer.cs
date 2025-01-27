/*
 * Created by SharpDevelop.
 * User: Family
 * Date: 26/01/2025
 * Time: 01:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FlightManager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		public System.Windows.Forms.ListView lstVoos;
		private System.Windows.Forms.RadioButton rbtnCapturaNao;
		private System.Windows.Forms.RadioButton rbtnCapturaSim;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader Data;
		private System.Windows.Forms.ColumnHeader Captura;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		public System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtCusto;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDistancia;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNivelDor;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		
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
			this.lstVoos = new System.Windows.Forms.ListView();
			this.Data = new System.Windows.Forms.ColumnHeader();
			this.Captura = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.rbtnCapturaNao = new System.Windows.Forms.RadioButton();
			this.rbtnCapturaSim = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.txtCusto = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDistancia = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNivelDor = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtData = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstVoos
			// 
			this.lstVoos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Data,
			this.Captura,
			this.columnHeader1});
			this.lstVoos.FullRowSelect = true;
			this.lstVoos.Location = new System.Drawing.Point(7, 9);
			this.lstVoos.MultiSelect = false;
			this.lstVoos.Name = "lstVoos";
			this.lstVoos.Size = new System.Drawing.Size(274, 240);
			this.lstVoos.TabIndex = 3;
			this.lstVoos.UseCompatibleStateImageBehavior = false;
			this.lstVoos.View = System.Windows.Forms.View.Details;
			this.lstVoos.SelectedIndexChanged += new System.EventHandler(this.LstVoosSelectedIndexChanged);
			// 
			// Data
			// 
			this.Data.Text = "Data";
			// 
			// Captura
			// 
			this.Captura.Text = "Captura";
			this.Captura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Nível de dor";
			this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader1.Width = 71;
			// 
			// rbtnCapturaNao
			// 
			this.rbtnCapturaNao.Location = new System.Drawing.Point(77, 107);
			this.rbtnCapturaNao.Name = "rbtnCapturaNao";
			this.rbtnCapturaNao.Size = new System.Drawing.Size(47, 24);
			this.rbtnCapturaNao.TabIndex = 10;
			this.rbtnCapturaNao.TabStop = true;
			this.rbtnCapturaNao.Text = "Nao";
			this.rbtnCapturaNao.UseVisualStyleBackColor = true;
			// 
			// rbtnCapturaSim
			// 
			this.rbtnCapturaSim.Location = new System.Drawing.Point(142, 108);
			this.rbtnCapturaSim.Name = "rbtnCapturaSim";
			this.rbtnCapturaSim.Size = new System.Drawing.Size(49, 24);
			this.rbtnCapturaSim.TabIndex = 11;
			this.rbtnCapturaSim.TabStop = true;
			this.rbtnCapturaSim.Text = "Sim";
			this.rbtnCapturaSim.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(5, 111);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 24);
			this.label1.TabIndex = 12;
			this.label1.Text = "Captura";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.txtCusto);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.txtDistancia);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.txtNivelDor);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.txtData);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.rbtnCapturaNao);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.rbtnCapturaSim);
			this.panel1.Location = new System.Drawing.Point(287, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 213);
			this.panel1.TabIndex = 13;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 178);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 22;
			this.button4.Text = "Salvar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(116, 177);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 21;
			this.button3.Text = "Cancelar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// txtCusto
			// 
			this.txtCusto.Location = new System.Drawing.Point(68, 43);
			this.txtCusto.Name = "txtCusto";
			this.txtCusto.Size = new System.Drawing.Size(123, 20);
			this.txtCusto.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.SystemColors.Control;
			this.label8.Location = new System.Drawing.Point(3, 46);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 17);
			this.label8.TabIndex = 19;
			this.label8.Text = "Custo";
			// 
			// txtDistancia
			// 
			this.txtDistancia.Location = new System.Drawing.Point(68, 78);
			this.txtDistancia.Name = "txtDistancia";
			this.txtDistancia.Size = new System.Drawing.Size(123, 20);
			this.txtDistancia.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.SystemColors.Control;
			this.label7.Location = new System.Drawing.Point(3, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 17);
			this.label7.TabIndex = 17;
			this.label7.Text = "Distancia";
			// 
			// txtNivelDor
			// 
			this.txtNivelDor.Location = new System.Drawing.Point(68, 147);
			this.txtNivelDor.Name = "txtNivelDor";
			this.txtNivelDor.Size = new System.Drawing.Size(123, 20);
			this.txtNivelDor.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.SystemColors.Control;
			this.label6.Location = new System.Drawing.Point(6, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 17);
			this.label6.TabIndex = 15;
			this.label6.Text = "Nivel dor";
			// 
			// txtData
			// 
			this.txtData.Location = new System.Drawing.Point(68, 6);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(123, 20);
			this.txtData.TabIndex = 14;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(3, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 14);
			this.label2.TabIndex = 13;
			this.label2.Text = "Data";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(293, 9);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Incluir";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(403, 9);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Excluir";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 261);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lstVoos);
			this.Name = "MainForm";
			this.Text = "FlightManager";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}
