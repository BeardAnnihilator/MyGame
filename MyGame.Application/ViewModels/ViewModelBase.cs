using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.ViewModels
{
    public abstract class ViewModelBase : ReactiveObject
    {
        protected abstract void InitData();
    }
}
