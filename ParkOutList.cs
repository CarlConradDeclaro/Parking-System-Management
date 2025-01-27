﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class ParkOutList : UserControl
    {
        public event EventHandler ParkingRecordAdded;
        private ParkingRecord parkingRecord;
        private FlowLayoutPanel flowPanelVH;
        private Parkout titleLabel;
        private System.Windows.Forms.Label amtTxt;
        private System.Windows.Forms.Label statusTxt;




    

        public ParkOutList(FlowLayoutPanel flowPanelVH, Parkout titleLabel, System.Windows.Forms.Label amtTxt, System.Windows.Forms.Label statusTxt)
        {
            InitializeComponent();
            this.flowPanelVH = flowPanelVH;
            this.titleLabel = titleLabel;
            this.amtTxt = amtTxt;
            this.statusTxt = statusTxt;
            SetButtonRoundedCorners(parkout);
        }

        private void ParkOutList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingRecord parkRecord)
        {
            parkingRecord = parkRecord; 
            plateNo.Text = parkRecord.PlateNumber;
            type.Text = parkRecord.Type;
            brand.Text = parkRecord.Model;
        }     
        private void parkout_Click(object sender, EventArgs e)
        {
          
            titleLabel.getVHparkOutnType(parkingRecord.PlateNumber,parkingRecord.Type);
          
            statusTxt.Text = "Not Paid";
            flowPanelVH.Controls.Clear();         
            string selectedPlateNo = plateNo.Text;
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();          
              foreach (var record in allParkingRecords)
             { 
                if(record.PlateNumber == selectedPlateNo)
                {
                    vehicleDetails Plate = new vehicleDetails();
                    Plate.UpdateLabels("Plate No.", record.PlateNumber);
                    flowPanelVH.Controls.Add(Plate);                  
                    vehicleDetails Type = new vehicleDetails();
                    Type.UpdateLabels("Type", record.Type);
                    flowPanelVH.Controls.Add(Type);

                    vehicleDetails Model = new vehicleDetails();
                    Model.UpdateLabels("Model", record.Model);
                    flowPanelVH.Controls.Add(Model);

                    vehicleDetails Driver = new vehicleDetails();
                    Driver.UpdateLabels("Driver", record.Driver);
                    flowPanelVH.Controls.Add(Driver);

                    vehicleDetails Phone = new vehicleDetails();
                    Phone.UpdateLabels("Phone", record.Phone);
                    flowPanelVH.Controls.Add(Phone);

                    vehicleDetails ArrivalDate = new vehicleDetails();
                    ArrivalDate.UpdateLabels("Arrival Date", record.ArrivalDate);
                    flowPanelVH.Controls.Add(ArrivalDate);

                    vehicleDetails ArrivalTime = new vehicleDetails();
                    ArrivalTime.UpdateLabels("Arrival Time", record.ArrivalTime);
                    flowPanelVH.Controls.Add(ArrivalTime);

                            
                    return;
                }               
              }
        }

        private void SetButtonRoundedCorners(Button button)
        {
            int radius = 20; // Radius for the rounded corners
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddLine(radius, 0, button.Width - radius, 0);
            path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), -90, 90);
            path.AddLine(button.Width, radius, button.Width, button.Height - radius);
            path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
            path.AddLine(button.Width - radius, button.Height, radius, button.Height);
            path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }
    }
}
