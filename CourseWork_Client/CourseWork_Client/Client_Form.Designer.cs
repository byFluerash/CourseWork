namespace CourseWork_Client
{
    partial class Client_Form
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
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.button1 = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.Label();
            this.poly = new System.Windows.Forms.Label();
            this.tryg = new System.Windows.Forms.Label();
            this.fx = new System.Windows.Forms.Label();
            this.Func = new System.Windows.Forms.Label();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.halfperiodNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.degreeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfperiodNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // zedGraph
            // 
            this.zedGraph.Location = new System.Drawing.Point(15, 5);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(1174, 949);
            this.zedGraph.TabIndex = 1;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button1.Location = new System.Drawing.Point(1198, 836);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(536, 118);
            this.button1.TabIndex = 10;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // P
            // 
            this.P.AutoSize = true;
            this.P.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.P.Location = new System.Drawing.Point(1225, 200);
            this.P.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(260, 29);
            this.P.TabIndex = 44;
            this.P.Text = "Степень полинома P";
            // 
            // L
            // 
            this.L.AutoSize = true;
            this.L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L.Location = new System.Drawing.Point(1275, 137);
            this.L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(200, 29);
            this.L.TabIndex = 43;
            this.L.Text = "Полуинтервал L";
            // 
            // N
            // 
            this.N.AutoSize = true;
            this.N.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(1280, 71);
            this.N.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(189, 29);
            this.N.TabIndex = 42;
            this.N.Text = "Кол-во точек N";
            // 
            // poly
            // 
            this.poly.AutoSize = true;
            this.poly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.poly.Location = new System.Drawing.Point(1205, 451);
            this.poly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.poly.Name = "poly";
            this.poly.Size = new System.Drawing.Size(490, 29);
            this.poly.TabIndex = 41;
            this.poly.Text = "Np= a0+∑(ak*cos(k*pi*x/L)+bk*sin(k*pi*x/L))";
            // 
            // tryg
            // 
            this.tryg.AutoSize = true;
            this.tryg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryg.Location = new System.Drawing.Point(1262, 405);
            this.tryg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tryg.Name = "tryg";
            this.tryg.Size = new System.Drawing.Size(379, 29);
            this.tryg.TabIndex = 40;
            this.tryg.Text = "Тригонометрический полином";
            // 
            // fx
            // 
            this.fx.AutoSize = true;
            this.fx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fx.Location = new System.Drawing.Point(1280, 336);
            this.fx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fx.Name = "fx";
            this.fx.Size = new System.Drawing.Size(328, 29);
            this.fx.TabIndex = 39;
            this.fx.Text = "F(x)=e^(-sinx)*(cosx+2*atanx)";
            // 
            // Func
            // 
            this.Func.AutoSize = true;
            this.Func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Func.Location = new System.Drawing.Point(1225, 290);
            this.Func.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(419, 29);
            this.Func.TabIndex = 38;
            this.Func.Text = "Функция заданная вариантом №19";
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Location = new System.Drawing.Point(1520, 71);
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.stepNumericUpDown.TabIndex = 45;
            // 
            // halfperiodNumericUpDown
            // 
            this.halfperiodNumericUpDown.Location = new System.Drawing.Point(1524, 137);
            this.halfperiodNumericUpDown.Name = "halfperiodNumericUpDown";
            this.halfperiodNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.halfperiodNumericUpDown.TabIndex = 46;
            // 
            // degreeNumericUpDown
            // 
            this.degreeNumericUpDown.Location = new System.Drawing.Point(1521, 200);
            this.degreeNumericUpDown.Name = "degreeNumericUpDown";
            this.degreeNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.degreeNumericUpDown.TabIndex = 47;
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 973);
            this.Controls.Add(this.degreeNumericUpDown);
            this.Controls.Add(this.halfperiodNumericUpDown);
            this.Controls.Add(this.stepNumericUpDown);
            this.Controls.Add(this.P);
            this.Controls.Add(this.L);
            this.Controls.Add(this.N);
            this.Controls.Add(this.poly);
            this.Controls.Add(this.tryg);
            this.Controls.Add(this.fx);
            this.Controls.Add(this.Func);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zedGraph);
            this.Name = "Client_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halfperiodNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label P;
        private System.Windows.Forms.Label L;
        private System.Windows.Forms.Label N;
        private System.Windows.Forms.Label poly;
        private System.Windows.Forms.Label tryg;
        private System.Windows.Forms.Label fx;
        private System.Windows.Forms.Label Func;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.NumericUpDown halfperiodNumericUpDown;
        private System.Windows.Forms.NumericUpDown degreeNumericUpDown;
    }
}

