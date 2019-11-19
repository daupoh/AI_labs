using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_AI_lab2
{
    public partial class FormAdaptiveResonance : Form
    {
        string[] aSignNames = { "Асинхронный двигатель", "Трансформатор", "Электрический кабель", "Вакуумный выключатель",
                                "Промежуточное реле","Магнитный пускатель","Токовое реле","Трансформатор тока",
                                "Контактор","Реле времени","Реле напряжения"};
        CAdaptiveResonance rAdaptRes;
        public FormAdaptiveResonance()
        {
            InitializeComponent();
            rAdaptRes = new CAdaptiveResonance();
            SetListOfSigns();
        }
        private void SetListOfSigns()
        {
            clbSigns.Items.Clear();
            decimal iVectorLength = nudVectorLength.Value;
            if (iVectorLength < 11)
            {
                for (int i = 0; i < iVectorLength; i++)
                {
                    clbSigns.Items.Add(aSignNames[i]);
                }
            }
            else
            {
                decimal iRest = iVectorLength - 11;
                for (int i = 0; i < 11; i++)
                {
                    clbSigns.Items.Add(aSignNames[i]);
                }
                for (int i = 0; i < iRest; i++)
                {
                    clbSigns.Items.Add("Дополнительный признак #" + i.ToString());
                }
            }
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            nudMaxClusters.Value = rAdaptRes.MaxClusters;
            nudVectorLength.Value = rAdaptRes.VectorLength;
            nudBeta.Value = rAdaptRes.Beta;
            nudAttention.Value = (decimal)rAdaptRes.Attention;
            SetListOfSigns();
            EnabledSettingButtons(false);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите изменить параметры алгоритма? " +
                                                        "Это приведет к уничтожению всех признаков, прототипов и кластеров."
                                                        , "Подтверждение изменения параметров", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                rAdaptRes.MaxClusters = (int)nudMaxClusters.Value;
                rAdaptRes.VectorLength = (int)nudVectorLength.Value;
                rAdaptRes.Beta = (int)nudBeta.Value;
                rAdaptRes.Attention = (double)nudAttention.Value;
                SetListOfSigns();
                EnabledSettingButtons(false);
                ClearLists();
            }
        }
        private void ClearLists()
        {
            cbxSigns.Items.Clear();            
        }
        private void EnabledSettingButtons(bool bEnabled)
        {
            btnCancelSettings.Enabled = bEnabled;
            btnSaveSettings.Enabled = bEnabled;
        }
        private void SetCheckedInSigns (bool bChecked)
        {
            for (int i = 0; i < clbSigns.Items.Count; i++)
            {
                clbSigns.SetItemChecked(i, bChecked);
            }
        }
        private void nudMaxClusters_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void nudVectorLength_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void nudBeta_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void nudAttention_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void btnAllSignsOn_Click(object sender, EventArgs e)
        {
            SetCheckedInSigns(true);
        }

        private void btnAllSignsOff_Click(object sender, EventArgs e)
        {
            SetCheckedInSigns(false);
        }

        private void btnAddSign_Click(object sender, EventArgs e)
        {
            
        }
         
    }
}
