using UnityEngine;

namespace UbiArt.ITF {
	public partial class PersistentGameData_Level : CSerializable {
		[Serialize("id"  )] public StringID id;
		[Serialize("ISDs")] public Placeholder ISDs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ISDs));
			} else {
				SerializeField(s, nameof(id));
			}
		}
		public override uint? ClassCRC => 0xABC6D60D;
	}
}

