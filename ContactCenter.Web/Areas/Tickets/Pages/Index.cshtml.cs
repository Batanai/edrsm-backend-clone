using ContactCenter.Data;
using ContactCenter.Web.Pages;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace ContactCenter.Web.Areas.Tickets.Pages
{
    public class IndexModel : SysListPageModel<Ticket>
    {
        public User Assignee { get; set; }
        public void OnGet(Guid? id, int? p, int? ps, string q)
        {
            PageTitle = Title = "Tickets";
            var query = Db.Tickets
                .Include(c => c.Contact)
                .Include(c => c.Assignee)
                .AsQueryable();
            if (!string.IsNullOrWhiteSpace(q))
            {
                QueryString = q;
                q = q.ToLower();
                query = query.Where(c => c.Number.ToLower().Contains(q) || c.Description.ToLower().Contains(q) || c.Contact.Name.Contains(q));
            }
            if (id.HasValue)
            {
                Assignee = Db.Users.FirstOrDefault(c => c.Id == id);
                query = query.Where(c => c.AssigneeId == id);
            }
            List = new PagedList<Ticket>(query.OrderByDescending(c => c.CreationDate), p ?? 1, ps ?? DefaultPageSize);
            PageSubTitle = "ticket".ToQuantity(List.TotalItemCount) + " found.."; ;
        }
    }
}
