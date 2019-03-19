using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventSetProceduralCursor : Event {
		[Serialize("proceduralCursor")] public float proceduralCursor;
		[Serialize("animName"        )] public StringID animName;
		[Serialize("isAdditive"      )] public bool isAdditive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(proceduralCursor));
			SerializeField(s, nameof(animName));
			SerializeField(s, nameof(isAdditive));
		}
		public override uint? ClassCRC => 0x884E9D1F;
	}
}

