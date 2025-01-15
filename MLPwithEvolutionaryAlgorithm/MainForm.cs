using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLPwithEvolutionaryAlgorithm
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// functia de activare a retelei: prag, semiliniara sau sigmoida unipolara
        /// </summary>
        private Func<double, double> ActivationFunction;

        private double w13, w23, w14, w24, t3, t4, w35, w45, t5; // ponderile si pragurile
        public MainForm()
        {
            InitializeComponent();
            comboBoxActivation.SelectedIndex = 0;
            ActivationFunction = StepActivation; // functia de activare implicita este functia prag
        }
        /// <summary>
        /// Functia de activare prag
        /// </summary>
        private double StepActivation(double x)
        {
            return (x >= 0) ? 1 : 0;
        }

        /// <summary>
        /// Functia de activare semiliniara
        /// </summary>
        private double SemiliniarActivation(double x)
        {
            return (x >= 1) ? 1 : ((x <= 0) ? 0 : x);
        }

        /// <summary>
        /// Functia de activare sigmoida unipolara
        /// </summary>
        private double SigmoidActivation(double x)
        {
            return 1 / (1 + Math.Exp(-x));
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// Converteste numerele citite ca text din interfata in valori reale
        /// </summary>
        private double ConvertToDouble(string s)
        {
            if (s.Contains(","))
                MessageBox.Show("Folositi punctul ca separator! (" + s + ")");

            try
            {
                CultureInfo ci = (CultureInfo)(CultureInfo.CurrentCulture.Clone());
                ci.NumberFormat.NumberDecimalSeparator = ".";
                return Convert.ToDouble(s, ci);
            }
            catch
            {
                MessageBox.Show("Numar invalid: " + s);
                return 0;
            }
        }
        /// <summary>
        /// Metoda calculeaza iesirea perceptronului cu doi neuroni in stratul ascuns pentru intrarile x si y
        /// </summary>
        private double MLP(double x1, double x2)
        {
            
        }
        /// <summary>
        /// Selecteaza functia de activare atunci cand utilizatorul o alege din combobox
        /// </summary>
        private void comboBoxActivation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxActivation.SelectedIndex == 0)
                ActivationFunction = StepActivation;
            else if (comboBoxActivation.SelectedIndex == 1)
                ActivationFunction = SemiliniarActivation;
            else if (comboBoxActivation.SelectedIndex == 2)
                ActivationFunction = SigmoidActivation;
        }
        /// <summary>
        /// Calculeaza si afiseaza iesirile retelei pentru combinatiile de intrari (0,0), (0,1), (1,0) si (1,1)
        /// </summary>
        private void ComputeResults()
        {
          
        }
        /// <summary>
        /// Citeste valorile ponderilor si pragurilor din interfata grafica
        /// </summary>
        private void ReadParametersFromGUI()
        {
            w13 = ConvertToDouble(textBoxMw13.Text);
            w23 = ConvertToDouble(textBoxMw23.Text);
            w14 = ConvertToDouble(textBoxMw14.Text);
            w24 = ConvertToDouble(textBoxMw24.Text);
            t3 = ConvertToDouble(textBoxMt3.Text);
            t4 = ConvertToDouble(textBoxMt4.Text);

            w35 = ConvertToDouble(textBoxMw35.Text);
            w45 = ConvertToDouble(textBoxMw45.Text);
            t5 = ConvertToDouble(textBoxMt5.Text);
        }
        /// <summary>
        /// Evenimentul de click al butonului "Deseneaza"
        /// </summary>
        private void buttonCompute_Click(object sender, EventArgs e)
        {
            ReadParametersFromGUI();
            ComputeResults();
            pictureBoxRegions.Refresh();

        }
        /// <summary>
        /// Desenarea regiunilor de decizie pentru retea in picturebox. Intrarile retelei sunt aici numere reale din intervalul [-0.5, 1.5]
        /// </summary>
        private void pictureBoxRegions_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
