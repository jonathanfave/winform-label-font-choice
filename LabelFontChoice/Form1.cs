using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelFontChoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Récupère la taille de police sélectionnée dans la ComboBox


            int selectedFontSize = Convert.ToInt32(comboBoxSize.SelectedItem);

            // Met à jour la taille de la police du label avec la taille sélectionnée
            labelFontChoice.Font = new Font(labelFontChoice.Font.FontFamily, selectedFontSize);
        }

        private void buttonSizeIncr_Click(object sender, EventArgs e)
        {
            labelFontChoice.Font = new Font(labelFontChoice.Font.FontFamily, labelFontChoice.Font.Size + 1);
        }

        private void buttonSizeDecr_Click(object sender, EventArgs e)
        {
            labelFontChoice.Font = new Font(labelFontChoice.Font.FontFamily, labelFontChoice.Font.Size - 1);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelFontChoice.ForeColor = colorDialog.Color;
            }
        }
    }
}
