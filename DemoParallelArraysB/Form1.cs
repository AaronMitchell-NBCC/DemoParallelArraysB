namespace DemoParallelArraysB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Change the color of the label for fun.
            lblGrade.BackColor = Color.PeachPuff;
        }
        //class-level arrays to hold student data
        //in this demo we are to be using arrays in parallel
        //multiple collections with indexes being linked
        int[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13 };
        string[] students = {"Aaron", "Cathy", "Bob", "Sue", "George", "Jerry", "Elaine",
                             "Kramer", "Mike", "Eleanor"};
        int[] grades = { 44, 99, 67, 80, 60, -12, 90, -10, 55, 75 };

        //event to handle a search based on the data the user provides in the textbox
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false; //Did we find the student info
            //blank out the label
            lblGrade.Text = "";
            //search by name OR id
            int.TryParse(txtStudent.Text, out int id);
            for (int i = 0; i < ids.Length; i++)
            {
                //look for what the student entered
                if (students[i] == txtStudent.Text || ids[i] == id)
                {
                    lblGrade.Text = grades[i].ToString();
                    found = true;
                    break;
                }
            }
            if (!found)
                MessageBox.Show("No student matching the id or name of " + txtStudent.Text,
                    "Data not Found");
        }
    }
}
