using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventMusicBeatBox : Event {
		[Serialize("Activate")] public bool Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Activate));
		}
		public override uint? ClassCRC => 0x1584131F;
	}
}

