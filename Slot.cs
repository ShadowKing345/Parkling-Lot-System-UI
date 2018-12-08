using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSystem
{
    class Slot
    {
        private List<ParkingSpot> spots = new List<ParkingSpot>();
        private String name;
        private Guid UUID;

        #region Constructers

        public Slot()
        {
            this.UUID = Guid.NewGuid();
        }

        public Slot(String name)
        {
            this.UUID = Guid.NewGuid();
            this.name = name;
        }

        public Slot(String name, String uuid)
        {
            this.UUID = Guid.Parse(uuid);
            this.name = name;
        }

        #endregion

        #region Setters

        /// <summary>
        /// Sets the name of the object.
        /// </summary>
        /// <param name="name">The name</param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Sets the UUID(Guid) of the object.
        /// </summary>
        /// <param name="str">Guid string</param>
        public void SetUUID(String str)
        {
            Guid.TryParse(str, out this.UUID);
        }

        #endregion

        #region Getters

        /// <summary>
        /// Returns the name of the object.
        /// </summary>
        public String GetName => this.name;

        /// <summary>
        /// Returns the UUID of the object.
        /// </summary>
        public Guid GetUUID => this.UUID;

        /// <summary>
        /// Returns a list of Parking Spots inside the object.
        /// </summary>
        public List<ParkingSpot> GetParkingSpots => this.spots;

        #endregion

        public override bool Equals(object obj)
        {
            var slot = obj as Slot;
            return slot != null &&
                   EqualityComparer<List<ParkingSpot>>.Default.Equals(spots, slot.spots) &&
                   name == slot.name &&
                   UUID.Equals(slot.UUID);
        }

        public override int GetHashCode()
        {
            var hashCode = 745057714;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<ParkingSpot>>.Default.GetHashCode(spots);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(UUID);
            return hashCode;
        }

        /// <summary>
        /// Converts object into a json string as well as any Parking spots held in the list.
        /// </summary>
        public new String ToString
        {
            get
            {
                String parkingSpots = "";
                if (this.spots.Count > 0)
                {
                    parkingSpots = "\"parkingspots\":[";
                    for (int i = 0; i < this.spots.Count; i++)
                    {
                        parkingSpots += this.spots[i].ToString;
                        if (i != this.spots.Count - 1)
                            parkingSpots += ",";

                    }
                    parkingSpots += "],";
                }
                return "{\n" + parkingSpots + "\n" +
                    "\"name\":\"" + this.name + "\",\n" +
                    "\"uuid\":\"" + this.UUID + "\"\n}";
            }
        }
    }
}