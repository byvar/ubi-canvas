using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GameProgressEvent : Event {
		[Serialize("Name")] public StringID Name;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Name));
		}
		public override uint? ClassCRC => 0x698778B8;
	}
}

