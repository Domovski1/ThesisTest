using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesis.Model
{
    public partial class Remark
    {
        public string IsRemark
        {
            get
            {
                var _remark = AppData.db.Remark.Where(x => x.Student.ID == this.StudentID);
                if (_remark != null)
                {
                    return "Red";
                } else
                {
                    return "White";
                }
            }
        }
    }
}
