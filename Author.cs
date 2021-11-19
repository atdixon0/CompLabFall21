namespace CompLabFall21
{
    public class Author
    {
         
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail)
        {
            tempName = name;
            tempGender = gender;
            tempEmail = email;   
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string tempName)
        {
            this.name = tempName;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char tempGender)
        {
            this.gender = tempGender;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string tempEmail)
        {
            this.email = tempEmail;
        }
    }
}