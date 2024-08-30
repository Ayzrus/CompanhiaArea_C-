namespace CompanhiaArea
{
    partial class Companhia
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
            tabControl1 = new TabControl();
            Voos = new TabPage();
            tabControl2 = new TabControl();
            Ver = new TabPage();
            dataGridViewVoos = new DataGridView();
            Criar = new TabPage();
            RegistarVoo = new Button();
            dateTimePickerData = new DateTimePicker();
            comboBoxNumAviao = new ComboBox();
            comboBoxDestino = new ComboBox();
            comboBoxOrigem = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBoxNVoo = new TextBox();
            N_Voo = new Label();
            InfoVoo = new TabPage();
            dataGridViewVooTr = new DataGridView();
            label12 = new Label();
            comboBoxVooTri = new ComboBox();
            Viagens = new TabPage();
            tabControl5 = new TabControl();
            VerVia = new TabPage();
            dataGridViewViagens = new DataGridView();
            ApagarVia = new TabPage();
            textBoxId = new TextBox();
            label11 = new Label();
            Apagar = new Button();
            Passageiros = new TabPage();
            tabControl3 = new TabControl();
            VerPass = new TabPage();
            dataGridViewPassageiros = new DataGridView();
            CriarPass = new TabPage();
            EditarPass = new TabPage();
            Aeroportos = new TabPage();
            tabControl4 = new TabControl();
            VerAero = new TabPage();
            dataGridViewAero = new DataGridView();
            CriarAero = new TabPage();
            RegistarAero = new Button();
            PaisBox = new TextBox();
            label6 = new Label();
            LocalBox = new TextBox();
            label5 = new Label();
            LongitudeBox = new TextBox();
            label4 = new Label();
            LatitudeBox = new TextBox();
            label3 = new Label();
            NomeBox = new TextBox();
            label2 = new Label();
            CodigoBox = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            Voos.SuspendLayout();
            tabControl2.SuspendLayout();
            Ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoos).BeginInit();
            Criar.SuspendLayout();
            InfoVoo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVooTr).BeginInit();
            Viagens.SuspendLayout();
            tabControl5.SuspendLayout();
            VerVia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewViagens).BeginInit();
            ApagarVia.SuspendLayout();
            Passageiros.SuspendLayout();
            tabControl3.SuspendLayout();
            VerPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPassageiros).BeginInit();
            Aeroportos.SuspendLayout();
            tabControl4.SuspendLayout();
            VerAero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAero).BeginInit();
            CriarAero.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Voos);
            tabControl1.Controls.Add(Viagens);
            tabControl1.Controls.Add(Passageiros);
            tabControl1.Controls.Add(Aeroportos);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1093, 614);
            tabControl1.TabIndex = 1;
            // 
            // Voos
            // 
            Voos.Controls.Add(tabControl2);
            Voos.Location = new Point(4, 24);
            Voos.Name = "Voos";
            Voos.Padding = new Padding(3);
            Voos.Size = new Size(1085, 586);
            Voos.TabIndex = 0;
            Voos.Text = "Voos";
            Voos.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(Ver);
            tabControl2.Controls.Add(Criar);
            tabControl2.Controls.Add(InfoVoo);
            tabControl2.Location = new Point(3, 99);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1079, 481);
            tabControl2.TabIndex = 1;
            // 
            // Ver
            // 
            Ver.Controls.Add(dataGridViewVoos);
            Ver.Location = new Point(4, 24);
            Ver.Name = "Ver";
            Ver.Padding = new Padding(3);
            Ver.Size = new Size(1071, 453);
            Ver.TabIndex = 0;
            Ver.Text = "Ver";
            Ver.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVoos
            // 
            dataGridViewVoos.BackgroundColor = Color.White;
            dataGridViewVoos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoos.Location = new Point(6, 6);
            dataGridViewVoos.Name = "dataGridViewVoos";
            dataGridViewVoos.ReadOnly = true;
            dataGridViewVoos.Size = new Size(1059, 441);
            dataGridViewVoos.TabIndex = 0;
            // 
            // Criar
            // 
            Criar.Controls.Add(RegistarVoo);
            Criar.Controls.Add(dateTimePickerData);
            Criar.Controls.Add(comboBoxNumAviao);
            Criar.Controls.Add(comboBoxDestino);
            Criar.Controls.Add(comboBoxOrigem);
            Criar.Controls.Add(label10);
            Criar.Controls.Add(label9);
            Criar.Controls.Add(label8);
            Criar.Controls.Add(label7);
            Criar.Controls.Add(textBoxNVoo);
            Criar.Controls.Add(N_Voo);
            Criar.Location = new Point(4, 24);
            Criar.Name = "Criar";
            Criar.Padding = new Padding(3);
            Criar.Size = new Size(1071, 453);
            Criar.TabIndex = 1;
            Criar.Text = "Criar";
            Criar.UseVisualStyleBackColor = true;
            // 
            // RegistarVoo
            // 
            RegistarVoo.Location = new Point(6, 356);
            RegistarVoo.Name = "RegistarVoo";
            RegistarVoo.Size = new Size(144, 34);
            RegistarVoo.TabIndex = 13;
            RegistarVoo.Text = "Registar";
            RegistarVoo.UseVisualStyleBackColor = true;
            RegistarVoo.Click += RegistarVoo_Click;
            // 
            // dateTimePickerData
            // 
            dateTimePickerData.Location = new Point(6, 108);
            dateTimePickerData.Name = "dateTimePickerData";
            dateTimePickerData.Size = new Size(167, 23);
            dateTimePickerData.TabIndex = 12;
            // 
            // comboBoxNumAviao
            // 
            comboBoxNumAviao.FormattingEnabled = true;
            comboBoxNumAviao.Location = new Point(6, 313);
            comboBoxNumAviao.Name = "comboBoxNumAviao";
            comboBoxNumAviao.Size = new Size(144, 23);
            comboBoxNumAviao.TabIndex = 11;
            // 
            // comboBoxDestino
            // 
            comboBoxDestino.FormattingEnabled = true;
            comboBoxDestino.Location = new Point(6, 248);
            comboBoxDestino.Name = "comboBoxDestino";
            comboBoxDestino.Size = new Size(144, 23);
            comboBoxDestino.TabIndex = 10;
            // 
            // comboBoxOrigem
            // 
            comboBoxOrigem.FormattingEnabled = true;
            comboBoxOrigem.Location = new Point(6, 179);
            comboBoxOrigem.Name = "comboBoxOrigem";
            comboBoxOrigem.Size = new Size(144, 23);
            comboBoxOrigem.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 284);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 8;
            label10.Text = "Número do Avião";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 215);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 6;
            label9.Text = "Destino";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 150);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 4;
            label8.Text = "Origem";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 79);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 2;
            label7.Text = "Data";
            // 
            // textBoxNVoo
            // 
            textBoxNVoo.Location = new Point(6, 41);
            textBoxNVoo.Name = "textBoxNVoo";
            textBoxNVoo.Size = new Size(144, 23);
            textBoxNVoo.TabIndex = 1;
            // 
            // N_Voo
            // 
            N_Voo.AutoSize = true;
            N_Voo.Location = new Point(6, 14);
            N_Voo.Name = "N_Voo";
            N_Voo.Size = new Size(91, 15);
            N_Voo.TabIndex = 0;
            N_Voo.Text = "Número do Voo";
            // 
            // InfoVoo
            // 
            InfoVoo.Controls.Add(dataGridViewVooTr);
            InfoVoo.Controls.Add(label12);
            InfoVoo.Controls.Add(comboBoxVooTri);
            InfoVoo.Location = new Point(4, 24);
            InfoVoo.Name = "InfoVoo";
            InfoVoo.Size = new Size(1071, 453);
            InfoVoo.TabIndex = 2;
            InfoVoo.Text = "Ver Informações do Voo";
            InfoVoo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVooTr
            // 
            dataGridViewVooTr.BackgroundColor = Color.White;
            dataGridViewVooTr.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVooTr.Location = new Point(3, 97);
            dataGridViewVooTr.Name = "dataGridViewVooTr";
            dataGridViewVooTr.ReadOnly = true;
            dataGridViewVooTr.Size = new Size(1065, 353);
            dataGridViewVooTr.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 14);
            label12.Name = "label12";
            label12.Size = new Size(101, 15);
            label12.TabIndex = 1;
            label12.Text = "Selecione um Voo";
            // 
            // comboBoxVooTri
            // 
            comboBoxVooTri.FormattingEnabled = true;
            comboBoxVooTri.Location = new Point(3, 42);
            comboBoxVooTri.Name = "comboBoxVooTri";
            comboBoxVooTri.Size = new Size(121, 23);
            comboBoxVooTri.TabIndex = 0;
            comboBoxVooTri.SelectedIndexChanged += comboBoxVooTri_SelectedIndexChanged;
            // 
            // Viagens
            // 
            Viagens.Controls.Add(tabControl5);
            Viagens.Location = new Point(4, 24);
            Viagens.Name = "Viagens";
            Viagens.Padding = new Padding(3);
            Viagens.Size = new Size(1085, 586);
            Viagens.TabIndex = 1;
            Viagens.Text = "Viagens";
            Viagens.UseVisualStyleBackColor = true;
            // 
            // tabControl5
            // 
            tabControl5.Controls.Add(VerVia);
            tabControl5.Controls.Add(ApagarVia);
            tabControl5.Location = new Point(3, 99);
            tabControl5.Name = "tabControl5";
            tabControl5.SelectedIndex = 0;
            tabControl5.Size = new Size(1079, 481);
            tabControl5.TabIndex = 1;
            // 
            // VerVia
            // 
            VerVia.Controls.Add(dataGridViewViagens);
            VerVia.Location = new Point(4, 24);
            VerVia.Name = "VerVia";
            VerVia.Padding = new Padding(3);
            VerVia.Size = new Size(1071, 453);
            VerVia.TabIndex = 0;
            VerVia.Text = "Ver";
            VerVia.UseVisualStyleBackColor = true;
            // 
            // dataGridViewViagens
            // 
            dataGridViewViagens.BackgroundColor = Color.White;
            dataGridViewViagens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewViagens.Location = new Point(6, 6);
            dataGridViewViagens.Name = "dataGridViewViagens";
            dataGridViewViagens.ReadOnly = true;
            dataGridViewViagens.Size = new Size(1059, 441);
            dataGridViewViagens.TabIndex = 0;
            // 
            // ApagarVia
            // 
            ApagarVia.Controls.Add(textBoxId);
            ApagarVia.Controls.Add(label11);
            ApagarVia.Controls.Add(Apagar);
            ApagarVia.Location = new Point(4, 24);
            ApagarVia.Name = "ApagarVia";
            ApagarVia.Padding = new Padding(3);
            ApagarVia.Size = new Size(1071, 453);
            ApagarVia.TabIndex = 1;
            ApagarVia.Text = "Apagar";
            ApagarVia.UseVisualStyleBackColor = true;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(6, 41);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(169, 23);
            textBoxId.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 12);
            label11.Name = "label11";
            label11.Size = new Size(76, 15);
            label11.TabIndex = 1;
            label11.Text = "Id da Viagem";
            // 
            // Apagar
            // 
            Apagar.Location = new Point(6, 88);
            Apagar.Name = "Apagar";
            Apagar.Size = new Size(169, 34);
            Apagar.TabIndex = 0;
            Apagar.Text = "Apagar";
            Apagar.UseVisualStyleBackColor = true;
            Apagar.Click += Apagar_Click;
            // 
            // Passageiros
            // 
            Passageiros.Controls.Add(tabControl3);
            Passageiros.Location = new Point(4, 24);
            Passageiros.Name = "Passageiros";
            Passageiros.Size = new Size(1085, 586);
            Passageiros.TabIndex = 2;
            Passageiros.Text = "Passageiros";
            Passageiros.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(VerPass);
            tabControl3.Controls.Add(CriarPass);
            tabControl3.Controls.Add(EditarPass);
            tabControl3.Location = new Point(3, 99);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(1079, 484);
            tabControl3.TabIndex = 1;
            // 
            // VerPass
            // 
            VerPass.Controls.Add(dataGridViewPassageiros);
            VerPass.Location = new Point(4, 24);
            VerPass.Name = "VerPass";
            VerPass.Padding = new Padding(3);
            VerPass.Size = new Size(1071, 456);
            VerPass.TabIndex = 0;
            VerPass.Text = "Ver";
            VerPass.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPassageiros
            // 
            dataGridViewPassageiros.BackgroundColor = Color.White;
            dataGridViewPassageiros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPassageiros.Location = new Point(6, 6);
            dataGridViewPassageiros.Name = "dataGridViewPassageiros";
            dataGridViewPassageiros.ReadOnly = true;
            dataGridViewPassageiros.Size = new Size(1059, 441);
            dataGridViewPassageiros.TabIndex = 0;
            // 
            // CriarPass
            // 
            CriarPass.Location = new Point(4, 24);
            CriarPass.Name = "CriarPass";
            CriarPass.Padding = new Padding(3);
            CriarPass.Size = new Size(1071, 456);
            CriarPass.TabIndex = 1;
            CriarPass.Text = "Criar";
            CriarPass.UseVisualStyleBackColor = true;
            // 
            // EditarPass
            // 
            EditarPass.Location = new Point(4, 24);
            EditarPass.Name = "EditarPass";
            EditarPass.Size = new Size(1071, 456);
            EditarPass.TabIndex = 2;
            EditarPass.Text = "Editar";
            EditarPass.UseVisualStyleBackColor = true;
            // 
            // Aeroportos
            // 
            Aeroportos.Controls.Add(tabControl4);
            Aeroportos.Location = new Point(4, 24);
            Aeroportos.Name = "Aeroportos";
            Aeroportos.Size = new Size(1085, 586);
            Aeroportos.TabIndex = 3;
            Aeroportos.Text = "Aeroportos";
            Aeroportos.UseVisualStyleBackColor = true;
            // 
            // tabControl4
            // 
            tabControl4.Controls.Add(VerAero);
            tabControl4.Controls.Add(CriarAero);
            tabControl4.Location = new Point(3, 102);
            tabControl4.Name = "tabControl4";
            tabControl4.SelectedIndex = 0;
            tabControl4.Size = new Size(1079, 481);
            tabControl4.TabIndex = 1;
            // 
            // VerAero
            // 
            VerAero.Controls.Add(dataGridViewAero);
            VerAero.Location = new Point(4, 24);
            VerAero.Name = "VerAero";
            VerAero.Padding = new Padding(3);
            VerAero.Size = new Size(1071, 453);
            VerAero.TabIndex = 0;
            VerAero.Text = "Ver";
            VerAero.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAero
            // 
            dataGridViewAero.BackgroundColor = Color.White;
            dataGridViewAero.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAero.Location = new Point(6, 6);
            dataGridViewAero.Name = "dataGridViewAero";
            dataGridViewAero.ReadOnly = true;
            dataGridViewAero.Size = new Size(1059, 441);
            dataGridViewAero.TabIndex = 0;
            // 
            // CriarAero
            // 
            CriarAero.Controls.Add(RegistarAero);
            CriarAero.Controls.Add(PaisBox);
            CriarAero.Controls.Add(label6);
            CriarAero.Controls.Add(LocalBox);
            CriarAero.Controls.Add(label5);
            CriarAero.Controls.Add(LongitudeBox);
            CriarAero.Controls.Add(label4);
            CriarAero.Controls.Add(LatitudeBox);
            CriarAero.Controls.Add(label3);
            CriarAero.Controls.Add(NomeBox);
            CriarAero.Controls.Add(label2);
            CriarAero.Controls.Add(CodigoBox);
            CriarAero.Controls.Add(label1);
            CriarAero.Location = new Point(4, 24);
            CriarAero.Name = "CriarAero";
            CriarAero.Padding = new Padding(3);
            CriarAero.Size = new Size(1071, 453);
            CriarAero.TabIndex = 1;
            CriarAero.Text = "Criar";
            CriarAero.UseVisualStyleBackColor = true;
            // 
            // RegistarAero
            // 
            RegistarAero.Cursor = Cursors.Hand;
            RegistarAero.Location = new Point(6, 414);
            RegistarAero.Name = "RegistarAero";
            RegistarAero.Size = new Size(127, 33);
            RegistarAero.TabIndex = 12;
            RegistarAero.Text = "Registar";
            RegistarAero.UseVisualStyleBackColor = true;
            RegistarAero.Click += RegistarAero_Click;
            // 
            // PaisBox
            // 
            PaisBox.Location = new Point(6, 373);
            PaisBox.Name = "PaisBox";
            PaisBox.Size = new Size(127, 23);
            PaisBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 345);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 10;
            label6.Text = "País";
            // 
            // LocalBox
            // 
            LocalBox.Location = new Point(6, 311);
            LocalBox.Name = "LocalBox";
            LocalBox.Size = new Size(127, 23);
            LocalBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 283);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 8;
            label5.Text = "Local";
            // 
            // LongitudeBox
            // 
            LongitudeBox.Location = new Point(6, 247);
            LongitudeBox.Name = "LongitudeBox";
            LongitudeBox.Size = new Size(127, 23);
            LongitudeBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 219);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 6;
            label4.Text = "Longitude";
            // 
            // LatitudeBox
            // 
            LatitudeBox.Location = new Point(6, 185);
            LatitudeBox.Name = "LatitudeBox";
            LatitudeBox.Size = new Size(127, 23);
            LatitudeBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 4;
            label3.Text = "Latitude";
            // 
            // NomeBox
            // 
            NomeBox.Location = new Point(6, 120);
            NomeBox.Name = "NomeBox";
            NomeBox.Size = new Size(127, 23);
            NomeBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // CodigoBox
            // 
            CodigoBox.Location = new Point(6, 51);
            CodigoBox.Name = "CodigoBox";
            CodigoBox.Size = new Size(127, 23);
            CodigoBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // Companhia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 641);
            Controls.Add(tabControl1);
            MaximumSize = new Size(1140, 680);
            MinimumSize = new Size(1140, 680);
            Name = "Companhia";
            Text = "Companhia Área";
            Load += Companhia_Load;
            tabControl1.ResumeLayout(false);
            Voos.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            Ver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoos).EndInit();
            Criar.ResumeLayout(false);
            Criar.PerformLayout();
            InfoVoo.ResumeLayout(false);
            InfoVoo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVooTr).EndInit();
            Viagens.ResumeLayout(false);
            tabControl5.ResumeLayout(false);
            VerVia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewViagens).EndInit();
            ApagarVia.ResumeLayout(false);
            ApagarVia.PerformLayout();
            Passageiros.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            VerPass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPassageiros).EndInit();
            Aeroportos.ResumeLayout(false);
            tabControl4.ResumeLayout(false);
            VerAero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAero).EndInit();
            CriarAero.ResumeLayout(false);
            CriarAero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tabControl1;
        private TabPage Voos;
        private TabPage Viagens;
        private TabPage Passageiros;
        private TabPage Aeroportos;
        private DataGridView dataGridViewVoos;
        private DataGridView dataGridViewViagens;
        private DataGridView dataGridViewPassageiros;
        private DataGridView dataGridViewAero;
        private TabControl tabControl2;
        private TabPage Ver;
        private TabPage Criar;
        private TabControl tabControl3;
        private TabPage VerPass;
        private TabPage CriarPass;
        private TabControl tabControl4;
        private TabPage VerAero;
        private TabPage CriarAero;
        private TabControl tabControl5;
        private TabPage VerVia;
        private TabPage ApagarVia;
        private TabPage EditarPass;
        private TextBox CodigoBox;
        private Label label1;
        private TextBox NomeBox;
        private Label label2;
        private TextBox LongitudeBox;
        private Label label4;
        private TextBox LatitudeBox;
        private Label label3;
        private TextBox PaisBox;
        private Label label6;
        private TextBox LocalBox;
        private Label label5;
        private Button RegistarAero;
        private TextBox textBoxNVoo;
        private Label N_Voo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label10;
        private ComboBox comboBoxDestino;
        private ComboBox comboBoxOrigem;
        private ComboBox comboBoxNumAviao;
        private DateTimePicker dateTimePickerData;
        private Button RegistarVoo;
        private TextBox textBoxId;
        private Label label11;
        private Button Apagar;
        private TabPage InfoVoo;
        private Label label12;
        private ComboBox comboBoxVooTri;
        private DataGridView dataGridViewVooTr;
    }
}
