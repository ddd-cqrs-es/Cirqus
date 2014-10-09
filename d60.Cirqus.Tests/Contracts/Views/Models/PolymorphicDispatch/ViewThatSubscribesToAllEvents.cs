﻿using d60.Cirqus.Events;
using d60.Cirqus.Views.ViewManagers;
using d60.Cirqus.Views.ViewManagers.Locators;

namespace d60.Cirqus.Tests.Contracts.Views.Models.PolymorphicDispatch
{
    public class ViewThatSubscribesToAllEvents : IViewInstance<InstancePerAggregateRootLocator>,
        ISubscribeTo<DomainEvent>
    {
        public string Id { get; set; }

        public long LastGlobalSequenceNumber { get; set; }

        public int ProcessedEvents { get; set; }

        public void Handle(IViewContext context, DomainEvent domainEvent)
        {
            ProcessedEvents++;
        }
    }
}