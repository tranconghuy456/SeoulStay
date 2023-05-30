using Module_1.Context;
using Module_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_1.Views
{
    public partial class frm_Action : Form
    {
        private ActionModel action = new ActionModel();
        public frm_Action()
        {
            InitializeComponent();
        }

        private void frm_Action_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table = action.ServiceTypesFill();
            cb_Type.DataSource = table;
            cb_Type.DisplayMember = "Name";
            cb_Type.ValueMember = "ID";
            LoadAmenities();
            LoadAttraction();
        }

        private void LoadAmenities()
        {
            DataGridViewCheckBoxColumn chkSelect = new DataGridViewCheckBoxColumn();

            DataTable table = new DataTable();
            table = action.GetAmenitiesData();
            dgv_Amenity.DataSource = table;
            dgv_Amenity.Columns.Add(chkSelect);

        }
        private void LoadAttraction()
        {
            DataTable table = new DataTable();
            table = action.GetAttractionData();
            dgv_Attraction.DataSource = table;
        }

        private void cb_Type_Validating(object sender, CancelEventArgs e)
        {
            ValidateType();
        }

        private void txt_Title_Validating(object sender, CancelEventArgs e)
        {
            ValidateTitle();
        }

        private void nbric_Capacity_Validating(object sender, CancelEventArgs e)
        {
            ValidateCapacity();
        }

        private void nbric_NoBeds_Validating(object sender, CancelEventArgs e)
        {
            ValidateBeds();
        }

        private void nbric_NoBedrooms_Validating(object sender, CancelEventArgs e)
        {
            ValidateBedrooms();
        }

        private void nbric_NoBathrooms_Validating(object sender, CancelEventArgs e)
        {
            ValidateBathrooms();
        }

        private void txt_ApproAddr_Validating(object sender, CancelEventArgs e)
        {
            ValidateApproAddr();
        }

        private void txt_ExactAddr_Validating(object sender, CancelEventArgs e)
        {
            ValidateExactAddr();
        }

        private void rtxt_Des_Validating(object sender, CancelEventArgs e)
        {
            ValidateDes();
        }

        private void txt_HostRules_Validating(object sender, CancelEventArgs e)
        {
            ValidateHostRules();
        }

        private void nbric_ReserMin_Validating(object sender, CancelEventArgs e)
        {
            ValidateReserMin();
        }

        private void nbric_ReserMax_Validating(object sender, CancelEventArgs e)
        {
            ValidateReserMax();
        }

        private bool ValidateType()
        {
            bool status = true;
            if ((int)cb_Type.SelectedValue <= -1)
            {
                errorProvider.SetError(cb_Type, "Please select Service Type!");
                status = false;
            }
            else
                errorProvider.SetError(cb_Type, "");
            return status;
        }

        private bool ValidateTitle()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_Title.Text))
            {
                errorProvider.SetError(txt_Title, "The Title Field must not be empty!");
                status = false;
            } else
                errorProvider.SetError(txt_Title, "");
            return status;
        }

        private bool ValidateCapacity()
        {
            bool status = true;
            if (nbric_Capacity.Value == 0)
            {
                errorProvider.SetError(nbric_Capacity, "The Capacity Field needs to have value of more than 0!");
                status = false;
            }
            else
                errorProvider.SetError(nbric_Capacity, "");
            return status;
        }

        private bool ValidateBeds()
        {
            bool status = true;
            if (nbric_NoBeds.Value == 0)
            {
                errorProvider.SetError(nbric_NoBeds, "The Beds Field needs to have value of more than 0!");
                status = false;
            }
            else
                errorProvider.SetError(nbric_NoBeds, "");
            return status;
        }

        private bool ValidateHostRules()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_ApproAddr.Text))
            {
                errorProvider.SetError(txt_HostRules, "The Host Rules Field must not be empty!");
                status = false;
            }
            else
                errorProvider.SetError(txt_HostRules, "");
            return status;
        }

        private bool ValidateBedrooms()
        {
            bool status = true;
            if (nbric_NoBedrooms.Value == 0)
            {
                errorProvider.SetError(nbric_NoBedrooms, "The Bedrooms Field needs to have value of more than 0!");
                status = false;
            }
            else
                errorProvider.SetError(txt_Title, "");
            return status;
        }

        private bool ValidateBathrooms()
        {
            bool status = true;
            if (nbric_NoBathrooms.Value == 0)
            {
                errorProvider.SetError(nbric_NoBathrooms, "The Bathrooms Field needs to have value of more than 0!");
                status = false;
            }
            else
                errorProvider.SetError(txt_Title, "");
            return status;
        }

        private bool ValidateApproAddr()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_ApproAddr.Text))
            {
                errorProvider.SetError(txt_ApproAddr, "The Approximate Address Field must not be empty!");
                status = false;
            }
            else
                errorProvider.SetError(txt_ApproAddr, "");
            return status;
        }

        private bool ValidateDes()
        {
            bool status = true;
            if (string.IsNullOrEmpty(rtxt_Des.Text))
            {
                errorProvider.SetError(rtxt_Des, "The Description Fields must not be empty!");
                status = false;
            }
            else
                errorProvider.SetError(rtxt_Des, "");
            return status;
        }

        private bool ValidateExactAddr()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txt_ExactAddr.Text))
            {
                errorProvider.SetError(txt_ExactAddr, "The Exact Address Fields must not be empty!");
                status = false;
            }
            else
                errorProvider.SetError(txt_ExactAddr, "");
            return status;
        }

        private bool ValidateReserMin()
        {
            bool status = true;
            if (nbric_ReserMin.Value == 0)
            {
                errorProvider.SetError(nbric_ReserMin, "The Reservation Minimum Field needs to have value of more than 0!");
                status = false;
            }
            else if (nbric_ReserMin.Value > nbric_ReserMax.Value)
            {
                errorProvider.SetError(nbric_ReserMin, "The Reservation Minimum Field needs to have value of smaller than or equal Maximum Field!");
                status = false;
            } else
                errorProvider.SetError(nbric_ReserMin, "");
            return status;
        }

        private bool ValidateReserMax()
        {
            bool status = true;
            if (nbric_ReserMax.Value == 0)
            {
                errorProvider.SetError(nbric_ReserMax, "The Reservation Maximum Field needs to have value of more than 0!");
                status = false;
            }
            else
                errorProvider.SetError(nbric_ReserMax, "");
            return status;
        }

        private void dgv_Amenity_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
