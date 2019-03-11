using UnityEngine;

namespace UbiArt.ITF {
	public partial class GameProgressManager_Template : TemplateObj {
		[Serialize("MapProgressList")] public CMap<StringID, MapProgressContainer> MapProgressList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MapProgressList));
		}
		public override uint? ClassCRC => 0x070A52F7;
	}
}

