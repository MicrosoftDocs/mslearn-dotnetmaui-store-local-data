using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    public class PersonRepository
    {
        string _dbPath;

        public string StatusMessage { get; set; }

        // TODO: Add variable for the SQLite connection

        private void Init()
        {
            // TODO: Add code to initialize the repository         
        }

        public PersonRepository(string dbPath)
        {
            _dbPath = dbPath;                        
        }

        public async Task AddNewPerson(string name)
        {            
            int result = 0;
            try
            {
                // TODO: Call Init()

                //basic validation to ensure a name was entered
                if (string.IsNullOrEmpty(name))
                    throw new Exception("Valid name required");

                // TODO: Insert the new person into the database
                result = 0;

                StatusMessage = string.Format("{0} record(s) added (Name: {1})", result, name);
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to add {0}. Error: {1}", name, ex.Message);
            }

        }

        public async Task<List<Person>> GetAllPeople()
        {
            try
            {
                // TODO: Init then retrieve a list of Person objects from the database into a list
            }
            catch (Exception ex)
            {
                StatusMessage = string.Format("Failed to retrieve data. {0}", ex.Message);
            }

            return new List<Person>();
        }
    }
}
