using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson8B
{
    public partial class Lab8Form : Form
    {
        /// <summary>
        /// Class Properties
        /// </summary>
        public string Username { get; set; }
        public float UserAge { get; set; }

        /// <summary>
        /// This is the Constructor for Lab08Form
        /// </summary>
        public Lab8Form()
        {
            InitializeComponent();
        }


        /// <summary>
        /// This is the event handler for the SubmitButton click Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            Username = this.NameTextBox.Text;

            /*float floatResult;
            bool result;
            result = float.TryParse(this.AgeTextBox.Text, out floatResult);
            UserAge = floatResult;*/

            UserAge = float.Parse(this.AgeTextBox.Text);

            OutputLabel.Text = this.NameTextBox.Text + " " + this.AgeTextBox.Text;
                        
            ClearForm();
        }

        /// <summary>
        /// This is method clears the text boxes on the form
        /// </summary>
        private void ClearForm()
        {
            // option A
            this.NameTextBox.Clear();
            this.AgeTextBox.Clear();
            SubmitButton.Enabled = false;

            // option B
            /*this.NameTextBox.Text = "";
            this.AgeTextBox.Text = "";*/

            // option C
            /*this.NameTextBox.Text = string.Empty;
            this.AgeTextBox.Text = string.Empty;*/
        }

        /// <summary>
        /// This is the Event Handler for the AgeTextBox_TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            // simple 
            try
            {
                float.Parse(this.AgeTextBox.Text);
                SubmitButton.Enabled = true;
            }
            catch
            {
                SubmitButton.Enabled = false;
            }
        }

        /// <summary>
        /// This is the Event Handler for the Lab08Form Load Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// This is the Event Handler for the NameTextBox_TextChanged Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;
        }
    }
}
