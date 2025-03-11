using System;

public class Job
{
        public string _jobTitle;
        public string _companyName;
        public int _starYear;
        public int _endYear;
        public void Display()
        {
            Console.WriteLine($"{_jobTitle}, ({_companyName}) {_starYear} - {_endYear}" );
        }
}