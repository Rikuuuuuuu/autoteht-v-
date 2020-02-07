using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Autokauppa.view
{
  
    public class KaupanLogiikka
    {
        DatabaseHallinta dbModel = new DatabaseHallinta();

        public bool TestDatabaseConnection()
        {
            bool doesItWork = dbModel.connectDatabase();
            return doesItWork;
        }

        public bool saveAuto(view.Auto newAuto) 
        {
            bool didItGoIntoDatabase = dbModel.saveAutoIntoDatabase(newAuto);
            return didItGoIntoDatabase;
        }

        public List<string> getAllAutoMakers() 
        {
            return dbModel.getAllAutoMakersFromDatabase();
        }

        public List<int> getAutoModels(int makerId) 
        {
            
            return dbModel.getAutoModelsByMakerId(makerId);
        }
    }
}
