using Potatoes.UseCases;

namespace Potatoes.Facade
{
    public class PotatoApp : IPotatoApp
    {
        private readonly PotatoUseCase potatoUseCase;

        public PotatoApp(PotatoUseCase potatoUseCase)
        {
            this.potatoUseCase = potatoUseCase;
        }
    }
}