using System.Linq;

namespace Tesis.Model
{
    public partial class Student
    {
        public string IsRemarkNull
        {
            get
            {
                var _remark = AppData.db.Remark.FirstOrDefault(x => x.StudentID == this.ID && x.Status != true);
                if (_remark != null)
                {
                    return "Red";
                }
                else
                {
                    return "White";
                }
            }
        }
    }
}
