using ChapChap.Web.Auth.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChapChap.Web.Auth.Controllers;

[ApiController]
[Route("register")]
public class RegisterController : ControllerBase
{
    [HttpPost]
    public IActionResult Index(RegisterRequest data)
    {
        return Ok(data);
    }
}