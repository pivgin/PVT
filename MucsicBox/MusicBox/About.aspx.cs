
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MusicBox
{
    public partial class About : Page
    {
        private IEnumerable GetDataLinq()
        {
            using (var context = new Data.DataClasses1DataContext())
            {
                var query = context.Authors.Where(a => a.NameTheBest.Length > 6);
                var authors = query.ToList();

                var query2 = from composition in context.Compositions
                             where  SqlMethods.Like(composition.Title, "%3%")
                             select new
                             {
                                 Caption = composition.Title
                             };

                //context.Authors.Attach(new Data.Author { NameTheBest = "123213" });
                

                var comp = query2.ToArray();
                return comp;
            }
        }

        private void GetDataEF()
        {
            using (var context = new MusicBox.Entity.MusicBoxEntities1())
            {
                var query = context.Authors.Where(a => a.Name.Length > 6);

                var auth = query.ToList();

                var query2 = from composition in context.Compositions
                             where composition.Title.Contains("3")
                             select new
                             {
                                 Caption = composition.Title
                             };

                var comp = query2.ToArray();

                //context.Authors.First(a => a.Id == 1).Name = "5665767";
                //context.Authors.Add(new Entity.Authors { Name = "dfgfdg" });
                context.SaveChanges();

                
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            GetDataEF();
        }
    }
}