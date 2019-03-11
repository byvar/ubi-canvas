using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Pad2Touch_Template : ActorComponent_Template {
		[Serialize("InputMapping"           )] public CMap<StringID, RLC_Pad2TouchInput> InputMapping;
		[Serialize("SelectInactive"         )] public bool SelectInactive;
		[Serialize("ActiveOnScreenOnly"     )] public bool ActiveOnScreenOnly;
		[Serialize("ActiveOnBackground"     )] public bool ActiveOnBackground;
		[Serialize("SensibleToAdventureLock")] public bool SensibleToAdventureLock;
		[Serialize("SensibleToIncubatorLock")] public bool SensibleToIncubatorLock;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(InputMapping));
			SerializeField(s, nameof(SelectInactive));
			SerializeField(s, nameof(ActiveOnScreenOnly));
			SerializeField(s, nameof(ActiveOnBackground));
			SerializeField(s, nameof(SensibleToAdventureLock));
			SerializeField(s, nameof(SensibleToIncubatorLock));
		}
		public override uint? ClassCRC => 0xD8678F00;
	}
}

