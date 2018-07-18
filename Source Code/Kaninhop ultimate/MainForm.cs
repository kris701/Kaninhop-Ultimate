using System;
using System.Windows.Forms;

namespace Kaninhop_ultimate
{
    public partial class MainForm : Form
    {
        #region Variabels

        double A = 0;
        double B = 0;
        double C = 0;
        double a = 0;
        double b = 0;
        double c = 0;
        int RoundTo = 2;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)  
        {
            foreach (Control InnerControls in Controls)
                if (InnerControls is TextBox)
                    if (InnerControls.Text == "") InnerControls.Text = "0";

            ErrorLabel.Text = "";
            CalculationsTextBox.Text = "";

            try
            {
                A = Convert.ToDouble(AInputTextBox.Text);
                B = Convert.ToDouble(BInputTextBox.Text);
                C = Convert.ToDouble(CInputTextBox.Text);
                a = Convert.ToDouble(_aInputTextBox.Text);
                b = Convert.ToDouble(_bInputTextBox.Text);
                c = Convert.ToDouble(_cInputTextBox.Text);

                int AmountOfAngles = 0;
                int AmountOfSides = 0;
                if (A > 0)
                    AmountOfAngles++;
                if (B > 0)
                    AmountOfAngles++;
                if (C > 0)
                    AmountOfAngles++;
                if (a > 0)
                    AmountOfSides++;
                if (b > 0)
                    AmountOfSides++;
                if (c > 0)
                    AmountOfSides++;

                if (AmountOfAngles + AmountOfSides > 0)
                {
                    if (AmountOfSides >= 1)
                    {
                        if (AmountOfAngles + AmountOfSides == 3)
                        {
                            if (A + B + C <= 180)
                            {
                                if (A + B < 180 & A + C < 180 & C + B < 180)
                                {
                                    int OverFlowCounter = 0;
                                    while (a == 0 | b == 0 | c == 0 | A == 0 | B == 0 | C == 0)
                                    {
                                        if (A == 0)
                                            GetA();

                                        if (B == 0)
                                            GetB();

                                        if (C == 0)
                                            GetC();

                                        if (a == 0)
                                            Geta();

                                        if (b == 0)
                                            Getb();

                                        if (c == 0)
                                            Getc();

                                        OverFlowCounter++;
                                        if (OverFlowCounter == 50)
                                        {
                                            MessageBox.Show("Unexpected error!");
                                            break;
                                        }
                                    }

                                    if (!Double.IsNaN(A) & !Double.IsNaN(B) & !Double.IsNaN(C))
                                    {
                                        if (a + b >= c & b + c >= a & c + a >= b)
                                        {
                                            AInputTextBox.Text = A.ToString();
                                            BInputTextBox.Text = B.ToString();
                                            CInputTextBox.Text = C.ToString();
                                            _aInputTextBox.Text = a.ToString();
                                            _bInputTextBox.Text = b.ToString();
                                            _cInputTextBox.Text = c.ToString();
                                            InformationLabel.Text = "Surface Area: " + Math.Round((a * b * Math.Sin(C * Math.PI / 180)) / 2, RoundTo) + " Circumference: " + Math.Round(a + b + c, RoundTo) + " Angle Sum: " + (A + B + C);
                                            CalculateButton.Enabled = false;
                                        }
                                        else
                                        {
                                            CalculationsTextBox.Text = "";
                                            ErrorLabel.Text = "Invalid sides!";
                                        }
                                    }
                                    else
                                    {
                                        CalculationsTextBox.Text = "";
                                        ErrorLabel.Text = "The angles does not correspond to the sides!";
                                    }
                                }
                                else
                                    ErrorLabel.Text = "The angle sum does not add up";
                            }
                            else
                                ErrorLabel.Text = "The angle sum does not add up";
                        }
                        else
                        {
                            if (AmountOfAngles + AmountOfSides > 3)
                                ErrorLabel.Text = "Insert only three known values";
                            else
                                ErrorLabel.Text = "Missing information";
                        }
                    }
                    else
                        ErrorLabel.Text = "Missing sides";
                }
                else
                    ErrorLabel.Text = "Missing information";
            }
            catch
            {
                ErrorLabel.Text = "Error in information";
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            foreach (Control InnerControl in Controls)
                if (InnerControl is TextBox)
                    InnerControl.Text = "";
            InformationLabel.Text = "Surface Area: 0 Circumference: 0 Angle Sum: 0";
            CalculateButton.Enabled = true;
        }

        private void Information_Changed(object sender, EventArgs e)
        {
            TextBox SenderTextBox = sender as TextBox;
            SenderTextBox.Text = System.Text.RegularExpressions.Regex.Replace(SenderTextBox.Text, "[A-Za-z ]", "").Replace(".",",");
            SenderTextBox.SelectionStart = SenderTextBox.Text.Length;
            SenderTextBox.SelectionLength = 0;
        }

        private void RoundToNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            RoundTo = (int)RoundToNumericUpDown.Value;
        }

