using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MultipleModelDataSingleView.Models
{
    public class MultiModelData
    {
        public List<student> my_students { get; set; }
        public List<teacher> my_teachers { get; set; }
    }
}