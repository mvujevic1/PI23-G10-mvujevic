using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmEvaulation : Form
    {
        private Student student;
        public FrmEvaulation(Student selectedstudent)
        {
            InitializeComponent();
            student = selectedstudent;  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmEvaulation_Load(object sender, EventArgs e)
        {
            SetFormText();
            var activities = ActivitiyRepository.GetActivities;
            cboActivities.DataSource = activities;
        }
        private void SetFormText()
        {
            Text = student.FirstName+" " + student.LastName;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;

            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;
        }

    }
}
