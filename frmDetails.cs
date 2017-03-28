﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using General;

namespace Nursery_Production_Software
{
    public partial class frmDetails : Form
    {
        string scrn;

        public frmDetails(string screen)
        {
            scrn = screen;
            InitializeComponent();

        }

        private void DynamicButton_Click(object sender, EventArgs e)
        {
            string assemblyname = ((Label)sender).Name;
            string formname = ((Label)sender).Tag.ToString();
            try
            {
                Assembly myAssembly = Assembly.Load(assemblyname);
                //Version vrs = myAssembly.GetName().Version;
                Form myForm = myAssembly.CreateInstance(formname) as Form;
                //myForm.MdiParent = this;
                myForm.Show();
                
            }
            catch
            {
                MessageBox.Show("There was an error loading the application. Please contact technical support", "Error");
            }
            
        }

        private void DynamicMouseOver(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void DynamicMouseOut(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM s_ParentScreenMaster PSM LEFT OUTER JOIN s_ParentScreenDetail PSD ON PSM.id = PSD.MasterID WHERE PSM.name = '" + scrn + "' ORDER BY PSD.Postion ASC";
            DataSet frmInfo = General.Global.GetData(query);

            this.Text = frmInfo.Tables[0].Rows[0]["title"].ToString();
            int y = 45;

            for (int i = 0; i < frmInfo.Tables[0].Rows.Count; i++)
            {
                string description = frmInfo.Tables[0].Rows[i]["Description"].ToString();
                string assembly = frmInfo.Tables[0].Rows[i]["AssemblyName"].ToString();
                string id = frmInfo.Tables[0].Rows[i]["id"].ToString();
                string formname = frmInfo.Tables[0].Rows[i]["FormName"].ToString();

                if (description != "")
                {
                    Label lbName = new Label();
                    lbName.Location = new System.Drawing.Point(28, y);
                    lbName.Name = assembly;
                    lbName.Text = description;
                    lbName.Tag = formname;
                    lbName.BorderStyle = BorderStyle.Fixed3D;
                    lbName.Font = new Font("Arial", 12, FontStyle.Bold);
                    lbName.Size = new Size(250, lbName.Size.Height);


                    lbName.Click += new EventHandler(DynamicButton_Click);
                    lbName.MouseEnter += new EventHandler(DynamicMouseOver);
                    lbName.MouseLeave += new EventHandler(DynamicMouseOut);

                    y += 30;
                    this.Controls.Add(lbName);
                }

            }
        }


    }
}
