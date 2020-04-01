using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace CSV.Models
{
    public class Structure
    {
        //Set "MyRecord" parameter True for my record
        public static void setMyRecord(Student stu)
        {
            Constants cons = new Constants();
            if (stu.StudentId == cons.Student.StudentId)
            {
                stu.MyRecord = true;
            }
            else
            {
                stu.MyRecord = false;
            }
        }

    }
}
