using System.Collections.Generic;
using System;

namespace Exercise
{
    public class StorageFacility
    {

        private Dictionary<string, List<string>> varasto = new Dictionary<string, List<string>>();
        public void Add(string unit, string item)
        {
            if (!this.varasto.ContainsKey(unit))
            {
                this.varasto.Add(unit, new List<string> { item });
            }
            else
            {
                this.varasto[unit].Add(item);
            }
        }

        public List<string> Contents(string storageUnit)
        {
            if (!this.varasto.ContainsKey(storageUnit))
            {
                return this.varasto[storageUnit];
            }
            return this.varasto[storageUnit];
        }

        public void Remove(string storageUnit, string item)
        {
            if (this.varasto.ContainsKey(storageUnit))
            {
                this.varasto[storageUnit].Remove(item);
            }
            if (this.varasto[storageUnit].Count == 0)
            {
                this.varasto.Remove(storageUnit);
            }
        }

        public List<string> StorageUnits()
        {
            List<string> varastoLista = new List<string>();
            Dictionary<string, List<string>>.KeyCollection keys = this.varasto.Keys;

            foreach (string yksikonNimi in keys)
            {
                varastoLista.Add(yksikonNimi);
            }
            return varastoLista;
        }
    }
}