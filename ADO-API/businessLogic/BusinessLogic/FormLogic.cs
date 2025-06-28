using businessLogic.BusinessObject;
using DataAccess.DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

public class FormLogic
{
    private readonly SQLHelper _sqlHelper;

    public FormLogic(SQLHelper sqlHelper)
    {
        _sqlHelper = sqlHelper;
    }

    public async Task<string> submitForm(FormObj obj)
    {
        string msg = string.Empty, query = "INSERTFORM"; // Your query here

        try
        {
            SqlParameter[] para = null;
            {
                para = new SqlParameter[4];
                para[0] = new SqlParameter("@P_NAME", obj.name);
                para[1] = new SqlParameter("@P_EMAIL", obj.email);
                para[2] = new SqlParameter("@P_NUMBER", obj.phone);
                para[3] = new SqlParameter("@P_COLLEGE", obj.college);
            }
            msg = _sqlHelper.ExecuteNonQuerySP(query, para); // ✅ instance call
        }
        catch (Exception ex)
        {
            msg = $"Error: {ex.Message}";
        }

        return msg;
    }
}
