using JackShopV2.Application.Interfaces.Services;
using JackShopV2.Core.InputModels;
using Microsoft.AspNetCore.Mvc;


namespace JackShopV2.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdesController : ControllerBase
    {
        protected readonly IOrderService _order;

        public OrdesController(IOrderService order)
        {
            _order = order;
        }

        [HttpGet]
        public async Task<IActionResult> GetCode(string code)
        {
            var order = await _order.GetTrackingCode(code);

            return Ok(order);


        }

        [HttpPost]
        public async Task<IActionResult> Post(OrderInputModel model)
        {
            var code = await _order.Add(model);

            return CreatedAtAction(
                nameof(GetCode),
                new { code },
                model
                );

        }


    }
}
