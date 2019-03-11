using UnityEngine;

namespace UbiArt.ITF {
	public partial class FactionRelationContainer : CSerializable {
		[Serialize("factions")] public CList<uint> factions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(factions));
		}
	}
}

