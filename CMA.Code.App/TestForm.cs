using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using CMA.Code.Processor;
using CMA.Code.Entities;


namespace CMA.Code.App
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            var selectedMatches = new List<Result>();            

            foreach (int indexChecked in this.subText.CheckedIndices)
            {
                selectedMatches.Add(new Result(this.subText.Items[indexChecked].ToString()));
            }

            var processor = new TextProcessor();

            IList results = processor.MatchText(this.text.Text, selectedMatches);

            this.lblResults.Text = string.Empty;
            this.lblResults.Text += "\n\n";

            foreach (Result result in results)
            {
                this.lblResults.Text += result.SubText + "\n";

                if (result.OutPut.Count != 0)
                {
                    foreach (int output in result.OutPut)
                    {
                        // Strip off coma from last position
                        if (result.OutPut.IndexOf(output) != result.OutPut.Count-1)
                        {
                            this.lblResults.Text += output + ", ";
                        }
                        else
                        {
                            this.lblResults.Text += output;
                        }
                    }
                }
                else
                {
                    this.lblResults.Text += "<no matches>";
                    
                }

                this.lblResults.Text += "\n\n";
                
            }
        }
    }
}
