using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEnhancer
{
    public partial class MainForm : Form
    {
        Pic originalPic;
        Pic resultPic;
        Panel parametersPanel;
        List<NumericUpDown> parameterControls; 

        public MainForm()
        {
            InitializeComponent();

            var bmp = (Bitmap)Image.FromFile("cocona.jpg");
            pictureBoxOriginal.Image = bmp;
            originalPic = Converter.BitmapToPic(bmp);
        }

        private void comboBoxFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonApply.Visible = true;
            
            if (parametersPanel != null) this.Controls.Remove(parametersPanel);

            parametersPanel = new Panel();
            parametersPanel.Left = comboBoxFilters.Left;
            parametersPanel.Top = comboBoxFilters.Bottom + 10;
            parametersPanel.Width = comboBoxFilters.Width;
            parametersPanel.Height = buttonApply.Top - comboBoxFilters.Bottom - 20;
            
            this.Controls.Add(parametersPanel);

            var filter = comboBoxFilters.SelectedItem as IFilter;
            if (filter == null) return;

            parameterControls = new List<NumericUpDown>();
            var parametersInfo = filter.GetParametersInfo();

            for (var i = 0; i < parametersInfo.Length; i++)
            {
                var label = new Label();
                label.Height = 28;
                label.Width = parametersPanel.Width - 60;
                label.Left = 0;
                label.Top = i * (label.Height + 10);
                label.Text = parametersInfo[i].Name;
                label.Font = new Font(label.Font.FontFamily, 10);

                parametersPanel.Controls.Add(label);

                var inputBox = new NumericUpDown();
                inputBox.Left = label.Right;
                inputBox.Top = label.Top;
                inputBox.Width = parametersPanel.Width - label.Width;
                inputBox.Height = label.Height;
                inputBox.Font = new Font(inputBox.Font.FontFamily, 10);
                inputBox.Minimum = (decimal)parametersInfo[i].MinValue;
                inputBox.Maximum = (decimal)parametersInfo[i].MaxValue;
                inputBox.Increment = (decimal)parametersInfo[i].Increment;
                inputBox.DecimalPlaces = 2;
                inputBox.Value = (decimal)parametersInfo[i].DefaultValue;

                parametersPanel.Controls.Add(inputBox);
                parameterControls.Add(inputBox);
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            var filter = comboBoxFilters.SelectedItem as IFilter;

            if (filter != null)
            {
                var parameters = new double[parameterControls.Count];
                for (var i = 0; i < parameters.Length; i++) parameters[i] = (double)parameterControls[i].Value;
                resultPic = filter.Process(originalPic, parameters);
                pictureBoxResult.Image = Converter.PicToBitmap(resultPic);
            }
        }

        public void AddFilter(IFilter filter)
        {
            if (filter != null) comboBoxFilters.Items.Add(filter);
        }
    }
}
