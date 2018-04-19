using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSVtoDatabase
{
    partial class AboutBox : Form
    {
        private static AboutBox aboutBox = new AboutBox();
        public AboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("About {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;

        }

        public new static void Show()
        {
            ((Control) aboutBox).Show();
             //AboutBox.Show();
        }

        public new static void ShowDialog()
        {
            ((Control) aboutBox).Show();
            //AboutBox.ShowDialog();
        }
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return "5.2.0"; //Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                //object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                //if (attributes.Length == 0)
                //{
                //    return "";
                //}
                //return ((AssemblyDescriptionAttribute)attributes[0]).Description;
                string description = @"此软件或程序由罗明章所作。
                你可以随意使用，但请不要反编译。";
                return description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                //object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                //if (attributes.Length == 0)
                //{
                //    return "";
                //}
                //return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
                return string.Empty;// "Octopos Co., Ltd";
            }
        }

        public string AssemblyCompany
        {
            get
            {
                //object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                //if (attributes.Length == 0)
                //{
                //    return "";
                //}
                //return ((AssemblyCompanyAttribute)attributes[0]).Company;
                return string.Empty; //"Octopos Co., Ltd";
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
