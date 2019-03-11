using UnityEngine;

namespace UbiArt.online {
	public partial class GameGlobalsPopulationCondition : GameGlobalsCondition {
		[Serialize("kind")] public StringID kind;
		[Serialize("type")] public StringID type;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(kind));
			SerializeField(s, nameof(type));
		}
		public override uint? ClassCRC => 0xC5A0F7D6;
	}
}

