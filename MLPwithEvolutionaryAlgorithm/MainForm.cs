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
            bool check = int.TryParse(textBoxSizePop.Text, out int popsize);
            bool check2 = int.TryParse(textBoxMaxGen.Text, out int maxPop);
            bool check3 = double.TryParse(textBoxIncrucisare.Text, out double crossRate);
            bool check4 = double.TryParse(textBoxMutatie.Text, out double mutRate);
            if (!check || !check2 || !check3 || !check4)
                MessageBox.Show("Campurile nu pot fi citite ca numere sau au tipul gresit de date!");
            else if(crossRate>1 ||mutRate>1)
                MessageBox.Show("Ratele trebuie sa fie intre 0 și 1!");
            else
            {
                try
                {
                    EvolutionaryAlgorithm ea = new EvolutionaryAlgorithm();
                    Chromosome solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw13.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw23.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw14.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw24.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMt3.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMt4.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw35.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMw45.Text = solution.Fitness.ToString();
                    solution = ea.Solve(new Iris(), popsize, maxPop, crossRate, mutRate);
                    textBoxMt5.Text = solution.Fitness.ToString();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Fisierul cu date de intrare lipseste!");
                }
            }
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
            // se calculeaza suma intrarilor ponderate pentru fiecare neuron, scadem pragul si aplicam functia de activare 
            // neuronul 5 are ca intrari iesirile neuronilor 3 si 4
            // iesirea neuronului 5 este iesirea retelei
            double N3 = ActivationFunction(w13 * x1 + w23 * x2 - t3);
            double N4 = ActivationFunction(w14 * x1 + w24 * x2 - t4);
            double N5 = ActivationFunction(w35 * N3 + w45 * N4 - t5);
            return N5;
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
            textBoxResults.Clear();
            for (int x1 = 0; x1 <= 1; x1++)
                for (int x2 = 0; x2 <= 1; x2++)
                {
                    double y = MLP(x1, x2);
                    textBoxResults.AppendText(string.Format("{0}   {1}   {2:F3}\r\n", x1, x2, y));
                }
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
            int size = pictureBoxRegions.Width; // patrat
            Bitmap b = new Bitmap(size, size);
            Graphics g = Graphics.FromImage(b);
            g.Clear(Color.White);

            for (double x1 = -0.5; x1 < 1.5; x1 += 0.01)
                for (double x2 = -0.5; x2 < 1.5; x2 += 0.01)
                {
                    double y = MLP(x1, x2);
                    int gray = (int)(y * 255);
                    Color c = Color.FromArgb(gray, gray, gray);

                    int xScreen = (int)(size * (x1 + 0.5) / 2.0);
                    int yScreen = size - (int)(size * (x2 + 0.5) / 2.0);

                    g.DrawLine(new Pen(c), xScreen, yScreen, xScreen, yScreen + 1);
                }

            for (int x1 = 0; x1 <= 1; x1++)
                for (int x2 = 0; x2 <= 1; x2++)
                {
                    int xScreen = (int)(size * (x1 + 0.5) / 2.0);
                    int yScreen = size - (int)(size * (x2 + 0.5) / 2.0);
                    g.DrawEllipse(Pens.Red, xScreen - 2, yScreen - 2, 4, 4);
                }

            e.Graphics.DrawImage(b, 0, 0);
        }
    }
}
