﻿using ModuloFacturacion.Models.ValueObject;
using System;
using System.Runtime.InteropServices;

namespace Framework.Aggregate
{
    public abstract class Entity<TId> : IInternalEventHandler<EventArgs>
        where TId : Value<TId>
    {
        private readonly Action<object> _applier;

        public event EventHandler<EventArgs> Handle;

        public TId Id { get; protected set; }

        protected Entity(Action<object> applier) => _applier = applier;

        protected Entity() { }

        public abstract void When(object source, EventArgs args);

        protected void Apply(EventArgs args)
        {
            When(this, args);
            _applier(args);
        }

        void IInternalEventHandler<EventHandler>.Handle(object source, EventArgs args)
        {
            When(source, args);
        }
    }
}
