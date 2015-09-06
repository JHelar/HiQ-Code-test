using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiQCodeTest.Classes.Helpers
{
    //Exceptionclasses should be serializable according to documentation.
    [Serializable()]
    class EntityHitWallException : Exception
    {
        public Entity Entity;

        //Custom constructor, with position when the crash happened.
        public EntityHitWallException(string message, Entity entity) : base(message) {
            Entity = entity;
        }
        //Default constructors.
        public EntityHitWallException() : base() { }
        public EntityHitWallException(string message) : base(message) { }
        public EntityHitWallException(string message, Exception inner) : base(message, inner) { }
        protected EntityHitWallException(System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context)
        { }
    }
}
