using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class FactionRelationContainer : CSerializable {
		public CListP<uint> factions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			factions = s.SerializeObject<CListP<uint>>(factions, name: "factions");
		}
	}
}

