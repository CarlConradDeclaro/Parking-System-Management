namespace Parking
{
    public partial class Form1 : Form
    {


        ParkingEntry pe1;
        Parkout pOut;
        Parkin content;

        private Dashboard _dashboard;

        private static Form1 instance;
      
        public static Form1 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Form1();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            _dashboard = new Dashboard();
            pe1 = new ParkingEntry();

            pe1.VehicleParked += YourForm_VehicleParked;

        }

        private void YourForm_VehicleParked(object sender, EventArgs e)
        {
            // Call the Display method to refresh the Dashboard
          //  _dashboard.Display();
        }


        public void CloseForm() {
            this.Close();
        }

     


        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        { 
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
        
        }

        private void parkout_Click(object sender, EventArgs e)
        {

        }

        private void parkin_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void parkOut1_Load(object sender, EventArgs e)
        {

        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parkin1_Load(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click_1(object sender, EventArgs e)
        {
         
        }

        private void humBtn_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
