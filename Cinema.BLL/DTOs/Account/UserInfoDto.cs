using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.DTOs.Reviews;
using Cinema.BLL.DTOs.Tickets;

namespace Cinema.BLL.DTOs.Account
{
    public class UserInfoDto
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<ReviewReadDto> Reviews { get; set; }
        public IEnumerable<InvoiceDetailsReadDto> Invoices { get; set; }
    }
}
