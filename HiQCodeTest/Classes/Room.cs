using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiQCodeTest.Classes.Helpers;

namespace HiQCodeTest.Classes
{
    class Room
    {
        #region Datamembers
        /// <summary>
        /// Set the entity that will move inside the room.
        /// </summary>
        private Entity _entity;

        private int _height;
        private int _width;
        private bool _isLogging;
        #endregion

        public Room(int width, int height, Entity entity, bool isLogging) {
            _entity = entity;
            _isLogging = isLogging;
            _width = width;
            _height = height;
        }

        public void MoveEntity(SimulationCommand command) {
            _entity.Move(command);
            if (_isLogging) Console.WriteLine("Moved entity: " + _entity.ToString());
            DidEntityHitWall();
        }

        /// <summary>
        /// Check if entity hit a wall in the room.
        /// Simple check since we move in whole meters.
        /// </summary>
        private void DidEntityHitWall() {
            if (_entity.Position.X < 0 ||
                _entity.Position.X > _width ||
                _entity.Position.Y < 0 ||
                _entity.Position.Y > _height)
            {
                throw new EntityHitWallException("Entity hit a wall.", _entity);
            }
        }
   
    }
}
