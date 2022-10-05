﻿using SZGC.Domain.BindingModels;
using SZGC.Domain.ViewModels;

namespace SZGC.Desktop.Services.Interfaces
{
    public interface IOrderManagerService
    {
        OrderBindingModel FormingBindingModel(OrderViewModel nomenclatureModel);
    }
}
