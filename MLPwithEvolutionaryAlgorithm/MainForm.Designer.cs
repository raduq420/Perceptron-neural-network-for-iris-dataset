
namespace MLPwithEvolutionaryAlgorithm
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
            this.groupBoxMLP = new System.Windows.Forms.GroupBox();
            this.comboBoxActivation = new System.Windows.Forms.ComboBox();
            this.textBoxMw35 = new System.Windows.Forms.TextBox();
            this.textBoxMw45 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxMt5 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxMw14 = new System.Windows.Forms.TextBox();
            this.textBoxMw24 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMt4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMt3 = new System.Windows.Forms.TextBox();
            this.textBoxMw13 = new System.Windows.Forms.TextBox();
            this.textBoxMw23 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.labelMutatie = new System.Windows.Forms.Label();
            this.labelIncrucisare = new System.Windows.Forms.Label();
            this.labelDimensiune = new System.Windows.Forms.Label();
            this.labelNumarMaxim = new System.Windows.Forms.Label();
            this.textBoxMutatie = new System.Windows.Forms.TextBox();
            this.textBoxIncrucisare = new System.Windows.Forms.TextBox();
            this.textBoxMaxGen = new System.Windows.Forms.TextBox();
            this.textBoxSizePop = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.pictureBoxRegions = new System.Windows.Forms.PictureBox();
            this.buttonDeseneaza = new System.Windows.Forms.Button();
            this.groupBoxMLP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegions)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMLP
            // 
            this.groupBoxMLP.Controls.Add(this.comboBoxActivation);
            this.groupBoxMLP.Controls.Add(this.textBoxMw35);
            this.groupBoxMLP.Controls.Add(this.textBoxMw45);
            this.groupBoxMLP.Controls.Add(this.label12);
            this.groupBoxMLP.Controls.Add(this.label13);
            this.groupBoxMLP.Controls.Add(this.textBoxMt5);
            this.groupBoxMLP.Controls.Add(this.label14);
            this.groupBoxMLP.Controls.Add(this.textBoxMw14);
            this.groupBoxMLP.Controls.Add(this.textBoxMw24);
            this.groupBoxMLP.Controls.Add(this.label10);
            this.groupBoxMLP.Controls.Add(this.label11);
            this.groupBoxMLP.Controls.Add(this.textBoxMt4);
            this.groupBoxMLP.Controls.Add(this.label9);
            this.groupBoxMLP.Controls.Add(this.textBoxMt3);
            this.groupBoxMLP.Controls.Add(this.textBoxMw13);
            this.groupBoxMLP.Controls.Add(this.textBoxMw23);
            this.groupBoxMLP.Controls.Add(this.label8);
            this.groupBoxMLP.Controls.Add(this.label7);
            this.groupBoxMLP.Controls.Add(this.label6);
            this.groupBoxMLP.Location = new System.Drawing.Point(236, 2);
            this.groupBoxMLP.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMLP.Name = "groupBoxMLP";
            this.groupBoxMLP.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMLP.Size = new System.Drawing.Size(334, 199);
            this.groupBoxMLP.TabIndex = 4;
            this.groupBoxMLP.TabStop = false;
            this.groupBoxMLP.Text = "Perceptron multistrat";
            // 
            // comboBoxActivation
            // 
            this.comboBoxActivation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxActivation.FormattingEnabled = true;
            this.comboBoxActivation.Items.AddRange(new object[] {
            "Functie de activare prag",
            "Functie de activare semiliniara",
            "Functie de activare sigmoida unipolara"});
            this.comboBoxActivation.Location = new System.Drawing.Point(25, 170);
            this.comboBoxActivation.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxActivation.Name = "comboBoxActivation";
            this.comboBoxActivation.Size = new System.Drawing.Size(283, 21);
            this.comboBoxActivation.TabIndex = 27;
            this.comboBoxActivation.SelectedIndexChanged += new System.EventHandler(this.comboBoxActivation_SelectedIndexChanged);
            // 
            // textBoxMw35
            // 
            this.textBoxMw35.Location = new System.Drawing.Point(222, 32);
            this.textBoxMw35.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw35.Name = "textBoxMw35";
            this.textBoxMw35.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw35.TabIndex = 22;
            // 
            // textBoxMw45
            // 
            this.textBoxMw45.Location = new System.Drawing.Point(222, 55);
            this.textBoxMw45.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw45.Name = "textBoxMw45";
            this.textBoxMw45.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw45.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "w35";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "w45";
            // 
            // textBoxMt5
            // 
            this.textBoxMt5.Location = new System.Drawing.Point(222, 78);
            this.textBoxMt5.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMt5.Name = "textBoxMt5";
            this.textBoxMt5.Size = new System.Drawing.Size(76, 20);
            this.textBoxMt5.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(174, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "t5";
            // 
            // textBoxMw14
            // 
            this.textBoxMw14.Location = new System.Drawing.Point(70, 78);
            this.textBoxMw14.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw14.Name = "textBoxMw14";
            this.textBoxMw14.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw14.TabIndex = 16;
            // 
            // textBoxMw24
            // 
            this.textBoxMw24.Location = new System.Drawing.Point(70, 101);
            this.textBoxMw24.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw24.Name = "textBoxMw24";
            this.textBoxMw24.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw24.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "w14";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 103);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "w24";
            // 
            // textBoxMt4
            // 
            this.textBoxMt4.Location = new System.Drawing.Point(70, 146);
            this.textBoxMt4.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMt4.Name = "textBoxMt4";
            this.textBoxMt4.Size = new System.Drawing.Size(76, 20);
            this.textBoxMt4.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "t4";
            // 
            // textBoxMt3
            // 
            this.textBoxMt3.Location = new System.Drawing.Point(70, 124);
            this.textBoxMt3.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMt3.Name = "textBoxMt3";
            this.textBoxMt3.Size = new System.Drawing.Size(76, 20);
            this.textBoxMt3.TabIndex = 11;
            // 
            // textBoxMw13
            // 
            this.textBoxMw13.Location = new System.Drawing.Point(70, 32);
            this.textBoxMw13.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw13.Name = "textBoxMw13";
            this.textBoxMw13.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw13.TabIndex = 9;
            // 
            // textBoxMw23
            // 
            this.textBoxMw23.Location = new System.Drawing.Point(70, 55);
            this.textBoxMw23.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMw23.Name = "textBoxMw23";
            this.textBoxMw23.Size = new System.Drawing.Size(76, 20);
            this.textBoxMw23.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "w13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "w23";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "t3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTrain);
            this.groupBox1.Controls.Add(this.labelMutatie);
            this.groupBox1.Controls.Add(this.labelIncrucisare);
            this.groupBox1.Controls.Add(this.labelDimensiune);
            this.groupBox1.Controls.Add(this.labelNumarMaxim);
            this.groupBox1.Controls.Add(this.textBoxMutatie);
            this.groupBox1.Controls.Add(this.textBoxIncrucisare);
            this.groupBox1.Controls.Add(this.textBoxMaxGen);
            this.groupBox1.Controls.Add(this.textBoxSizePop);
            this.groupBox1.Location = new System.Drawing.Point(10, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(203, 199);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algoritm evolutiv";
            // 
            // buttonTrain
            // 
            this.buttonTrain.Location = new System.Drawing.Point(95, 159);
            this.buttonTrain.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(94, 26);
            this.buttonTrain.TabIndex = 32;
            this.buttonTrain.Text = "Antreneaza";
            this.buttonTrain.UseVisualStyleBackColor = true;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // labelMutatie
            // 
            this.labelMutatie.AutoSize = true;
            this.labelMutatie.Location = new System.Drawing.Point(68, 129);
            this.labelMutatie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMutatie.Name = "labelMutatie";
            this.labelMutatie.Size = new System.Drawing.Size(67, 13);
            this.labelMutatie.TabIndex = 7;
            this.labelMutatie.Text = "Rata mutatie";
            // 
            // labelIncrucisare
            // 
            this.labelIncrucisare.AutoSize = true;
            this.labelIncrucisare.Location = new System.Drawing.Point(51, 103);
            this.labelIncrucisare.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIncrucisare.Name = "labelIncrucisare";
            this.labelIncrucisare.Size = new System.Drawing.Size(84, 13);
            this.labelIncrucisare.TabIndex = 6;
            this.labelIncrucisare.Text = "Rata incrucisare";
            // 
            // labelDimensiune
            // 
            this.labelDimensiune.AutoSize = true;
            this.labelDimensiune.Location = new System.Drawing.Point(16, 52);
            this.labelDimensiune.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDimensiune.Name = "labelDimensiune";
            this.labelDimensiune.Size = new System.Drawing.Size(116, 13);
            this.labelDimensiune.TabIndex = 5;
            this.labelDimensiune.Text = "Dimensiunea populatiei";
            // 
            // labelNumarMaxim
            // 
            this.labelNumarMaxim.AutoSize = true;
            this.labelNumarMaxim.Location = new System.Drawing.Point(7, 80);
            this.labelNumarMaxim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumarMaxim.Name = "labelNumarMaxim";
            this.labelNumarMaxim.Size = new System.Drawing.Size(128, 13);
            this.labelNumarMaxim.TabIndex = 4;
            this.labelNumarMaxim.Text = "Numar maxim de generatii";
            // 
            // textBoxMutatie
            // 
            this.textBoxMutatie.Location = new System.Drawing.Point(139, 126);
            this.textBoxMutatie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMutatie.Name = "textBoxMutatie";
            this.textBoxMutatie.Size = new System.Drawing.Size(50, 20);
            this.textBoxMutatie.TabIndex = 3;
            // 
            // textBoxIncrucisare
            // 
            this.textBoxIncrucisare.Location = new System.Drawing.Point(139, 101);
            this.textBoxIncrucisare.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIncrucisare.Name = "textBoxIncrucisare";
            this.textBoxIncrucisare.Size = new System.Drawing.Size(50, 20);
            this.textBoxIncrucisare.TabIndex = 2;
            // 
            // textBoxMaxGen
            // 
            this.textBoxMaxGen.Location = new System.Drawing.Point(139, 73);
            this.textBoxMaxGen.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxMaxGen.Name = "textBoxMaxGen";
            this.textBoxMaxGen.Size = new System.Drawing.Size(50, 20);
            this.textBoxMaxGen.TabIndex = 1;
            // 
            // textBoxSizePop
            // 
            this.textBoxSizePop.Location = new System.Drawing.Point(139, 49);
            this.textBoxSizePop.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSizePop.Name = "textBoxSizePop";
            this.textBoxSizePop.Size = new System.Drawing.Size(50, 20);
            this.textBoxSizePop.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 247);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(132, 382);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(13, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(5, 330);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "0";
            // 
            // textBoxResults
            // 
            this.textBoxResults.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxResults.Location = new System.Drawing.Point(190, 215);
            this.textBoxResults.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.Size = new System.Drawing.Size(188, 163);
            this.textBoxResults.TabIndex = 20;
            // 
            // pictureBoxRegions
            // 
            this.pictureBoxRegions.Location = new System.Drawing.Point(23, 215);
            this.pictureBoxRegions.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRegions.Name = "pictureBoxRegions";
            this.pictureBoxRegions.Size = new System.Drawing.Size(150, 162);
            this.pictureBoxRegions.TabIndex = 19;
            this.pictureBoxRegions.TabStop = false;
            this.pictureBoxRegions.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxRegions_Paint);
            // 
            // buttonDeseneaza
            // 
            this.buttonDeseneaza.Location = new System.Drawing.Point(81, 419);
            this.buttonDeseneaza.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDeseneaza.Name = "buttonDeseneaza";
            this.buttonDeseneaza.Size = new System.Drawing.Size(152, 26);
            this.buttonDeseneaza.TabIndex = 26;
            this.buttonDeseneaza.Text = "Deseneaza";
            this.buttonDeseneaza.UseVisualStyleBackColor = true;
            this.buttonDeseneaza.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 479);
            this.Controls.Add(this.buttonDeseneaza);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.pictureBoxRegions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxMLP);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MLP with Evolutionary Algorithm";
            this.groupBoxMLP.ResumeLayout(false);
            this.groupBoxMLP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMLP;
        private System.Windows.Forms.TextBox textBoxMw35;
        private System.Windows.Forms.TextBox textBoxMw45;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxMt5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxMw14;
        private System.Windows.Forms.TextBox textBoxMw24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMt4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMt3;
        private System.Windows.Forms.TextBox textBoxMw13;
        private System.Windows.Forms.TextBox textBoxMw23;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelMutatie;
        private System.Windows.Forms.Label labelIncrucisare;
        private System.Windows.Forms.Label labelDimensiune;
        private System.Windows.Forms.Label labelNumarMaxim;
        private System.Windows.Forms.TextBox textBoxMutatie;
        private System.Windows.Forms.TextBox textBoxIncrucisare;
        private System.Windows.Forms.TextBox textBoxMaxGen;
        private System.Windows.Forms.TextBox textBoxSizePop;
        private System.Windows.Forms.ComboBox comboBoxActivation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxResults;
        private System.Windows.Forms.PictureBox pictureBoxRegions;
        private System.Windows.Forms.Button buttonDeseneaza;
    }
}

