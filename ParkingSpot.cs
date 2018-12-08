using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSystem
{
    public class ParkingSpot
    {
        private System.Guid UUID;
        private String name;
        private Boolean occupied = false;

        #region ParkingSpot Constructers

        public ParkingSpot() => this.UUID = Guid.NewGuid();

        public ParkingSpot(Boolean isOccupied)
        {
            this.UUID = Guid.NewGuid();
            this.occupied = isOccupied;
        }

        public ParkingSpot(String name)
        {
            this.name = name;
            this.UUID = Guid.NewGuid();
        }

        public ParkingSpot(String name, Boolean isOccupied)
        {
            this.name = name;
            this.UUID = Guid.NewGuid();
            this.occupied = isOccupied;
        }

        public ParkingSpot(String name, String uuid, Boolean isOccupied)
        {
            this.name = name;
            this.UUID = Guid.Parse(uuid);
            this.occupied = isOccupied;
        }

        #endregion

        #region Setters

        /// <summary>
        /// Sets the name of the object.
        /// </summary>
        /// <param name="name">Name</param>
        public void SetName(String name)
        {
            this.name = name;
        }

        /// <summary>
        /// Sets if the parking spot object has been occupied.
        /// </summary>
        /// <param name="isOccupied">True means it is occupied.</param>
        public void SetOccupied(Boolean isOccupied)
        {
            this.occupied = isOccupied;
        }

        /// <summary>
        /// Sets the UUID of the object.
        /// </summary>
        /// <param name="str">Guid string.</param>
        public void SetUUID (String str)
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
        /// Returns true if the parking spot is occupied.
        /// </summary>
        public Boolean IsOccupied => this.occupied;
        
        /// <summary>
        /// Returns the UUID.
        /// </summary>
        public Guid GetUUID => this.UUID;

        #endregion

        public override bool Equals(object obj)
        {
            return obj is ParkingSpot spot &&
                   UUID.Equals(spot.UUID) &&
                   name == spot.name &&
                   occupied == spot.occupied;
        }

        public override int GetHashCode()
        {
            var hashCode = 78377662;
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(UUID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + occupied.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ToString);
            return hashCode;
        }


        /// <summary>
        /// Returns the object in a json string format.
        /// </summary>
        public new String ToString => "{\n\"name\":\"" + name + "\",\n" +
            "\"occupied\":\"" + occupied + "\",\n" +
            "\"uuid\":\"" + UUID + "\"\n}";
    }
}
