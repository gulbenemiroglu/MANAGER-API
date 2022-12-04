using EntitiesLayer.Concrete;

namespace AdminUI.Services
{
    public interface ICommandSessionService
    {
        Command GetCommand();
        void SetCart(Command command);
    }
}
