using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingSystem
{
    class Node
    {
        private List<Slot> slots = new List<Slot>();
        private String name;
        private Guid UUID;

        #region Node Constructers

        public Node()
        {
            this.UUID = Guid.NewGuid();
        }

        public Node(String name)
        {
            this.UUID = Guid.NewGuid();
            this.name = name;
        }

        public Node(String name, String uuid)
        {
            this.name = name;
            this.UUID = Guid.Parse(uuid);
        }

        #endregion

        #region Setters

        /// <summary>
        /// Sets the name of the object.
        /// </summary>
        /// <param name="name"></param>
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
        /// Returns the object name.
        /// </summary>
        public String GetName => this.name;

        /// <summary>
        /// Returns the object UUID.
        /// </summary>
        public Guid GetUUID => this.UUID;

        /// <summary>
        /// Returns the list of Slots in the object.
        /// </summary>
        public List<Slot> GetSlots => this.slots;

        #endregion

        public override bool Equals(object obj)
        {
            return obj is Node node &&
                   EqualityComparer<List<Slot>>.Default.Equals(slots, node.slots) &&
                   name == node.name &&
                   UUID.Equals(node.UUID) &&
                   ToString == node.ToString;
        }

        public override int GetHashCode()
        {
            var hashCode = 2082037475;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Slot>>.Default.GetHashCode(slots);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Guid>.Default.GetHashCode(UUID);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ToString);
            return hashCode;
        }
        
        /// <summary>
        /// Converts the object and any slots within into a json string.
        /// </summary>
        public new String ToString
        {
            get
            {
                String slot = "";
                if (this.slots.Count > 0)
                {
                    slot = "\"slots\":[";
                    for (int i = 0; i < this.slots.Count; i++)
                    {
                        slot += this.slots[i].ToString;
                        if (i != this.slots.Count - 1)
                            slot += ",";

                    }
                    slot += "],";
                }
                return "{\n" + slot + "\n" +
                    "\"name\":\"" + this.name + "\",\n" +
                    "\"uuid\":\"" + this.UUID + "\"\n}";
            }
        }
    }
}
