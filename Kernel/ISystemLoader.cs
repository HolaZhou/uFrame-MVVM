﻿using System;
using UnityEngine;
using System.Collections;

public interface ISystemLoader
{

    void Load();

    IGameContainer Container
    {
        get;
        set;
    }

    IEventAggregator EventAggregator
    {
        get;
        set;
    }

}

public class SystemLoader : MonoBehaviour,ISystemLoader
{
    public virtual void Load()
    {
        
    }

    public IGameContainer Container
    {
        get;
        set;
    }

    public IEventAggregator EventAggregator
    {
        get;
        set;
    }

    public TViewModel CreateInstanceViewModel<TViewModel>(string identifier) where TViewModel : ViewModel
    {
        var contextViewModel = Activator.CreateInstance(typeof(TViewModel), EventAggregator) as TViewModel;
        contextViewModel.Identifier = identifier;
        return contextViewModel;
    }

}
