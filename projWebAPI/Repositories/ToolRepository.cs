using System.Data.SqlClient;
using Dapper;
using projWebAPI.Models;

namespace projWebAPI.Repositories
{
    public class ToolRepository : IToolRepository
    {
        private string _conn = @"Server=(localdb)\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=C:\Users\adm\source\repos\projWebAPI\projWebAPI\Database\AndreFerramentas.mdf";

        public List<Tool> GetAll()
        {
            List<Tool> list = new List<Tool>();
            using (var db = new SqlConnection(_conn))
            {
                var tools = db.Query<Tool>(Tool.GETALL);
                list = (List<Tool>)tools;
            }
                return list;
        }

        public bool Insert(Tool tool)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Execute(Tool.INSERT, tool);
            }
                return true;
        }
    }
}
