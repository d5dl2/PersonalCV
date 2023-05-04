namespace PersonalCV.Models
{
    public class CVContainer
    {
        public Page1 Page1Content { get; set; }
        public Page2 Page2Content { get; set; }

        public class Page1
        {
            public SideBar SideBarContent { get; set; }
            public Main MainContent { get; set; }

            public class SideBar
            {
                public PersonalInfo PersonalInfoContent { get; set; }
                public ContactInfo ContactInfoContent { get; set; }

                public class PersonalInfo
                {
                    public string ImagePath { get; set; }
                    public string NameSurName { get; set; }
                    public DateTime BirthDate { get; set; }
                    public string Nationality { get; set; }
                }
                public class ContactInfo
                {
                    public string Location { get; set; }
                    public string Email { get; set; }
                    public string Phone { get; set; }
                    public string LinkedInUrl { get; set; }
                    public string GithubUrl { get; set; }
                }
            }

            public class Main
            {
                public string Motto { get; set; }
                public List<string> WaitingFor { get; set; }
                public List<string> Offer { get; set; }
            }
        }

        public class Page2
        {
            public SideBar SideBarContent { get; set; }
            public Main MainContent { get;set; }

            public class SideBar
            {
                public SkillSet SkillSetContent { get; set; }
                public List<string> Concepts { get; set; }

                public List<string> Hobbies { get; set; }

                public class SkillSet
                {
                    public List<Skill> Skills { get; set; }
                    public class Skill
                    {
                        public string Name { get; set; }
                        public double Rank { get; set; }
                    }
                }
            }

            public class Main
            {
                public List<JobExperience> JobExperiences { get; set; }

                public class JobExperience
                {
                    public string Name { get; set; }
                    public DateTime StartDate { get; set; }
                    public DateTime? EndDate { get; set; }
                    public string ReferansContent { get; set; }
                    public List<Project> Projects { get; set; }

                    public class Project
                    {
                        public string Name { get; set; }
                        public string Experience { get; set; }
                    }
                }
            }
        }
    }
}
