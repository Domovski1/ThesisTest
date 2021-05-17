using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Tesis
{
    class SomeClass
    {
        //        var CurrentGroup = CmbGroup.SelectedItem as Group;
        //        var data = AppData.db.Student.Where(x => x.GroupID == CurrentGroup.Code).ToList();


        //        var word = new Word.Application();
        //            try
        //            {
        //                var document = word.Documents.Open(Environment.CurrentDirectory + @"\" + "Template.docx");
        //        var table = document.Tables[1];

        //        int i = 2;
        //                foreach (var item in data)
        //                {
        //                    table.Rows.Add();
        //                    table.Cell(i, 1).Range.Text = item.FirstName;
        //                    table.Cell(i, 2).Range.Text = item.LastName;
        //                    table.Cell(i, 3).Range.Text = item.Group.Title;
        //                    var CountTime = AppData.db.Attendance.Count(x => x.IsPresense == false && x.StudentID == item.ID && x.Day > DpickerFrom.SelectedDate.Value && x.Day < DpickerTo.SelectedDate.Value);
        //        table.Cell(i, 4).Range.Text = (CountTime* 2).ToString() + " ч";
        //                i++;
        //                }

        //    document.SaveAs2(@"C:\Users\Domovski\Desktop\Template.pdf", Word.WdSaveFormat.wdFormatPDF);
        //                document.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
        //                word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
        //                MessageBox.Show("Документ сохранён на рабочем столе");

        //            }
        //            catch (Exception ex)
        //{
        //    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //    word.Quit(Word.WdSaveOptions.wdDoNotSaveChanges);
        //}
    }
}
