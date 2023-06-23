namespace AutomationDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_mapear = new System.Windows.Forms.Button();
            this.bt_parar = new System.Windows.Forms.Button();
            this.bt_add_texto = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.lbl_x = new System.Windows.Forms.Label();
            this.lbl_y = new System.Windows.Forms.Label();
            this.lv_itens = new System.Windows.Forms.ListView();
            this.step = new System.Windows.Forms.ColumnHeader();
            this.Tipoe = new System.Windows.Forms.ColumnHeader();
            this.value = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // bt_mapear
            // 
            this.bt_mapear.Location = new System.Drawing.Point(171, 23);
            this.bt_mapear.Name = "bt_mapear";
            this.bt_mapear.Size = new System.Drawing.Size(75, 23);
            this.bt_mapear.TabIndex = 0;
            this.bt_mapear.Text = "MAPEAR";
            this.bt_mapear.UseVisualStyleBackColor = true;
            this.bt_mapear.Click += new System.EventHandler(this.bt_mapear_Click);
            // 
            // bt_parar
            // 
            this.bt_parar.Location = new System.Drawing.Point(262, 23);
            this.bt_parar.Name = "bt_parar";
            this.bt_parar.Size = new System.Drawing.Size(75, 23);
            this.bt_parar.TabIndex = 1;
            this.bt_parar.Text = "PARAR";
            this.bt_parar.UseVisualStyleBackColor = true;
            this.bt_parar.Visible = false;
            this.bt_parar.Click += new System.EventHandler(this.bt_parar_Click);
            // 
            // bt_add_texto
            // 
            this.bt_add_texto.Location = new System.Drawing.Point(171, 64);
            this.bt_add_texto.Name = "bt_add_texto";
            this.bt_add_texto.Size = new System.Drawing.Size(166, 23);
            this.bt_add_texto.TabIndex = 2;
            this.bt_add_texto.Text = "ADICIONAR TEXTO";
            this.bt_add_texto.UseVisualStyleBackColor = true;
            this.bt_add_texto.Click += new System.EventHandler(this.bt_add_texto_Click);
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(171, 104);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(166, 23);
            this.bt_start.TabIndex = 3;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // lbl_x
            // 
            this.lbl_x.AutoSize = true;
            this.lbl_x.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_x.Location = new System.Drawing.Point(25, 23);
            this.lbl_x.Name = "lbl_x";
            this.lbl_x.Size = new System.Drawing.Size(22, 21);
            this.lbl_x.TabIndex = 4;
            this.lbl_x.Text = "X:";
            // 
            // lbl_y
            // 
            this.lbl_y.AutoSize = true;
            this.lbl_y.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_y.Location = new System.Drawing.Point(25, 66);
            this.lbl_y.Name = "lbl_y";
            this.lbl_y.Size = new System.Drawing.Size(22, 21);
            this.lbl_y.TabIndex = 5;
            this.lbl_y.Text = "Y:";
            // 
            // lv_itens
            // 
            this.lv_itens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.step,
            this.Tipoe,
            this.value});
            this.lv_itens.Location = new System.Drawing.Point(0, 145);
            this.lv_itens.Name = "lv_itens";
            this.lv_itens.Size = new System.Drawing.Size(384, 213);
            this.lv_itens.TabIndex = 6;
            this.lv_itens.UseCompatibleStateImageBehavior = false;
            this.lv_itens.View = System.Windows.Forms.View.Details;
            // 
            // step
            // 
            this.step.Text = "Etapa";
            // 
            // Tipoe
            // 
            this.Tipoe.Text = "Tipo";
            this.Tipoe.Width = 120;
            // 
            // value
            // 
            this.value.Text = "Valor";
            this.value.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 356);
            this.Controls.Add(this.lv_itens);
            this.Controls.Add(this.lbl_y);
            this.Controls.Add(this.lbl_x);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_add_texto);
            this.Controls.Add(this.bt_parar);
            this.Controls.Add(this.bt_mapear);
            this.Name = "Form1";
            this.Text = "Painel - IDE";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_mapear;
        private Button bt_parar;
        private Button bt_add_texto;
        private Button bt_start;
        private Label lbl_x;
        private Label lbl_y;
        private ListView lv_itens;
        private ColumnHeader step;
        private ColumnHeader Tipoe;
        private ColumnHeader value;
    }
}