        void GetA()
        {
            if (B != 0 & C != 0)
            {
                A = Math.Round(180 - (B + C),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: A = 180 - (B + C)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "A = 180 - (" + B + " + " + C + ")" + Environment.NewLine +
                    "A = 180 - ( " + (B + C) + ")" + Environment.NewLine +
                    "A = " + A + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (b != 0 & c != 0 & a != 0)
            {
                A = Math.Round(Math.Acos((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: A = Cos^-1( (b^2 + c^2 - a^2 ) / 2 * b * c)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "A = Cos^-1( (" + Math.Pow(b, 2) + " + " + Math.Pow(c, 2) + " - " + Math.Pow(a, 2) + " ) / 2 * " + b + " * " + c + ")" + Environment.NewLine +
                    "A = Cos^-1( (" + (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) + " ) / " + 2*b*c + ")" + Environment.NewLine +
                    "A = Cos^-1( (" + ((Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c)) + ")" + Environment.NewLine +
                    "A = " + A + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (B != 0 & b != 0 & a != 0)
            {
                A = Math.Round(Math.Asin((a * Math.Sin(B * Math.PI / 180)) / b) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text += 
                    "Formula: A = Sin^-1(a * Sin(B) / b)" + Environment.NewLine + 
                    "Calculation:" + Environment.NewLine +
                    "A = Sin^-1(" + a + " * Sin(" + B + ") / " + b + ")" + Environment.NewLine +
                    "A = Sin^-1(" + a + " * " + Math.Sin(B * Math.PI / 180) + " / " + b + ")" + Environment.NewLine +
                    "A = Sin^-1(" + (a * Math.Sin(B * Math.PI / 180)) + " / " + b + ")" + Environment.NewLine +
                    "A = Sin^-1(" + (a * Math.Sin(B * Math.PI / 180) / b) + ")" + Environment.NewLine +
                    "A = " + A + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (C != 0 & c != 0 & a != 0)
            {
                A = Math.Round(Math.Asin((a * Math.Sin(C * Math.PI / 180)) / c) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text += 
                    "Formula: A = Sin^-1(a * Sin(C) / c)" + Environment.NewLine + 
                    "Calculation: " + Environment.NewLine +
                    "A = Sin^-1(" + a + " * Sin(" + C + ") / " + c + ")" + Environment.NewLine +
                    "A = Sin^-1(" + a + " * " + Math.Sin(C * Math.PI / 180) + " / " + c + ")" + Environment.NewLine +
                    "A = Sin^-1(" + (a * Math.Sin(C * Math.PI / 180)) + " / " + c + ")" + Environment.NewLine +
                    "A = Sin^-1(" + (a * Math.Sin(C * Math.PI / 180) / c) + ")" + Environment.NewLine +
                    "A = " + A + Environment.NewLine + Environment.NewLine;
                return;
            }
        }

        void GetB()
        {
            if (A != 0 & C != 0)
            {
                B = Math.Round(180 - (A + C),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: B = 180 - (A + C)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "B = 180 - (" + A + " + " + C + ")" + Environment.NewLine +
                    "B = 180 - ( " + (A + C) + ")" + Environment.NewLine +
                    "B = " + B + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (b != 0 & c != 0 & a != 0)
            {
                B = Math.Round(Math.Acos((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: B = Cos^-1( (a^2 + c^2 - b^2 ) / 2 * a * c)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "B = Cos^-1( (" + Math.Pow(a, 2) + " + " + Math.Pow(c, 2) + " - " + Math.Pow(b, 2) + " ) / 2 * " + a + " * " + c + ")" + Environment.NewLine +
                    "B = Cos^-1( (" + (Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) + " ) / " + 2 * a * c + ")" + Environment.NewLine +
                    "B = Cos^-1( (" + ((Math.Pow(a, 2) + Math.Pow(c, 2) - Math.Pow(b, 2)) / (2 * a * c)) + ")" + Environment.NewLine +
                    "B = " + B + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (A != 0 & a != 0 & b != 0)
            {
                B = Math.Round(Math.Asin((b * Math.Sin(A * Math.PI / 180)) / a) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: B = Sin^-1(b * Sin(A) / a)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "B = Sin^-1(" + b + " * Sin(" + A + ") / " + a + ")" + Environment.NewLine +
                    "B = Sin^-1(" + b + " * " + Math.Sin(A * Math.PI / 180) + " / " + a + ")" + Environment.NewLine +
                    "B = Sin^-1(" + (b * Math.Sin(A * Math.PI / 180)) + " / " + a + ")" + Environment.NewLine +
                    "B = Sin^-1(" + (b * Math.Sin(A * Math.PI / 180) / a) + ")" + Environment.NewLine +
                    "B = " + B + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (C != 0 & c != 0 & b != 0)
            {
                B = Math.Round(Math.Asin((b * Math.Sin(C * Math.PI / 180)) / c) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: B = Sin^-1(b * Sin(C) / c)" + Environment.NewLine +
                    "Calculation: " + Environment.NewLine +
                    "B = Sin^-1(" + b + " * Sin(" + C + ") / " + c + ")" + Environment.NewLine +
                    "B = Sin^-1(" + b + " * " + Math.Sin(C * Math.PI / 180) + " / " + c + ")" + Environment.NewLine +
                    "B = Sin^-1(" + (b * Math.Sin(C * Math.PI / 180)) + " / " + c + ")" + Environment.NewLine +
                    "B = Sin^-1(" + (b * Math.Sin(C * Math.PI / 180) / c) + ")" + Environment.NewLine +
                    "B = " + B + Environment.NewLine + Environment.NewLine;
                return;
            }
        }

        void GetC()
        {
            if (A != 0 & B != 0)
            {
                C = Math.Round(180 - (A + B),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: C = 180 - (A + B)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "C = 180 - (" + A + " + " + B + ")" + Environment.NewLine +
                    "C = 180 - ( " + (A + B) + ")" + Environment.NewLine +
                    "C = " + C + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (b != 0 & c != 0 & a != 0)
            {
                B = Math.Round(Math.Acos((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: C = Cos^-1( (a^2 + b^2 - c^2 ) / 2 * a * b)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "C = Cos^-1( (" + Math.Pow(a, 2) + " + " + Math.Pow(b, 2) + " - " + Math.Pow(c, 2) + " ) / 2 * " + a + " * " + b + ")" + Environment.NewLine +
                    "C = Cos^-1( (" + (Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) + " ) / " + 2 * a * b + ")" + Environment.NewLine +
                    "C = Cos^-1( (" + ((Math.Pow(a, 2) + Math.Pow(b, 2) - Math.Pow(c, 2)) / (2 * a * b)) + ")" + Environment.NewLine +
                    "C = " + C + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (A != 0 & a != 0 & c != 0)
            {
                C = Math.Round(Math.Asin((c * Math.Sin(A * Math.PI / 180)) / a) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: C = Sin^-1(c * Sin(A) / a)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "C = Sin^-1(" + c + " * Sin(" + A + ") / " + a + ")" + Environment.NewLine +
                    "C = Sin^-1(" + c + " * " + Math.Sin(A * Math.PI / 180) + " / " + a + ")" + Environment.NewLine +
                    "C = Sin^-1(" + (c * Math.Sin(A * Math.PI / 180)) + " / " + a + ")" + Environment.NewLine +
                    "C = Sin^-1(" + (c * Math.Sin(A * Math.PI / 180) / a) + ")" + Environment.NewLine +
                    "C = " + C + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (B != 0 & b != 0 & c != 0)
            {
                C = Math.Round(Math.Asin((c * Math.Sin(B * Math.PI / 180)) / b) * 180 / Math.PI,RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: C = Sin^-1(c * Sin(B) / b)" + Environment.NewLine +
                    "Calculation: " + Environment.NewLine +
                    "C = Sin^-1(" + c + " * Sin(" + B + ") / " + b + ")" + Environment.NewLine +
                    "C = Sin^-1(" + c + " * " + Math.Sin(B * Math.PI / 180) + " / " + b + ")" + Environment.NewLine +
                    "C = Sin^-1(" + (c * Math.Sin(B * Math.PI / 180)) + " / " + b + ")" + Environment.NewLine +
                    "C = Sin^-1(" + (c * Math.Sin(B * Math.PI / 180) / b) + ")" + Environment.NewLine +
                    "C = " + C + Environment.NewLine + Environment.NewLine;
                return;
            }
        }

        void Geta()
        {
            if (b != 0 & c != 0 & A != 0)
            {
                a = Math.Round(Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2) - 2 * b * c * Math.Cos(A * Math.PI / 180)),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: a = Sqrt(b^2 + c^2 - 2 * b * c * Cos(A))" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "a = Sqrt(" + b + "^2 + " + c + "^2 - 2 * " + b + " * " + c + " * Cos(" + A + "))" + Environment.NewLine +
                    "a = Sqrt(" + Math.Pow(b, 2) + " + " + Math.Pow(c, 2) + " - 2 * " + b + " * " + c + " * Cos(" + A + "))" + Environment.NewLine +
                    "a = Sqrt(" + (Math.Pow(b, 2) + Math.Pow(c, 2)) + " - " + (2 * b * c) + " * Cos(" + A + "))" + Environment.NewLine +
                    "a = Sqrt(" + (Math.Pow(b, 2) + Math.Pow(c, 2)) + " - " + (2 * b * c) + " * " + (Math.Cos(A * Math.PI / 180)) + ")" + Environment.NewLine +
                    "a = Sqrt(" + (Math.Pow(b, 2) + Math.Pow(c, 2)) + " - " + (2 * b * c) * (Math.Cos(A * Math.PI / 180)) + ")" + Environment.NewLine +
                    "a = Sqrt(" + ((Math.Pow(b, 2) + Math.Pow(c, 2)) - (2 * b * c * Math.Cos(A * Math.PI / 180))) + ")" + Environment.NewLine +
                    "a = " + a + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (b != 0 & B != 0 & A != 0)
            {
                a = Math.Round((b * (Math.Sin(A * Math.PI / 180))) / (Math.Sin(B * Math.PI / 180)), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: a = (b * Sin(A)) / Sin(B)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "a = (" + b + " * Sin(" + B + ")) / Sin(" + A + ")" + Environment.NewLine +
                    "a = (" + b + " * " + (Math.Sin(A * Math.PI / 180) * 180 / Math.PI) + ") / " + (Math.Sin(B * Math.PI / 180) * 180 / Math.PI) + Environment.NewLine +
                    "a = (" + (b * Math.Sin(A * Math.PI / 180) * 180 / Math.PI) + ") / " + (Math.Sin(B * Math.PI / 180) * 180 / Math.PI) + Environment.NewLine +
                    "a = " + a + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (c != 0 & b != 0)
            {
                a = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(c, 2) - Math.Pow(b, 2))), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: a = Sqrt(c^2 - b^2)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "a = Sqrt(" + c + "^2 - " + b + "^2)" + Environment.NewLine +
                    "a = Sqrt(" + Math.Pow(c, 2) + " - " + Math.Pow(b, 2) + ")" + Environment.NewLine +
                    "a = Sqrt(" + (Math.Pow(c, 2) + Math.Pow(b, 2)) + ")" + Environment.NewLine +
                    "a = " + a + Environment.NewLine + Environment.NewLine;
                return;
            }
        }

        void Getb()
        {
            if (a != 0 & c != 0 & B != 0)
            {
                b = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2) - 2 * a * c * Math.Cos(B * Math.PI / 180)),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: b = Sqrt(a^2 + c^2 - 2 * a * c * Cos(B))" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "b = Sqrt(" + a + "^2 + " + c + "^2 - 2 * " + a + " * " + c + " * Cos(" + B + "))" + Environment.NewLine +
                    "b = Sqrt(" + Math.Pow(a, 2) + " + " + Math.Pow(c, 2) + " - 2 * " + a + " * " + c + " * Cos(" + B + "))" + Environment.NewLine +
                    "b = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(c, 2)) + " - " + (2 * a * c) + " * Cos(" + B + "))" + Environment.NewLine +
                    "b = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(c, 2)) + " - " + (2 * a * c) + " * " + Math.Round(Math.Cos(B * Math.PI / 180),RoundTo) + ")" + Environment.NewLine +
                    "b = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(c, 2)) + " - " + (2 * a * c) * Math.Round(Math.Cos(B * Math.PI / 180),RoundTo) + ")" + Environment.NewLine +
                    "b = Sqrt(" + ((Math.Pow(a, 2) + Math.Pow(c, 2)) - (2 * a * c * Math.Round(Math.Cos(B * Math.PI / 180),RoundTo))) + ")" + Environment.NewLine +
                    "b = " + b + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (c != 0 & C != 0 & B != 0)
            {
                b = Math.Round((c * Math.Sin(B * Math.PI / 180)) / (Math.Sin(C * Math.PI / 180)), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: b = (c * Sin(B)) / Sin(C)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "b = (" + c + " * Sin(" + B + ")) / Sin(" + C + ")" + Environment.NewLine +
                    "b = (" + c + " * " + Math.Round(Math.Sin(B * Math.PI / 180), RoundTo) + ") / " + Math.Round(Math.Sin(C * Math.PI / 180), RoundTo) + Environment.NewLine +
                    "b = (" + (c * Math.Round(Math.Sin(B * Math.PI / 180), RoundTo)) + ") / " + Math.Round(Math.Sin(C * Math.PI / 180), RoundTo) + Environment.NewLine +
                    "b = " + b + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (c != 0 & a != 0)
            {
                b = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(c, 2) - Math.Pow(a, 2))), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: b = Sqrt(c^2 - a^2)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "b = Sqrt(" + c + "^2 - " + a + "^2)" + Environment.NewLine +
                    "b = Sqrt(" + Math.Pow(c, 2) + " - " + Math.Pow(a, 2) + ")" + Environment.NewLine +
                    "b = Sqrt(" + (Math.Pow(c, 2) + Math.Pow(a, 2)) + ")" + Environment.NewLine +
                    "b = " + b + Environment.NewLine + Environment.NewLine;
                return;
            }
        }

        void Getc()
        {
            if (a != 0 & b != 0 & C != 0)
            {
                c = Math.Round(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(C * Math.PI / 180)),RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: c = Sqrt(a^2 + b^2 - 2 * a * b * Cos(C))" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "c = Sqrt(" + a + "^2 + " + b + "^2 - 2 * " + a + " * " + b + " * Cos(" + C + "))" + Environment.NewLine +
                    "c = Sqrt(" + Math.Pow(a, 2) + " + " + Math.Pow(b, 2) + " - 2 * " + a + " * " + b + " * Cos(" + C + "))" + Environment.NewLine +
                    "c = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(b, 2)) + " - " + (2 * a * b) + " * Cos(" + C + "))" + Environment.NewLine +
                    "c = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(b, 2)) + " - " + (2 * a * b) + " * " + Math.Round(Math.Cos(C * Math.PI / 180),RoundTo) + ")" + Environment.NewLine +
                    "c = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(b, 2)) + " - " + (2 * a * b) * Math.Round(Math.Cos(C * Math.PI / 180),RoundTo) + ")" + Environment.NewLine +
                    "c = Sqrt(" + ((Math.Pow(a, 2) + Math.Pow(b, 2)) - (2 * a * b * Math.Cos(C * Math.PI / 180))) + ")" + Environment.NewLine +
                    "c = " + c + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (a != 0 & A != 0 & C != 0)
            {
                c = Math.Round((a * Math.Sin(C * Math.PI / 180)) / (Math.Sin(A * Math.PI / 180)), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: c = (a * Sin(C)) / Sin(A)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "c = (" + a + " * Sin(" + C + ")) / Sin(" + A + ")" + Environment.NewLine +
                    "c = (" + a + " * " + Math.Round(Math.Sin(C * Math.PI / 180), RoundTo) + ") / " + Math.Round(Math.Sin(A * Math.PI / 180), RoundTo) + Environment.NewLine +
                    "c = (" + Math.Round(a * Math.Sin(C * Math.PI / 180), RoundTo) + ") / " + Math.Round(Math.Sin(A * Math.PI / 180), RoundTo) + Environment.NewLine +
                    "c = " + c + Environment.NewLine + Environment.NewLine;
                return;
            }
            if (b != 0 & a != 0)
            {
                c = Math.Round(Math.Sqrt(Math.Abs(Math.Pow(a, 2) + Math.Pow(b, 2))), RoundTo);
                CalculationsTextBox.Text +=
                    "Formula: c = Sqrt(a^2 - b^2)" + Environment.NewLine +
                    "Calculation:" + Environment.NewLine +
                    "c = Sqrt(" + a + "^2 - " + b + "^2)" + Environment.NewLine +
                    "c = Sqrt(" + Math.Pow(a, 2) + " - " + Math.Pow(b, 2) + ")" + Environment.NewLine +
                    "c = Sqrt(" + (Math.Pow(a, 2) + Math.Pow(b, 2)) + ")" + Environment.NewLine +
                    "c = " + c + Environment.NewLine + Environment.NewLine;
                return;
            }
        }
    }
}
