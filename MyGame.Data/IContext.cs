using MyGame.Data.Models;
using System;

namespace MyGame.Data
{
    internal interface IContext : IDisposable
    {
        GameEngine Engine { get; }

        void Init();
    }
}