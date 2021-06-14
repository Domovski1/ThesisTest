using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
