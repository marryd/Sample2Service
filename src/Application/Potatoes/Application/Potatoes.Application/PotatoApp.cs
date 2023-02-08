using Potatoes.UseCases;

namespace Potatoes.Application
{
    public class PotatoApp
    {
        private readonly PotatoUseCase potatoUseCase;

        public PotatoApp(PotatoUseCase potatoUseCase)
        {
            this.potatoUseCase = potatoUseCase;
        }
    }
}