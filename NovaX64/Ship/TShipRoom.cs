﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ReturnToLithium.Miscellaneous;
using ReturnToLithium.Crew;

namespace ReturnToLithium.Ship
{
    class TShipRoom : IUpdatableObject
    {
        public int ID;

        public int X;
        public int Y;
        public int Width;   //always a multiple of the width of a floor tile
        public int Height;  //always a multiple of the height of a floor tile

        public double OxygenLevel = 100;

        public List<List<TFloorBlock>> FloorTiles;   //2D array of floor tiles
        public List<TShipRoom> AdjacentRooms;
        public List<TShipRoom> ConnectedRooms;
        public List<TShipDoor> Doors;               //Each connected room is matched to a single door.

        public List<TPerson> Occupants;

        public void Update(DateTime currentTime)
        {
            throw new NotImplementedException();
        }
    }
}
