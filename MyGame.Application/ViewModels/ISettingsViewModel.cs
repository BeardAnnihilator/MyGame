using MyGame.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.ViewModels
{
    public interface ISettingsViewModel
    {
        ISetting Setting { get; }
    }
}
