namespace Gerenciador_Pedidos
{
    partial class VisualizarCompleto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTodosPedidos = new System.Windows.Forms.Button();
            this.btnPedidosHoje = new System.Windows.Forms.Button();
            this.btnFazer = new System.Windows.Forms.Button();
            this.btnAndamento = new System.Windows.Forms.Button();
            this.btnConcluido = new System.Windows.Forms.Button();
            this.btnCancelado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btncadastro = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 229);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1420, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnTodosPedidos
            // 
            this.btnTodosPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTodosPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTodosPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodosPedidos.FlatAppearance.BorderSize = 0;
            this.btnTodosPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTodosPedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodosPedidos.Location = new System.Drawing.Point(46, 172);
            this.btnTodosPedidos.Name = "btnTodosPedidos";
            this.btnTodosPedidos.Size = new System.Drawing.Size(194, 38);
            this.btnTodosPedidos.TabIndex = 1;
            this.btnTodosPedidos.Text = "Todos Pedidos";
            this.btnTodosPedidos.UseVisualStyleBackColor = false;
            this.btnTodosPedidos.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPedidosHoje
            // 
            this.btnPedidosHoje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPedidosHoje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPedidosHoje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidosHoje.FlatAppearance.BorderSize = 0;
            this.btnPedidosHoje.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidosHoje.Location = new System.Drawing.Point(261, 172);
            this.btnPedidosHoje.Name = "btnPedidosHoje";
            this.btnPedidosHoje.Size = new System.Drawing.Size(192, 38);
            this.btnPedidosHoje.TabIndex = 2;
            this.btnPedidosHoje.Text = "Pedidos de Hoje";
            this.btnPedidosHoje.UseVisualStyleBackColor = false;
            this.btnPedidosHoje.Click += new System.EventHandler(this.btnPedidosHoje_Click);
            // 
            // btnFazer
            // 
            this.btnFazer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnFazer.BackColor = System.Drawing.Color.Yellow;
            this.btnFazer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFazer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFazer.FlatAppearance.BorderSize = 0;
            this.btnFazer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFazer.Location = new System.Drawing.Point(477, 172);
            this.btnFazer.Name = "btnFazer";
            this.btnFazer.Size = new System.Drawing.Size(198, 38);
            this.btnFazer.TabIndex = 3;
            this.btnFazer.Text = "Pedidos Á Fazer";
            this.btnFazer.UseVisualStyleBackColor = false;
            this.btnFazer.Click += new System.EventHandler(this.btnFazer_Click);
            // 
            // btnAndamento
            // 
            this.btnAndamento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAndamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAndamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAndamento.FlatAppearance.BorderSize = 0;
            this.btnAndamento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAndamento.Location = new System.Drawing.Point(697, 172);
            this.btnAndamento.Name = "btnAndamento";
            this.btnAndamento.Size = new System.Drawing.Size(200, 38);
            this.btnAndamento.TabIndex = 4;
            this.btnAndamento.Text = "Pedidos Em Andamento";
            this.btnAndamento.UseVisualStyleBackColor = false;
            this.btnAndamento.Click += new System.EventHandler(this.btnAndamento_Click);
            // 
            // btnConcluido
            // 
            this.btnConcluido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConcluido.BackColor = System.Drawing.Color.Lime;
            this.btnConcluido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConcluido.FlatAppearance.BorderSize = 0;
            this.btnConcluido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConcluido.Location = new System.Drawing.Point(923, 172);
            this.btnConcluido.Name = "btnConcluido";
            this.btnConcluido.Size = new System.Drawing.Size(188, 38);
            this.btnConcluido.TabIndex = 5;
            this.btnConcluido.Text = "Pedidos Concluídos";
            this.btnConcluido.UseVisualStyleBackColor = false;
            this.btnConcluido.Click += new System.EventHandler(this.btnConcluido_Click);
            // 
            // btnCancelado
            // 
            this.btnCancelado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelado.BackColor = System.Drawing.Color.Red;
            this.btnCancelado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelado.FlatAppearance.BorderSize = 0;
            this.btnCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelado.Location = new System.Drawing.Point(1137, 172);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(183, 38);
            this.btnCancelado.TabIndex = 6;
            this.btnCancelado.Text = "Pedidos Cancelados";
            this.btnCancelado.UseVisualStyleBackColor = false;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alterar Status (com código):";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Location = new System.Drawing.Point(220, 96);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(108, 22);
            this.txtCodigo.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Á Fazer",
            "Em Produção",
            "Concluído",
            "Cancelado"});
            this.cbStatus.Location = new System.Drawing.Point(379, 96);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(136, 24);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Para:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConfirmar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(538, 91);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 32);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btncadastro
            // 
            this.btncadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btncadastro.BackColor = System.Drawing.Color.PeachPuff;
            this.btncadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncadastro.FlatAppearance.BorderSize = 0;
            this.btncadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncadastro.Location = new System.Drawing.Point(1098, 12);
            this.btncadastro.Name = "btncadastro";
            this.btncadastro.Size = new System.Drawing.Size(191, 35);
            this.btncadastro.TabIndex = 12;
            this.btncadastro.Text = "NOVO CADASTRAR";
            this.btncadastro.UseVisualStyleBackColor = false;
            this.btncadastro.Click += new System.EventHandler(this.btncadastro_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMenu.Location = new System.Drawing.Point(1305, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(112, 35);
            this.btnMenu.TabIndex = 13;
            this.btnMenu.Text = "MENU";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Jokerman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(676, 55);
            this.label3.TabIndex = 14;
            this.label3.Text = "ACOMPANHAMENTOS DE PEDIDOS";
            // 
            // VisualizarCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1420, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btncadastro);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.btnConcluido);
            this.Controls.Add(this.btnAndamento);
            this.Controls.Add(this.btnFazer);
            this.Controls.Add(this.btnPedidosHoje);
            this.Controls.Add(this.btnTodosPedidos);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VisualizarCompleto";
            this.Text = "\'";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.VisualizarCompleto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTodosPedidos;
        private System.Windows.Forms.Button btnPedidosHoje;
        private System.Windows.Forms.Button btnFazer;
        private System.Windows.Forms.Button btnAndamento;
        private System.Windows.Forms.Button btnConcluido;
        private System.Windows.Forms.Button btnCancelado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btncadastro;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label3;
    }
}