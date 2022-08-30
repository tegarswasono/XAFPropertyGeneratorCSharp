using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XAFPropertyGeneratorCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "XAF C# Property Generator";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string[] properties = rtbSource.Text.Split("\n");

                //constructor
                string[] classDetail = properties[0].Split(" ");
                string className = classDetail[0];

                string generatedClassHeader = $"[DefaultClassOptions]" + Environment.NewLine;
                generatedClassHeader += $"public class {className} : BaseObject" + Environment.NewLine + "{" + Environment.NewLine;
                string generatedClassConstructor = $"\t public {className}(Session session) : base(session) {{}}";
                string generatedClassFooter = $"}}";

                List<string> generatedProperties = new List<string>();
                int index = -1;
                foreach (string property in properties)
                {
                    index += 1;
                    if (index == 0)
                    {

                    }
                    else
                    {
                        string[] propertyDetail = property.Split(" ");
                        string propertyName = propertyDetail[0];
                        string propertyType = propertyDetail[1];

                        string privatePropertyName = "_" + propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1, propertyName.Length - 1);
                        string generatedProperty = $"\t private {propertyType} {privatePropertyName};";
                        if (index % 5 == 0) generatedProperty += Environment.NewLine;

                        generatedProperties.Add(generatedProperty);
                    }
                }

                index = -1;
                foreach (string property in properties)
                {
                    index += 1;
                    if (index == 0)
                    {

                    }
                    else
                    {
                        string[] propertyDetail = property.Split(" ");
                        string propertyName = propertyDetail[0];
                        string propertyType = propertyDetail[1];

                        string privatePropertyName = "_" + propertyName.Substring(0, 1).ToLower() + propertyName.Substring(1, propertyName.Length - 1);
                        string generatedProperty = "";
                        generatedProperty += $"\t public {propertyType} {propertyName} {{" + Environment.NewLine;
                        generatedProperty += $"\t \t get {{ return {privatePropertyName};}}" + Environment.NewLine;
                        generatedProperty += $"\t \t set {{ SetPropertyValue(nameof({propertyName}), ref {privatePropertyName}, value);}}" + Environment.NewLine;
                        generatedProperty += $"\t }}";

                        generatedProperties.Add(generatedProperty);
                    }
                }

                rtbDestination.Text = generatedClassHeader + generatedClassConstructor + Environment.NewLine;
                foreach (string generatedProperty in generatedProperties)
                {
                    rtbDestination.Text += (generatedProperty + Environment.NewLine);
                }
                rtbDestination.Text += generatedClassFooter;
            }
            catch (Exception ex)
            {
                rtbDestination.Text = "Error | " + ex.ToString();
            }
        }
    }
}
