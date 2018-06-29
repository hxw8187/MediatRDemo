using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MediatRDemo.Command;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MediatRDemo.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost("{Register}")]
        public async Task<IActionResult> Register([FromBody]Ping registerUser)
        {
            return await Task.Run(()=>Json(registerUser)) ;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            string registered = await _mediator.Send(new Ping());//MediatR用于请求/响应,只使用发现的第一个处理程序,对于给定请求有多个处理程序没有意义
            _logger.LogWarning(registered);
            await _mediator.Publish(new SomeEvent("Hello World"));//MediatR发布活动,所有处理程序都会收到请求
            return Ok();
        }
    }
}