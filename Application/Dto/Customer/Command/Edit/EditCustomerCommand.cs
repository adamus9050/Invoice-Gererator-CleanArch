using MediatR;

namespace Application.Dto.Customer.Command.Edit
{
    public class EditCustomerCommand : CustomerDto, IRequest<Unit>//<int>
    {
        //public int Id { get; set; }

        //public EditCustomerCommand(int id)
        //{
        //    Id = id;
        //}
    }
}
