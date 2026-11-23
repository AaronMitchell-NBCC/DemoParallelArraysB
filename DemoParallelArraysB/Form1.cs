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



    }
}
