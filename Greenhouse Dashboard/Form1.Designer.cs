
namespace Greenhouse_Dashboard
{
    partial class Window
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
            this.sensor1Label = new System.Windows.Forms.Label();
            this.sensor1Value = new System.Windows.Forms.Label();
            this.sensor2Label = new System.Windows.Forms.Label();
            this.sensor2Value = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.temperatureValue = new System.Windows.Forms.Label();
            this.fanButton = new System.Windows.Forms.Button();
            this.electrovalveButton = new System.Windows.Forms.Button();
            this.humidityButton = new System.Windows.Forms.Button();
            this.arduinoLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sensor1Label
            // 
            this.sensor1Label.AutoSize = true;
            this.sensor1Label.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor1Label.Location = new System.Drawing.Point(12, 92);
            this.sensor1Label.Name = "sensor1Label";
            this.sensor1Label.Size = new System.Drawing.Size(304, 35);
            this.sensor1Label.TabIndex = 0;
            this.sensor1Label.Text = "Humedad Sensor 1:";
            this.sensor1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // sensor1Value
            // 
            this.sensor1Value.AutoSize = true;
            this.sensor1Value.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor1Value.Location = new System.Drawing.Point(311, 92);
            this.sensor1Value.Name = "sensor1Value";
            this.sensor1Value.Size = new System.Drawing.Size(25, 35);
            this.sensor1Value.TabIndex = 1;
            this.sensor1Value.Text = " ";
            this.sensor1Value.Click += new System.EventHandler(this.label2_Click);
            // 
            // sensor2Label
            // 
            this.sensor2Label.AutoSize = true;
            this.sensor2Label.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor2Label.Location = new System.Drawing.Point(12, 134);
            this.sensor2Label.Name = "sensor2Label";
            this.sensor2Label.Size = new System.Drawing.Size(304, 35);
            this.sensor2Label.TabIndex = 2;
            this.sensor2Label.Text = "Humedad Sensor 2:";
            // 
            // sensor2Value
            // 
            this.sensor2Value.AutoSize = true;
            this.sensor2Value.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensor2Value.Location = new System.Drawing.Point(311, 134);
            this.sensor2Value.Name = "sensor2Value";
            this.sensor2Value.Size = new System.Drawing.Size(25, 35);
            this.sensor2Value.TabIndex = 3;
            this.sensor2Value.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puerto";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(184, 25);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Conectar";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(57, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "Seleccionar puerto";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Temperatura:";
            // 
            // temperatureValue
            // 
            this.temperatureValue.AutoSize = true;
            this.temperatureValue.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureValue.Location = new System.Drawing.Point(683, 92);
            this.temperatureValue.Name = "temperatureValue";
            this.temperatureValue.Size = new System.Drawing.Size(25, 35);
            this.temperatureValue.TabIndex = 10;
            this.temperatureValue.Text = " ";
            // 
            // fanButton
            // 
            this.fanButton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fanButton.Location = new System.Drawing.Point(18, 204);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(185, 109);
            this.fanButton.TabIndex = 11;
            this.fanButton.Text = "Encender ventilador";
            this.fanButton.UseVisualStyleBackColor = true;
            this.fanButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // electrovalveButton
            // 
            this.electrovalveButton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electrovalveButton.Location = new System.Drawing.Point(209, 204);
            this.electrovalveButton.Name = "electrovalveButton";
            this.electrovalveButton.Size = new System.Drawing.Size(218, 109);
            this.electrovalveButton.TabIndex = 12;
            this.electrovalveButton.Text = "Encender electroválvula";
            this.electrovalveButton.UseVisualStyleBackColor = true;
            this.electrovalveButton.Click += new System.EventHandler(this.electrovalveButton_Click);
            // 
            // humidityButton
            // 
            this.humidityButton.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityButton.Location = new System.Drawing.Point(433, 204);
            this.humidityButton.Name = "humidityButton";
            this.humidityButton.Size = new System.Drawing.Size(204, 109);
            this.humidityButton.TabIndex = 13;
            this.humidityButton.Text = "Encender sensores de humedad";
            this.humidityButton.UseVisualStyleBackColor = true;
            this.humidityButton.Click += new System.EventHandler(this.humidityButton_Click);
            // 
            // arduinoLabel
            // 
            this.arduinoLabel.AutoSize = true;
            this.arduinoLabel.ForeColor = System.Drawing.Color.Red;
            this.arduinoLabel.Location = new System.Drawing.Point(16, 5);
            this.arduinoLabel.Name = "arduinoLabel";
            this.arduinoLabel.Size = new System.Drawing.Size(114, 13);
            this.arduinoLabel.TabIndex = 14;
            this.arduinoLabel.Text = "Arduino desconectado";
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(265, 25);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(80, 23);
            this.disconnectButton.TabIndex = 15;
            this.disconnectButton.Text = "Desconectar";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.arduinoLabel);
            this.Controls.Add(this.humidityButton);
            this.Controls.Add(this.electrovalveButton);
            this.Controls.Add(this.fanButton);
            this.Controls.Add(this.temperatureValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sensor2Value);
            this.Controls.Add(this.sensor2Label);
            this.Controls.Add(this.sensor1Value);
            this.Controls.Add(this.sensor1Label);
            this.Name = "Window";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Window_FormClosed);
            this.Load += new System.EventHandler(this.Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sensor1Label;
        private System.Windows.Forms.Label sensor1Value;
        private System.Windows.Forms.Label sensor2Label;
        private System.Windows.Forms.Label sensor2Value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label temperatureValue;
        private System.Windows.Forms.Button fanButton;
        private System.Windows.Forms.Button electrovalveButton;
        private System.Windows.Forms.Button humidityButton;
        private System.Windows.Forms.Label arduinoLabel;
        private System.Windows.Forms.Button disconnectButton;
    }
}

