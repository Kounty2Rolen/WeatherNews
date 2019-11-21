namespace WeatherNews
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cityLable = new MaterialSkin.Controls.MaterialLabel();
            this.tempLabel = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.feelLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.uvIndexLabel = new System.Windows.Forms.Label();
            this.windSpeedLabel = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.AboutButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // cityLable
            // 
            this.cityLable.AutoSize = true;
            this.cityLable.Depth = 0;
            this.cityLable.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.cityLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cityLable.Location = new System.Drawing.Point(12, 167);
            this.cityLable.MouseState = MaterialSkin.MouseState.Hover;
            this.cityLable.Name = "cityLable";
            this.cityLable.Size = new System.Drawing.Size(34, 23);
            this.cityLable.TabIndex = 0;
            this.cityLable.Text = "City";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Trebuchet MS", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(12, 78);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tempLabel.Size = new System.Drawing.Size(187, 81);
            this.tempLabel.TabIndex = 2;
            this.tempLabel.Text = "TEMP";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel1.Size = new System.Drawing.Size(66, 23);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "RealFeal:";
            // 
            // feelLabel
            // 
            this.feelLabel.AutoSize = true;
            this.feelLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.feelLabel.ForeColor = System.Drawing.Color.Black;
            this.feelLabel.Location = new System.Drawing.Point(84, 198);
            this.feelLabel.Name = "feelLabel";
            this.feelLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.feelLabel.Size = new System.Drawing.Size(47, 20);
            this.feelLabel.TabIndex = 4;
            this.feelLabel.Text = "label1";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 180000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.AllowNavigation = false;
            this.webBrowser.AllowWebBrowserDrop = false;
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser.Location = new System.Drawing.Point(205, 78);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(64, 64);
            this.webBrowser.TabIndex = 6;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(12, 224);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel2.Size = new System.Drawing.Size(72, 23);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "UV-Index:";
            // 
            // uvIndexLabel
            // 
            this.uvIndexLabel.AutoSize = true;
            this.uvIndexLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uvIndexLabel.ForeColor = System.Drawing.Color.Black;
            this.uvIndexLabel.Location = new System.Drawing.Point(84, 223);
            this.uvIndexLabel.Name = "uvIndexLabel";
            this.uvIndexLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uvIndexLabel.Size = new System.Drawing.Size(47, 20);
            this.uvIndexLabel.TabIndex = 8;
            this.uvIndexLabel.Text = "label1";
            // 
            // windSpeedLabel
            // 
            this.windSpeedLabel.AutoSize = true;
            this.windSpeedLabel.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windSpeedLabel.ForeColor = System.Drawing.Color.Black;
            this.windSpeedLabel.Location = new System.Drawing.Point(102, 246);
            this.windSpeedLabel.Name = "windSpeedLabel";
            this.windSpeedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.windSpeedLabel.Size = new System.Drawing.Size(47, 20);
            this.windSpeedLabel.TabIndex = 10;
            this.windSpeedLabel.Text = "label1";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Nazanintar", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 247);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.Hover;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialLabel3.Size = new System.Drawing.Size(84, 23);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "WindSpeed:";
            // 
            // AboutButton
            // 
            this.AboutButton.AutoSize = true;
            this.AboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AboutButton.Depth = 0;
            this.AboutButton.Icon = null;
            this.AboutButton.Location = new System.Drawing.Point(263, 247);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AboutButton.MouseState = MaterialSkin.MouseState.Hover;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Primary = false;
            this.AboutButton.Size = new System.Drawing.Size(68, 36);
            this.AboutButton.TabIndex = 11;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 290);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.windSpeedLabel);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.uvIndexLabel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.feelLabel);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.cityLable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(344, 290);
            this.MinimumSize = new System.Drawing.Size(344, 290);
            this.Name = "MainForm";
            this.Text = "Weather";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel cityLable;
        private System.Windows.Forms.Label tempLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label feelLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Label uvIndexLabel;
        private System.Windows.Forms.Label windSpeedLabel;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton AboutButton;
    }
}

