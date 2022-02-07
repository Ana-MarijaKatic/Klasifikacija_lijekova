using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace DrugClassification
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class StringTable
        {
            public string[] ColumnNames { get; set; }
            public string[,] Values { get; set; }
        }
        private async void buttonAnalyze_Click(object sender, EventArgs e)
        {
            string age = numericUpDownAge.Value.ToString();
            string sex = "";
            if (radioButtonMale.Checked)
            {
                sex = "M";
            }
            else if(radioButtonFemale.Checked)
            {
                sex = "F";
            }
            string bp = comboBoxBP.Text;
            string cholesterol = comboBoxCholesterol.Text;
            string na_to_k = textBoxNatoK.Text;
            string drug = "";
            using (var client = new HttpClient())
            {
                var scoreRequest = new
                {

                    Inputs = new Dictionary<string, StringTable>() {
                        {
                            "input1",
                            new StringTable()
                            {
                                ColumnNames = new string[] {"Age", "Sex", "BP", "Cholesterol", "Na_to_K", "Drug"},
                                Values = new string[,] {  { age, sex, bp, cholesterol, na_to_k, drug }  }
                            }
                        },
                    },
                    GlobalParameters = new Dictionary<string, string>()
                    {
                    }
                };
                const string apiKey = "2JVFoE0X4sEnibmTHwbgi+QV/E2DwpnDXf0BNP4ja9cwlhx5F6h6z9RqYoLlCPehG15mabHZjUxMSaU7b+Xgrw=="; // Replace this with the API key for the web service
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);

                client.BaseAddress = new Uri("https://ussouthcentral.services.azureml.net/workspaces/f668f756737b4befae789695d4cc7ee9/services/e311256e0907447eaafdc1483c9c9dbe/execute?api-version=2.0&details=true");

                // WARNING: The 'await' statement below can result in a deadlock if you are calling this code from the UI thread of an ASP.Net application.
                // One way to address this would be to call ConfigureAwait(false) so that the execution does not attempt to resume on the original context.
                // For instance, replace code such as:
                //      result = await DoSomeTask()
                // with the following:
                //      result = await DoSomeTask().ConfigureAwait(false)


                HttpResponseMessage response = await client.PostAsJsonAsync("", scoreRequest);

                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    
                    //Console.WriteLine("Result: {0}", result);

                    var returnedObject = JsonConvert.DeserializeObject<RootObject>(result);
                    string drugType = returnedObject.Results.output1.value.Values[0][11];
                    labelDrugType.Text = drugType;
                }
                else
                {
                    Console.WriteLine(string.Format("The request failed with status code: {0}", response.StatusCode));

                    // Print the headers - they include the requert ID and the timestamp, which are useful for debugging the failure
                    Console.WriteLine(response.Headers.ToString());

                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownAge.Value = 0;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            comboBoxBP.SelectedIndex = -1;
            comboBoxCholesterol.SelectedIndex = -1;
            textBoxNatoK.Clear();
            labelDrugType.Text = String.Empty;
        }
    }
}
