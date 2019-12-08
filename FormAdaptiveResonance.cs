using NUnit.Framework;
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
        readonly string[] m_aSignNames = { "Асинхронный двигатель", "Трансформатор", "Электрический кабель", "Вакуумный выключатель",
                                "Промежуточное реле","Магнитный пускатель","Токовое реле","Трансформатор тока",
                                "Контактор","Реле времени","Реле напряжения"};
        readonly string m_sConfermStr = "Вы действительно хотите изменить параметры алгоритма? "
                                + "\r\nЭто приведет к уничтожению всех признаков, прототипов и кластеров.",
                m_sConfermTitle = "Подтверждение изменения параметров";
        readonly CAdaptiveResonance m_rAdaptRes;
        public FormAdaptiveResonance()
        {
            InitializeComponent();
            m_rAdaptRes = new CAdaptiveResonance();
            SetListOfSigns();
        }
        private void SetListOfSigns()
        {
            ClbSigns.Items.Clear();
            decimal iVectorLength = nudVectorLength.Value;
            if (iVectorLength < 11)
            {
                for (int i = 0; i < iVectorLength; i++)
                {
                    ClbSigns.Items.Add(m_aSignNames[i]);
                }
            }
            else
            {
                decimal iRest = iVectorLength - 11;
                for (int i = 0; i < 11; i++)
                {
                    ClbSigns.Items.Add(m_aSignNames[i]);
                }
                for (int i = 0; i < iRest; i++)
                {
                    ClbSigns.Items.Add("Дополнительный признак #" + i.ToString());
                }
            }
        }
        private void BtnCancelSettings_Click(object sender, EventArgs e)
        {           
            nudMaxClusters.Value = m_rAdaptRes.MaxClusters;
            nudVectorLength.Value = m_rAdaptRes.VectorLength;
            nudBeta.Value = m_rAdaptRes.Beta;
            nudAttention.Value = (decimal)m_rAdaptRes.Attention;
            SetListOfSigns();
            EnabledSettingButtons(false);
            ClearLists();
        }

        private void BtnSaveSettings_Click(object sender, EventArgs e)
        {
            if (m_rAdaptRes.MaxClusters != (int)nudMaxClusters.Value || m_rAdaptRes.VectorLength != (int)nudVectorLength.Value)
            {
                DialogResult dialogResult = MessageBox.Show(m_sConfermStr, m_sConfermTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    m_rAdaptRes.MaxClusters = (int)nudMaxClusters.Value;
                    m_rAdaptRes.VectorLength = (int)nudVectorLength.Value;
                    m_rAdaptRes.Beta = (int)nudBeta.Value;
                    m_rAdaptRes.Attention = (double)nudAttention.Value;
                    SetListOfSigns();
                    EnabledSettingButtons(false);
                    ClearLists();
                }
            }
        }
        private void EnabledSettingButtons(bool bEnabled)
        {
            btnCancelSettings.Enabled = bEnabled;
            btnSaveSettings.Enabled = bEnabled;
        }
        private void ClearLists()
        {
            m_rAdaptRes.ClearVectors();
            m_rAdaptRes.ClearClusters();
            CbxSigns.Items.Clear();
            CbxSigns.Text = "";
            CbxPrototypes.Items.Clear();
            CbxPrototypes.Text = "";
        }
       
        private void SetCheckedInSigns (bool bChecked)
        {
            for (int i = 0; i < ClbSigns.Items.Count; i++)
            {
                ClbSigns.SetItemChecked(i, bChecked);
            }
        }
        private void NudMaxClusters_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void NudVectorLength_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void NudBeta_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void NudAttention_ValueChanged(object sender, EventArgs e)
        {
            EnabledSettingButtons(true);
        }

        private void BtnAllSignsOn_Click(object sender, EventArgs e)
        {
            SetCheckedInSigns(true);
        }

        private void BtnAllSignsOff_Click(object sender, EventArgs e)
        {
            SetCheckedInSigns(false);
        }

        private void BtnAddSign_Click(object sender, EventArgs e)
        {
            string sCode = GenerateVector();
            m_rAdaptRes.AddVectorSign(sCode);
            CbxSigns.Items.Add(m_rAdaptRes.GetVectorSign(CbxSigns.Items.Count).Name);
            BalloonTip("Вектор признаков успешно добавлен.");
            CheckResonanceMayStart();
        }
        private void CheckResonanceMayStart()
        {
            if (CbxSigns.Items.Count>0)
            {
                BtnStartResonance.Enabled = true;
            }
            else
            {
                BtnStartResonance.Enabled = false;
            }
        }
        private void CbxSigns_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxPrototypes.Text = "";
            string sCode = m_rAdaptRes.GetVectorSign(CbxSigns.SelectedIndex).Code;
            SelectingListVectors(ClbSigns,sCode);
        }
        
        private void BtnSaveVector_Click(object sender, EventArgs e)
        {
            string sCode = GenerateVector();
            if (CbxPrototypes.Text != "")
            {
                m_rAdaptRes.UpdateVectorPrototype(CbxPrototypes.SelectedIndex,sCode);
                CbxPrototypes.Items[CbxPrototypes.SelectedIndex] = "Прототип #" + CbxPrototypes.SelectedIndex.ToString() + " (" + sCode + ")";
                BalloonTip("Вектор прототип успешно обновлен.");
            }
            else
            {
                m_rAdaptRes.UpdateVectorSign(CbxSigns.SelectedIndex, sCode);
                CbxSigns.Items[CbxSigns.SelectedIndex] = "Признак #" + CbxSigns.SelectedIndex.ToString() + " (" + sCode + ")";
                BalloonTip("Вектор признаков успешно обновлен.");
            }
        }

        private void BtnDeleteSign_Click(object sender, EventArgs e)
        {
            if (CbxPrototypes.Text != "")
            {
                m_rAdaptRes.DeleteVectorPrototype(CbxPrototypes.SelectedIndex);
                DeleteVectorFromList(CbxPrototypes);
                BalloonTip("Вектор прототип успешно удален.");
            }
            else
            {
                m_rAdaptRes.DeleteVectorSign(CbxSigns.SelectedIndex);
                DeleteVectorFromList(CbxSigns);
                BalloonTip("Вектор признаков успешно удален.");
            }
            CheckResonanceMayStart();
        }
        private void DeleteVectorFromList(ComboBox rList)
        {
            rList.Items.RemoveAt(rList.SelectedIndex);
            rList.SelectedIndex = rList.Items.Count - 1;
            if (rList.SelectedIndex == -1)
            {
                BackToAdding();
            }
        }
        private void BtnToAdd_Click(object sender, EventArgs e)
        {
            BackToAdding();
        }
        private void BackToAdding()
        {
            CbxSigns.Text = "";
            CbxPrototypes.Text = "";
            BtnToAdd.Enabled = false;
            BtnAddSign.Enabled = true;
            BtnAddPrototype.Enabled = true;
            BtnDeleteSign.Enabled = false;
            BtnSaveVector.Enabled = false;
            BtnAddRandSign.Enabled = true;
            BtnAddRandPrototype.Enabled = true;
        }

        private void BtnAddPrototype_Click(object sender, EventArgs e)
        {
            string sCode = GenerateVector();
            m_rAdaptRes.AddVectorPrototype(sCode);
            CbxPrototypes.Items.Add(m_rAdaptRes.GetVectorPrototype(CbxPrototypes.Items.Count).Name);
            BalloonTip("Вектор прототип успешно добавлен.");
            CheckResonanceMayStart();
        }
        private void BalloonTip(string sText)
        {
            nicAddVectorSucces.BalloonTipText = sText;
            nicAddVectorSucces.ShowBalloonTip(20);
        }
        private void CbxPrototypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CbxSigns.Text = "";
            string sCode = m_rAdaptRes.GetVectorPrototype(CbxPrototypes.SelectedIndex).Code;
            SelectingListVectors(ClbSigns,sCode);
        }
        private void SelectingListVectors(CheckedListBox rList,string sCode)
        {
            for (int i = 0; i < sCode.Length; i++)
            {
                if (sCode[i] == '1')
                {
                    rList.SetItemChecked(i, true);
                }
                else
                {
                    rList.SetItemChecked(i, false);
                }
            }
            BtnAddSign.Enabled = false;
            BtnAddPrototype.Enabled = false;
            BtnAddRandPrototype.Enabled = false;
            BtnAddRandSign.Enabled = false;
            BtnToAdd.Enabled = true;
            BtnDeleteSign.Enabled = true;
            BtnSaveVector.Enabled = true;
        }

        private void BtnStartResonance_Click(object sender, EventArgs e)
        {
            try
            {
                m_rAdaptRes.ClearClusters();
                m_rAdaptRes.Resonance();
                MessageBox.Show("Алгоритм успешно выполнен!");
                gbClusters.Enabled = true;
                CCluster[] aClusters = m_rAdaptRes.GetClusters();
                if (aClusters.Length > 0)
                {
                    CbxClusters.Enabled = true;
                    for (int i = 0; i < aClusters.Length; i++)
                    {
                        string sCode = aClusters[i].Name;
                        CbxClusters.Items.Add(sCode);
                    }
                }                
            }
            catch (AssertionException rExp)
            {
                MessageBox.Show("Ошибка при выполнении алгоритма!\r\n"+ rExp.Message);
            }
            TbLog.Text = m_rAdaptRes.Log;
            BtnStartResonance.Enabled = false;
            GbSigns.Enabled = false;
            BtnReset.Enabled = true;
            gbSettings.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            gbClusters.Enabled = false;
            CbxClusters.Items.Clear();
            CbxClusterSigns.Items.Clear();
            CbxClusters.Text = "";
            CbxClusterSigns.Text = "";
            GbSigns.Enabled = true;
            gbSettings.Enabled = true;
            ClearLists();
            TbLog.Clear();
        }
        private void CbxClusters_SelectedIndexChanged(object sender, EventArgs e)
        {
            CBinVector[] aVectors = m_rAdaptRes.GetSignsFromCluster(CbxClusters.SelectedIndex);
            CbxClusterSigns.Items.Clear();
            CbxClusterSigns.Text = "";
            if (aVectors.Length > 0)
            {
                for (int i = 0; i < aVectors.Length; i++)
                {
                    string sName = aVectors[i].Name;
                    CbxClusterSigns.Items.Add(sName);
                }
                CbxClusterSigns.Enabled = true;
            }
        }

        private void BtnRandSign_Click(object sender, EventArgs e)
        {
            string sCode = GenerateRandomVector();
            m_rAdaptRes.AddVectorSign(sCode);
            CbxSigns.Items.Add(m_rAdaptRes.GetVectorSign(CbxSigns.Items.Count).Name);
            BalloonTip("Вектор признаков успешно добавлен.");
            CheckResonanceMayStart();
        }
        private string GenerateRandomVector()
        {
            string sCode = "";
            Random rRand = new Random();
            for (int i = 0; i < ClbSigns.Items.Count; i++)
            {
                if (rRand.NextDouble() > 0.5)
                {
                    ClbSigns.SetItemChecked(i, true);
                    sCode += '1';
                }
                else
                {
                    ClbSigns.SetItemChecked(i, false);
                    sCode += '0';
                }
            }
            return sCode;
        }

        private void BtnAddRandPrototype_Click(object sender, EventArgs e)
        {
            string sCode = GenerateRandomVector();
            m_rAdaptRes.AddVectorPrototype(sCode);
            CbxPrototypes.Items.Add(m_rAdaptRes.GetVectorPrototype(CbxPrototypes.Items.Count).Name);
            BalloonTip("Вектор прототип успешно добавлен.");
            CheckResonanceMayStart();
        }

        private string GenerateVector()
        {
            string sCode="";
            for (int i = 0; i < ClbSigns.Items.Count; i++)
            {
                if(ClbSigns.GetItemChecked(i))
                {
                    sCode += '1';
                }
                else
                {
                    sCode += '0';
                }
            }
            return sCode;
        }
    }
}
