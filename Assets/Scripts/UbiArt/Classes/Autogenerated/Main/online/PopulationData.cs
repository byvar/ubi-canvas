using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class PopulationData : CSerializable {
		public CMap<StringID, Population> populations;
		public CArray<StringID> deletedPopulations;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			populations = s.SerializeObject<CMap<StringID, Population>>(populations, name: "populations");
			deletedPopulations = s.SerializeObject<CArray<StringID>>(deletedPopulations, name: "deletedPopulations");
		}
		public override uint? ClassCRC => 0xAE1EAD54;
	}
}

