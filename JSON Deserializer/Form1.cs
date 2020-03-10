using System;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace JSON_Deserializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region UI Events

        private void cmdDeserialize_Click(object sender, EventArgs e)
        {
            //debugOutput(txtInput.Text);
            deserializeJSON(txtInput.Text);
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtDebugOutput.Text = string.Empty;
        }

        #endregion

        #region json functions

        private void deserializeJSON(string strJSON)
        {
            try
            {
                //Below you can select 4 ways to parse (Dynamic, Simple, Complex or Array). Comment in the version to test below:
                
                //Dynamic (prints both the JSON formated and output)
                //var jPerson = JsonConvert.DeserializeObject<dynamic>(strJSON);

                //Parse Simple (standard JSON)
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonSimple>(strJSON);

                //Parse Complex (nested JSON formats)
                //var jPerson = JsonConvert.DeserializeObject<jsonPersonComplex>(strJSON);

                //Parse Array (complex method with Array)
                var jPerson = JsonConvert.DeserializeObject<jsonPersonArray>(strJSON);

                //Print the Json object
                debugOutput("Here's our JSON object: " + jPerson.ToString());

                //Print Firstname
                debugOutput("Here's is the first Name: " + jPerson.firstname.ToString());

                //Print Lastname
                debugOutput("Here's is the last Name: " + jPerson.lastname.ToString());

                //Print Age
                debugOutput("Here's is the age: " + jPerson.age.ToString());

                //Print is Alive
                debugOutput("Is alive?: " + jPerson.isAlive.ToString());

                //Print Address
                debugOutput("Address: " + jPerson.address.streetAddress.ToString());

                //Print City
                debugOutput("City: " + jPerson.address.city.ToString());

                //Print Postcode
                debugOutput("Postcode: " + jPerson.address.postCode.ToString());

                //Reading the JSON Aray:
                //debugOutput("Attempting to print phone numbers....");

                debugOutput("Phone numbers: " + jPerson.phoneNumbers.ToString());

                foreach (var num in jPerson.phoneNumbers)
                {
                    debugOutput(num.type.ToString() + " - " + num.number.ToString());
                }

                //debugOutput("Here's is the first Name: " + jPerson.firstname);
                //debugOutput("Here's the street address: " + jPerson.address.streetAddress);

            }
            catch (Exception ex)
            {
                debugOutput("We had a problem, please check format!! Error: " + ex.Message.ToString());
            }
        }

        #endregion

        #region Debug Output

        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtDebugOutput.Text = txtDebugOutput.Text + strDebugText + Environment.NewLine;
                txtDebugOutput.SelectionStart = txtDebugOutput.TextLength;
                txtDebugOutput.ScrollToCaret();

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message.ToString() + Environment.NewLine);
            }
        }

        #endregion


    }
}
