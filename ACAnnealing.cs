using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_AI_lab1
{
    abstract class ACAnnealing
    {
        int m_iMaxLength = 8, m_iStepPerChange = 100;
        string sLog = "", sLongLog="";
        double m_fInitialTemperature = 30.0,
                m_fFinalTemperature = 0.1,
                m_fAlpha = 0.99;
        CBoard m_rBoard = null;

        protected int MaxLen
        {
            get
            {
                return m_iMaxLength;
            }
            set
            {                
                value.CompareTo(0).Equals(1);
                m_iMaxLength = value;
            }
        }
        protected int StepsPerChange
        {
            get
            {
                return m_iStepPerChange;
            }
            set
            {
                value.CompareTo(0).Equals(1);
                m_iStepPerChange = value;
            }
        }
        protected double FinTemperature
        {
            get
            {
                return m_fFinalTemperature;
            }
            set
            {
                value.CompareTo(0).Equals(1);
                m_fFinalTemperature = value;
            }
        }
        protected double InitTemperature
        {
            get { return m_fInitialTemperature; }
            set
            {
                value.CompareTo(m_fFinalTemperature).Equals(1); 
                m_fInitialTemperature = value;
            }
        }
        protected double Alpha
        {
            get
            {
                return m_fAlpha;
            }
            set
            {
                value.CompareTo(0).Equals(1);
                value.CompareTo(1).Equals(-1);
                m_fAlpha = value;
            }
        }
        protected CBoard Board
        {
            get
            {
                return m_rBoard;
            }
            set
            {
                SCValidator.CheckReferenceIsNotNull(value);
                m_rBoard = value;
            }
        }
        public string LogLines
        {
            get
            {
                return sLog;
            }
            protected set
            {
                sLog =value + "\r\n";
            }
        }
        public string AllLogs
        {
            get
            {
                return sLog;
            }            
        }
        protected void SaveLogs()
        {
            sLongLog += sLog + "\r\n"+ "*********************";
        }


    }
}
