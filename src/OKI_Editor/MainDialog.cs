﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OKI_Editor
{
    public partial class MainDialog : Form
    {
        System.Windows.Forms.Button[] B0_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B0_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B0_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B0_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B0_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B0_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B0_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B0_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B0_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B2_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B2_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B2_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B2_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B2_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B2_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B2_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B2_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B2_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B3_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B3_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B3_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B3_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B3_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B3_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B3_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B3_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B3_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B4_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B4_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B4_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B4_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B4_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B4_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B4_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B4_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B4_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B5_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B5_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B5_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B5_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B5_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B5_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B5_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B5_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B5_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B6_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B6_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B6_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B6_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B6_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B6_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B6_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B6_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B6_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] B7_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] B7_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] B7_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B7_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] B7_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] B7_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] B7_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] B7_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] B7_ID = new System.Windows.Forms.Label[127];

        System.Windows.Forms.Button[] BCOM_Play = new System.Windows.Forms.Button[127];
        System.Windows.Forms.Button[] BCOM_Export = new System.Windows.Forms.Button[127];
        System.Windows.Forms.TextBox[] BCOM_Length = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] BCOM_Offset = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.TextBox[] BCOM_Depends = new System.Windows.Forms.TextBox[127];
        System.Windows.Forms.Button[] BCOM_Import = new System.Windows.Forms.Button[127];
        System.Windows.Forms.CheckBox[] BCOM_Enable = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.CheckBox[] BCOM_Common = new System.Windows.Forms.CheckBox[127];
        System.Windows.Forms.Label[] BCOM_ID = new System.Windows.Forms.Label[127];

        public MainDialog()
        {
            InitializeComponent();
        }

        public byte[] WPCROM { get; private set; }

        public byte[] U12 { get; private set; }
        public int U12Totalsize { get; private set; }

        public byte[] U13 { get; private set; }
        public int U13Totalsize { get; private set; }
        public bool U12Mirror { get; private set; }
        public bool U13Mirror { get; private set; }

        public CommonBank CommonBank { get; private set; }

        public Bank[] Banks { get; private set; }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ImportLoad(object sender, EventArgs e)
        {
            ROMLoader rl = new ROMLoader();
            rl.ShowDialog();
            if (rl.DialogResult == DialogResult.OK)
            {
                CommonBank = new CommonBank();
                Banks = new Bank[8];
                U12 = new byte[0x80000];
                U13 = new byte[0x80000];
                WPCROM = new byte[0x160000];
                U12Totalsize = 0;
                U13Totalsize = 0;

                foreach (TreeNode U12Node in rl.U12List.Nodes)
                {
                    String U12Name = U12Node.Text;
                    byte[] bytes = File.ReadAllBytes(U12Name);
                    Array.Copy(bytes, 0, U12, U12Totalsize, bytes.Length);

                    U12Totalsize += bytes.Length;
                }
                if (U12Totalsize < 0x80000)
                {
                    U12Mirror = true;
                    int tempsize = U12Totalsize;
                    int i = 0;
                    do
                    {
                        U12[tempsize + i] = U12[i];
                        U12Totalsize++;
                        i++;
                    }
                    while (U12Totalsize < 0x80000);
                }
                foreach (TreeNode U13Node in rl.U13List.Nodes)
                {
                    String U13Name = U13Node.Text;
                    byte[] bytes = File.ReadAllBytes(U13Name);
                    Array.Copy(bytes, 0, U13, U13Totalsize, bytes.Length);

                    U13Totalsize += bytes.Length;
                }
                if (U13Totalsize < 0x80000)
                {
                    U13Mirror = true;
                    int tempsize = U13Totalsize;
                    int i = 0;
                    do
                    {
                        U13[tempsize + i] = U13[i];
                        U13Totalsize++;
                        i++;
                    }
                    while (U13Totalsize < 0x80000);
                }
                Array.Copy(U12, WPCROM, U12.Length);
                Array.Copy(U13, 0, WPCROM, U12.Length, U13.Length);

                U12 = null;
                U13 = null;

                Banks[0] = new Bank(0, WPCROM, 0x40000, CommonBank);
                setCtrl0();

                if (U12Mirror == false)
                {
                    Banks[2] = new Bank(2, WPCROM, 0x20000, CommonBank);
                    setCtrl2();
                    Banks[3] = new Bank(3, WPCROM, 0x00000, CommonBank);
                    setCtrl3();
                    B2_Table.Enabled = true;
                    B3_Table.Enabled = true;
                }
                else
                {
                    B2_Table.Enabled = false;
                    B3_Table.Enabled = false;
                }
                if (U13Mirror == false)
                {
                    Banks[4] = new Bank(4, WPCROM, 0xe0000, CommonBank);
                    setCtrl4();
                    Banks[5] = new Bank(5, WPCROM, 0xc0000, CommonBank);
                    setCtrl5();
                    B4_Table.Enabled = true;
                    B5_Table.Enabled = true;
                }
                else
                {
                    B2_Table.Enabled = false;
                    B3_Table.Enabled = false;
                }
                Banks[6] = new Bank(6, WPCROM, 0xa0000, CommonBank);
                setCtrl6();
                Banks[7] = new Bank(7, WPCROM, 0x80000, CommonBank);
                setCtrl7();
            }
        }

        private void updateCtrl0()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[0].samples[i].enabled == true)
				{
					Banks[0].samples[i].depends.Clear();
					B0_Depends[i].Text = "";
					B0_Offset[i].Text = "0x" + Banks[0].samples[i].offset.ToString("x");
					B0_Length[i].Text = "0x" + Banks[0].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl2()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[2].samples[i].enabled == true)
				{
					Banks[2].samples[i].depends.Clear();
					B2_Depends[i].Text = "";
					B2_Offset[i].Text = "0x" + Banks[2].samples[i].offset.ToString("x");
					B2_Length[i].Text = "0x" + Banks[2].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl3()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[3].samples[i].enabled == true)
				{
					Banks[3].samples[i].depends.Clear();
					B3_Depends[i].Text = "";
					B3_Offset[i].Text = "0x" + Banks[3].samples[i].offset.ToString("x");
					B3_Length[i].Text = "0x" + Banks[3].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl4()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[4].samples[i].enabled == true)
				{
					Banks[4].samples[i].depends.Clear();
					B4_Depends[i].Text = "";
					B4_Offset[i].Text = "0x" + Banks[4].samples[i].offset.ToString("x");
					B4_Length[i].Text = "0x" + Banks[4].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl5()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[5].samples[i].enabled == true)
				{
					Banks[5].samples[i].depends.Clear();
					B5_Depends[i].Text = "";
					B5_Offset[i].Text = "0x" + Banks[5].samples[i].offset.ToString("x");
					B5_Length[i].Text = "0x" + Banks[5].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl6()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[6].samples[i].enabled == true)
				{
					Banks[6].samples[i].depends.Clear();
					B6_Depends[i].Text = "";
					B6_Offset[i].Text = "0x" + Banks[6].samples[i].offset.ToString("x");
					B6_Length[i].Text = "0x" + Banks[6].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrl7()
        {
			for (int i=0; i < 127; i++) {
				if (Banks[7].samples[i].enabled == true)
				{
					Banks[7].samples[i].depends.Clear();
					B7_Depends[i].Text = "";
					B7_Offset[i].Text = "0x" + Banks[7].samples[i].offset.ToString("x");
					B7_Length[i].Text = "0x" + Banks[7].samples[i].length.ToString("x");
				}				
			}
        }
        private void updateCtrlCOM()
        {
			for (int i=0; i < 127; i++) {
				if (CommonBank.samples[i].enabled == true)
				{
					CommonBank.samples[i].depends.Clear();
					BCOM_Depends[i].Text = "";
					BCOM_Offset[i].Text = "0x" + CommonBank.samples[i].offset.ToString("x");
					BCOM_Length[i].Text = "0x" + CommonBank.samples[i].length.ToString("x");
				}				
			}
        }

        private void setCtrl0()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[0].samples[i].enabled == true)
                {
                    B0_Enable[i].Enabled = true;
                    B0_Enable[i].Checked = true;

                    if (Banks[0].samples[i].common == true)
                    {
                        B0_ID[i].Text = "C" + (Banks[0].samples[i].commonid.ToString().PadLeft(4, '0'));
                        B0_Import[i].Enabled = false;
                        B0_Export[i].Enabled = false;					
                        B0_Common[i].Checked = true;
                    }
                    else
                    {
                        B0_ID[i].Text = i.ToString().PadLeft(3, '0');
                        B0_Import[i].Enabled = true;
                        B0_Export[i].Enabled = true;					
                        B0_Common[i].Checked = false;
                    }

                    int start = Banks[0].samples[i].start;
                    int id = Banks[0].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[0].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[0].samples[i].id > smp.id)
                                {
                                    Banks[0].samples[smp.id].parents.Add(id);
                                    Banks[0].samples[i].depends.Add(smp.id);
                                    if (Banks[0].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[0].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[0].samples[i].common == true)
                    {
                        Banks[0].samples[i].depends.Clear();
                        Banks[0].samples[i].offset = Banks[0].samples[i].start - 0x20000;
                    }
                    if (Banks[0].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[0].samples[i].depends[0];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B0_Depends[i].Text = deps;
                    B0_Offset[i].Text = "0x" + Banks[0].samples[i].offset.ToString("x");
                    B0_Length[i].Text = "0x" + Banks[0].samples[i].length.ToString("x");
                }

            }
            computetimeBank0();
        }

        private void setCtrl2()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[2].samples[i].enabled == true)
                {
                    B2_Enable[i].Enabled = true;
                    B2_Enable[i].Checked = true;

                    if (Banks[2].samples[i].common == true)
                    {
                        B2_ID[i].Text = "C" + (Banks[2].samples[i].commonid.ToString().PadLeft(4, '0'));
                        B2_Import[i].Enabled = false;
                        B2_Export[i].Enabled = false;					
                        B2_Common[i].Checked = true;
                    }
                    else
                    {
                        B2_ID[i].Text = i.ToString().PadLeft(3, '0');
                        B2_Import[i].Enabled = true;
                        B2_Export[i].Enabled = true;					
                        B2_Common[i].Checked = false;
                    }

                    int start = Banks[2].samples[i].start;
                    int id = Banks[2].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[2].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[2].samples[i].id > smp.id)
                                {
                                    Banks[2].samples[smp.id].parents.Add(id);
                                    Banks[2].samples[i].depends.Add(smp.id);
                                    if (Banks[2].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[2].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[2].samples[i].common == true)
                    {
                        Banks[2].samples[i].depends.Clear();
                        Banks[2].samples[i].offset = Banks[2].samples[i].start - 0x20000;
                    }
                    if (Banks[2].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[2].samples[i].depends[2];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B2_Depends[i].Text = deps;
                    B2_Offset[i].Text = "0x" + Banks[2].samples[i].offset.ToString("x");
                    B2_Length[i].Text = "0x" + Banks[2].samples[i].length.ToString("x");
                }

            }
            computetimeBank2();
        }

        private void setCtrl3()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[3].samples[i].enabled == true)
                {
                    B3_Enable[i].Enabled = true;
                    B3_Enable[i].Checked = true;

                    if (Banks[3].samples[i].common == true)
                    {
                        B3_ID[i].Text = "C" + (Banks[3].samples[i].commonid.ToString().PadLeft(4, '0'));
                        B3_Import[i].Enabled = false;
                        B3_Export[i].Enabled = false;					
                        B3_Common[i].Checked = true;
                    }
                    else
                    {
                        B3_ID[i].Text = i.ToString().PadLeft(3, '0');
                        B3_Import[i].Enabled = true;
                        B3_Export[i].Enabled = true;					
                        B3_Common[i].Checked = false;
                    }

                    int start = Banks[3].samples[i].start;
                    int id = Banks[3].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[3].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[3].samples[i].id > smp.id)
                                {
                                    Banks[3].samples[smp.id].parents.Add(id);
                                    Banks[3].samples[i].depends.Add(smp.id);
                                    if (Banks[3].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[3].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[3].samples[i].common == true)
                    {
                        Banks[3].samples[i].depends.Clear();
                        Banks[3].samples[i].offset = Banks[3].samples[i].start - 0x20000;
                    }
                    if (Banks[3].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[3].samples[i].depends[3];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B3_Depends[i].Text = deps;
                    B3_Offset[i].Text = "0x" + Banks[3].samples[i].offset.ToString("x");
                    B3_Length[i].Text = "0x" + Banks[3].samples[i].length.ToString("x");
                }

            }
            computetimeBank3();
        }

        private void setCtrl4()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[4].samples[i].enabled == true)
                {
                    B4_Enable[i].Enabled = true;
                    B4_Enable[i].Checked = true;

                    if (Banks[4].samples[i].common == true)
                    {
                        B4_ID[i].Text = "C" + (Banks[4].samples[i].commonid.ToString().PadLeft(3, '0'));
                        B4_Import[i].Enabled = false;
                        B4_Export[i].Enabled = false;					
                        B4_Common[i].Checked = true;
                    }
                    else
                    {
                        B4_Import[i].Enabled = true;
                        B4_Export[i].Enabled = true;					
                        B4_Common[i].Checked = false;
                    }

                    int start = Banks[4].samples[i].start;
                    int id = Banks[4].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[4].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[4].samples[i].id > smp.id)
                                {
                                    Banks[4].samples[smp.id].parents.Add(id);
                                    Banks[4].samples[i].depends.Add(smp.id);
                                    if (Banks[4].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[4].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[4].samples[i].common == true)
                    {
                        Banks[4].samples[i].depends.Clear();
                        Banks[4].samples[i].offset = Banks[4].samples[i].start - 0x20000;
                    }
                    if (Banks[4].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[4].samples[i].depends[4];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B4_Depends[i].Text = deps;
                    B4_Offset[i].Text = "0x" + Banks[4].samples[i].offset.ToString("x");
                    B4_Length[i].Text = "0x" + Banks[4].samples[i].length.ToString("x");
                }

            }
            computetimeBank4();
        }

        private void setCtrl5()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[5].samples[i].enabled == true)
                {
                    B5_Enable[i].Enabled = true;
                    B5_Enable[i].Checked = true;

                    if (Banks[5].samples[i].common == true)
                    {
                        B5_ID[i].Text = "C" + (Banks[5].samples[i].commonid.ToString().PadLeft(3, '0'));
                        B5_Import[i].Enabled = false;
                        B5_Export[i].Enabled = false;					
                        B5_Common[i].Checked = true;
                    }
                    else
                    {
                        B5_Import[i].Enabled = true;
                        B5_Export[i].Enabled = true;					
                        B5_Common[i].Checked = false;
                    }

                    int start = Banks[5].samples[i].start;
                    int id = Banks[5].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[5].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[5].samples[i].id > smp.id)
                                {
                                    Banks[5].samples[smp.id].parents.Add(id);
                                    Banks[5].samples[i].depends.Add(smp.id);
                                    if (Banks[5].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[5].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[5].samples[i].common == true)
                    {
                        Banks[5].samples[i].depends.Clear();
                        Banks[5].samples[i].offset = Banks[5].samples[i].start - 0x20000;
                    }
                    if (Banks[5].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[5].samples[i].depends[5];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B5_Depends[i].Text = deps;
                    B5_Offset[i].Text = "0x" + Banks[5].samples[i].offset.ToString("x");
                    B5_Length[i].Text = "0x" + Banks[5].samples[i].length.ToString("x");
                }

            }
            computetimeBank5();
        }

        private void setCtrl6()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[6].samples[i].enabled == true)
                {
                    B6_Enable[i].Enabled = true;
                    B6_Enable[i].Checked = true;

                    if (Banks[6].samples[i].common == true)
                    {
                        B6_ID[i].Text = "C" + (Banks[6].samples[i].commonid.ToString().PadLeft(3, '0'));
                        B6_Import[i].Enabled = false;
                        B6_Export[i].Enabled = false;					
                        B6_Common[i].Checked = true;
                    }
                    else
                    {
                        B6_Import[i].Enabled = true;
                        B6_Export[i].Enabled = true;					
                        B6_Common[i].Checked = false;
                    }

                    int start = Banks[6].samples[i].start;
                    int id = Banks[6].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[6].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[6].samples[i].id > smp.id)
                                {
                                    Banks[6].samples[smp.id].parents.Add(id);
                                    Banks[6].samples[i].depends.Add(smp.id);
                                    if (Banks[6].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[6].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[6].samples[i].common == true)
                    {
                        Banks[6].samples[i].depends.Clear();
                        Banks[6].samples[i].offset = Banks[6].samples[i].start - 0x20000;
                    }
                    if (Banks[6].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[6].samples[i].depends[6];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B6_Depends[i].Text = deps;
                    B6_Offset[i].Text = "0x" + Banks[6].samples[i].offset.ToString("x");
                    B6_Length[i].Text = "0x" + Banks[6].samples[i].length.ToString("x");
                }

            }
            computetimeBank6();
        }

        private void setCtrl7()
        {
            for (int i=0; i<127; i++)
            {
                if (Banks[7].samples[i].enabled == true)
                {
                    B7_Enable[i].Enabled = true;
                    B7_Enable[i].Checked = true;

                    if (Banks[7].samples[i].common == true)
                    {
                        B7_ID[i].Text = "C" + (Banks[7].samples[i].commonid.ToString().PadLeft(3, '0'));
                        B7_Import[i].Enabled = false;
                        B7_Export[i].Enabled = false;					
                        B7_Common[i].Checked = true;
                    }
                    else
                    {
                        B7_Import[i].Enabled = true;
                        B7_Export[i].Enabled = true;					
                        B7_Common[i].Checked = false;
                    }

                    int start = Banks[7].samples[i].start;
                    int id = Banks[7].samples[i].id;
                    for (int j = 0; j < 127; j++)
                    {
                        Sample smp = Banks[7].samples[j];
                        if (smp.enabled == true)
                        {
                            if (IsBetween(start, smp.start, smp.end))
                            {
                                if (Banks[7].samples[i].id > smp.id)
                                {
                                    Banks[7].samples[smp.id].parents.Add(id);
                                    Banks[7].samples[i].depends.Add(smp.id);
                                    if (Banks[7].samples[i].depends.Count == 1)
                                    {
                                        //find offset
                                        Banks[7].samples[i].offset = start - smp.start;
                                    }
                                }
                            }
                        }
                    }
                    string deps = "";
                    if (Banks[7].samples[i].common == true)
                    {
                        Banks[7].samples[i].depends.Clear();
                        Banks[7].samples[i].offset = Banks[7].samples[i].start - 0x20000;
                    }
                    if (Banks[7].samples[i].depends.Count > 0)
                    {
                        int dep = Banks[7].samples[i].depends[7];
                        {
                            deps = dep.ToString();
                        }
                    }
                    B7_Depends[i].Text = deps;
                    B7_Offset[i].Text = "0x" + Banks[7].samples[i].offset.ToString("x");
                    B7_Length[i].Text = "0x" + Banks[7].samples[i].length.ToString("x");
                }

            }
            computetimeBank7();
        }

        private void computetimeBank0()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[0].headersize;
            foreach (Sample smp in Banks[0].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[0].lastsample) && Banks[0].samples[Banks[0].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[0].sparespace = totalsize;

            if (totalsize < 0)
            {
                B0_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B0_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B0_Seconds.Text = time.ToString("0.00000");
        }

        private void computetimeBank2()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[2].headersize;
            foreach (Sample smp in Banks[2].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[2].lastsample) && Banks[2].samples[Banks[2].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[2].sparespace = totalsize;

            if (totalsize < 0)
            {
                B2_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B2_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B2_Seconds.Text = time.ToString("0.00000");
        }
        private void computetimeBank3()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[3].headersize;
            foreach (Sample smp in Banks[3].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[3].lastsample) && Banks[3].samples[Banks[3].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[3].sparespace = totalsize;

            if (totalsize < 0)
            {
                B3_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B3_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B3_Seconds.Text = time.ToString("0.00000");
        }
        private void computetimeBank4()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[4].headersize;
            foreach (Sample smp in Banks[4].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[4].lastsample) && Banks[4].samples[Banks[4].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[4].sparespace = totalsize;

            if (totalsize < 0)
            {
                B4_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B4_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B4_Seconds.Text = time.ToString("0.00000");
        }
        private void computetimeBank5()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[5].headersize;
            foreach (Sample smp in Banks[5].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[5].lastsample) && Banks[5].samples[Banks[5].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[5].sparespace = totalsize;

            if (totalsize < 0)
            {
                B5_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B5_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B5_Seconds.Text = time.ToString("0.00000");
        }
        private void computetimeBank6()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[6].headersize;
            foreach (Sample smp in Banks[6].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[6].lastsample) && Banks[6].samples[Banks[6].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[6].sparespace = totalsize;

            if (totalsize < 0)
            {
                B6_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B6_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B6_Seconds.Text = time.ToString("0.00000");
        }
        private void computetimeBank7()
        {
            //compute bytes spare
            int totalsize = 0x20000 - Banks[7].headersize;
            foreach (Sample smp in Banks[7].samples)
            {
                if (smp != null)
                {
                    if (smp.common == false)
                    {
                        if (smp.depends.Count() == 0)
                        {
                            if (smp.enabled == true)
                            {
                                totalsize -= smp.length;
                            }

                        }
                    }
                    if ((smp.id == Banks[7].lastsample) && Banks[7].samples[Banks[7].lastsample].enabled == false)
                    {
                        totalsize += 0x08;
                    }
                }
            }
            Banks[7].sparespace = totalsize;

            if (totalsize < 0)
            {
                B6_Bytes.Text = "-0x" + Math.Abs(totalsize).ToString("x");
            }
            else
            {
                B6_Bytes.Text = "0x" + totalsize.ToString("x");
            }
            float time = (totalsize / float.Parse(samprate.Text)) * 2;
            B6_Seconds.Text = time.ToString("0.00000");
        }

        private bool IsBetween(int item, int start, int end)
        {
            return Comparer<int>.Default.Compare(item, start) > 0
                && Comparer<int>.Default.Compare(item, end) < 0;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exportRAWfile(int bank, int sample)
        {
            SaveFileDialog SF = new SaveFileDialog
            {
                Title = "Save RAW File",
                InitialDirectory = "C:\\",
                Filter = "All files (*) | *.*",
                OverwritePrompt = true
            };
            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SF.FilterIndex = 0;
                SF.RestoreDirectory = true;
                Sample smp = Banks[bank].samples[sample];

                if (smp.depends.Count > 0)
                {
                    int StartPosition = smp.offset;
                    int EndPosition = StartPosition + smp.length;
                    byte[] tmp = new byte[smp.length];

                    Array.Copy(smp.RAW, smp.offset, tmp, 0, smp.length);
                    File.WriteAllBytes(SF.FileName, tmp);
                }
                else
                {
                    File.WriteAllBytes(SF.FileName, Banks[bank].samples[sample].RAW);
                }
            }

        }

        private void importRAWfile(int bank, int sample)
        {
            OpenFileDialog OF = new OpenFileDialog
            {
                Title = "Open RAW File",
                InitialDirectory = "C:\\",
                Filter = "All files (*) | *.*",
            };
            if (OF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                OF.FilterIndex = 0;
                OF.RestoreDirectory = true;
                byte[] tmp = File.ReadAllBytes(OF.FileName);

                int newspace = 0;
                if (Banks[bank].samples[sample].depends.Count > 0 && Banks[bank].samples[sample].depends.Count > 0)
                {
                    newspace = Banks[bank].sparespace;
                }
                else
                {
                    newspace = Banks[bank].sparespace - Banks[bank].samples[sample].RAW.Length;
                }

                int calcspace = newspace - tmp.Length;
                if (calcspace < 0)
                {
                    DialogResult confirmResult = MessageBox.Show("Importing this file will exceed the available space by 0x" +
                    Math.Abs(calcspace).ToString("x") + " bytes, proceed?", "Space Warning",
                                                         MessageBoxButtons.OKCancel);
                    if (confirmResult == DialogResult.OK)
                    {
                        Banks[bank].samples[sample].RAW = tmp;
                        Banks[bank].samples[sample].depends.Clear();
                        Banks[bank].samples[sample].common = false;
                        Banks[bank].samples[sample].offset = 0;
                        Banks[bank].samples[sample].start = sample * 0x40000;
                        Banks[bank].samples[sample].length = Banks[bank].samples[sample].RAW.Length;

                        switch (bank)
                        {
                            case 0:
                                setCtrl0();
                                break;
                            case 2:
                                setCtrl2();
                                break;
                            case 3:
                                setCtrl3();
                                break;
                            case 4:
                                setCtrl4();
                                break;
                            case 5:
                                setCtrl5();
                                break;
                            case 6:
                                setCtrl6();
                                break;
                            case 7:
                                setCtrl7();
                                break;
                        }
                    }
                }
                else
                {
                    Banks[bank].samples[sample].RAW = tmp;
                    Banks[bank].samples[sample].depends.Clear();
                    Banks[bank].samples[sample].common = false;
                    Banks[bank].samples[sample].offset = 0;
                    Banks[bank].samples[sample].start = sample * 0x40000;
                    Banks[bank].samples[sample].length = Banks[bank].samples[sample].RAW.Length;
                    switch (bank)
                    {
                        case 0:
                            setCtrl0();
                            break;
                        case 2:
                            setCtrl2();
                            break;
                        case 3:
                            setCtrl3();
                            break;
                        case 4:
                            setCtrl4();
                            break;
                        case 5:
                            setCtrl5();
                            break;
                        case 6:
                            setCtrl6();
                            break;
                        case 7:
                            setCtrl7();
                            break;
                            //case 8:
                            //    setCtrlCom();
                            //    break;
                    }
                }
            }

        }

        private byte [] GenerateBank(int bank)
        {
            int[] newstarts = new int[127];
            byte[] result = new byte[0x20000];
            for (int i = 0; i < 8; i++)
            {
                result[i] = 0x00;
            }
            int cursor = 8;
            int headersize = Banks[bank].headersize;
            Sample lastsample = Banks[bank].samples[Banks[bank].lastsample];
            if (lastsample.enabled == false)
            {
                //we can use the last sample's headerspace and make a few bytes.
                headersize -= 0x08;
            }

            if (Banks[bank].sparespace < 0)
            {
                MessageBox.Show("Bank " + bank + "is too large, cannot proceed", "Space Error",
                                                             MessageBoxButtons.OK);
            }

            foreach (Sample smp in Banks[bank].samples)
            {
                if (smp != null)
                {

                    if (smp.enabled == true)
                    {
                        if (smp.common == true)
                        {
                            newstarts[smp.id] = smp.start;
                            result[cursor] = (byte)(smp.start >> 0x10);
                            cursor++;
                            result[cursor] = (byte)((smp.start >> 0x08) & 0xff);
                            cursor++;
                            result[cursor] = (byte)((smp.start) & 0xff);
                            cursor++;
                            result[cursor] = (byte)(smp.end >> 0x10);
                            cursor++;
                            result[cursor] = (byte)((smp.end >> 0x08) & 0xff);
                            cursor++;
                            result[cursor] = (byte)((smp.end) & 0xff);
                            cursor++;
                            result[cursor] = 0x00;
                            cursor++;
                            result[cursor] = 0x00;
                            cursor++;
                        }
                        else
                        {
                            if (smp.depends.Count == 0)
                            {
                                int StartPosition = headersize;
                                newstarts[smp.id] = StartPosition;
                                int EndPosition = StartPosition + smp.length;
                                result[cursor] = (byte)(StartPosition >> 0x10);
                                cursor++;
                                result[cursor] = (byte)((StartPosition >> 0x08) & 0xff);
                                cursor++;
                                result[cursor] = (byte)((StartPosition) & 0xff);
                                cursor++;
                                result[cursor] = (byte)(EndPosition >> 0x10);
                                cursor++;
                                result[cursor] = (byte)((EndPosition >> 0x08) & 0xff);
                                cursor++;
                                result[cursor] = (byte)((EndPosition) & 0xff);
                                cursor++;
                                result[cursor] = 0x00;
                                cursor++;
                                result[cursor] = 0x00;
                                cursor++;

                                Array.Copy(smp.RAW, 0, result, StartPosition, smp.length);
                                headersize += smp.length;
                            }
                            else
                            {
                                int StartPosition = newstarts[smp.depends.ElementAt(0)] + smp.offset;
                                newstarts[smp.id] = StartPosition;
                                int EndPosition = StartPosition + smp.length;
                                result[cursor] = (byte)(StartPosition >> 0x10);
                                cursor++;
                                result[cursor] = (byte)((StartPosition >> 0x08) & 0xff);
                                cursor++;
                                result[cursor] = (byte)((StartPosition) & 0xff);
                                cursor++;
                                result[cursor] = (byte)(EndPosition >> 0x10);
                                cursor++;
                                result[cursor] = (byte)((EndPosition >> 0x08) & 0xff);
                                cursor++;
                                result[cursor] = (byte)((EndPosition) & 0xff);
                                cursor++;
                                result[cursor] = 0x00;
                                cursor++;
                                result[cursor] = 0x00;
                                cursor++;

                                Array.Copy(smp.RAW, 0, result, StartPosition, smp.length);
                            }
                        }
                    }
                    else if (smp.id != lastsample.id)
                    {
                        newstarts[smp.id] = 0;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                        result[cursor] = 0x00;
                        cursor++;
                    }
                }
            }
            return result;
        }
        private void GenerateROMs(object sender, EventArgs e)
        {
            byte[] bank0 = null;
            byte[] bank2 = null;
            byte[] bank3 = null;
            byte[] bank4 = null;
            byte[] bank5 = null;
            byte[] bank6 = null;
            byte[] bank7 = null;
            bank0 = GenerateBank(0);

            if (U12Mirror == false)
            {
                bank2 = GenerateBank(2);
                bank3 = GenerateBank(3);
            }
            if (U13Mirror == false)
            {
                bank4 = GenerateBank(4);
                bank5 = GenerateBank(5);
            }

            bank6 = GenerateBank(6);
            bank7 = GenerateBank(7);

            SaveFileDialog SF = new SaveFileDialog
            {
                Title = "Save U12 File",
                InitialDirectory = "C:\\adpcm\roms",
                Filter = "All files (*) | *.*",
                OverwritePrompt = true
            };
            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SF.FilterIndex = 0;
                SF.RestoreDirectory = true;

                byte[] U12Out;
                if (U12Mirror == false)
                {
                    U12Out = new byte[0x80000];
                    Array.Copy(bank3, 0, U12Out, 0x00000, 0x20000);
                    Array.Copy(bank2, 0, U12Out, 0x20000, 0x20000);
                    Array.Copy(bank0, 0, U12Out, 0x40000, 0x20000);
                    Array.Copy(U12,   0, U12Out, 0x60000, 0x20000);//common
                }
                else
                {
                    U12Out = new byte[0x40000];
                    Array.Copy(bank0, 0, U12Out, 0x00000, 0x20000);
                    Array.Copy(U12,   0, U12Out, 0x20000, 0x20000);//common
                }

                File.WriteAllBytes(SF.FileName, U12Out);
                U12Out = null;
            }
            SF = new SaveFileDialog
            {
                Title = "Save U13 File",
                InitialDirectory = "C:\\adpcm\roms",
                Filter = "All files (*) | *.*",
                OverwritePrompt = true
            };
            if (SF.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SF.FilterIndex = 0;
                SF.RestoreDirectory = true;

                byte[] U13Out;
                if (U13Mirror == false)
                {
                    U13Out = new byte[0x80000];
                    Array.Copy(bank7, 0, U13Out, 0x00000, 0x20000);
                    Array.Copy(bank6, 0, U13Out, 0x20000, 0x20000);
                    Array.Copy(bank5, 0, U13Out, 0x40000, 0x20000);
                    Array.Copy(bank4, 0, U13Out, 0x60000, 0x20000);
                }
                else
                {
                    U13Out = new byte[0x40000];
                    Array.Copy(bank7, 0, U13Out, 0x00000, 0x20000);
                    Array.Copy(bank6, 0, U13Out, 0x20000, 0x20000);
                }

                File.WriteAllBytes(SF.FileName, U13Out);
                U13Out = null;
            }

        }
        private void UpdateEnable(int bank, int sample, bool state)
        {
            Banks[bank].samples[sample].enabled = state;
            switch (bank)
            {
                case 0:
					computetimeBank0();
                    break;
                case 2:
					computetimeBank2();
                    break;
                case 3:
					computetimeBank3();
                    break;
                case 4:
					computetimeBank4();
                    break;
                case 5:
					computetimeBank5();
                    break;
                case 6:
					computetimeBank6();
                    break;
                case 7:
					computetimeBank7();
                    break;
                    //case 8:
                    //    computetimeBank8();

                    //    break;
            }
        }


        private void UpdateLength(int bank, int sample, String text)
        {
            Banks[bank].samples[sample].length = int.Parse(text, NumberStyles.HexNumber);
            switch (bank)
            {
                case 0:
                    setCtrl0();
                    break;
                case 2:
                    setCtrl2();
                    break;
                case 3:
                    setCtrl3();
                    break;
                case 4:
                    setCtrl4();
                    break;
                case 5:
                    setCtrl5();
                    break;
                case 6:
                    setCtrl6();
                    break;
                case 7:
                    setCtrl7();
                    break;
                    //case 8:
                    //    setCtrlCom();
                    //    break;
            }

        }

        private void UpdateOffset(int bank, int sample, String text)
        {
            Banks[bank].samples[sample].offset = int.Parse(text, NumberStyles.HexNumber);
            switch (bank)
            {
                case 0:
                    setCtrl0();
                    break;
                case 2:
                    setCtrl2();
                    break;
                case 3:
                    setCtrl3();
                    break;
                case 4:
                    setCtrl4();
                    break;
                case 5:
                    setCtrl5();
                    break;
                case 6:
                    setCtrl6();
                    break;
                case 7:
                    setCtrl7();
                    break;
                    //case 8:
                    //    setCtrlCom();
                    //    break;
            }

        }

        private void UpdateDepend(int bank, int sample, String text)
        {
            if (text.Contains("0x"))
            {
                Banks[bank].samples[sample].depends[0] = int.Parse(text, NumberStyles.HexNumber);
            }
            else
            {
                Banks[bank].samples[sample].depends[0] = int.Parse(text);
            }
            switch (bank)
            {
                case 0:
                    setCtrl0();
                    break;
                case 2:
                    setCtrl2();
                    break;
                case 3:
                    setCtrl3();
                    break;
                case 4:
                    setCtrl4();
                    break;
                case 5:
                    setCtrl5();
                    break;
                case 6:
                    setCtrl6();
                    break;
                case 7:
                    setCtrl7();
                    break;
                    //case 8:
                    //    setCtrlCom();
                    //    break;
            }

        }
    }
    }
