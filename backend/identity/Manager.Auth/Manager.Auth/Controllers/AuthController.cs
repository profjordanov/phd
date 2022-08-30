using Manager.Auth.Models;
using Manager.Auth.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Manager.Auth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        /// <summary>
        /// Login.
        /// </summary>
        /// <param name="model">The credentials.</param>
        /// <returns>A JWT token.</returns>
        /// <response code="200">If the credentials have a match.</response>
        /// <response code="400">If the credentials don't match/don't meet the requirements.</response>
        [HttpPost("login")]
        [ProducesResponseType(typeof(JwtModel), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorModel), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Login([FromBody] LoginUserModel model) =>
            (await _authService.Login(model))
            .Match(Ok, Error);

        /// <summary>
        /// Register.
        /// </summary>
        /// <param name="model">The user model.</param>
        /// <returns>A user model.</returns>
        /// <response code="201">A user was created.</response>
        /// <response code="400">Invalid input.</response>
        [HttpPost("register")]
        [ProducesResponseType(typeof(UserModel), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorModel), (int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Register([FromBody] RegisterUserModel model) =>
            (await _authService.Register(model))
            .Match(u => CreatedAtAction(nameof(Register), u), Error);

        protected IActionResult Error(ErrorModel error) =>
            new BadRequestObjectResult(error);
    }
}
