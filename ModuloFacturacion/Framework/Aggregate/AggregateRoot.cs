using ModuloFacturacion.Models.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Framework.Aggregate
{
     public abstract class AggregateRoot<TId> : IInternalEventHandler<EventArgs>
        where TId : Value<TId>
    {
        public TId Id { get; protected set; }
        
        private readonly List<object> _changes;

        public event EventHandler<EventArgs> Handle;

        protected AggregateRoot()
        {
            _changes = new List<object>();
        }

        protected void Apply(object source, EventArgs args)
        {
            When(this, args);
            ValidateStatus();
            _changes.Add(args);
        }

        public IEnumerable<object> GetChanges() => _changes.AsEnumerable();

        public void ClearChanges() => _changes.Clear();

        protected abstract void ValidateStatus();

        protected void ApplyToEntity(IInternalEventHandler<EventArgs> entity, object args)
            => entity?.HandleEvent(this, args);

        void IInternalEventHandler.Handle(object source, EventArgs args) => When(this, args);
    }
}

