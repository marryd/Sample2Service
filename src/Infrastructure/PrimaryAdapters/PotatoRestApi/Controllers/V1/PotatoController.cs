using Microsoft.AspNetCore.Mvc;
using Potatoes.Facade;

namespace PotatoRestApi.Controllers.V1
{
    [ApiController]
    public class PotatoController : ControllerBase
    {
        private readonly IPotatoApp potatoApp;

        public PotatoController(IPotatoApp potatoApp)
        {
            this.potatoApp = potatoApp;
        }


    }
}
