using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimPolylineEvent : AnimMarkerEvent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xF366A28D;
	}
}

