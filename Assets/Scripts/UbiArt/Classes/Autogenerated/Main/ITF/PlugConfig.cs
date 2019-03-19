using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class PlugConfig : CSerializable {
		[Serialize("plugId"    )] public StringID plugId;
		[Serialize("slotId"    )] public uint slotId;
		[Serialize("snapConfig")] public Nullable<PlugSnapConfig> snapConfig;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(plugId));
			SerializeField(s, nameof(slotId));
			SerializeField(s, nameof(snapConfig));
		}
	}
}

