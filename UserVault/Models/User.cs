namespace UserVault.Models
{
    internal class User: Person
    {
        private string ? _UserName;
        private string ? _Email;

        public string UserName
        {
            get{return _UserName;}
            set{_UserName = value;}
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value;}
        }


        public Demographic Demographic
        {
            get; set; 
        }
    }

}
