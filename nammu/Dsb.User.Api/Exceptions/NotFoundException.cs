using BuildingBlocks.Exceptions;

namespace Dsb.User.Api.Exceptions;

public class userNotFoundException : NotFoundException
{
    public userNotFoundException(Guid Id) : base("User", Id)
    {
    } 
}


