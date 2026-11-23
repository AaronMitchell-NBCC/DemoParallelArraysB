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
        //in this demo we are going to be using arrays in parallel
        //multiple collections with indexes being linked
        int[] ids = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 13 };
        string[] students = {"Aaron", "Cathy", "Bob", "Sue", "George", "Jerry", "Elaine",
                             "Kramer", "Mike", "Eleanor"};
        int[] grades = { 44, 99, 67, 80, 60, -12, 90, -10, 55, 75 };

        //event to handle a search based on the data the user provides in the textbox
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool found = false; //Did we find the student info?

            //blank out the label
            lblGrade.Text = "";

            //search by name OR id through the arrays
            //we are not capturing the result of our TryParse because we
            //want to search regardless of its success
            int.TryParse(txtStudent.Text, out int id);
            //We could use any of the arrays for the test condition (because they are the same length!)
            for (int i = 0; i < ids.Length; i++)
            {
                //look for what the student entered and compare it to the arrays
                if (students[i].ToLower() == txtStudent.Text.ToLower() || ids[i] == id)
                {
                    //if we have a match, set the label with the grade and exit the loop
                    lblGrade.Text = grades[i].ToString();
                    found = true;
                    break;
                }
            }
            if (!found) //this is if we never flipped our found bool, so we had no grade to show
                MessageBox.Show("No student matching the id or name of " + txtStudent.Text,
                    "Data not Found");
        }
    }
}
