namespace Интерфейс_программы
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.tbPreyGrowth = new System.Windows.Forms.TextBox();
            this.tbMeetingProb = new System.Windows.Forms.TextBox();
            this.tbPredatorReprod = new System.Windows.Forms.TextBox();
            this.tbPredatorDeath = new System.Windows.Forms.TextBox();
            this.tbInitPredators = new System.Windows.Forms.TextBox();
            this.tbInitPrey = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tbMaxPred = new System.Windows.Forms.TextBox();
            this.tbMinPred = new System.Windows.Forms.TextBox();
            this.tbAvgPred = new System.Windows.Forms.TextBox();
            this.tbDeadPred = new System.Windows.Forms.TextBox();
            this.tbLifeTimePred = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbDeadTimePred = new System.Windows.Forms.TextBox();
            this.tbFinalPred = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbMaxPrey = new System.Windows.Forms.TextBox();
            this.tbMinPrey = new System.Windows.Forms.TextBox();
            this.tbAvgPrey = new System.Windows.Forms.TextBox();
            this.tbDeadPrey = new System.Windows.Forms.TextBox();
            this.tbLifeTimePrey = new System.Windows.Forms.TextBox();
            this.tbDeadTimePrey = new System.Windows.Forms.TextBox();
            this.tbFinalPrey = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(134, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Параметры среды";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(595, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "График популяций";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1192, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Статистика";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(248, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Коэффициент роста жертв:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вероятность встречи:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(341, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Коэффициент размножения хищников:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Коэффициент смертности хищников:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(306, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Начальная численность хищников:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(14, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Начальная численность жертв:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(14, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Время моделирования:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(467, 354);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 22);
            this.label11.TabIndex = 11;
            this.label11.Text = "с.";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(508, 73);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.LegendText = "Время";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.LegendText = "Численность популяций (жертв и хищников)";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(441, 349);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(66, 452);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(186, 67);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(625, 440);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(186, 67);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(1198, 440);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(186, 67);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // tbPreyGrowth
            // 
            this.tbPreyGrowth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPreyGrowth.Location = new System.Drawing.Point(361, 73);
            this.tbPreyGrowth.Name = "tbPreyGrowth";
            this.tbPreyGrowth.Size = new System.Drawing.Size(100, 34);
            this.tbPreyGrowth.TabIndex = 16;
            // 
            // tbMeetingProb
            // 
            this.tbMeetingProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMeetingProb.Location = new System.Drawing.Point(361, 114);
            this.tbMeetingProb.Name = "tbMeetingProb";
            this.tbMeetingProb.Size = new System.Drawing.Size(100, 34);
            this.tbMeetingProb.TabIndex = 17;
            // 
            // tbPredatorReprod
            // 
            this.tbPredatorReprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPredatorReprod.Location = new System.Drawing.Point(361, 157);
            this.tbPredatorReprod.Name = "tbPredatorReprod";
            this.tbPredatorReprod.Size = new System.Drawing.Size(100, 34);
            this.tbPredatorReprod.TabIndex = 18;
            // 
            // tbPredatorDeath
            // 
            this.tbPredatorDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPredatorDeath.Location = new System.Drawing.Point(361, 203);
            this.tbPredatorDeath.Name = "tbPredatorDeath";
            this.tbPredatorDeath.Size = new System.Drawing.Size(100, 34);
            this.tbPredatorDeath.TabIndex = 19;
            // 
            // tbInitPredators
            // 
            this.tbInitPredators.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitPredators.Location = new System.Drawing.Point(361, 255);
            this.tbInitPredators.Name = "tbInitPredators";
            this.tbInitPredators.Size = new System.Drawing.Size(100, 34);
            this.tbInitPredators.TabIndex = 20;
            // 
            // tbInitPrey
            // 
            this.tbInitPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInitPrey.Location = new System.Drawing.Point(361, 298);
            this.tbInitPrey.Name = "tbInitPrey";
            this.tbInitPrey.Size = new System.Drawing.Size(100, 34);
            this.tbInitPrey.TabIndex = 21;
            // 
            // tbTime
            // 
            this.tbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTime.Location = new System.Drawing.Point(361, 346);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(100, 34);
            this.tbTime.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1120, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "по хищникам";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1307, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "по жертвам";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(980, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 25);
            this.label14.TabIndex = 25;
            this.label14.Text = "макс.численность:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(988, 149);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 25);
            this.label15.TabIndex = 26;
            this.label15.Text = "мин.численность:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1031, 181);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "ср.значение:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(966, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(208, 25);
            this.label17.TabIndex = 28;
            this.label17.Text = "момент вымирания:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1066, 216);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 25);
            this.label18.TabIndex = 29;
            this.label18.Text = "вымерли:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(966, 250);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(218, 25);
            this.label19.TabIndex = 30;
            this.label19.Text = "длительность жизни:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(1014, 324);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(156, 25);
            this.label20.TabIndex = 31;
            this.label20.Text = "итоговая числ.:";
            // 
            // tbMaxPred
            // 
            this.tbMaxPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxPred.Location = new System.Drawing.Point(1184, 114);
            this.tbMaxPred.Name = "tbMaxPred";
            this.tbMaxPred.Size = new System.Drawing.Size(100, 28);
            this.tbMaxPred.TabIndex = 32;
            // 
            // tbMinPred
            // 
            this.tbMinPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMinPred.Location = new System.Drawing.Point(1184, 148);
            this.tbMinPred.Name = "tbMinPred";
            this.tbMinPred.Size = new System.Drawing.Size(100, 28);
            this.tbMinPred.TabIndex = 33;
            // 
            // tbAvgPred
            // 
            this.tbAvgPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAvgPred.Location = new System.Drawing.Point(1184, 178);
            this.tbAvgPred.Name = "tbAvgPred";
            this.tbAvgPred.Size = new System.Drawing.Size(100, 28);
            this.tbAvgPred.TabIndex = 34;
            // 
            // tbDeadPred
            // 
            this.tbDeadPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeadPred.Location = new System.Drawing.Point(1184, 212);
            this.tbDeadPred.Name = "tbDeadPred";
            this.tbDeadPred.Size = new System.Drawing.Size(100, 28);
            this.tbDeadPred.TabIndex = 35;
            // 
            // tbLifeTimePred
            // 
            this.tbLifeTimePred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLifeTimePred.Location = new System.Drawing.Point(1188, 247);
            this.tbLifeTimePred.Name = "tbLifeTimePred";
            this.tbLifeTimePred.Size = new System.Drawing.Size(100, 28);
            this.tbLifeTimePred.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(1458, 255);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 18);
            this.label21.TabIndex = 37;
            this.label21.Text = "с.";
            // 
            // tbDeadTimePred
            // 
            this.tbDeadTimePred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeadTimePred.Location = new System.Drawing.Point(1188, 286);
            this.tbDeadTimePred.Name = "tbDeadTimePred";
            this.tbDeadTimePred.Size = new System.Drawing.Size(100, 28);
            this.tbDeadTimePred.TabIndex = 38;
            // 
            // tbFinalPred
            // 
            this.tbFinalPred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFinalPred.Location = new System.Drawing.Point(1188, 324);
            this.tbFinalPred.Name = "tbFinalPred";
            this.tbFinalPred.Size = new System.Drawing.Size(100, 28);
            this.tbFinalPred.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(1294, 255);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(20, 18);
            this.label22.TabIndex = 40;
            this.label22.Text = "с.";
            // 
            // tbMaxPrey
            // 
            this.tbMaxPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMaxPrey.Location = new System.Drawing.Point(1325, 116);
            this.tbMaxPrey.Name = "tbMaxPrey";
            this.tbMaxPrey.Size = new System.Drawing.Size(100, 28);
            this.tbMaxPrey.TabIndex = 41;
            // 
            // tbMinPrey
            // 
            this.tbMinPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMinPrey.Location = new System.Drawing.Point(1325, 148);
            this.tbMinPrey.Name = "tbMinPrey";
            this.tbMinPrey.Size = new System.Drawing.Size(100, 28);
            this.tbMinPrey.TabIndex = 42;
            // 
            // tbAvgPrey
            // 
            this.tbAvgPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAvgPrey.Location = new System.Drawing.Point(1325, 180);
            this.tbAvgPrey.Name = "tbAvgPrey";
            this.tbAvgPrey.Size = new System.Drawing.Size(100, 28);
            this.tbAvgPrey.TabIndex = 43;
            // 
            // tbDeadPrey
            // 
            this.tbDeadPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeadPrey.Location = new System.Drawing.Point(1325, 214);
            this.tbDeadPrey.Name = "tbDeadPrey";
            this.tbDeadPrey.Size = new System.Drawing.Size(100, 28);
            this.tbDeadPrey.TabIndex = 44;
            // 
            // tbLifeTimePrey
            // 
            this.tbLifeTimePrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLifeTimePrey.Location = new System.Drawing.Point(1325, 251);
            this.tbLifeTimePrey.Name = "tbLifeTimePrey";
            this.tbLifeTimePrey.Size = new System.Drawing.Size(100, 28);
            this.tbLifeTimePrey.TabIndex = 45;
            // 
            // tbDeadTimePrey
            // 
            this.tbDeadTimePrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDeadTimePrey.Location = new System.Drawing.Point(1325, 288);
            this.tbDeadTimePrey.Name = "tbDeadTimePrey";
            this.tbDeadTimePrey.Size = new System.Drawing.Size(100, 28);
            this.tbDeadTimePrey.TabIndex = 46;
            // 
            // tbFinalPrey
            // 
            this.tbFinalPrey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFinalPrey.Location = new System.Drawing.Point(1325, 326);
            this.tbFinalPrey.Name = "tbFinalPrey";
            this.tbFinalPrey.Size = new System.Drawing.Size(100, 28);
            this.tbFinalPrey.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(497, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 417);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(2, 428);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1455, 5);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(955, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 420);
            this.panel3.TabIndex = 50;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(1431, 255);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 18);
            this.label23.TabIndex = 51;
            this.label23.Text = "с.";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 531);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbFinalPrey);
            this.Controls.Add(this.tbDeadTimePrey);
            this.Controls.Add(this.tbLifeTimePrey);
            this.Controls.Add(this.tbDeadPrey);
            this.Controls.Add(this.tbAvgPrey);
            this.Controls.Add(this.tbMinPrey);
            this.Controls.Add(this.tbMaxPrey);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.tbFinalPred);
            this.Controls.Add(this.tbDeadTimePred);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.tbLifeTimePred);
            this.Controls.Add(this.tbDeadPred);
            this.Controls.Add(this.tbAvgPred);
            this.Controls.Add(this.tbMinPred);
            this.Controls.Add(this.tbMaxPred);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbInitPrey);
            this.Controls.Add(this.tbInitPredators);
            this.Controls.Add(this.tbPredatorDeath);
            this.Controls.Add(this.tbPredatorReprod);
            this.Controls.Add(this.tbMeetingProb);
            this.Controls.Add(this.tbPreyGrowth);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "АС \"Биомодель\"";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox tbPreyGrowth;
        private System.Windows.Forms.TextBox tbMeetingProb;
        private System.Windows.Forms.TextBox tbPredatorReprod;
        private System.Windows.Forms.TextBox tbPredatorDeath;
        private System.Windows.Forms.TextBox tbInitPredators;
        private System.Windows.Forms.TextBox tbInitPrey;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbMaxPred;
        private System.Windows.Forms.TextBox tbMinPred;
        private System.Windows.Forms.TextBox tbAvgPred;
        private System.Windows.Forms.TextBox tbDeadPred;
        private System.Windows.Forms.TextBox tbLifeTimePred;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbDeadTimePred;
        private System.Windows.Forms.TextBox tbFinalPred;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbMaxPrey;
        private System.Windows.Forms.TextBox tbMinPrey;
        private System.Windows.Forms.TextBox tbAvgPrey;
        private System.Windows.Forms.TextBox tbDeadPrey;
        private System.Windows.Forms.TextBox tbLifeTimePrey;
        private System.Windows.Forms.TextBox tbDeadTimePrey;
        private System.Windows.Forms.TextBox tbFinalPrey;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer timer1;
    }
}

