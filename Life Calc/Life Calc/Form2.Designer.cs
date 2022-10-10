
namespace Life_Calc
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CollegeCB = new System.Windows.Forms.ComboBox();
            this.MajorCB = new System.Windows.Forms.ComboBox();
            this.MonthlyRevTB = new System.Windows.Forms.TextBox();
            this.MonthlySpendingTB = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.ParentsPayRB = new System.Windows.Forms.RadioButton();
            this.AllLoansRB = new System.Windows.Forms.RadioButton();
            this.PartialPaymentsRB = new System.Windows.Forms.RadioButton();
            this.AmountPaidTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.FinShapeLB = new System.Windows.Forms.Label();
            this.SpendLimLB = new System.Windows.Forms.Label();
            this.EstimatedEarnLB = new System.Windows.Forms.Label();
            this.LearnMoreLB = new System.Windows.Forms.Button();
            this.HomeBN = new System.Windows.Forms.Button();
            this.ColCostLB = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2400, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "      Calculate Your Financial Future";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CollegeCB
            // 
            this.CollegeCB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollegeCB.FormattingEnabled = true;
            this.CollegeCB.Items.AddRange(new object[] {
            "Massachusetts Institute of Technology",
            "Princeton University",
            "Yale University",
            "Harvard University",
            "California Institute of Technology",
            "Duke University",
            "University of Pennsylvania",
            "Columbia University",
            "Rice University",
            "Stanford University",
            "University of California--Berkeley",
            "Vanderbilt University",
            "Brown University",
            "Williams College",
            "University of California--Los Angeles",
            "University of Chicago",
            "Georgia Institute of Technology",
            "Northwestern University",
            "Pomona College",
            "Johns Hopkins University",
            "Amherst College",
            "Dartmouth College",
            "Harvey Mudd College",
            "University of Notre Dame",
            "Carnegie Mellon University",
            "Washington University in St. Louis",
            "Georgetown University",
            "University of Michigan--Ann Arbor",
            "Swarthmore College",
            "University of Virginia",
            "Cornell University",
            "University of California--San Diego",
            "University of North Carolina--Chapel Hill",
            "Emory University",
            "Claremont McKenna College",
            "Wellesley College",
            "University of Southern California",
            "Case Western Reserve University",
            "Northeastern University",
            "University of California--Irvine",
            "Colby College",
            "Carleton College",
            "Middlebury College",
            "University of Florida",
            "Tufts University",
            "College of William and Mary",
            "University of California--Santa Barbara",
            "Vassar College",
            "University of Texas--Austin",
            "Grinnell College",
            "Binghamton University--SUNY",
            "Colgate University",
            "Barnard College",
            "Washington and Lee University",
            "Stevens Institute of Technology",
            "University of Richmond",
            "Brigham Young University--Provo",
            "Lehigh University",
            "Boston College",
            "University of California--Davis",
            "Lafayette College",
            "Macalester College",
            "University of Tulsa",
            "California Polytechnic State University--San Luis Obispo",
            "University of Washington",
            "Stony Brook University--SUNY",
            "University of Georgia",
            "Bryn Mawr College",
            "Illinois Institute of Technology",
            "Rensselaer Polytechnic Institute",
            "Ohio State University--Columbus",
            "Brandeis University",
            "University of Connecticut",
            "North Carolina State University--Raleigh",
            "New York University",
            "Davidson College",
            "University of Wisconsin--Madison",
            "Haverford College",
            "St. Olaf College",
            "University of Minnesota--Twin Cities",
            "University of Illinois--Urbana-Champaign",
            "Tulane University",
            "Villanova University",
            "Clemson University",
            "Trinity University",
            "Boston University",
            "California State University--Long Beach",
            "Oberlin College",
            "Purdue University--West Lafayette",
            "University of California--Santa Cruz",
            "Bucknell University",
            "Kenyon College",
            "Bentley University",
            "Milwaukee School of Engineering",
            "Rhodes College",
            "George Washington University",
            "Florida State University",
            "American University",
            "Scripps College",
            "University of South Florida",
            "Virginia Military Institute",
            "Santa Clara University",
            "Skidmore College",
            "College of New Jersey",
            "University of Miami",
            "Pepperdine University",
            "Truman State University",
            "DePauw University",
            "Occidental College",
            "Centre College",
            "Yeshiva University",
            "College of Wooster",
            "University of Massachusetts--Amherst",
            "Whitman College",
            "Michigan Technological University",
            "Rochester Institute of Technology",
            "Texas A&M University--College Station",
            "University of California--Riverside",
            "Southern Methodist University",
            "Illinois Wesleyan University",
            "Syracuse University",
            "Southwestern University",
            "University at Buffalo--SUNY",
            "College of the Ozarks",
            "University of Delaware",
            "University of San Diego",
            "Union University",
            "University of Pittsburgh",
            "Fordham University",
            "Mississippi College",
            "Wabash College",
            "SUNY Polytechnic Institute--Albany/Utica",
            "Gonzaga University",
            "Howard University",
            "Reed College",
            "New Jersey Institute of Technology",
            "William Jewell College",
            "University of Dallas",
            "LeTourneau University",
            "Missouri University of Science & Technology",
            "Drake University",
            "University of Minnesota--Morris",
            "Miami University--Oxford",
            "Alice Lloyd College",
            "Baylor University",
            "University of Utah",
            "University of Central Florida",
            "Clarkson University",
            "Loyola Marymount University",
            "Augustana University",
            "University of Maryland--Baltimore County",
            "San Diego State University",
            "Coe College",
            "Saint Louis University",
            "St. Joseph\'s College New York",
            "William Carey University",
            "Michigan State University",
            "University of the Pacific",
            "St. Mary\'s College of Maryland",
            "Wofford College",
            "Wheaton College",
            "Lewis University",
            "SUNY College--Oneonta",
            "Millsaps College",
            "University of Evansville",
            "University of Vermont",
            "Ohio Northern University",
            "University of Texas--Dallas",
            "University of Detroit Mercy",
            "Bradley University",
            "California State Polytechnic University--Pomona",
            "Cedarville University",
            "Indiana University--Bloomington",
            "Newman University",
            "University of Iowa",
            "Dominican University",
            "California State University--Fullerton",
            "University of St. Francis",
            "Columbia International University",
            "Saint Vincent College",
            "Presbyterian College",
            "University of Houston",
            "University of Denver",
            "Pennsylvania State University--University Park",
            "University of Illinois--Springfield",
            "Simmons University",
            "Appalachian State University",
            "Ave Maria University",
            "Texas Christian University",
            "Webster University",
            "Goshen College",
            "Cottey College",
            "Austin College",
            "Walla Walla University",
            "Eastern Mennonite University",
            "Lawrence Technological University",
            "University of West Alabama",
            "SUNY--Plattsburgh",
            "Maryville College",
            "Creighton University",
            "University of Missouri--Kansas City",
            "California State University--Los Angeles",
            "Florida International University",
            "Pacific Lutheran University",
            "Thomas Aquinas College",
            "Hendrix College",
            "Western Carolina University",
            "University of California--Merced",
            "University of Massachusetts--Lowell",
            "James Madison University",
            "Rockhurst University",
            "Mercer University",
            "Caldwell University",
            "Kuyper College",
            "Seattle University",
            "Washington State University",
            "University of Tennessee",
            "University of South Carolina",
            "Calvin College",
            "University of Oklahoma",
            "University of St. Mary",
            "University of North Carolina--Wilmington",
            "University of Missouri",
            "Le Moyne College",
            "Chapman University",
            "John Brown University",
            "SUNY--Oswego",
            "Luther College",
            "Central College",
            "Florida Southern College",
            "Drexel University",
            "Holy Names University",
            "Fresno Pacific University",
            "Azusa Pacific University",
            "California State University--Northridge",
            "University at Albany--SUNY",
            "University of San Francisco",
            "University of North Florida",
            "SUNY--Geneseo",
            "University of Rhode Island",
            "Messiah College",
            "Framingham State University",
            "Manhattan College",
            "Brescia University",
            "University of Nebraska--Lincoln",
            "Ball State University",
            "Randolph-Macon College",
            "University of Mount Olive",
            "York College of Pennsylvania",
            "Albion College",
            "University of Dayton",
            "Dallas Baptist University",
            "Lipscomb University",
            "Piedmont College",
            "Butler University",
            "Duquesne University",
            "University of Redlands",
            "Tennessee Technological University",
            "College of St. Benedict",
            "Simpson College",
            "San Jose State University",
            "St. Mary\'s College",
            "University of Scranton",
            "Florida Institute of Technology",
            "College at Brockport--SUNY",
            "Arizona State University--Tempe",
            "Northwestern College",
            "University of La Verne",
            "Hope College",
            "Augsburg University",
            "Salem College",
            "Kettering University",
            "Elon University",
            "Ramapo College of New Jersey",
            "Iowa State University",
            "Berry College",
            "North Park University",
            "John Carroll University",
            "Bridgewater College",
            "Capital University",
            "California Lutheran University",
            "Oregon Institute of Technology",
            "Oklahoma Christian University",
            "University of New Mexico",
            "Taylor University",
            "Andrews University",
            "Bryan College",
            "Roberts Wesleyan College",
            "Florida A&M University",
            "George Mason University",
            "University of Montevallo",
            "Harding University",
            "Notre Dame of Maryland University",
            "St. John Fisher College",
            "New York Institute of Technology",
            "Louisiana Tech University",
            "SUNY--Fredonia",
            "Spelman College",
            "University of Alabama",
            "Georgia College & State University",
            "University of Mary Washington",
            "St. Mary\'s College of California",
            "University of Alabama--Huntsville",
            "Olivet Nazarene University",
            "Oklahoma Baptist University",
            "St. John\'s University",
            "Spalding University",
            "Barton College",
            "California State University--San Marcos",
            "Nova Southeastern University",
            "Lycoming College",
            "University of Illinois--Chicago",
            "Seton Hall University",
            "University of Idaho",
            "Birmingham-Southern College",
            "Pacific Union College",
            "Lindenwood University",
            "California State University--San Bernardino",
            "Eastern Michigan University",
            "Asbury University",
            "North Greenville University",
            "Ripon College",
            "College of Our Lady of the Elms",
            "Eastern University",
            "University of Texas--Rio Grande Valley",
            "Biola University",
            "Geneva College",
            "Ferris State University",
            "Trevecca Nazarene University",
            "The Master\'s University and Seminary",
            "Mount Vernon Nazarene University",
            "California State University--Fresno",
            "Corban University",
            "Point Loma Nazarene University",
            "Davis and Elkins College",
            "Niagara University",
            "Christopher Newport University",
            "Rockford University",
            "Texas A&M International University",
            "Valparaiso University",
            "University of Science and Arts of Oklahoma",
            "Hanover College",
            "Blackburn College",
            "Marietta College",
            "Canisius College",
            "Wheeling Jesuit University",
            "Hamline University",
            "Auburn University",
            "Texas Lutheran University",
            "California State University--Chico",
            "Doane University",
            "Oglethorpe University",
            "Samford University",
            "Worcester State University",
            "University of Louisiana--Lafayette",
            "Spring Hill College",
            "St. Bonaventure University",
            "Lakeland University",
            "Otterbein University",
            "Loyola University Chicago",
            "Purchase College--SUNY",
            "University of Cincinnati",
            "Adelphi University",
            "Loyola University New Orleans",
            "Marquette University",
            "Molloy College",
            "Greenville University",
            "Bowie State University",
            "Clarke University",
            "MidAmerica Nazarene University",
            "St. Francis College",
            "Alma College",
            "Oklahoma State University",
            "Lincoln Memorial University",
            "Mount St. Mary\'s University",
            "Liberty University",
            "Covenant College",
            "Gardner-Webb University",
            "Vanguard University of Southern California",
            "Indiana Wesleyan University",
            "St. Catherine University",
            "Elizabethtown College",
            "University of Arkansas",
            "Western Washington University",
            "Ashland University",
            "York College",
            "University of North Carolina--Charlotte",
            "McDaniel College",
            "San Francisco State University",
            "Thomas Jefferson University",
            "Misericordia University",
            "Oregon State University",
            "Catawba College",
            "SUNY--New Paltz",
            "Oklahoma City University",
            "East Central University",
            "Fitchburg State University",
            "Minot State University",
            "Emerson College",
            "St. Thomas University",
            "University of North Alabama",
            "Linfield College",
            "Farmingdale State College--SUNY",
            "Texas Tech University",
            "Middle Tennessee State University",
            "Colorado State University",
            "Young Harris College",
            "McPherson College",
            "Wartburg College",
            "California State University--Sacramento",
            "Houghton College",
            "Carroll College",
            "College of St. Scholastica",
            "University of Michigan--Flint",
            "University of Northern Iowa",
            "Nebraska Wesleyan University",
            "Cardinal Stritch University",
            "Arcadia University",
            "Georgetown College",
            "University of Maryland--Eastern Shore",
            "Xavier University",
            "Springfield College",
            "Trinity Christian College",
            "University of North Carolina--Asheville",
            "University of Minnesota--Crookston",
            "Northern Illinois University",
            "University of Mary",
            "Ouachita Baptist University",
            "Millikin University",
            "Moravian College",
            "Flagler College",
            "Grand Valley State University",
            "West Virginia University Institute of Technology",
            "University of North Carolina--Greensboro",
            "Roanoke College",
            "University of West Florida",
            "Central Washington University",
            "University of Louisiana--Monroe",
            "St. Xavier University",
            "Sam Houston State University",
            "Jacksonville State University",
            "Gannon University",
            "Anderson University",
            "Hollins University",
            "Bridgewater State University",
            "Manchester University",
            "Trine University",
            "Carroll University",
            "Cedar Crest College",
            "Minnesota State University--Moorhead",
            "Winona State University",
            "Lyon College",
            "Friends University",
            "Avila University",
            "Hampden-Sydney College",
            "McKendree University",
            "Westmont College",
            "New Mexico State University",
            "University of Colorado--Boulder",
            "West Virginia University",
            "Woodbury University",
            "University of Tampa",
            "Arkansas State University",
            "Eckerd College",
            "University of Charleston",
            "Central Michigan University",
            "Coppin State University",
            "St. John\'s University",
            "Viterbo University",
            "Elmhurst College",
            "University of Lynchburg",
            "Meredith College",
            "The Citadel",
            "St. Norbert College",
            "Georgia State University",
            "Lake Superior State University",
            "Edgewood College",
            "Hampton University",
            "Franklin College",
            "Florida Atlantic University",
            "Southwestern Assemblies of God University",
            "Houston Baptist University",
            "Marian University",
            "Huntington University",
            "Towson University",
            "Emory and Henry College",
            "University of Hawaii--Manoa",
            "Carthage College",
            "Bethany Lutheran College",
            "Alfred University",
            "Mills College",
            "Utah State University",
            "University of Texas--Arlington",
            "Stevenson University",
            "University of North Texas",
            "University of Findlay",
            "University of Mississippi",
            "Judson University",
            "University of Alaska--Fairbanks",
            "Stockton University",
            "Harrisburg Area Community College",
            "Undecided"});
            this.CollegeCB.Location = new System.Drawing.Point(102, 226);
            this.CollegeCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CollegeCB.Name = "CollegeCB";
            this.CollegeCB.Size = new System.Drawing.Size(715, 49);
            this.CollegeCB.TabIndex = 2;
            // 
            // MajorCB
            // 
            this.MajorCB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MajorCB.FormattingEnabled = true;
            this.MajorCB.Items.AddRange(new object[] {
            "Computer Science",
            "Master of Arts",
            "Engineering",
            "Undecided",
            "Agriculture, General",
            "Agribusiness Operations",
            "Agricultural Business & Management",
            "Agricultural Economics",
            "Agricultural Mechanization",
            "Agricultural Production",
            "Agronomy & Crop Science",
            "Animal Sciences",
            "Food Sciences & Technology",
            "Horticulture Operations & Management",
            "Horticulture Science",
            "Natural Resources Conservation, General",
            "Environmental Science",
            "Forestry",
            "Natural Resources Management",
            "Wildlife & Wildlands Management",
            "Architecture, General",
            "Architectural Environmental Design",
            "City/Urban/Regional Planning",
            "Interior Architecture",
            "Landscape Architecture",
            "Area Studies, General (e.g., African, Middle Eastern)",
            "Asian Area Studies",
            "European Area Studies",
            "Latin American Area Studies",
            "North American Area Studies",
            "Ethnic & Minority Studies, General",
            "African American Studies",
            "American Indian/Native American Studies",
            "Latino/Chicano Studies",
            "Women’s Studies",
            "Liberal Arts & General Studies",
            "Library Science",
            "Multi/Interdisciplinary Studies",
            "Art, General",
            "Art History, Criticism & Conservation",
            "Fine/Studio Arts",
            "Cinema/Film",
            "Cinematography/Film/Vide Production",
            "Dance",
            "Design & Visual Communications, General",
            "Fashion/Apparel Design",
            "Graphic Design",
            "Industrial Design",
            "Interior Design",
            "Music, General",
            "Music, Performance",
            "Music, Theory & Composition",
            "Photography",
            "Theatre Arts/Drama",
            "Accounting",
            "Accounting Technician",
            "Business Administration & Management, General",
            "Hotel/Motel Management",
            "Human Resources Development/Training",
            "Human Resources Management",
            "International Business Management",
            "Labor/Industrial Relations",
            "Logistics & Materials Management",
            "Marketing Management & Research",
            "Office Supervision & Management",
            "Operations Management & Supervision",
            "Organizational Behavior",
            "Purchasing/Procurement/Contracts Management",
            "Restaurant/Food Services Management",
            "Small Business Management/Operations",
            "Travel/Tourism Management",
            "Business/Management Quantitative Methods, General",
            "Actuarial Science",
            "Business/Managerial Economics",
            "Finance, General",
            "Banking & Financial Support Services",
            "Financial Planning & Services",
            "Insurance & Risk Management",
            "Investments & Securities",
            "Management Information Systems",
            "Real Estate",
            "Sales, Merchandising, & Marketing, General",
            "Fashion Merchandising",
            "Tourism & Travel Marketing",
            "Secretarial Studies & Office Administration",
            "Communications, General",
            "Advertising",
            "Digital Communications/Media",
            "Journalism, Broadcast",
            "Journalism, Print",
            "Mass Communications",
            "Public Relations & Organizational Communication",
            "Radio & Television Broadcasting",
            "Communications Technology, General",
            "Graphic & Printing Equipment Operation",
            "Multimedia/Animation/Special Effects",
            "Radio & Television Broadcasting Technology",
            "Computer & Information Sciences, General",
            "Computer Networking/Telecommunications",
            "Computer Science & Programming",
            "Computer Software & Media Applications",
            "Computer System Administration",
            "Data Management Technology",
            "Information Science",
            "Webpage Design",
            "Mathematics, General",
            "Applied Mathematics",
            "Statistics",
            "Counseling & Student Services",
            "Educational Administration",
            "Special Education",
            "Teacher Education, General",
            "Curriculum & Instruction",
            "Early Childhood Education",
            "Elementary Education",
            "Junior High/Middle School Education",
            "Postsecondary Education",
            "Secondary Education",
            "Teacher Assisting/Aide Education",
            "Teacher Education, Subject-Specific",
            "Agricultural Education",
            "Art Education",
            "Business Education",
            "Career & Technical Education",
            "English-as-a-Second-Language Education",
            "English/Language Arts Education",
            "Foreign Languages Education",
            "Health Education",
            "Mathematics Education",
            "Music Education",
            "Physical Education & Coaching",
            "Science Education",
            "Social Studies/Sciences Education",
            "Aerospace/Aeronautical Engineering",
            "Agricultural/Bioengineering",
            "Architectural Engineering",
            "Biomedical Engineering",
            "Chemical Engineering",
            "Civil Engineering",
            "Computer Engineering",
            "Construction Engineering/Management",
            "Electrical, Electronics & Communications Engineering",
            "Environmental Health Engineering",
            "Industrial Engineering",
            "Nuclear Engineering",
            "Drafting/CAD Technology, General",
            "Architectural Drafting/CAD Technology",
            "Mechanical Drafting/CAD Technology",
            "Engineering Technology, General",
            "Aeronautical/Aerospace Engineering Technologies",
            "Architectural Engineering Technology",
            "Automotive Engineering Technology",
            "Civil Engineering Technology",
            "Computer Engineering Technology",
            "Construction/Building Technology",
            "Electrical, Electronics Engineering Technologies",
            "Electromechanical/Biomedical Engineering Technologies",
            "Environmental Control Technologies",
            "Industrial Production Technologies",
            "Quality Control & Safety Technologies",
            "Surveying Technology",
            "English Language & Literature, General",
            "American/English Literature",
            "Creative Writing",
            "Public Speaking",
            "Foreign Languages/Literatures, General",
            "Asian Languages & Literatures",
            "Classical/Ancient Languages & Literatures",
            "Comparative Literature",
            "French Language & Literature",
            "German Language & Literature",
            "Linguistics",
            "Middle Eastern Languages & Literatures",
            "Spanish Language & Literature",
            "Health Services Administration,General",
            "Hospital/Facilities Administration",
            "Medical Office/Secretarial",
            "Medical Records",
            "Medical/Clinical Assisting, General",
            "Dental Assisting",
            "Medical Assisting",
            "Occupational Therapy Assisting",
            "Physical Therapy Assisting",
            "Veterinarian Assisting/Technology",
            "Chiropractic (Pre-Chiropractic)",
            "Dental Hygiene",
            "Dentistry (Pre-Dentistry)",
            "Emergency Medical Technology",
            "Health-Related Professions & Services, General",
            "Athletic Training",
            "Communication Disorder Services (e.g., Speech Pathology)",
            "Public Health",
            "Health/Medical Technology, General",
            "Medical Laboratory Technology",
            "Medical Radiologic Technology",
            "Nuclear Medicine Technology",
            "Respiratory Therapy Technology",
            "Surgical Technology",
            "Medicine (Pre-Medicine)",
            "Nursing, Practical/Vocational (LPN)",
            "Nursing, Registered (BS/RN)",
            "Optometry (Pre-Optometry)",
            "Osteopathic Medicine",
            "Pharmacy (Pre-Pharmacy)",
            "Physician Assisting",
            "Therapy & Rehabilitation, General",
            "Alcohol/Drug Abuse Counseling",
            "Massage Therapy",
            "Mental Health Counseling",
            "Occupational Therapy",
            "Physical Therapy (Pre-Physical Therapy)",
            "Psychiatric/Mental Health Technician",
            "Rehabilitation Therapy",
            "Vocational Rehabilitation Counseling",
            "Veterinary Medicine (Pre-Veterinarian)",
            "Philosophy",
            "Religion",
            "Theology, General",
            "Bible/Biblical Studies",
            "Divinity/Ministry",
            "Religious Education",
            "Biology, General",
            "Biochemistry & Biophysics",
            "Cell/Cellular Biology",
            "Ecology",
            "Genetics",
            "Marine/Aquatic Biology",
            "Microbiology & Immunology",
            "Zoology",
            "Physical Sciences, General",
            "Astronomy",
            "Atmospheric Sciences & Meteorology",
            "Chemistry",
            "Geological & Earth Sciences",
            "Physics",
            "Legal Studies, General",
            "Court Reporting",
            "Law (Pre-Law)",
            "Legal Administrative Assisting/Secretarial",
            "Paralegal/Legal Assistant",
            "Social Sciences, General",
            "Anthropology",
            "Criminology",
            "Economics",
            "Geography",
            "History",
            "International Relations & Affairs",
            "Political Science & Government",
            "Psychology, Clinical & Counseling",
            "Psychology, General",
            "Sociology",
            "Urban Studies/Urban Affairs",
            "Mechanical Engineering"});
            this.MajorCB.Location = new System.Drawing.Point(102, 309);
            this.MajorCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MajorCB.Name = "MajorCB";
            this.MajorCB.Size = new System.Drawing.Size(715, 49);
            this.MajorCB.TabIndex = 3;
            // 
            // MonthlyRevTB
            // 
            this.MonthlyRevTB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyRevTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.MonthlyRevTB.Location = new System.Drawing.Point(102, 495);
            this.MonthlyRevTB.Name = "MonthlyRevTB";
            this.MonthlyRevTB.Size = new System.Drawing.Size(517, 48);
            this.MonthlyRevTB.TabIndex = 4;
            this.MonthlyRevTB.Text = "Current Monthly Revenue";
            // 
            // MonthlySpendingTB
            // 
            this.MonthlySpendingTB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlySpendingTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.MonthlySpendingTB.Location = new System.Drawing.Point(102, 549);
            this.MonthlySpendingTB.Name = "MonthlySpendingTB";
            this.MonthlySpendingTB.Size = new System.Drawing.Size(517, 48);
            this.MonthlySpendingTB.TabIndex = 5;
            this.MonthlySpendingTB.Text = "Cost of Monthly Necessities";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(88, 628);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(453, 168);
            this.panel.TabIndex = 10;
            // 
            // ParentsPayRB
            // 
            this.ParentsPayRB.AutoSize = true;
            this.ParentsPayRB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParentsPayRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ParentsPayRB.Location = new System.Drawing.Point(102, 648);
            this.ParentsPayRB.Name = "ParentsPayRB";
            this.ParentsPayRB.Size = new System.Drawing.Size(409, 45);
            this.ParentsPayRB.TabIndex = 6;
            this.ParentsPayRB.TabStop = true;
            this.ParentsPayRB.Text = "Parents Pay for College";
            this.ParentsPayRB.UseVisualStyleBackColor = true;
            this.ParentsPayRB.CheckedChanged += new System.EventHandler(this.ParentsPayRB_CheckedChanged);
            // 
            // AllLoansRB
            // 
            this.AllLoansRB.AutoSize = true;
            this.AllLoansRB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllLoansRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AllLoansRB.Location = new System.Drawing.Point(102, 698);
            this.AllLoansRB.Name = "AllLoansRB";
            this.AllLoansRB.Size = new System.Drawing.Size(192, 45);
            this.AllLoansRB.TabIndex = 7;
            this.AllLoansRB.TabStop = true;
            this.AllLoansRB.Text = "All Loans";
            this.AllLoansRB.UseVisualStyleBackColor = true;
            this.AllLoansRB.CheckedChanged += new System.EventHandler(this.AllLoansRB_CheckedChanged);
            // 
            // PartialPaymentsRB
            // 
            this.PartialPaymentsRB.AutoSize = true;
            this.PartialPaymentsRB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartialPaymentsRB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PartialPaymentsRB.Location = new System.Drawing.Point(102, 749);
            this.PartialPaymentsRB.Name = "PartialPaymentsRB";
            this.PartialPaymentsRB.Size = new System.Drawing.Size(314, 45);
            this.PartialPaymentsRB.TabIndex = 8;
            this.PartialPaymentsRB.TabStop = true;
            this.PartialPaymentsRB.Text = "Partial Payments";
            this.PartialPaymentsRB.UseVisualStyleBackColor = true;
            this.PartialPaymentsRB.CheckedChanged += new System.EventHandler(this.PartialPaymentsRB_CheckedChanged);
            // 
            // AmountPaidTB
            // 
            this.AmountPaidTB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountPaidTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.AmountPaidTB.Location = new System.Drawing.Point(102, 802);
            this.AmountPaidTB.Name = "AmountPaidTB";
            this.AmountPaidTB.Size = new System.Drawing.Size(440, 48);
            this.AmountPaidTB.TabIndex = 11;
            this.AmountPaidTB.Text = "Enter Amount Paid For";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 892);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(440, 85);
            this.button1.TabIndex = 12;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(1196, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 69);
            this.label2.TabIndex = 13;
            this.label2.Text = "Result";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.Color.Gold;
            this.temp.ForeColor = System.Drawing.Color.Gold;
            this.temp.Location = new System.Drawing.Point(1574, 29);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(21, 20);
            this.temp.TabIndex = 16;
            this.temp.Text = "hi";
            // 
            // FinShapeLB
            // 
            this.FinShapeLB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinShapeLB.ForeColor = System.Drawing.Color.Lime;
            this.FinShapeLB.Location = new System.Drawing.Point(824, 328);
            this.FinShapeLB.Name = "FinShapeLB";
            this.FinShapeLB.Size = new System.Drawing.Size(1052, 55);
            this.FinShapeLB.TabIndex = 17;
            this.FinShapeLB.Text = "You are in good financial shape:";
            this.FinShapeLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpendLimLB
            // 
            this.SpendLimLB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpendLimLB.ForeColor = System.Drawing.Color.Black;
            this.SpendLimLB.Location = new System.Drawing.Point(824, 414);
            this.SpendLimLB.Name = "SpendLimLB";
            this.SpendLimLB.Size = new System.Drawing.Size(1052, 55);
            this.SpendLimLB.TabIndex = 18;
            this.SpendLimLB.Text = "Your Monthly Spending Limit is $___ to $___";
            this.SpendLimLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EstimatedEarnLB
            // 
            this.EstimatedEarnLB.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstimatedEarnLB.ForeColor = System.Drawing.Color.Black;
            this.EstimatedEarnLB.Location = new System.Drawing.Point(824, 508);
            this.EstimatedEarnLB.Name = "EstimatedEarnLB";
            this.EstimatedEarnLB.Size = new System.Drawing.Size(1052, 55);
            this.EstimatedEarnLB.TabIndex = 19;
            this.EstimatedEarnLB.Text = "You are estimated to earn $____ after college (based on major)";
            this.EstimatedEarnLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LearnMoreLB
            // 
            this.LearnMoreLB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LearnMoreLB.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LearnMoreLB.ForeColor = System.Drawing.Color.White;
            this.LearnMoreLB.Location = new System.Drawing.Point(1072, 681);
            this.LearnMoreLB.Name = "LearnMoreLB";
            this.LearnMoreLB.Size = new System.Drawing.Size(523, 141);
            this.LearnMoreLB.TabIndex = 20;
            this.LearnMoreLB.Text = "Learn More";
            this.LearnMoreLB.UseVisualStyleBackColor = false;
            this.LearnMoreLB.Click += new System.EventHandler(this.LearnMoreLB_Click);
            // 
            // HomeBN
            // 
            this.HomeBN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HomeBN.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBN.ForeColor = System.Drawing.Color.White;
            this.HomeBN.Location = new System.Drawing.Point(1072, 881);
            this.HomeBN.Name = "HomeBN";
            this.HomeBN.Size = new System.Drawing.Size(523, 120);
            this.HomeBN.TabIndex = 25;
            this.HomeBN.Text = "Home";
            this.HomeBN.UseVisualStyleBackColor = false;
            this.HomeBN.Click += new System.EventHandler(this.HomeBN_Click);
            // 
            // ColCostLB
            // 
            this.ColCostLB.Font = new System.Drawing.Font("Georgia", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColCostLB.ForeColor = System.Drawing.Color.Black;
            this.ColCostLB.Location = new System.Drawing.Point(817, 587);
            this.ColCostLB.Name = "ColCostLB";
            this.ColCostLB.Size = new System.Drawing.Size(1069, 55);
            this.ColCostLB.TabIndex = 26;
            this.ColCostLB.Text = "Your expected college loans can range from $_____ to $______.";
            this.ColCostLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(878, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 49);
            this.button2.TabIndex = 27;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ColCostLB);
            this.Controls.Add(this.HomeBN);
            this.Controls.Add(this.LearnMoreLB);
            this.Controls.Add(this.EstimatedEarnLB);
            this.Controls.Add(this.SpendLimLB);
            this.Controls.Add(this.FinShapeLB);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AmountPaidTB);
            this.Controls.Add(this.PartialPaymentsRB);
            this.Controls.Add(this.AllLoansRB);
            this.Controls.Add(this.ParentsPayRB);
            this.Controls.Add(this.MonthlySpendingTB);
            this.Controls.Add(this.MonthlyRevTB);
            this.Controls.Add(this.MajorCB);
            this.Controls.Add(this.CollegeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CollegeCB;
        private System.Windows.Forms.ComboBox MajorCB;
        private System.Windows.Forms.TextBox MonthlyRevTB;
        private System.Windows.Forms.TextBox MonthlySpendingTB;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.RadioButton ParentsPayRB;
        private System.Windows.Forms.RadioButton AllLoansRB;
        private System.Windows.Forms.RadioButton PartialPaymentsRB;
        private System.Windows.Forms.TextBox AmountPaidTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label SpendLimLB;
        private System.Windows.Forms.Label EstimatedEarnLB;
        private System.Windows.Forms.Button LearnMoreLB;
        private System.Windows.Forms.Button HomeBN;
        private System.Windows.Forms.Label ColCostLB;
        private System.Windows.Forms.Label FinShapeLB;
        private System.Windows.Forms.Button button2;
    }
}