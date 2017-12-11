using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuaCtoIceSkid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convert_Click(object sender, EventArgs e)
        {
            string result = "";
            string[] array = In.Text.Split("\r\n".ToCharArray());
            for (int i = 0; i < array.Length; i++)
            {
                string script = array[i];

                string[] srcs = script.Split(' ');

                if (srcs[0] == "getglobal")
                {
                    string parameter = "";
                    int o = 1;
                    while (o < srcs.Length)
                    {
                        parameter += srcs[o] + " ";
                        o++;
                    }
                    result += "SKID_globalSkId(SkidState, " + '"' + parameter.TrimEnd() + '"' + ");";
                }
                else if (srcs[0] == "getfield")
                {
                    string parameter = "";
                    int o = 2;
                    while (o < srcs.Length)
                    {
                        parameter += srcs[o] + " ";
                        o++;
                    }
                    result += "SKID_getSkId(SkidState, " + srcs[1] + "," + '"' + parameter.TrimEnd() + '"' + ");";
                }
                else if (srcs[0] == "pushvalue")
                {
                    result += "SKID_SkIdvalue(SkidState, " + srcs[1] + ");";
                }
                else if (srcs[0] == "pushnumber")
                {
                    result += "SKID_hOwMaNySkIdS(SkidState, " + srcs[1] + ");";
                }
                else if (srcs[0] == "pushstring")
                {
                    string parameter = "";
                    int o = 1;
                    while (o < srcs.Length)
                    {
                        parameter += srcs[o] + " ";
                        o++;
                    }
                    result += "SKID_pushSkId(SkidState, " + '"' + parameter.TrimEnd() + '"' + ");";
                }
                else if (srcs[0] == "call")
                {
                    result += "SKID_SkId(SkidState, " + srcs[1] + "," + srcs[2] + ");";
                }
                else if (srcs[0] == "pcall")
                {
                    result += "SKID_bpSkId(SkidState, " + srcs[1] + "," + srcs[2] + "," + srcs[3] + ");";
                }
                else if (srcs[0] == "setfield")
                {
                    string parameter = "";
                    int o = 2;
                    while (o < srcs.Length)
                    {
                        parameter += srcs[o] + " ";
                        o++;
                    }

                    result += "SKID_setSkId(SkidState, " + srcs[1] + "," + '"' + parameter.TrimEnd() + '"' + ");";
                }
                else if (srcs[0] == "emptystack")
                {
                    result += "SKID_SkIdtop(0);";
                }
                else if (srcs[0] == "settop")
                {
                    result += "SKID_SkIdtop(SkidState, " + srcs[1] + ");";
                }
                else if (srcs[0] == "pushboolean")
                {
                    result += "//PUSHBOOLEAN IS NOT SUPPORTED BY STOCK ICE, PLEASE UPGRADE ICE AND THE CONVERTER IN ORDER TO USE IT.";
                }
                result += "\r\n";
            }
            Out.Text = result;
        }
    }
}
