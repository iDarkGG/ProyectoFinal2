using Microsoft.AspNetCore.Mvc;
using Dependencias.Data;
using Dependencias.Model;
using Dependencias.Dtos;
using Microsoft.EntityFrameworkCore;
namespace API.Controllers
{
    [Route("ApiTienda/[Controller]")]
    [ApiController]
    public class UsersController : Controller
    {
            private readonly MainContext context;
            private readonly ILogger<UsersController> logger;

            public UsersController(MainContext context, ILogger<UsersController> logger)
            {
                this.context = context;
                this.logger = logger;
            }

            [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<IEnumerable<User>>> GetUsers()
            {
                logger.LogInformation("Get all Users");
                var lst = await context.Users.ToListAsync();
                return Ok(lst);
            }

            [HttpGet("{Id:int}", Name = "getUsersById")]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<User>> GetUsersById(int Id)
            {
                logger.LogInformation("Gets the User with the specified id");

                if (Id == 0)
                {
                    logger.LogError($"The User with id {Id} does not exists.");
                    return BadRequest();
                }

                var Users = await context.Users.FindAsync(Id);

                if (Users is null)
                {
                    logger.LogError($"Cannot find the Users with id: {Id}.");
                    return NotFound();
                }

                return Ok(Users);
            }

            [HttpGet("{Name}", Name = "getUsersByName")]
            [ProducesResponseType(StatusCodes.Status404NotFound)]
            [ProducesResponseType(StatusCodes.Status200OK)]
            public async Task<ActionResult<User>> GetUsersByName(string Name)
            {
                logger.LogInformation("Gets the User from the specified name");

                var Users = await context.Users.FirstOrDefaultAsync(x => x.UserName == Name);

                if (string.IsNullOrWhiteSpace(Name))
                {
                    logger.LogError($"Cannot find the User with the name: {Name}.");
                    return NotFound();
                }

                return Ok(Users);
            }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> Post([FromBody] UserPostDto user)
        {
            var searchUser = await context.Users.FirstOrDefaultAsync(x => x.UserName.ToUpper() == user.UserName.ToUpper() || x.Email.ToUpper() == user.Email.ToUpper());
            if(searchUser is not null)
            {
                logger.LogError($"Cannot add the user {user.UserName} because it already exists");
                return BadRequest();
            }


            if (!ModelState.IsValid)
            {
                logger.LogError("The parameters sent were invalid");
                return BadRequest(ModelState);
            }

            if (user is null) return BadRequest();


            await context.Users.AddAsync(new User() {UserName = user.UserName, Email = user.Email,Password = user.Password });

            await context.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id:int}",Name = "UpdateUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> UpdateUser([FromBody] UserUpdateDto user, int Id)
        {
            if (Id == 0) return BadRequest();
            
            if (user is null) return BadRequest();

            var usertofind = await context.Users.FindAsync(Id);

            if (usertofind is null)
            {
                logger.LogError($"Cannot find the User.");
                return NotFound();
            }

            usertofind.Email = user.Email;
            usertofind.UserName = user.UserName;
            usertofind.Password = user.Password;

            context.Entry(usertofind).State = EntityState.Modified;

            await context.SaveChangesAsync();

            return Ok();
        }


        [HttpDelete("Name",Name ="DeleteUserByName")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteUserByName(string Name)
        {
            if(string.IsNullOrWhiteSpace(Name)) return BadRequest(ModelState);

            var user = await context.Users.FirstOrDefaultAsync(x => x.UserName.ToUpper() == Name.ToUpper());

            if (user is null)
            {
                logger.LogError("Cannot find the user to delete it.");
                return NotFound(ModelState);
            }

            context.Users.Remove(user);

            context.Users.Entry(user).State = EntityState.Deleted;

           await context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id:int}", Name = "DeleteUserById")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> DeleteUserById(int id)
        {
            if (id == 0) return BadRequest();

            var user = await context.Users.FindAsync(id);

            if (user is null)
            {
                logger.LogError("Cannot find the user to delete it.");
                return NotFound(ModelState);
            }

            context.Users.Remove(user);

            context.Users.Entry(user).State = EntityState.Deleted;

            await context.SaveChangesAsync();

            return Ok();
        }

    }  
}
