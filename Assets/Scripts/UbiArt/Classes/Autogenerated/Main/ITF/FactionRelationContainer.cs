using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class FactionRelationContainer : CSerializable {
		public CList<uint> factions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factions = s.SerializeObject<CList<uint>>(factions, name: "factions");
		}
	}
}

