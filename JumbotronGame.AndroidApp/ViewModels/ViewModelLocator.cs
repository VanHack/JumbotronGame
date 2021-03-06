﻿using JumbotronGame.AndroidApp.ViewModels.Main;
using System;
using Microsoft.Extensions.DependencyInjection;
using JumbotronGame.AndroidApp.ViewModels.Common;
using JumbotronGame.AndroidApp.ViewModels.ArenaEvents;
using JumbotronGame.AndroidApp.ViewModels.Users;

namespace JumbotronGame.AndroidApp.ViewModels
{
    public class ViewModelLocator
    {
        #region Fields

        private readonly IServiceProvider _serviceProvider;

        #endregion Fields

        #region .ctor

        public ViewModelLocator(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        #endregion .ctor

        #region Properties

        public IMainViewModel Main => _serviceProvider.GetService<IMainViewModel>();

        public IItemFactory<ArenaEventViewModel> ArenaEventFactory => _serviceProvider.GetService<IItemFactory<ArenaEventViewModel>>();

        public IItemFactory<UserProfileViewModel> UserProfileFactory => _serviceProvider.GetService<IItemFactory<UserProfileViewModel>>();

        #endregion Properties
    }
}