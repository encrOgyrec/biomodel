using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Интерфейс_программы
{
    public partial class Form1 : Form
    {
        private double a, b, c, d;
        private double currentPrey, currentPredators;
        private double currentTime, maxTime;
        private double dt = 0.01; // Шаг интегрирования

        // Списки для хранения истории популяций (для статистики)
        private List<double> preyHistory = new List<double>();
        private List<double> predHistory = new List<double>();
        private List<double> timeHistory = new List<double>();

        private bool isPaused = false;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();

            // Привязка обработчиков событий
            btnStart.Click += BtnStart_Click;
            btnPause.Click += BtnPause_Click;
            btnReset.Click += BtnReset_Click;
            timer1.Tick += Timer1_Tick;
        }

        private void InitializeChart()
        {
            chart1.Series.Clear();

            Series preySeries = new Series("Жертвы");
            preySeries.ChartType = SeriesChartType.Spline;
            preySeries.Color = Color.Orange;
            preySeries.BorderWidth = 2;

            Series predSeries = new Series("Хищники");
            predSeries.ChartType = SeriesChartType.Spline;
            predSeries.Color = Color.Blue;
            predSeries.BorderWidth = 2;

            chart1.Series.Add(preySeries);
            chart1.Series.Add(predSeries);

            chart1.ChartAreas[0].AxisX.Title = "Время";
            chart1.ChartAreas[0].AxisY.Title = "Численность популяций";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (isPaused)
            {
                isPaused = false;
                timer1.Start();
                return;
            }

            try
            {
                // Чтение и проверка исходных параметров
                a = Convert.ToDouble(tbPreyGrowth.Text);
                b = Convert.ToDouble(tbMeetingProb.Text);
                c = Convert.ToDouble(tbPredatorReprod.Text);
                d = Convert.ToDouble(tbPredatorDeath.Text);
                currentPredators = Convert.ToDouble(tbInitPredators.Text);
                currentPrey = Convert.ToDouble(tbInitPrey.Text);
                maxTime = Convert.ToDouble(tbTime.Text);

                if (a <= 0 || b <= 0 || c <= 0 || d <= 0 || currentPredators < 0 || currentPrey < 0 || maxTime <= 0)
                {
                    MessageBox.Show("Параметры должны быть положительными числами.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ResetSimulation();

                preyHistory.Add(currentPrey);
                predHistory.Add(currentPredators);
                timeHistory.Add(currentTime);

                chart1.Series["Жертвы"].Points.AddXY(currentTime, currentPrey);
                chart1.Series["Хищники"].Points.AddXY(currentTime, currentPredators);

                timer1.Start();
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка формата", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int stepsPerTick = 10;

            for (int i = 0; i < stepsPerTick; i++)
            {
                if (currentTime >= maxTime)
                {
                    timer1.Stop();
                    UpdateStatistics();
                    MessageBox.Show("Моделирование завершено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Расчёт изменения численности методом Эйлера
                double nextPrey = currentPrey + (a * currentPrey - b * currentPrey * currentPredators) * dt;
                double nextPred = currentPredators + (c * currentPrey * currentPredators - d * currentPredators) * dt;

                // Защита от отрицательной популяции
                currentPrey = Math.Max(0, nextPrey);
                currentPredators = Math.Max(0, nextPred);
                currentTime += dt;

                preyHistory.Add(currentPrey);
                predHistory.Add(currentPredators);
                timeHistory.Add(currentTime);
            }

            // Построение графиков
            chart1.Series["Жертвы"].Points.AddXY(currentTime, currentPrey);
            chart1.Series["Хищники"].Points.AddXY(currentTime, currentPredators);

            UpdateStatistics();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            isPaused = true;
            timer1.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            isPaused = false;
            ResetSimulation();
        }

        private void ResetSimulation()
        {
            currentTime = 0;
            preyHistory.Clear();
            predHistory.Clear();
            timeHistory.Clear();

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }

            ClearStatistics();
        }

        private void UpdateStatistics()
        {
            if (preyHistory.Count == 0 || predHistory.Count == 0) return;

            // Статистика жертв
            tbMaxPrey.Text = Math.Round(preyHistory.Max()).ToString();
            tbMinPrey.Text = Math.Round(preyHistory.Min()).ToString();
            tbAvgPrey.Text = Math.Round(preyHistory.Average()).ToString();
            tbFinalPrey.Text = Math.Round(currentPrey).ToString();

            bool preyExtinct = currentPrey < 1;
            tbDeadPrey.Text = preyExtinct ? "Да" : "Нет";

            if (preyExtinct)
            {
                int extinctIndex = preyHistory.FindIndex(p => p < 1);
                double extinctTime = timeHistory[extinctIndex];
                tbDeadTimePrey.Text = Math.Round(extinctTime, 2).ToString();
                tbLifeTimePrey.Text = Math.Round(extinctTime, 2).ToString();
            }
            else
            {
                tbDeadTimePrey.Text = "-";
                tbLifeTimePrey.Text = Math.Round(currentTime, 2).ToString();
            }

            // Статистика хищников
            tbMaxPred.Text = Math.Round(predHistory.Max()).ToString();
            tbMinPred.Text = Math.Round(predHistory.Min()).ToString();
            tbAvgPred.Text = Math.Round(predHistory.Average()).ToString();
            tbFinalPred.Text = Math.Round(currentPredators).ToString();

            bool predExtinct = currentPredators < 1;
            tbDeadPred.Text = predExtinct ? "Да" : "Нет";

            if (predExtinct)
            {
                int extinctIndex = predHistory.FindIndex(p => p < 1);
                double extinctTime = timeHistory[extinctIndex];
                tbDeadTimePred.Text = Math.Round(extinctTime, 2).ToString();
                tbLifeTimePred.Text = Math.Round(extinctTime, 2).ToString();
            }
            else
            {
                tbDeadTimePred.Text = "-";
                tbLifeTimePred.Text = Math.Round(currentTime, 2).ToString();
            }
        }

        private void ClearStatistics()
        {
            tbMaxPrey.Text = ""; tbMinPrey.Text = ""; tbAvgPrey.Text = "";
            tbDeadPrey.Text = ""; tbLifeTimePrey.Text = ""; tbDeadTimePrey.Text = ""; tbFinalPrey.Text = "";

            tbMaxPred.Text = ""; tbMinPred.Text = ""; tbAvgPred.Text = "";
            tbDeadPred.Text = ""; tbLifeTimePred.Text = ""; tbDeadTimePred.Text = ""; tbFinalPred.Text = "";
        }
    }
}