namespace Caneja_Survey
{
    public partial class Form1 : Form
    {
        private string gender, marital, ageRange, income;
        private string employ, educate, rate1, rate2;
        private string purchase, sport, store, design, estitik;
        private string water, cool, bacteria, odor, material, elastic, endure;
        private string brand, interest;
        public Form1()
        {
            InitializeComponent();
        }
        string GetCheckedRadioButtonText(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text;
                }
            }
            return null;
        }
        private void button1_Click(object sender, EventArgs e) //First NextBtn
        {
            //Gender Status
            gender = GetCheckedRadioButtonText(isGender);
            //Age Status
            ageRange = GetCheckedRadioButtonText(RangeAge);
            //Income Status
            income = GetCheckedRadioButtonText(Income);
            //Marital Status
            marital = GetCheckedRadioButtonText(Marital);
            if (marital!=null && gender!=null&&ageRange!=null&&income!=null&&LName.Text!=null&&FName!=null)
            {
                Question2.Visible = true;
            }
            else
                MessageBox.Show("Fill all fields");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Question2.Visible = false;
            Question3.Visible = false;
            Question4.Visible = false;
            Question5.Visible = false;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e) { }
        private void Next2_Click(object sender, EventArgs e)
        {
            //Employment Status
            employ = GetCheckedRadioButtonText(Employment);
            //Education Status
            educate = GetCheckedRadioButtonText(Education);
            //Exercise Rate
            rate1 =GetCheckedRadioButtonText(Exercise);
            //Sportwear products rate
            rate2 =GetCheckedRadioButtonText(Products);

            if (employ!=null && educate!=null&&rate1!=null&&rate2!=null)
            {
                Question3.Visible = true;
            }
            else
                MessageBox.Show("Fill all fields");
        }
        private void groupBox7_Enter(object sender, EventArgs e) { }
        List<string> GetCheckedCheckBoxTexts(GroupBox groupBox)
        {
            List<string> checkedTexts = new List<string>();
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    checkedTexts.Add(checkBox.Text);
                }
            }
            return checkedTexts;
        }
        private void next3_Click(object sender, EventArgs e)
        {
            purchase = GetCheckedRadioButtonText(LastBuy);

            List<string> sportList = GetCheckedCheckBoxTexts(Sport);
            sport = sportList.Count > 0 ? string.Join(", ", sportList) : null;

            List<string> storeList = GetCheckedCheckBoxTexts(Store);
            store = storeList.Count > 0 ? string.Join(", ", storeList) : null;

            List<string> designList = GetCheckedCheckBoxTexts(Design);
            design = designList.Count > 0 ? string.Join(", ", designList) : null;

            List<string> estitikList = GetCheckedCheckBoxTexts(Estitik);
            estitik = estitikList.Count > 0 ? string.Join(", ", estitikList) : null;
            if (sport!=null && store!=null&& design!=null&&estitik!=null)
            {
                Question4.Visible = true;
            }
            else
                MessageBox.Show("Fill all fields");

        }

        private void next4_Click(object sender, EventArgs e)
        {
            water = GetCheckedRadioButtonText(waterr);
            cool = GetCheckedRadioButtonText(Cool);
            bacteria = GetCheckedRadioButtonText(Bacteria);
            odor = GetCheckedRadioButtonText(Odour);
            material = GetCheckedRadioButtonText(Material);
            elastic = GetCheckedRadioButtonText(Elastic);
            endure = GetCheckedRadioButtonText(Endurance);

            if (water!=null && cool!=null&& bacteria!=null&&odor!=null&&material!=null&&elastic!=null&&endure!=null)
            {
                Question5.Visible = true;
            }
            else
                MessageBox.Show("Fill all fields");
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            List<string> brandList = GetCheckedCheckBoxTexts(Brand);
            brand = brandList.Count > 0 ? string.Join(", ", brandList) : null;

            List<string> intList = GetCheckedCheckBoxTexts(Interest);
            interest = intList.Count > 0 ? string.Join(", ", intList) : null;

            if (brand!=null && interest!=null&& Email.Text!=null)
            {
                MessageBox.Show(LName.Text+","+FName.Text+" "+MName+ Environment.NewLine +
                    "Age Range:"+ ageRange+Environment.NewLine+ 
                    "Gender:" + gender +Environment.NewLine+
                    "Employment: " + employ+Environment.NewLine+
                    "Income range:" + income +Environment.NewLine+
                    "Email:" + Email.Text);
            }
            else
                MessageBox.Show("Fill all fields");
        }
    }
}
