namespace NameConcationationLibrary
{
    public class NameConcationation
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public NameConcationation(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public string ConcationateFirstAndLastName(string firstName, string lastName)
        //{
        //    return $"{firstName} {lastName}";
        //}
    }
}