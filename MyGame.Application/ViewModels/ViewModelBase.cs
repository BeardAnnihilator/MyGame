using ReactiveUI;

namespace MyGame.ViewModels
{
    public abstract class ViewModelBase : ReactiveObject
    {
        protected abstract void InitData();
    }
}