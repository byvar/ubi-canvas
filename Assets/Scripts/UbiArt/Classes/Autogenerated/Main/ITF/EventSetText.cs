using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSetText : Event {
		[Serialize("text")] public SmartLocId text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(text));
		}
		public override uint? ClassCRC => 0xC474850E;
	}
}

